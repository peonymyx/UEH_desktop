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
    public partial class SinhVien_Class : Form
    {
        private List<Form> currentFormChilds;
        public SinhVien_Class()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, Panel panel)
        {
            currentFormChilds = new List<Form>();
            currentFormChilds.Add(childForm);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SinhVien_Class_Load(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien_Class_Subclass(), panel3);
            OpenChildForm(new SinhVien_Class_Subclass(), panel4);
        }
    }
}
