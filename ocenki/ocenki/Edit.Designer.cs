namespace ocenki
{
    partial class Edit
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
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.newStudent = new System.Windows.Forms.Button();
            this.n_mark = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.b_done = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_subj = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.n_mark)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(40, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(218, 29);
            this.title.TabIndex = 3;
            this.title.Text = "Изменить запись";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Студент";
            // 
            // cb_student
            // 
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(38, 86);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(189, 24);
            this.cb_student.TabIndex = 8;
            // 
            // newStudent
            // 
            this.newStudent.Location = new System.Drawing.Point(233, 86);
            this.newStudent.Name = "newStudent";
            this.newStudent.Size = new System.Drawing.Size(33, 24);
            this.newStudent.TabIndex = 9;
            this.newStudent.Text = "...";
            this.newStudent.UseVisualStyleBackColor = true;
            this.newStudent.Click += new System.EventHandler(this.newStudent_Click);
            // 
            // n_mark
            // 
            this.n_mark.Location = new System.Drawing.Point(113, 252);
            this.n_mark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.n_mark.Name = "n_mark";
            this.n_mark.Size = new System.Drawing.Size(43, 22);
            this.n_mark.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Оценка";
            // 
            // b_done
            // 
            this.b_done.Location = new System.Drawing.Point(198, 306);
            this.b_done.Name = "b_done";
            this.b_done.Size = new System.Drawing.Size(68, 24);
            this.b_done.TabIndex = 12;
            this.b_done.Text = "Готово";
            this.b_done.UseVisualStyleBackColor = true;
            this.b_done.Click += new System.EventHandler(this.b_done_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(38, 306);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(68, 24);
            this.b_cancel.TabIndex = 13;
            this.b_cancel.Text = "Отмена";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Курс";
            // 
            // cb_course
            // 
            this.cb_course.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_course.Location = new System.Drawing.Point(38, 206);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(228, 24);
            this.cb_course.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Предмет";
            // 
            // cb_subj
            // 
            this.cb_subj.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_subj.FormattingEnabled = true;
            this.cb_subj.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_subj.Location = new System.Drawing.Point(38, 159);
            this.cb_subj.Name = "cb_subj";
            this.cb_subj.Size = new System.Drawing.Size(228, 24);
            this.cb_subj.TabIndex = 16;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_subj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_done);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_mark);
            this.Controls.Add(this.newStudent);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cb_student;
        public System.Windows.Forms.Button newStudent;
        public System.Windows.Forms.NumericUpDown n_mark;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button b_done;
        public System.Windows.Forms.Button b_cancel;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_course;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_subj;
    }
}