using APP3.Model;
using APP3.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3
{
    public partial class Form2 : Form
    {
        bool LaThemMoi;
        LearningHistory learningHistory;
        Student student;
        public Form2(Student student)
        {
            InitializeComponent();
            this.Text = "Thêm mới quá trình học tập";
            this.student = student;
            LaThemMoi = true;
        }

        public Form2(LearningHistory history)
        {
            InitializeComponent();
            this.learningHistory = history;
            numTuNam.Value = history.FromYear;
            numDenNam.Value = history.ToYear;
            tbHocTai.Text = history.Address;
            LaThemMoi = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (LaThemMoi)
            {
                var history = new LearningHistory
                {
                    Id = Guid.NewGuid().ToString(),
                    FromYear = (int)numTuNam.Value,
                    ToYear = (int)numDenNam.Value,
                    Address = tbHocTai.Text,
                    IdStudent = "102T102"
                };

                LearningHistoryService.Add(Form1.pathDataHistory, history);
                DialogResult = DialogResult.OK;
            }
            else
            {
                learningHistory.FromYear = (int)numTuNam.Value;
                learningHistory.ToYear = (int)numDenNam.Value;
                learningHistory.Address = tbHocTai.Text;
                LearningHistoryService.Update(Form1.pathDataHistory, learningHistory);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
