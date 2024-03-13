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
    public partial class Form_SignIn_Up : Form
    {
        private List<string> imagePaths = new List<string>
        {
            "D:\\WORKSPACE\\C#\\project_C#\\manager_UEH\\manager_UEH\\img\\image1.jpg",
            "D:\\WORKSPACE\\C#\\project_C#\\manager_UEH\\manager_UEH\\img\\image2.png",
            "D:\\WORKSPACE\\C#\\project_C#\\manager_UEH\\manager_UEH\\img\\image3.jpg"
            // Thêm các đường dẫn hình ảnh khác tại đây
        };
        private int currentIndex = 0;
        private Timer timer;
        private Form currentFormChild;
        private void DisplayCurrentImage()
        {

            // Load hình ảnh từ đường dẫn
            Image image = System.Drawing.Image.FromFile(imagePaths[currentIndex]);

            // Đặt hình ảnh nền của Panel
            panel2.BackgroundImage = image;

            // Đảm bảo hình ảnh nằm vừa trong PictureBox và kích thước bằng với Panel
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = image;
        }
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
            panel_SV_GV.Controls.Add(childForm);
            panel_SV_GV.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public Form_SignIn_Up()
        {
            InitializeComponent();
            InitializeSlideshow();
        }
        private void InitializeSlideshow()
        {
            // Khởi tạo Timer với interval là 2000 milliseconds (2 giây)
            timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += timer1_Tick;

            // Hiển thị hình ảnh đầu tiên khi form khởi động
            DisplayCurrentImage();

            // Bắt đầu slideshow
            timer.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Chuyển đổi đến hình ảnh tiếp theo
            currentIndex = (currentIndex + 1) % imagePaths.Count;
            DisplayCurrentImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SignIn_SV(this));
        }

        private void panel_SV_GV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SignIn_GV(this));
        }
    }
}
