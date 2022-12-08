using System;
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
        //SqlCommand cmd  ;
        //SqlDataReader dr;
        //SqlConnection con;
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

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

            //button1.BackColor = System.Drawing.Color.Transparent;
            //button1.Parent = pictureBox1;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //con= new SqlConnection(
            //  @"Data Source= .\SQLEXPRESS; 
            //    Initial Catalog= admin;
            //    user id =sa ; 
            //    password =kist@123;");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    if (textBox1.Text == "" || textBox2.Text == "")
            //    {
            //        MessageBox.Show("please enter details");

            //    }
            //    //else
            //    //{
            //    //try
            //    //{
            //    //to save the data of textbox into database
            //   // con.Open();
            //            string query = "Insert into employees1" + "( name,phone_number,password)" +
            //                            "values('" +
            //                             textBox1.Text +
            //                            "','" + textBox2.Text +
            //                            "','" + textBox3.Text +
            //                 //"','" + textBox4.Text +
            //                        "')";
            //                SqlCommand cmd = con.CreateCommand();
            //                cmd.CommandText = query;
            //                cmd.ExecuteNonQuery();


            //    if (textBox2.Text== textBox3.Text)
            //    {
            //        MessageBox.Show("Your account has been created successfully");
            //        Form1 LoginForm = new Form1();
            //        LoginForm.ShowDialog();

            //    }
            //    else
            //    {
            //        MessageBox.Show("error");

            //    }
            //    con.Close();
            //    this.Hide(); //hides the first form 
            //   // Form1 LoginForm = new Form1();
            //    //LoginForm.ShowDialog();


            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //    MessageBox.Show("error");


            //    //}

            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from employees1 where username='" + textBox1.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        //cmd = new SqlCommand("insert into LoginTable values(@username,@password)", con);
                        //cmd.Parameters.AddWithValue("username", textBox1.Text);
                        //cmd.Parameters.AddWithValue("password", textBox2.Text);
                        //cmd.ExecuteNonQuery();


                        string query = "Insert into employees1" + "( name,phone_number,password)" +
                                                   "values('" +
                                                    textBox1.Text +
                                                   "','" + textBox2.Text +
                                                   "','" + textBox3.Text +
                                               //"','" + textBox4.Text +
                                               "')";
                        cmd = con.CreateCommand();
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done");
                    }

                }

            }

        }

    }



    
    
}








//if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
//{
//    if (txtpassword.Text == txtconfirmpassword.Text)
//    {
//        cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", cn);
//        dr = cmd.ExecuteReader();
//        if (dr.Read())
//        {
//            dr.Close();
//            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//        else
//        {
//            dr.Close();
//            cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
//            cmd.Parameters.AddWithValue("username", txtusername.Text);
//            cmd.Parameters.AddWithValue("password", txtpassword.Text);
//            cmd.ExecuteNonQuery();
//            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//    }
//    else
//    {
//        MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}
//else
//{
//    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}
//}