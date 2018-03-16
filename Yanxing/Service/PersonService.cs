using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Yanxing.DataAccess;
using Yanxing.Models;


namespace Yanxing.Service
{
    public class PersonService
    {
        PersonDal _pdl;

        public PersonService() {
            _pdl = new PersonDal();
        }
        /*Retrieve the basic infomation by condition.*/
        public IEnumerable<Person> GetAll(Expression<Func<Person, bool>> predicate)
        {     
            var _model = _pdl.GetEntities(predicate);
            return _model;
        }
    }
}