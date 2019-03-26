namespace NTCodeFirst2_MtoMRelation
{
    using NTCodeFirst2_MtoMRelation.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UniversityContext : DbContext
    {
        public UniversityContext()
            : base("name=UniversityContext")
        {
        }
        //Student ve Teacher tipindeki DBSetler veritabanındaki Students ve Teachers tablolarını oluşturur
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
    
}