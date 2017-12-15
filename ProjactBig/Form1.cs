using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjactBig
{
    public partial class Form1 : Form
    {
        private int i;//กำหนดตัวแปล

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';//คำสั่งทำการให้เครื่องหมาย*แสดงแทนตัวเลข
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณแน่ใจหรือไม่ที่จะออกจากโปรแกรม", "แจ้งเตือน", MessageBoxButtons.OKCancel) == DialogResult.OK)//คำสั่งการแจ้งเตือนเมื่อกดออกจากโปรแกรม
            {
                this.Close();//คำสั่งในการปิดForm
                Environment.Exit(0);//ออกจากระบบทั้งหมด
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] ID = System.IO.File.ReadAllLines(Application.StartupPath + @"\ID.txt");//อ่านไฟร์ไปกับไว้ในID
            if ((textBox1.Text == "") || (textBox2.Text == ""))//กำหนดให้เป็นช่องว่าง
            {
                MessageBox.Show("กรุณาใส่ Username และ Password ให้ครบ", "แจ้งเตือน");//แจ้งเตือนMessageBox
            }
            else//
            {
                if ((textBox1.Text == ID[0]) && (textBox2.Text == ID[1]))//เลือกใช้ข้อมูลในID
                {
                    Form f2 = new Form2();//เปิดฟอร์ม2
                    f2.Show();//โชวฟอร์ม2
                    this.Hide();//คำสั่งซ่อน
                }
                else
                if ((textBox1.Text == ID[2]) && (textBox2.Text == ID[3]))//เลือกใช้ข้อมูลในID
                {
                    Form f2 = new Form2();//เปิดฟอร์ม2
                    f2.Show();//โชวฟอร์ม2
                    this.Hide();//คำสั่งซ่อน
                }
                else
                if ((textBox1.Text == ID[4]) && (textBox2.Text == ID[5]))//เลือกใช้ข้อมูลในID
                {
                    Form f2 = new Form2();//เปิดฟอร์ม2
                    f2.Show();//โชวฟอร์ม2
                    this.Hide();//คำสั่งซ่อน
                }
                else
                if ((textBox1.Text == ID[6]) && (textBox2.Text == ID[7]))//เลือกใช้ข้อมูลในID
                {
                    Form f2 = new Form2();//เปิดฟอร์ม2
                    f2.Show();//โชวฟอร์ม2
                    this.Hide();//คำสั่งซ่อน
                }
                else
                {
                    i++;//คำสั่งเพิ่ม
                    MessageBox.Show("คุณใส่รหัสผิดกรุณากรอก\r\nรหัสของคุณอีกครั้ง", "แจ้งเตือน" + i);//โชวMessageBox
                    textBox1.Focus();//focusในtextBox1
                    textBox2.Clear();//Clearข้อมูล
                    textBox1.SelectAll();//เงื่อนไขออกจากระบบทั้งหมด
                    if (i == 5)//ทำต้ามเงื่อนไขครบ5ครั้ง
                    {
                        MessageBox.Show("คุณใส่รหัสผิดครบ 5 ครั้งแล้วกรุณาปิดโปรแกรม", "แจ้งเตือน");//คำสั่งการแจ้งเตือนเมื่อใส่รหัสผิดครบ5ครั้งแล้วจะเด่งออกจากระบบ
                        this.Close();//คำสั่งปิดระบบ
                    }
                }
                
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);//คำสั่งของปุ่มEnter
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
