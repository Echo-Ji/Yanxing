using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.DataAccess;
using Yanxing.Models;

namespace Yanxing.Service
{
    public class XiaoYanService
    {
        public Person _person;
        public XiaoYan _xiaoyan;
        private PersonDal _persondal;
        private XiaoYanDal _xiaoyandal;

        public XiaoYanService(string username)
        {
            _persondal = new PersonDal();
            _xiaoyandal = new XiaoYanDal();
            var resultp = _persondal.GetEntities(i => i.Username == username);
            foreach (var p in resultp)
            {
                _person = p;
            }
            if (_person != null)
            {
                var resultx = _xiaoyandal.GetEntities(i => i.PID == _person.PID);
                foreach (var x in resultx)
                {
                    _xiaoyan = x;
                }
            }
            
        }

        public void updateInfo(Person person, XiaoYan xiaoyan)
        {
            _persondal.Update(person);
            _xiaoyandal.Update(xiaoyan);
        }
    }
}