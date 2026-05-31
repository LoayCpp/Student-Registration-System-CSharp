namespace StudentRegistrationSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnIAbout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.rdAdvanced = new System.Windows.Forms.RadioButton();
            this.rdIntermediate = new System.Windows.Forms.RadioButton();
            this.rdBeginner = new System.Windows.Forms.RadioButton();
            this.gbSkills = new System.Windows.Forms.GroupBox();
            this.chbSQL = new System.Windows.Forms.CheckBox();
            this.chbJavaScript = new System.Windows.Forms.CheckBox();
            this.chbCplus = new System.Windows.Forms.CheckBox();
            this.chbCsharp = new System.Windows.Forms.CheckBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbLevel.SuspendLayout();
            this.gbSkills.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(214, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(372, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Student Registration System";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.Navy;
            this.lblSubtitle.Location = new System.Drawing.Point(249, 69);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(308, 20);
            this.lblSubtitle.TabIndex = 3;
            this.lblSubtitle.Text = "Fill the form below to register a new student";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbLevel);
            this.panel1.Controls.Add(this.gbSkills);
            this.panel1.Controls.Add(this.gbGender);
            this.panel1.Controls.Add(this.gbInformation);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 328);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnIAbout);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(6, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(6, 71);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 41);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.Cursor_Hand);
            // 
            // btnIAbout
            // 
            this.btnIAbout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIAbout.ForeColor = System.Drawing.Color.White;
            this.btnIAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIAbout.Location = new System.Drawing.Point(133, 71);
            this.btnIAbout.Name = "btnIAbout";
            this.btnIAbout.Size = new System.Drawing.Size(119, 41);
            this.btnIAbout.TabIndex = 14;
            this.btnIAbout.Text = "About";
            this.btnIAbout.UseVisualStyleBackColor = false;
            this.btnIAbout.Click += new System.EventHandler(this.btnIAbout_Click);
            this.btnIAbout.MouseEnter += new System.EventHandler(this.Cursor_Hand);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(133, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 41);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.Cursor_Hand);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 41);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.Cursor_Hand);
            // 
            // gbLevel
            // 
            this.gbLevel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbLevel.Controls.Add(this.rdAdvanced);
            this.gbLevel.Controls.Add(this.rdIntermediate);
            this.gbLevel.Controls.Add(this.rdBeginner);
            this.gbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbLevel.ForeColor = System.Drawing.Color.DarkRed;
            this.gbLevel.Location = new System.Drawing.Point(312, 132);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(117, 118);
            this.gbLevel.TabIndex = 5;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level";
            // 
            // rdAdvanced
            // 
            this.rdAdvanced.AutoSize = true;
            this.rdAdvanced.ForeColor = System.Drawing.Color.Black;
            this.rdAdvanced.Location = new System.Drawing.Point(3, 83);
            this.rdAdvanced.Name = "rdAdvanced";
            this.rdAdvanced.Size = new System.Drawing.Size(99, 24);
            this.rdAdvanced.TabIndex = 7;
            this.rdAdvanced.Tag = "Advanced";
            this.rdAdvanced.Text = "Advanced";
            this.rdAdvanced.UseVisualStyleBackColor = true;
            // 
            // rdIntermediate
            // 
            this.rdIntermediate.AutoSize = true;
            this.rdIntermediate.ForeColor = System.Drawing.Color.Black;
            this.rdIntermediate.Location = new System.Drawing.Point(4, 55);
            this.rdIntermediate.Name = "rdIntermediate";
            this.rdIntermediate.Size = new System.Drawing.Size(118, 24);
            this.rdIntermediate.TabIndex = 6;
            this.rdIntermediate.Tag = "Intermediate";
            this.rdIntermediate.Text = "Intermediate";
            this.rdIntermediate.UseVisualStyleBackColor = true;
            // 
            // rdBeginner
            // 
            this.rdBeginner.AutoSize = true;
            this.rdBeginner.Checked = true;
            this.rdBeginner.ForeColor = System.Drawing.Color.Black;
            this.rdBeginner.Location = new System.Drawing.Point(6, 27);
            this.rdBeginner.Name = "rdBeginner";
            this.rdBeginner.Size = new System.Drawing.Size(92, 24);
            this.rdBeginner.TabIndex = 5;
            this.rdBeginner.TabStop = true;
            this.rdBeginner.Tag = "Beginner";
            this.rdBeginner.Text = "Beginner";
            this.rdBeginner.UseVisualStyleBackColor = true;
            // 
            // gbSkills
            // 
            this.gbSkills.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbSkills.Controls.Add(this.chbSQL);
            this.gbSkills.Controls.Add(this.chbJavaScript);
            this.gbSkills.Controls.Add(this.chbCplus);
            this.gbSkills.Controls.Add(this.chbCsharp);
            this.gbSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSkills.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbSkills.ForeColor = System.Drawing.Color.Indigo;
            this.gbSkills.Location = new System.Drawing.Point(435, 8);
            this.gbSkills.Name = "gbSkills";
            this.gbSkills.Size = new System.Drawing.Size(262, 156);
            this.gbSkills.TabIndex = 2;
            this.gbSkills.TabStop = false;
            this.gbSkills.Text = "Skills";
            // 
            // chbSQL
            // 
            this.chbSQL.AutoSize = true;
            this.chbSQL.ForeColor = System.Drawing.Color.Black;
            this.chbSQL.Location = new System.Drawing.Point(26, 124);
            this.chbSQL.Name = "chbSQL";
            this.chbSQL.Size = new System.Drawing.Size(57, 24);
            this.chbSQL.TabIndex = 11;
            this.chbSQL.Tag = "SQL";
            this.chbSQL.Text = "SQL";
            this.chbSQL.UseVisualStyleBackColor = true;
            // 
            // chbJavaScript
            // 
            this.chbJavaScript.AutoSize = true;
            this.chbJavaScript.ForeColor = System.Drawing.Color.Black;
            this.chbJavaScript.Location = new System.Drawing.Point(26, 92);
            this.chbJavaScript.Name = "chbJavaScript";
            this.chbJavaScript.Size = new System.Drawing.Size(102, 24);
            this.chbJavaScript.TabIndex = 10;
            this.chbJavaScript.Tag = "JavaScript";
            this.chbJavaScript.Text = "JavaScript";
            this.chbJavaScript.UseVisualStyleBackColor = true;
            // 
            // chbCplus
            // 
            this.chbCplus.AutoSize = true;
            this.chbCplus.ForeColor = System.Drawing.Color.Black;
            this.chbCplus.Location = new System.Drawing.Point(26, 60);
            this.chbCplus.Name = "chbCplus";
            this.chbCplus.Size = new System.Drawing.Size(61, 24);
            this.chbCplus.TabIndex = 9;
            this.chbCplus.Tag = "C++";
            this.chbCplus.Text = "C++";
            this.chbCplus.UseVisualStyleBackColor = true;
            // 
            // chbCsharp
            // 
            this.chbCsharp.AutoSize = true;
            this.chbCsharp.ForeColor = System.Drawing.Color.Black;
            this.chbCsharp.Location = new System.Drawing.Point(26, 28);
            this.chbCsharp.Name = "chbCsharp";
            this.chbCsharp.Size = new System.Drawing.Size(50, 24);
            this.chbCsharp.TabIndex = 8;
            this.chbCsharp.Tag = "C#";
            this.chbCsharp.Text = "C#";
            this.chbCsharp.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbGender.Controls.Add(this.rdFemale);
            this.gbGender.Controls.Add(this.rdMale);
            this.gbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbGender.ForeColor = System.Drawing.Color.Green;
            this.gbGender.Location = new System.Drawing.Point(312, 5);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(97, 107);
            this.gbGender.TabIndex = 1;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.ForeColor = System.Drawing.Color.Black;
            this.rdFemale.Location = new System.Drawing.Point(4, 57);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(80, 24);
            this.rdFemale.TabIndex = 4;
            this.rdFemale.TabStop = true;
            this.rdFemale.Tag = "Fenmale";
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.ForeColor = System.Drawing.Color.Black;
            this.rdMale.Location = new System.Drawing.Point(6, 27);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(64, 24);
            this.rdMale.TabIndex = 3;
            this.rdMale.TabStop = true;
            this.rdMale.Tag = "Male";
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // gbInformation
            // 
            this.gbInformation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbInformation.Controls.Add(this.txtPhone);
            this.gbInformation.Controls.Add(this.txtEmail);
            this.gbInformation.Controls.Add(this.txtName);
            this.gbInformation.Controls.Add(this.lblphone);
            this.gbInformation.Controls.Add(this.lblEmail);
            this.gbInformation.Controls.Add(this.lblName);
            this.gbInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbInformation.ForeColor = System.Drawing.Color.Navy;
            this.gbInformation.Location = new System.Drawing.Point(6, 3);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(287, 197);
            this.gbInformation.TabIndex = 0;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Student Information";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(94, 140);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(178, 35);
            this.txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 89);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 35);
            this.txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 37);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 35);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.ForeColor = System.Drawing.Color.Black;
            this.lblphone.Location = new System.Drawing.Point(26, 150);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(60, 20);
            this.lblphone.TabIndex = 2;
            this.lblphone.Text = "Phone :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(29, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(27, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::StudentRegistrationSystem.Properties.Resources._68c07b66cdba4;
            this.pictureBox3.Location = new System.Drawing.Point(451, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(298, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(682, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Student Registration System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbLevel.ResumeLayout(false);
            this.gbLevel.PerformLayout();
            this.gbSkills.ResumeLayout(false);
            this.gbSkills.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.GroupBox gbSkills;
        private System.Windows.Forms.CheckBox chbCsharp;
        private System.Windows.Forms.CheckBox chbSQL;
        private System.Windows.Forms.CheckBox chbJavaScript;
        private System.Windows.Forms.CheckBox chbCplus;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.RadioButton rdIntermediate;
        private System.Windows.Forms.RadioButton rdBeginner;
        private System.Windows.Forms.RadioButton rdAdvanced;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnIAbout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

