using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager_UEH
{
    public partial class GiangVien_Subject : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-3PR29SO1;Initial Catalog=QL_LMS;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadData()
        {
            dgv_subject.AllowUserToAddRows = false;
            dgv_subject.AllowUserToDeleteRows = false;
            dgv_subject.AllowUserToResizeColumns = false;
            command = connection.CreateCommand();
            command.CommandText = "select name as N'Tên', khoa as 'Khoa', soBaiGiang as N'Số bài giảng', nguoiTao as N'Người tạo' from dbo.MonHoc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_subject.DataSource = table;
            dgv_subject.Columns[0].Width = 290;
            dgv_subject.Columns[1].Width = 290;
            dgv_subject.Columns[2].Width = 100;
            dgv_subject.Columns[3].Width = 237;
            foreach (DataGridViewRow row in dgv_subject.Rows)
            {
                row.Height = 50;
            }    
            foreach(DataGridViewColumn column in dgv_subject.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.ReadOnly = true;
            }    
        }
        public GiangVien_Subject()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GiangVien_Subject_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void False(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
