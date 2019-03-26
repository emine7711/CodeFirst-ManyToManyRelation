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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }
        UniversityContext ctx = DbSingleTone.GetInstance();

        //Students form classındakilerle aynı şekilde teacher form classında da ekleme güncelleme ve silme işlemleri yapılır
        public void FillTeacher()
        {
            var teacherList = ctx.Teachers.Select(x => new
            {
                x.ID,
                x.Name,
                x.Surname
            }).ToList();
            dgTeacher.DataSource = teacherList;
        }
        private void FormTeacher_Load(object sender, EventArgs e)
        {
            FillTeacher();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Name = txtName.Text;
            t.Surname = txtSurname.Text;
            ctx.Teachers.Add(t);
            ctx.SaveChanges();
            FillTeacher();
        }
        public static int selectedID;
        private void dgTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = Convert.ToInt32(dgTeacher.CurrentRow.Cells[0].Value);
            var teacherList=ctx.Teachers.Where(x=>x.ID==selectedID).Select(x => new
            {
                EgitmenID = x.ID,
                Ad = x.Name,
                Soyad = x.Surname
            }).FirstOrDefault();
            txtName.Text = teacherList.Ad.ToString();
            txtSurname.Text = teacherList.Soyad.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedID = Convert.ToInt32(dgTeacher.CurrentRow.Cells[0].Value);
            var teacherList = ctx.Teachers.Find(selectedID);
            teacherList.Name = txtName.Text;
            teacherList.Surname = txtSurname.Text;
            ctx.SaveChanges();
            FillTeacher();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedID = Convert.ToInt32(dgTeacher.CurrentRow.Cells[0].Value);
            var teacherList = ctx.Teachers.Find(selectedID);
            ctx.Teachers.Remove(teacherList);
            ctx.SaveChanges();
            FillTeacher();
        }
    }
}
