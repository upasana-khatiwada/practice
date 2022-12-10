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
            user id =sa1 ; 
            password =kist@123;");
        public Form2()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;

            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox1;

            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox1;

            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Parent = pictureBox1;


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
            // remove the focus from the textboxes by making a label the active control
            this.ActiveControl = label1;

            //con= new SqlConnection(
            //  @"Data Source= .\SQLEXPRESS; 
            //    Initial Catalog= admin;
            //    user id =sa ; 
            //    password =kist@123;");
            //con.Open();
        }

       

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                textBoxUsername.Text = "username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxContactNumber_Enter(object sender, EventArgs e)
        {
            String contact = textBoxContactNumber.Text;
            if (contact.ToLower().Trim().Equals("contact number")||contact.Trim().Equals(""))
              //  if(contact.Equals("contact number"))
            {
                textBoxContactNumber.Text = "";
                textBoxContactNumber.ForeColor = Color.Black;
            }

        }

        private void textBoxContactNumber_Leave(object sender, EventArgs e)
        {
            String contact = textBoxContactNumber.Text;
            if (contact.ToLower().Trim().Equals("contact number") || contact.Trim().Equals(""))
            {
                textBoxContactNumber.Text = "contact number";
                textBoxContactNumber.ForeColor = Color.Gray;
            }

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxConfirmPassword_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxConfirmPassword.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxConfirmPassword.Text = "";
                textBoxConfirmPassword.UseSystemPasswordChar = true;
                textBoxConfirmPassword.ForeColor = Color.Black;

            }
        }
        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            String cpassword = textBoxConfirmPassword.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                textBoxConfirmPassword.Text = "confirm password";
                textBoxConfirmPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.ForeColor = Color.Gray;
            }

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

            //if (textBoxUsername.Text != string.Empty || textBoxContactNumber.Text != string.Empty || textBoxPassword.Text != string.Empty)
            //{
            //    if (textBoxContactNumber.Text == textBoxPassword.Text)
            //    {
            //        SqlCommand cmd = new SqlCommand("select * from employees1 where username='" + textBoxUsername.Text + "'", con);
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        if (dr.Read())
            //        {
            //            dr.Close();
            //            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            dr.Close();
            ////cmd = new SqlCommand("insert into LoginTable values(@username,@password)", con);
            ////cmd.Parameters.AddWithValue("username", textBox1.Text);
            ////cmd.Parameters.AddWithValue("password", textBox2.Text);
            ////cmd.ExecuteNonQuery();


            //string query = "Insert into employees1" + "( name,phone_number,password)" +
            //                           "values('" +
            //                            textBoxUsername.Text +
            //                           "','" + textBoxContactNumber.Text +
            //                           "','" + textBoxPassword.Text +
            //                       //"','" + textBox4.Text +
            //                       "')";
            //            cmd = con.CreateCommand();
            //            cmd.CommandText = query;
            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("Your Account is created . Please login now.", "Done");
            //        }

            //    }

            // }

            string query = "INSERT INTO 'employees1'('username','phone_number','password') VALUES(@usn,@phn,@pass)";

            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.Add("@usn", SqlDbType.NVarChar).Value = textBoxUsername.Text ;
            cmd.Parameters.Add("@phn", SqlDbType.NVarChar).Value = textBoxContactNumber.Text;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = textBoxPassword.Text;

            // open the connection
            con.Open();

            //execute the query 
            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if (textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //// execute the query
                        //if (cmd.ExecuteNonQuery() == 1)
                        //{
                        //    MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("ERROR");
                        //}

                        MessageBox.Show("Account created");
                        this.Hide(); //hides the first form 
                        Form1 LoginForm = new Form1();
                        LoginForm.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            //if (cmd.ExecuteNonQuery()==1)
            //{
            //    MessageBox.Show("Account created");

            //}
            //else
            //{
            //    MessageBox.Show("error");
            //}



            // close the connection
           con.Close();



        }
        // check if the username already exists
        public Boolean checkUsername()
        {
           // DB db = new DB();

            String username = textBoxUsername.Text;

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM employees1 WHERE name = @usn", con);

            command.Parameters.Add("@usn", SqlDbType.NVarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // check if the textboxes contains the default values
        public Boolean checkTextBoxesValues()
        {
            
            String uname = textBoxUsername.Text;
            String phno = textBoxContactNumber.Text;
            String pass = textBoxPassword.Text;

            if ( uname.Equals("username")|| phno.Equals("contact number")|| pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}








