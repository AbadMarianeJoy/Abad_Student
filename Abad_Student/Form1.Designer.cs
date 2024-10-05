using System;
using System.Windows.Forms;

namespace Abad_Student
{
    partial class STUDENT_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STUDENT_FORM));
            this.FORM = new System.Windows.Forms.Label();
            this.LNAME_Label = new System.Windows.Forms.Label();
            this.COURSE = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.Label();
            this.GENDER = new System.Windows.Forms.Label();
            this.MNAME_label = new System.Windows.Forms.Label();
            this.FNAME_label = new System.Windows.Forms.Label();
            this.text_Lastname = new System.Windows.Forms.TextBox();
            this.text_Firstname = new System.Windows.Forms.TextBox();
            this.text_Middlename = new System.Windows.Forms.TextBox();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.comboBox_Program = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_Browse = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FORM
            // 
            this.FORM.AutoSize = true;
            this.FORM.BackColor = System.Drawing.Color.Transparent;
            this.FORM.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FORM.Location = new System.Drawing.Point(16, 9);
            this.FORM.Name = "FORM";
            this.FORM.Size = new System.Drawing.Size(458, 34);
            this.FORM.TabIndex = 0;
            this.FORM.Text = "Student Registration form";
            // 
            // LNAME_Label
            // 
            this.LNAME_Label.AutoSize = true;
            this.LNAME_Label.BackColor = System.Drawing.Color.Transparent;
            this.LNAME_Label.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNAME_Label.Location = new System.Drawing.Point(35, 61);
            this.LNAME_Label.Name = "LNAME_Label";
            this.LNAME_Label.Size = new System.Drawing.Size(89, 18);
            this.LNAME_Label.TabIndex = 1;
            this.LNAME_Label.Text = "Last name*";
            // 
            // COURSE
            // 
            this.COURSE.AutoSize = true;
            this.COURSE.BackColor = System.Drawing.Color.Transparent;
            this.COURSE.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COURSE.Location = new System.Drawing.Point(19, 330);
            this.COURSE.Name = "COURSE";
            this.COURSE.Size = new System.Drawing.Size(166, 18);
            this.COURSE.TabIndex = 3;
            this.COURSE.Text = "Program to be Apply*";
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.BackColor = System.Drawing.Color.Transparent;
            this.Birth.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth.Location = new System.Drawing.Point(35, 265);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(77, 18);
            this.Birth.TabIndex = 4;
            this.Birth.Text = "Birthday*";
            // 
            // GENDER
            // 
            this.GENDER.AutoSize = true;
            this.GENDER.BackColor = System.Drawing.Color.Transparent;
            this.GENDER.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDER.Location = new System.Drawing.Point(35, 219);
            this.GENDER.Name = "GENDER";
            this.GENDER.Size = new System.Drawing.Size(68, 18);
            this.GENDER.TabIndex = 5;
            this.GENDER.Text = "Gender*";
            // 
            // MNAME_label
            // 
            this.MNAME_label.AutoSize = true;
            this.MNAME_label.BackColor = System.Drawing.Color.Transparent;
            this.MNAME_label.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNAME_label.Location = new System.Drawing.Point(35, 171);
            this.MNAME_label.Name = "MNAME_label";
            this.MNAME_label.Size = new System.Drawing.Size(107, 18);
            this.MNAME_label.TabIndex = 6;
            this.MNAME_label.Text = "Middle name*";
            // 
            // FNAME_label
            // 
            this.FNAME_label.AutoSize = true;
            this.FNAME_label.BackColor = System.Drawing.Color.Transparent;
            this.FNAME_label.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNAME_label.Location = new System.Drawing.Point(34, 117);
            this.FNAME_label.Name = "FNAME_label";
            this.FNAME_label.Size = new System.Drawing.Size(91, 18);
            this.FNAME_label.TabIndex = 7;
            this.FNAME_label.Text = "First name*";
            // 
            // text_Lastname
            // 
            this.text_Lastname.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Lastname.Location = new System.Drawing.Point(69, 82);
            this.text_Lastname.Name = "text_Lastname";
            this.text_Lastname.Size = new System.Drawing.Size(309, 22);
            this.text_Lastname.TabIndex = 8;
            // 
            // text_Firstname
            // 
            this.text_Firstname.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Firstname.Location = new System.Drawing.Point(69, 138);
            this.text_Firstname.Name = "text_Firstname";
            this.text_Firstname.Size = new System.Drawing.Size(309, 22);
            this.text_Firstname.TabIndex = 9;
            // 
            // text_Middlename
            // 
            this.text_Middlename.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Middlename.Location = new System.Drawing.Point(69, 187);
            this.text_Middlename.Name = "text_Middlename";
            this.text_Middlename.Size = new System.Drawing.Size(309, 22);
            this.text_Middlename.TabIndex = 10;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Male.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.ForeColor = System.Drawing.Color.Black;
            this.radioButton_Male.Location = new System.Drawing.Point(86, 238);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(56, 20);
            this.radioButton_Male.TabIndex = 11;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = false;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Female.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.Location = new System.Drawing.Point(166, 238);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(67, 20);
            this.radioButton_Female.TabIndex = 12;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = false;
            // 
            // comboBox_Day
            // 
            this.comboBox_Day.FormattingEnabled = true;
            this.comboBox_Day.Location = new System.Drawing.Point(86, 286);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(83, 21);
            this.comboBox_Day.TabIndex = 13;
            this.comboBox_Day.Text = "-Day-";
            // 
            // comboBox_Month
            // 
            this.comboBox_Month.FormattingEnabled = true;
            this.comboBox_Month.Location = new System.Drawing.Point(185, 286);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(103, 21);
            this.comboBox_Month.TabIndex = 14;
            this.comboBox_Month.Text = "-Month-";
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Location = new System.Drawing.Point(307, 286);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(71, 21);
            this.comboBox_Year.TabIndex = 15;
            this.comboBox_Year.Text = "-Year-";
            // 
            // comboBox_Program
            // 
            
            this.comboBox_Program.Location = new System.Drawing.Point(69, 351);
            this.comboBox_Program.Name = "comboBox_Program";
            this.comboBox_Program.Size = new System.Drawing.Size(309, 24);
            this.comboBox_Program.TabIndex = 16;
            this.comboBox_Program.Text = "-Select Program-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-428, -704);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.IndianRed;
            this.button_Register.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Location = new System.Drawing.Point(90, 381);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(182, 24);
            this.button_Register.TabIndex = 18;
            this.button_Register.Text = "Register Student";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_Browse
            // 
            this.button_Browse.BackColor = System.Drawing.Color.IndianRed;
            this.button_Browse.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Browse.ForeColor = System.Drawing.Color.Black;
            this.button_Browse.Location = new System.Drawing.Point(542, 265);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(102, 28);
            this.button_Browse.TabIndex = 19;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(471, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // STUDENT_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 417);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_Program);
            this.Controls.Add(this.comboBox_Year);
            this.Controls.Add(this.comboBox_Month);
            this.Controls.Add(this.comboBox_Day);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.text_Middlename);
            this.Controls.Add(this.text_Firstname);
            this.Controls.Add(this.text_Lastname);
            this.Controls.Add(this.FNAME_label);
            this.Controls.Add(this.MNAME_label);
            this.Controls.Add(this.GENDER);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.COURSE);
            this.Controls.Add(this.LNAME_Label);
            this.Controls.Add(this.FORM);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "STUDENT_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


     

        #endregion

        private System.Windows.Forms.Label FORM;
        private System.Windows.Forms.Label LNAME_Label;
        private System.Windows.Forms.Label COURSE;
        private System.Windows.Forms.Label Birth;
        private System.Windows.Forms.Label GENDER;
        private System.Windows.Forms.Label MNAME_label;
        private System.Windows.Forms.Label FNAME_label;
        private System.Windows.Forms.TextBox text_Lastname;
        private System.Windows.Forms.TextBox text_Firstname;
        private System.Windows.Forms.TextBox text_Middlename;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Program;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private EventHandler pictureBox1_Click;
        private EventHandler pictureBox2_Click;

        public EventHandler FORM_Click { get; private set; }
    }
}

