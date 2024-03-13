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
    public partial class SinhVienPart : Form
    {
        private Form_SignIn_Up _parentForm;
        bool sidebarExpand;
        bool avarExpand;
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
        public SinhVienPart(Form_SignIn_Up parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void avarTimer_Tick(object sender, EventArgs e)
        {
            if (avarExpand)
            {
                avarInfo.Height -= 10;
                if (avar.Height != 12)
                {
                    avar.Height -= 5;
                    avar.Width -= 5;
                }
                if (avarInfo.Height == avarInfo.MinimumSize.Height)
                {
                    avarExpand = false;
                    avarInfo.BackColor = Color.FromArgb(0, 95, 105);
                    pl_menu.BackColor = Color.FromArgb(0, 95, 105);
                    avarTimer.Stop();
                }
                info.Location = new Point(info.Location.X, (avarInfo.Height - info.Height) / 2);
                avar.Location = new Point(10, (avarInfo.Height - avar.Height) / 2);
            }
            else
            {
                avarInfo.Height += 10;
                if (avar.Height != 97)
                {
                    avar.Height += 5;
                    avar.Width += 5;
                }
                if (avarInfo.Height == avarInfo.MaximumSize.Height)
                {
                    avarExpand = true;
                    pl_menu.BackColor = Color.FromArgb(0, 95, 105);
                    avarInfo.BackColor = Color.Gray;
                    avarTimer.Stop();
                }
                info.Location = new Point(info.Location.X, (avarInfo.Height - info.Height) / 2);
                avar.Location = new Point(30, (avarInfo.Height - avar.Height) / 2);
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            avarTimer.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void class_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien_Class());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            this.Close();
        }

        private void essay_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien_TuLuan());
        }

        private void choice_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien_TracNghiem());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien_KetQuaHocTap());
        }

        private void evaluate_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien_DeLaiYKien());
        }
    }
}
