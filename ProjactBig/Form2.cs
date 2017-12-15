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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();//คำสั่งเปิดForm1
            f1.Show();//คำสั่งให้โชวForm1
            this.Hide();//คำสั่งซ่อน
        }

        private void ยหอรถToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ducati");// คำสั่งเพิ่มItemsลงไปในcomboBox1
            comboBox1.Items.Add("Honda");//คำสั่งเพิ่มItemsลงไปในcomboBox1
            comboBox1.Items.Add("BMW");//คำสั่งเพิ่มItemsลงไปในcomboBox1
            comboBox1.Items.Add("Yamaha");//คำสั่งเพิ่มItemsลงไปในcomboBox1
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("/1.txt", comboBox2.Text);//คำสั่งเขียนไฟร์จากcomboBox2ไปเก็บไว้ในไฟร์ 1.txt
            Form f5 = new Form5(); //คำสั่งเปิดForm5
            f5.Show();//คำสั่งให้โชวForm5
            this.Hide();//คำสั่งซ่อน

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)//คำสั่งใช่งานComboBox1
            {
                case "Ducati"://คำสั่งทำงานในcase
                    {
                        comboBox2.Items.Clear();//Clearข้อมูลในcaseของDucati
                        comboBox2.Items.Add("Ducati 1299"); //คำสั่งเพิ่มItemsลงไปในcomboBox2
                        comboBox2.Items.Add("Ducati 959"); break;//คำสั่งเพิ่มItemsลงไปในcomboBox2
                    }
                case "Honda"://คำสั่งทำงานในcase
                    {
                        comboBox2.Items.Clear();//Clearข้อมูลในcaseของHonda
                        comboBox2.Items.Add("Honda CB 650 F ");//คำสั่งเพิ่มItemsลงไปในcomboBox2
                        comboBox2.Items.Add("Honda CBR 650 F "); break;//คำสั่งเพิ่มItemsลงไปในcomboBox2
                    }
                case "BMW"://คำสั่งทำงานในcase
                    {
                        comboBox2.Items.Clear(); //Clearข้อมูลในcaseของBMW             
                        comboBox2.Items.Add("BMW R");//คำสั่งเพิ่มItemsลงไปในcomboBox2
                        comboBox2.Items.Add("BMW S"); break;//คำสั่งเพิ่มItemsลงไปในcomboBox2
                    }
                case "Yamaha"://คำสั่งทำงานในcase
                    {
                        comboBox2.Items.Clear();//Clearข้อมูลในcaseของYamaha
                        comboBox2.Items.Add("Yamaha Bolt");//คำสั่งเพิ่มItemsลงไปในcomboBox2
                        comboBox2.Items.Add("Yamaha FJ-09"); break;//คำสั่งเพิ่มItemsลงไปในcomboBox2
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void โปรโมชนสำหรบลกคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();//คำสั่งเพื่อให้เปิดไปที่หน้าform-
            f3.ShowDialog();//คำสั่งให้Show Form3 และ ล็อกหน้าform3          
        }
    }
}

