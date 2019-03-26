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
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }
        UniversityContext ctx = DbSingleTone.GetInstance();

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent fs = new FormStudent();
            fs.Show();
            FormEnter fe = new FormEnter();
            fe.Close();
            this.Hide();
        }

        private void eğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeacher ft = new FormTeacher();
            ft.Show();
            FormEnter fe = new FormEnter();
            fe.Close();
            this.Hide();
        }

        private void öğrenciEğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelation fr = new FormRelation();
            fr.Show();
            FormEnter fe = new FormEnter();
            fe.Close();
            this.Hide();
        }
    }
}
