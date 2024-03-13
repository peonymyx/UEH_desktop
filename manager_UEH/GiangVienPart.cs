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
    public partial class GiangVienPart : Form
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
        public GiangVienPart(Form_SignIn_Up parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void class_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiangVien_Class());
        }

        private void essay_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiangVien_Subject());
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiangVien_Document());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _parentForm.Show();
        }
    }
}
