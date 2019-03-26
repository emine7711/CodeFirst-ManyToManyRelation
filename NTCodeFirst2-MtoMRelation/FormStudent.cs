using NTCodeFirst2_MtoMRelation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTCodeFirst2_MtoMRelation
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        UniversityContext ctx = DbSingleTone.GetInstance();//context oluşturulur
        public void FillStudent()//lambda expiression ile Öğrenci Entitysindeki özellikler studentList nesnesine aktarılır
        {
            var studentList = ctx.Students.Select(x => new
            {
                x.ID,
                x.Name,
                x.Surname
            }).ToList();
            dgStudent.DataSource = studentList;//bu studentlist datagridview in kaynağı olarak atanır.
        }
        private void FormStudent_Load(object sender, EventArgs e)//Form açıldığında 
        {
            FillStudent();//datagridview in yüklenmesi sağlanır
        }
        private void btnInsert_Click(object sender, EventArgs e)//Ekle butonuna basıldığında
        {
            Student s = new Student();//Student classından bir nesne oluşturulur ve özellikleri atanır
            s.Name = txtName.Text;
            s.Surname = txtSurname.Text;
            ctx.Students.Add(s);//nesne entities e eklenir
            ctx.SaveChanges();//ve değişiklikler database e kaydedilir
            FillStudent();//kaydetme işleminden sonra datagridview güncellenir
        }
        public static int selectedID;//birkaç yerde kullanılması için static ID tanımlanır
        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)//datagridview e tıklandığında
        {
            selectedID = Convert.ToInt32(dgStudent.CurrentRow.Cells[0].Value);//datagrid in ilk sütunundaki ID static değişkene atanır
            var studentList = ctx.Students.Where(x => x.ID == selectedID).Select(x => new
            {
                OgrenciID = x.ID,
                Ad = x.Name,
                Soyad = x.Surname
            }).FirstOrDefault();//bu IDye eşit olan IDnin bilgileri studentList e atılır
            txtName.Text = studentList.Ad.ToString();//ID ye ait ad ve soyad ilgili alanlara basılır
            txtSurname.Text = studentList.Soyad.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)//Güncelle butonuna tıklandığında da datagridden 
        {                                                       //ID ile çekilen bilgiler ilgili alanlardakilerle güncellenir
            selectedID = Convert.ToInt32(dgStudent.CurrentRow.Cells[0].Value);
            var studentlist = ctx.Teachers.Find(selectedID);
            studentlist.Name = txtName.Text;
            studentlist.Surname = txtSurname.Text;
            ctx.SaveChanges();
            FillStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)//Sil butonuna basıldığında da datagridden çekilen 
                                                                //IDye ait bilgiler Remove()metodu ile entitiesden kaldırılır 
        {                                                       //ve değişiklikler database e kaydedilir,böylece kayıt silinmiş olur
            selectedID = Convert.ToInt32(dgStudent.CurrentRow.Cells[0].Value);
            var studentList = ctx.Teachers.Find(selectedID);
            ctx.Teachers.Remove(studentList);
            ctx.SaveChanges();
            FillStudent();
        }
    }
}
