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
    public partial class GiangVien_Class : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-3PR29SO1;Initial Catalog=QL_LMS;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            dgv_class.AllowUserToAddRows = false;
            dgv_class.AllowUserToDeleteRows = false;
            dgv_class.AllowUserToResizeColumns = false;
            command = connection.CreateCommand();
            command.CommandText = "select TenLopHocPhan as N'Tên lớp học phần',\r\nMonHoc as 'Môn học', SoTinChi as N'Số tín chỉ',\r\nGiangVien as N'Giảng viên', SDT as N'Số điện thoại',\r\nNamHoc as N'Năm học',\r\nHocKy as N'Học kỳ',\r\nSoSinhVien as N'Số sinh viên' from dbo.LopHoc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_class.DataSource = table;
            dgv_class.Columns[0].Width = 290;
            dgv_class.Columns[1].Width = 290;
            dgv_class.Columns[2].Width = 100;
            dgv_class.Columns[3].Width = 237;
            foreach (DataGridViewRow row in dgv_class.Rows)
            {
                row.Height = 50;
            }
            foreach (DataGridViewColumn column in dgv_class.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.ReadOnly = true;
            }
        }
        public GiangVien_Class()
        {
            InitializeComponent();
        }

        private void dgv_class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GiangVien_Class_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }
    }
}
