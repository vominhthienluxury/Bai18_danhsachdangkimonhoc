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
            cbxkhoa.Items.Add("2020");
            cbxkhoa.Items.Add("2021");
            cbxkhoa.Items.Add("2022");
            cbxkhoa.Items.Add("2023");
            cbxkhoa.Items.Add("2024");
            cbxkhoa.Items.Add("2025");
            cbxkhoa.SelectedIndex = 0;

            cbxlop.Items.Add("Ứng dụng phần mềm 1");
            cbxlop.Items.Add("Ứng dụng phần mềm 2");
            cbxlop.Items.Add("Ứng dụng phần mềm 3");
            cbxlop.Items.Add("Ứng dụng đồ họa 1");
            cbxlop.Items.Add("Ứng dụng đồ họa 2");
            cbxlop.Items.Add("Quản trị mạng 1");
            cbxlop.Items.Add("Quản trị mạng 2");
            cbxlop.SelectedIndex = 0;

            khoaI.Checked = true;

            checkedListBox1.Items.Add("LT Windows");
            checkedListBox1.Items.Add("LT Internet");
            checkedListBox1.Items.Add("Mạng máy tính");
            checkedListBox1.Items.Add("UML");
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã số sinh viên: " + txtmssv.Text;
            thongtin += "\nHọ và tên: " + txtname.Text;
            thongtin += "\nNiên khóa: " + cbxkhoa.SelectedItem;
            thongtin += "\nLớp: " + cbxlop.SelectedItem;

            string hocky = "";
            if (khoaI.Checked)
            {
                hocky = khoaI.Text;
            }
            else if (khoaII.Checked)
            {
                hocky = khoaII.Text;
            }
            else if (khoaIII.Checked)
            {
                hocky = khoaIII.Text;
            }
            else if (khoaIV.Checked)
            {
                hocky = khoaIV.Text;
            }
            thongtin += "\nĐã đăng ký học Học Kỳ " + hocky + " \ncác môn học sau:";
            int stt = 1;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }
    }
}
