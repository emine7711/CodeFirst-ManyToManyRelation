using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst2_MtoMRelation.Entities
{
    public class Student
    {   //Student classının özellikleri,veri tabanındaki Students tablosunun kolonlarını oluşturur
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Teacher> teachers { get; set; }//Bir öğrencinin birden fazla öğretmeni olabileceği için collection tanımlanır
    }
}
