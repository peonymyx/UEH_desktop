using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager_UEH
{
    public partial class SignIn_GV : Form
    {
        private Form_SignIn_Up _parentForm;
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public SignIn_GV(Form_SignIn_Up parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new SignUp_GV());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parentForm.Hide();
            this.Close();
            GiangVienPart giangVienPart = new GiangVienPart(_parentForm);
            giangVienPart.Show();
        }
    }
}
