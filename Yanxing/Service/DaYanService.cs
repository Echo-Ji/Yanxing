using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.DataAccess;
using Yanxing.Models;

namespace Yanxing.Service
{
    public class DaYanService
    {
        private Person _person;
        private DaYan _dayan;
        private PersonDal _persondal;
        private DaYanDal _dayandal;

        public DaYanService(string username)
        {
            _persondal = new PersonDal();
            _dayandal = new DaYanDal();
            var resultp = _persondal.GetEntities(i => i.Username == username);
            foreach (var p in resultp)
            {
                _person = p;
            }
            var resultd = _dayandal.GetEntities(i => i.PID == _person.PID);
            foreach (var d in resultd)
            {
                _dayan = d;
            }
        }

        public void update_inform(Person person,DaYan dayan)
        {
            _persondal.Update(person);
            _dayandal.Update(dayan);
        }
    }
}