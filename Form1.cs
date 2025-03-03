using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai18_danhsachdangkimonhoc
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            string str = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                count++;
                str += count.ToString() + ". " + item.ToString() + "\n";
            }
             return;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            while (checkedListBox1.CheckedIndices.Count > 0)
            {
                // lst.CheckedIndices[0]==> lay ra vi tri trong list 
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("LT Windows");
            checkedListBox1.Items.Add("LT Internet");
            checkedListBox1.Items.Add("Mạng máy tính");
            checkedListBox1.Items.Add("UML");
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            string studentID = txtmssv.Text;
            string fullName = txtname.Text;
            string academicYear = cbxkhoa.SelectedItem?.ToString();
            string className = cbxlop.Text;
           

            string message = $"MSSV: {studentID}\nHọ và Tên: {fullName}\nNiên khóa: {academicYear}\nLớp: {className}\nHọc kỳ: {khoaI}\nMôn học: {checkedListBox1}";
            MessageBox.Show(message, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
