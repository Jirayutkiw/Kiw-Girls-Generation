﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace coffy_new
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void label3_Click(object sender, EventArgs e)
=======
        string gender;
        private void Form3_Load(object sender, EventArgs e)
>>>>>>> ba2e80965635f364936d49c4d6cc654dce8aa26d
        {

        }

<<<<<<< HEAD
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

=======
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FORM staffs";
            sql = "INSERT INTO staffs (StaffCode, StaffName, Gender, StaffPassword) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + gender + "','"+textBox3.Text+"')";
            MySqlConnection con = new MySqlConnection("datasource=localhost;Initial Catalog='coffy';username=coffys;password=12345678");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
>>>>>>> ba2e80965635f364936d49c4d6cc654dce8aa26d
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
