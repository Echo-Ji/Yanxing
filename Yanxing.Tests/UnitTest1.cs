using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yanxing.DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Yanxing.Models;
using Yanxing.Service;

namespace Yanxing.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AccountDal account = new AccountDal();
            account.Insert(new Account {UserID=Guid.NewGuid(), Username = "bh15061088", Password = "bh" });
            PersonDal person = new PersonDal();
            person.Insert(new Person {PID=Guid.NewGuid(),Pname="york",Pgrade = "BoardMember",Padvs="",Pact4fire="",Pact4water="",Pcontact="",Pemail="",Pfield_of_firm="",Phobbies="",Pjob4u="",Ppro ="",Psex="男",Ptel="135",Ptime=1234567,PwechatID="",Pwork_years=1,Username="bh15061088" });


        }

        [TestMethod]
        public void TestMethod2()
        {
            AccountDal login = new AccountDal();
            var entity = login.GetEntities(i => i.Username =="echo");
            using (StreamWriter writer =
            new StreamWriter(@"C:\Users\lenovo\Desktop\t.txt", true))
            {
                foreach (var p in entity)
                {
                    writer.WriteLine(p.Username);
                }
            }
                
            //account.Insert(new Account { Username = "皇帝爸爸",Password = "echo_ashraf" });


        }

        [TestMethod]
        public void TestActivity()
        {
            ActivityDal activity = new ActivityDal();
            //activity.Insert(new Activity { Aid = 5,Aname = "echo_ashraf" ,Arate = 2});
            //activity.Update(new Activity { Aname = "echo_ashraf", Arate = 3 });
            //activity.Delete(new Activity { Aname = "echo_ashraf", Arate = 3 });
            var result = activity.GetEntities(p => p.Arate <= 8.0);
            using (StreamWriter writer =
            new StreamWriter(@"C:\Users\lenovo\Desktop\t.txt", true))
            {
                foreach (var q in result)
                {
                    writer.WriteLine(q.Aname);
                }
            }

        }
        [TestMethod]
        public void TestPerson()
        {
            //PersonDal person = new PersonDal();
            //activity.Insert(new Activity { Aid = 5,Aname = "echo_ashraf" ,Arate = 2});
            //person.Update(new Person { Ptel = "11111111", Pname = "jijiahao", PwechatID = "234", Pgrade = "Jmember", Psex = "男", Pemail = "jijiahao@buaa.edu.cn", Username = "echo" });
            //activity.Delete(new Activity { Aname = "echo_ashraf", Arate = 3 });
            //XiaoYan x = new XiaoYan("echo");
            //x.update_baseinform("jijia", "男", "EC");





        }
        [TestMethod]
        public void sdxvv()
        {

            XiaoYanDal xyd = new XiaoYanDal();
            XiaoYan x = new XiaoYan();
            x.isActive = true;
            x.isEC = false;
            x.PID = Guid.NewGuid();
            x.Sid = 1;
            xyd.Insert(x);

        }



        [TestMethod]
        public void TestParticipant()
        {
            ParticipantDal participant = new ParticipantDal();
            //participant.Insert(new Participant {PTid = 2, Aid = 15, Ptel = "13521542933", PTtime = DateTime.Now, Rid = 1});
            //participant.Delete(new Participant {Aid = 15, Ptel = "13521542933"});
            var result = participant.GetEntities(p => p.Rid <= 8);
            using (StreamWriter writer =
            new StreamWriter(@"C:\Users\lenovo\Desktop\t.txt", true))
            {
                foreach (var q in result)
                {
                    writer.WriteLine(q.PTid);
                }
            }





        }

        [TestMethod]
        public void TestRole()
        {
            RoleDal role = new RoleDal();
            //role.Insert(new Role {Rid = 1,Rname = "hahaha", Rscore = 3.3 });
            //role.Delete(new Role {Rname = "hahaha"});
            var result = role.GetEntities(p => p.Rscore <= 8);
             using (StreamWriter writer =
             new StreamWriter(@"C:\Users\lenovo\Desktop\t.txt", true))
             {
                 foreach (var q in result)
                 {
                     writer.WriteLine(q.Rname);
                 }
             }





        }


        /*[TestMethod]
        public void TestSchoolDal()
        {
            var sdl = new SchoolOp();
            var schools = sdl.Query(i => i.Sname == "aa" && i.Sprovince == "bj");
            sdl.Insert(new School() { });
        }*/

        //[TestMethod]
        //public void TestMethod()
        //{
        //    ConnSql C = new ConnSql();
        //    C.Open();
        //    C.Close();
        //}


        //[TestMethod]
        //public void TestMethodECleader()
        //{
        //    ECleaderModel ecleader = new ECleaderModel();
        //    //ecleader.CreateAct("eee",2017,"xxx",5.5);
        //    ecleader.CreateRole("asas",3.3);
        //    //var acd = new ActivityDal();
        //    //acd.Insert(new Activity() { Aname = "ppp", Ayear = 2, Aloc = "xxx", Arate = 4.4});

        //}

        //[TestMethod]
        //public void TestMethodboard()
        //{
        //    BoardMemberModel b = new BoardMemberModel();
        //    DateTime dt = new DateTime(2007, 1, 1, 21, 21, 21);
        //    DateTime dt2 = new DateTime(2017, 1, 1, 21, 21, 21);
        //    var result = b.CmpuPointsByGivenTime(dt, dt2);
        //    var enumerator = result.GetEnumerator();
        //    using (StreamWriter writer =
        //     new StreamWriter(@"C:\Users\lenovo\Desktop\t.txt", true))
        //    {
        //        while (enumerator.MoveNext())
        //        {
        //            writer.WriteLine(enumerator.Current);
        //        }
        //    }
        //    //b.CreateSchool("hhh","211","1234");
        //}


    }
}
