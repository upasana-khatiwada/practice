﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_main
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(
          @"Data Source= .\SQLEXPRESS; 
            Initial Catalog= admin;
            user id =sa ; 
            password =kist@123;");
        public Form2()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            //button1.BackColor = System.Drawing.Color.Transparent;
            //button1.Parent = pictureBox1;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;


            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;

            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox1;

            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox1;

            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Parent = pictureBox1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Username";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Phone Number")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter Phone Number";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter Password";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Confirm Password")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Confirm Password";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text == "" || textBox2.Text=="")
            //{
            //    MessageBox.Show("please enter details");

            //}
            //else
            //{
            try
            {
                //to save the data of textbox into database
                con.Open();
                string query = "Insert into employees1" + "( name,phone_number,password)" +
                    "values('" +
                    textBox1.Text +
                    "','" + textBox2.Text +
                    "','" + textBox3.Text +
                    //"','" + textBox4.Text +
                    "')";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your account has been created successfully");
                con.Close();
                //to go to login page 
                this.Hide(); //hides the first form 
                Form1 LoginForm = new Form1();
                LoginForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(textBox1.Text);


            }

        }
    }
    
    
}
