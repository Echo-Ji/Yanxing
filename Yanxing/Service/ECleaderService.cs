using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Yanxing.DataAccess;
using Yanxing.Models;

namespace Yanxing.Service
{
    public class ECleaderService
    {
        
        public bool CreateActivity(Activity activity)
        {
            bool res = true;
        
            try
            {
                var adl = new ActivityDal();
                adl.Insert(activity);
            }
            catch(Exception e)
            {
                res = false;
                using (StreamWriter writer =
               new StreamWriter(@"C:\Users\lenovo\Desktop\log.txt", true))
                {
                    writer.WriteLine(DateTime.Now.ToString());
                    writer.WriteLine(e.Message);
                    writer.WriteLine(e.StackTrace);
                }
            }
            return res;
        }

        /*Create a new role for activity.*/
        public bool CreateRole(Role role) {
            bool res = true;

            try
            {
                var rdl = new RoleDal();
                rdl.Insert(role);
            }
            catch (Exception e)
            {
                res = false;
                using (StreamWriter writer =
               new StreamWriter(@"C:\Users\JJH\Desktop\log.txt", true))
                {
                    writer.WriteLine(DateTime.Now.ToString());
                    writer.WriteLine(e.ToString());
                    //writer.WriteLine(e.StackTrace);
                }
            }
            
            return res;
        }


        //update member grade
        public bool updateMemGrade(Person person,string toGrade)
        {
            bool res = true;
            Person tPerson=null;
            var persondal = new PersonDal();
            //get the person's old profile
            var pres = persondal.GetEntities(m => m.PID == person.PID);

            try
            {
                foreach (var p in pres) {
                    tPerson = p;
                }
                if (person.Pgrade != toGrade) {//若前后grade不一致
                    //update person first
                    updatePersonGrade(person, toGrade);
                    //update Member later
                    switch (person.Pgrade) {
                        case "XiaoYan":case "EC": {
                                //get the old profile of the member
                                var oldmem = new XiaoYan();
                                var xymemdal = new XiaoYanDal();
                                var mems = xymemdal.GetEntities(m => m.PID == person.PID);
                                foreach (var p in mems) {
                                    oldmem = p;
                                }
                                //update the member profile
                                if (toGrade == "EC") { 
                                    //XiaoYan=>EC,set EC flag
                                    xymemdal.Update(new XiaoYan { XYID = oldmem.XYID,
                                        PID = oldmem.PID, Sid = oldmem.Sid,
                                        isEC = true, isActive = oldmem.isActive });
                                }
                                else if (toGrade == "XiaoYan") {
                                    //EC=>XiaoYan,unset EC flag
                                    xymemdal.Update(new XiaoYan
                                    {
                                        XYID = oldmem.XYID,
                                        PID = oldmem.PID,
                                        Sid = oldmem.Sid,
                                        isEC = false,
                                        isActive = oldmem.isActive
                                    });
                                }
                                else if (toGrade == "DaYan") {
                                    var dymemdal = new DaYanDal();
                                    //inactivate the xiaoyan
                                    xymemdal.Update(new XiaoYan
                                    {
                                        XYID = oldmem.XYID,
                                        PID = oldmem.PID,
                                        Sid = oldmem.Sid,
                                        isEC = oldmem.isEC,
                                        isActive = false
                                    });
                                    //insert a dayan
                                    dymemdal.Insert(new DaYan
                                    {
                                        DYID = Guid.NewGuid(),
                                        PID = oldmem.PID,
                                        Sid = oldmem.Sid,
                                        isECleader = false,
                                        isActive = true
                                    });
                                }
                                break;
                            }
                        case "DaYan": case "ECleader": {
                                var oldmem = new DaYan();
                                var dymemdal = new DaYanDal();
                                var mems = dymemdal.GetEntities(m => m.PID == person.PID);
                                foreach (var p in mems) {
                                    oldmem = p;
                                }
                                
                                if (toGrade == "ECleader")
                                {//DaYan=>ECleader,set ECleader flag
                                    dymemdal.Update(new DaYan
                                    {
                                        DYID = oldmem.DYID,
                                        PID = oldmem.PID,
                                        Sid = oldmem.Sid,
                                        isECleader = true,
                                        isActive = oldmem.isActive
                                    });
                                }
                                else if (toGrade == "DaYan")
                                {//ECleader=>DaYan,unset ECleader flag
                                    dymemdal.Update(new DaYan
                                    {
                                        DYID = oldmem.DYID,
                                        PID = oldmem.PID,
                                        Sid = oldmem.Sid,
                                        isECleader = false,
                                        isActive = oldmem.isActive
                                    });
                                }
                                break;
                            }
                    }
                }
            }
            catch (Exception e)
            {
                res = false;
                using (StreamWriter writer =
               new StreamWriter(@"C:\Users\JJH\Desktop\log.txt", true))
                {
                    writer.WriteLine(DateTime.Now.ToString());
                    writer.WriteLine(e.Message);
                    writer.WriteLine(e.StackTrace);
                }
            }
            return (res);
        }

        protected bool updatePersonGrade(Person person, string toGrade)
        {
            bool res = true;
            try
            {
                var pdal = new PersonDal();
                pdal.Update(new Person
                {
                    PID = person.PID,
                    Ptel = person.Ptel,
                    Username = person.Username,
                    Pname = person.Pname,
                    Ptime = person.Ptime,
                    Pgrade = toGrade,
                    PwechatID = person.PwechatID,
                    Psex = person.Psex,
                    Pemail = person.Pemail,
                    Pcontact = person.Pcontact,
                    Ppro = person.Ppro,
                    Pwork_years = person.Pwork_years,
                    Pjob4u = person.Pjob4u,
                    Padvs = person.Padvs,
                    Pact4fire = person.Pact4fire,
                    Pact4water = person.Pact4water,
                    Phobbies = person.Phobbies,
                    Pfield_of_firm = person.Pfield_of_firm
                });
            }
            catch (Exception e) {
                res = false;
            }
            return res;
        }
    }
}