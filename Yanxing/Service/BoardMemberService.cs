using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Yanxing.DataAccess;
using Yanxing.Models;

namespace Yanxing.Service
{
    public class BoardMemberService
    {
        Helper _helper;

        public BoardMemberService() {
            _helper = new Helper();
        }

        /*calculate the memeber points by given time duration*/
        public IOrderedEnumerable<ScoresOutView> GenPointsByGivenTime(DateTime startTime, DateTime endTime) {
            long start = _helper.string2long(startTime.ToString()),
                end = _helper.string2long(endTime.ToString());

            var pvdal = new PointsViewDal();
            //query by the given time duration
            var points = pvdal.GetEntities(m=> m.time>=start && m.time<=end);
            var query = points.GroupBy(m => new { Name = m.name, Tel = m.tel, Grade=m.grade})
                .Select(k => new ScoresOutView{ Name = k.Key.Name, Tel = k.Key.Tel, Grade=k.Key.Grade, Scores = k.Sum(l => l.point) })
                .OrderByDescending(l => l.Scores);

            return query;
        }

        /*Create new school profile.*/
        public bool CreateSchool(School school) {
            bool res = true;
            DateTime dt = DateTime.Now;  /*get date now*/

            try
            {
                var sdl = new SchoolDal();
                sdl.Insert(school);
            }
            catch (Exception e)
            {
                res = false;
                using (StreamWriter writer =
               new StreamWriter(@"C:\Users\JJH\Desktop\log.txt", true))
                {
                    writer.WriteLine(dt.ToString());
                    writer.WriteLine(e.Message);
                    writer.WriteLine(e.StackTrace);
                }
            }

            return res;
        }

        public bool UpdatePrivateInfo() {
            throw new NotImplementedException();
        }
    }
}