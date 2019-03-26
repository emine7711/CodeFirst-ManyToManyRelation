namespace NTCodeFirst2_MtoMRelation
{
    partial class FormRelation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgRelation = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStudent = new System.Windows.Forms.ListBox();
            this.btnRelation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelation)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTeacher
            // 
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(91, 48);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(121, 21);
            this.cbTeacher.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eğitmen";
            // 
            // dgRelation
            // 
            this.dgRelation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRelation.Location = new System.Drawing.Point(27, 149);
            this.dgRelation.Name = "dgRelation";
            this.dgRelation.Size = new System.Drawing.Size(240, 150);
            this.dgRelation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci:";
            // 
            // lbStudent
            // 
            this.lbStudent.FormattingEnabled = true;
            this.lbStudent.Location = new System.Drawing.Point(412, 149);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(120, 147);
            this.lbStudent.TabIndex = 4;
            // 
            // btnRelation
            // 
            this.btnRelation.Location = new System.Drawing.Point(27, 327);
            this.btnRelation.Name = "btnRelation";
            this.btnRelation.Size = new System.Drawing.Size(75, 23);
            this.btnRelation.TabIndex = 5;
            this.btnRelation.Text = "İlişkilendir";
            this.btnRelation.UseVisualStyleBackColor = true;
            this.btnRelation.Click += new System.EventHandler(this.btnRelation_Click);
            // 
            // FormRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRelation);
            this.Controls.Add(this.lbStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgRelation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTeacher);
            this.Name = "FormRelation";
            this.Text = "Formİliski";
            this.Load += new System.EventHandler(this.FormRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRelation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgRelation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbStudent;
        private System.Windows.Forms.Button btnRelation;
    }
}