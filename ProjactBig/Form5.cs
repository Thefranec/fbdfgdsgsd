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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            data();//method
        }
        string a = System.IO.File.ReadAllText("/1.txt");//คำสั่งอ่านไฟร์ในtxtไปเก็บไว้ในa
       public void data()//สร้างmethod
        {

             if(a== "Ducati 1299")//คำสั่งการเช็กค่าของข้อมูลว่าตรงกับรุ่นของรถไหม
             {
                 pictureBox1.Image = Image.FromFile(Application.StartupPath+@"\1.jpg");//คำสั่งเรียอกใช้ไฟร์มาแสดงในpictureBox1
             }
             if (a == "Ducati 959")//คำสั่งการเช็กค่าของข้อมูลว่าตรงกับรุ่นของรถไหม
            {
                 pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\2.jpg");//คำสั่งเรียอกใช้ไฟร์มาแสดงในpictureBox1
            }
             if (a == "Honda CB 650 F ")//คำสั่งการเช็กค่าของข้อมูลว่าตรงกับรุ่นของรถไหม
            {
                 pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\3.jpg");//คำสั่งเรียอกใช้ไฟร์มาแสดงในpictureBox1
            }
             if (a == "Honda CBR 650 F ")//คำสั่งการเช็กค่าของข้อมูลว่าตรงกับรุ่นของรถไหม
            {
                 pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\4.jpg");//คำสั่งเรียอกใช้ไฟร์มาแสดงในpictureBox1
            }
            if (a == "BMW R")//คำสั่งการเช็กค่าของข้อมูลว่าตรงกับรุ่นของรถไหม
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\5.jpg");//คำสั่งเรียอกใช้ไฟร์มาแสดงในpictureBox1
            }
            if (a == "BMW S")//คำสั่งการเช็กค่าของข้อมูลว่าตรงกับรุ่นของรถไหม
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\6.jpg");//คำสั่งเรียอกใช้ไฟร์มาแสดงในpictureBox1
            }
            if (a == "Yamaha Bolt")//คำสั่งการเช็กค่าของข้อมูลว่าตรงกับรุ่นของรถไหม
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\7.jpg");//คำสั่งเรียอกใช้ไฟร์มาแสดงในpictureBox1
            }
            if (a == "Yamaha FJ-09")//คำสั่งการเช็กค่าของข้อมูลว่าตรงกับรุ่นของรถไหม
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\8.jpg");//คำสั่งเรียอกใช้ไฟร์มาแสดงในpictureBox1
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();//คำสั่งเปิดForm2
            f2.Show();//คำสั่งให้โชวForm2
            this.Hide();//คำสั่งซ่อน
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
