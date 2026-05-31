using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class Form1 : Form
    {
        frmSave frSave = new frmSave();
        public Form1()
        {
            InitializeComponent();
            btnSave.Image = new Bitmap(Image.FromFile(@"Save.png"),new Size (20,20));
            btnClear.Image = new Bitmap(Image.FromFile(@"Clear.png"),new Size (20,20));
            btnIAbout.Image = new Bitmap(Image.FromFile(@"aboutt.png"),new Size (20,20));
            btnExit.Image = new Bitmap(Image.FromFile(@"Exit.png"),new Size (20,20));
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Cursor_Hand(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Cursor = Cursors.Hand;



        }
     
        private bool AreHaveNumber(string name)
        {
            for(int i=0; i < name.Length; i++)
            {
                if (char.IsNumber(name[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool AreHaveLatterOrSymbol(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (char.IsLetter(phone[i]) || char.IsSymbol(phone[i])|| char.IsPunctuation(phone[i]) || char.IsWhiteSpace(phone[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool AreHaveEmailLatter(string email)
        {
             return email.Contains("@gmail.com") ? true : false;
            
        }
        private bool CheckAboutTextBoxName()
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {

                if (AreHaveNumber(txtName.Text)){

                    MessageBox.Show("Please you cant`t Enter The Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("you cant`t Save name is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private bool CheckAboutTextBoxEmail()
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {

                if (!AreHaveEmailLatter(txtEmail.Text))
                {
                    MessageBox.Show("Email be *****@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("you cant`t Save Email is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private bool CheckAboutTextBoxPhone()
        {
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {

                if (AreHaveLatterOrSymbol(txtPhone.Text))
                {
                    MessageBox.Show("The Phone Can`t Contains Latter or Symbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("you cant`t Save Phone is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private string MaleOrFemale()
        {

            return rdMale.Checked ? rdMale.Tag.ToString() : rdFemale.Tag.ToString();




        }
        private string LevelBeginnerOrMidOrAdvance()
        {

            return rdBeginner.Checked ? rdBeginner.Tag.ToString() : rdIntermediate.Checked ?
                rdIntermediate.Tag.ToString() : rdAdvanced.Tag.ToString();




        }
       private void CheckSkills()
        {

            if (chbCplus.Checked)
            {
                frSave.lblSkills1.Visible = true;
                frSave.lblSkills1.Text = chbCplus.Tag.ToString();
            }
            if (chbCsharp.Checked)
            {
                frSave.lblSkills2.Visible = true;
                frSave.lblSkills2.Text = chbCsharp.Tag.ToString();
            }
            if (chbJavaScript.Checked)
            {
                frSave.lblSkills3.Visible = true;
                frSave.lblSkills3.Text = chbJavaScript.Tag.ToString();
            }
            if (chbSQL.Checked)
            {
                frSave.lblSkills4.Visible = true;
                frSave.lblSkills4.Text = chbSQL.Tag.ToString();
            }

        }
        private void Show_Info()
        {
            
             frSave.lblNameUnderImage.Text=frSave.lblName.Text= txtName.Text;
            frSave.lblEmail.Text = txtEmail.Text;
            frSave.lblPhone.Text = txtPhone.Text;
            frSave.lblGender.Text = MaleOrFemale();
            frSave.lblLevel.Text = LevelBeginnerOrMidOrAdvance();
            CheckSkills();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
         if (CheckAboutTextBoxName() &&
            CheckAboutTextBoxEmail()&&
            CheckAboutTextBoxPhone())
            {

                MessageBox.Show("Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show_Info();
                frSave.ShowDialog();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIAbout_Click(object sender, EventArgs e)
        {
            Form form = new frmAboutme();
            form.ShowDialog();
        }
    }
}
