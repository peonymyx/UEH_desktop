using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using static System.Windows.Forms.VisualStyles.VisualStyleElement;*/

namespace manager_UEH
{
    public partial class GiangVien_Document : Form
    {
        private TreeNode grootNode;
        public GiangVien_Document()
        {
            InitializeComponent();
            grootNode = new TreeNode("Thư mục của bạn");
            Directory.CreateDirectory("Thư mục của bạn");
            treeView1.Nodes.Add(grootNode);
            treeView1.AfterLabelEdit += treeView1_AfterLabelEdit;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folderName = thuMucTao_txt.Text.Trim();
            if (string.IsNullOrEmpty(folderName))
            {
                MessageBox.Show("Vui lòng nhập tên thư mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!Directory.Exists(folderName))
                {
                    // Tạo một node mới cho thư mục con
                    TreeNode newNode = new TreeNode(folderName);

                    // Thêm node mới vào thư mục cha được chọn (nếu có)
                    if (treeView1.SelectedNode != null)
                    {
                        string parent = Path.Combine(Environment.CurrentDirectory, folderName);
                        treeView1.SelectedNode.Nodes.Add(newNode);
                        Directory.CreateDirectory(parent);
                    }
                    else
                    {
                        // Nếu không có thư mục cha được chọn, thêm node mới vào gốc của TreeView
                        treeView1.Nodes.Add(newNode);
                    }
                    thuMucTao_txt.Clear();
                }
                else
                {
                    MessageBox.Show("Thư mục đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // Kiểm tra xem có phải là hoạt động sửa đổi tên không và tên mới không được rỗng
            if (e.Label != null && e.Label != "")
            {
                // Gán tên mới cho node
                e.Node.Text = e.Label;
            }
            else
            {
                // Nếu tên mới là rỗng hoặc null, hủy bỏ sửa đổi
                e.CancelEdit = true;
            }
        }
    }
}
