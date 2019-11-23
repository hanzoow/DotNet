using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP3.Service;
using APP3.Model;

namespace APP3
{
    public partial class Form1 : Form
    {
        private string pathDataToStudentInfo;
        private string pathDataToHistoryInfo;
        public Form1(string idStudent)
        {
            InitializeComponent();
            ptcb1.AllowDrop = true;
            dtgvQuaTrinhHocTap.AutoGenerateColumns = false;
            pathDataToStudentInfo = Application.StartupPath + @"\Data\student.husc";
            pathDataToHistoryInfo = Application.StartupPath + @"\Data\history.husc";
            var student = StudentService.GetStudent(pathDataToStudentInfo, idStudent);
            if (student != null)
            {
                txtMaSinhVien.Text = student.Id;
                txtHo.Text = student.LastName;
                txtTen.Text = student.FirstName;
                dtpNgaySinh.Value = student.DateOfBirth;
                txtNoiSinh.Text = student.PlaceOfBirth;
                cmbGioiTinh.SelectedIndex = (int)student.Gender;
                student.ListLearningHistory = LearningHistoryService.GetList(pathDataToHistoryInfo, idStudent);
                bdsQuaTrinhHocTap.DataSource = student.ListLearningHistory;
                dtgvQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
                lblTongSoMuc.Text = student.ListLearningHistory.Count().ToString();
            }
            else
            {
                throw new Exception("Sinh viên này không tồn tại!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chonAnhDaiDien();
        }
        /// <summary>
        /// Chon anh dai dien tu OpenFileDialog
        /// </summary>
        void chonAnhDaiDien()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File anh (*.pngm *.jpg) | *.png;*.jpg";
            dialog.Title = "Chon anh dai dien";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                ptcb1.Image = Image.FromFile(fileName);
            }
        }

        private void ptcb1_Click(object sender, EventArgs e)
        {

        }

        private void ptcb1_DoubleClick(object sender, EventArgs e)
        {
            chonAnhDaiDien();
        }

        private void ptcb1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ptcb1_DragDrop(object sender, DragEventArgs e)
        {
            var listFileName = (String[])e.Data.GetData(DataFormats.FileDrop);
            var fileName = listFileName.FirstOrDefault();
            ptcb1.Image = Image.FromFile(fileName);
        }

        private void cmbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
