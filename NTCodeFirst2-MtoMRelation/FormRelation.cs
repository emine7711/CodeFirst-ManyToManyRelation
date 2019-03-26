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
    public partial class FormRelation : Form
    {
        public FormRelation()
        {
            InitializeComponent();
        }
        UniversityContext ctx = DbSingleTone.GetInstance();
        public void FillRelation()//Teacher a ait öğrenci bilgileriyle birlikte anonym type kullanılarak relationlist nesnesi oluşturulur
        {                         //ve datagride kaynak olarak atanır
            var relationlist = ctx.Teachers.Select(x => new
            {
                x.ID,
                x.Name,
                x.Surname,
                x.students
            }).ToList();
            dgRelation.DataSource = relationlist;
        }
        public void FillTeacherCombo()//Eğitmenlerin seçildiği combobox doldurma metodu
        {
            var teacherList = ctx.Teachers.Select(x => new //anonym type kullanımı
            {
                EgitmenID=x.ID,
                Egitmen=x.Name + " "+x.Surname,//string birleştirme
            }).ToList();
            cbTeacher.DisplayMember = "Egitmen";//Comboboxta görünen veri kolonu
            cbTeacher.ValueMember = "EgitmenID";//Arkada tutulan veri kolonu
            cbTeacher.DataSource = teacherList;
        }
        public void FillStudentLB()//listbox ı öğrenci listesiyle doldurma metodu
        {
            var studentList=ctx.Students.Select(x => new
            {
                OgrenciID = x.ID,
                Ogrenci = x.Name + " " + x.Surname,
            }).ToList();
            lbStudent.DisplayMember = "Ogrenci";
            lbStudent.ValueMember = "OgrenciID";
            lbStudent.DataSource = studentList;
        }

        private void FormRelation_Load(object sender, EventArgs e)//Form açıldığında combobox ve listbox doldurulur
        {
            FillStudentLB();
            FillTeacherCombo();
        }
        
        private void btnRelation_Click(object sender, EventArgs e)//ilişkilendir butonuna basıldığında
        {
            int selectedTID=(int)cbTeacher.SelectedValue;//combodan seçilen eğitmen IDsi alınır
            int selectedSID = (int)lbStudent.SelectedValue;//listboxtan seçilen öğrenci IDsi alınır
            var teacherList = ctx.Teachers.Find(selectedTID);//Teachers entitysinde eğitmenin IDsi bulunur
            var studentList = ctx.Students.Find(selectedSID);//Students entitysinde de öğrencinin IDsi bulunur
            teacherList.students.Add(studentList);//bulunan öğrenci, bulunmuş olan öğretmene eklenir
            ctx.SaveChanges();//değişiklikler veritabanına kaydedilir.
            
        }
    }
}
