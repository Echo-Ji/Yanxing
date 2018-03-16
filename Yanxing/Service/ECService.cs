using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Yanxing.DataAccess;
using Yanxing.Models;

namespace Yanxing.Service
{
    public class ECService
    {
        public Person _person;
        public XiaoYan _ec;
        private PersonDal _persondal;
        private XiaoYanDal _ecdal;
        private XiaoYanDal _memdal;
        private AccountDal _account;

        public ECService(string username)
        {
            _persondal = new PersonDal();
            _ecdal = new XiaoYanDal();
            _memdal = new XiaoYanDal();
            _account = new AccountDal();
            var resultp = _persondal.GetEntities(i => i.Username == username);
            foreach (var p in resultp)
            {
                _person = p;
            }
            var resulte = _ecdal.GetEntities(i => i.PID == _person.PID);
            foreach (var e in resulte)
            {
                _ec = e;
            }
        }

        //修改自己的信息
        public void updateInfo(Person person, XiaoYan ec)
        {
            _persondal.Update(person);
            _ecdal.Update(ec);
        }


        public void deleteMem(Guid pid)
        {
            var mems = _ecdal.GetEntities(m => m.PID == pid);
            XiaoYan xy=null;
            foreach (var mem in mems) {
                xy = mem;
            }
            var pers = _persondal.GetEntities(m => m.PID == pid);
            Person ps = null;
            foreach(var per in pers) {
                ps = per;
            }
            var accs = _account.GetEntities(m => m.Username == ps.Username);
            Account at = null;
            foreach(var acc in accs)
            {
                at = acc;
            }
            if (xy != null) {
                
                _memdal.Delete(xy);
                _persondal.Delete(ps);
                _account.Delete(at);


            }
        }


        public bool insertMem(Account account,Person person, XiaoYan xiaoyan)
        {
            bool res = true;
            try
            {
                _account.Insert(account);
                _persondal.Insert(person);
                _memdal.Insert(xiaoyan);
                
            }
            catch (Exception e)
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
            return (res);
        }

        /*会将外校的修改为本校的*/
        public bool updateMem(Person person,XiaoYan xiaoyan)
        {//update member who is only xiaoyan
            bool res = true;
            try
            {
                if (person.Pgrade == "XiaoYan" && person.PID == xiaoyan.PID)
                {
                    _persondal.Update(person);
                    _memdal.Update(xiaoyan);
                }
                else return false;
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


        /*Update your school profile.*/
        public bool updateSchool(School school) {
            bool res = true;
            
            try
            {
                var sdl = new SchoolDal();
                sdl.Update(school);
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

            return res;
        }


        public bool insertParticipant(Participant participant) {
            bool res = true;
            try
            {
                var ptdl = new ParticipantDal();
                ptdl.Insert(participant);
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

            return res;
        }

        public bool updateParticipant(Participant participant)
        {
            bool res = true;
            try
            {
                var ptdl = new ParticipantDal();
                ptdl.Update(participant);
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

            return res;
        }
    }
}