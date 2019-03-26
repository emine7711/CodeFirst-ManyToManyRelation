using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst2_MtoMRelation.Entities
{
    public class Teacher
    {   //teacher classının özellikleri, veritabanındaki Teachers tablosunun kolonlarını oluşturur
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Student> students { get; set; }//Bir öğretmenin birden fazla öğrencisi olabileceği için collection tanımlanır.
    }
}
