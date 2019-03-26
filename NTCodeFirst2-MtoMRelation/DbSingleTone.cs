using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst2_MtoMRelation
{
    public class DbSingleTone
    {
        public static UniversityContext ctx;
        public static UniversityContext GetInstance()
        {
            if (ctx==null)
            {
                ctx = new UniversityContext();
            }
            return ctx;
        }
    }
}
