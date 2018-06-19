namespace ocenki
{
    partial class newStudent
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
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_group = new System.Windows.Forms.ComboBox();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_done = new System.Windows.Forms.Button();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(27, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(232, 29);
            this.title.TabIndex = 4;
            this.title.Text = "Добавить студента";
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
            this.cb_course.Location = new System.Drawing.Point(32, 187);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(227, 24);
            this.cb_course.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Курс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Группа";
            // 
            // cb_group
            // 
            this.cb_group.FormattingEnabled = true;
            this.cb_group.Location = new System.Drawing.Point(32, 135);
            this.cb_group.Name = "cb_group";
            this.cb_group.Size = new System.Drawing.Size(227, 24);
            this.cb_group.TabIndex = 14;
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(31, 262);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(68, 24);
            this.b_cancel.TabIndex = 17;
            this.b_cancel.Text = "Отмена";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_done
            // 
            this.b_done.Location = new System.Drawing.Point(191, 262);
            this.b_done.Name = "b_done";
            this.b_done.Size = new System.Drawing.Size(68, 24);
            this.b_done.TabIndex = 16;
            this.b_done.Text = "Готово";
            this.b_done.UseVisualStyleBackColor = true;
            this.b_done.Click += new System.EventHandler(this.b_done_Click);
            // 
            // cb_name
            // 
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(32, 89);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(227, 24);
            this.cb_name.TabIndex = 18;
            // 
            // newStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 298);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.title);
            this.Name = "newStudent";
            this.Text = "newStudent";
            this.Load += new System.EventHandler(this.newStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox cb_course;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_group;
        public System.Windows.Forms.Button b_cancel;
        public System.Windows.Forms.Button b_done;
        private System.Windows.Forms.ComboBox cb_name;
    }
}