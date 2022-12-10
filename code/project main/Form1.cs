using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace project_main
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
          @"Data Source= .\SQLEXPRESS; 
            Initial Catalog= admin;
            user id =sa1 ; 
            password =kist@123;");
        public Form1()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.BackColor = System.Drawing.Color.Transparent;
            button2.Parent = pictureBox1;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;


            button3.BackColor = System.Drawing.Color.Transparent;
            button3.Parent = pictureBox1;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            //label3.Parent = pictureBox1;
            //label3.BackColor = Color.Transparent;
            //label4.Parent = pictureBox1;
            //label4.BackColor = Color.Transparent;

            checkBox1.Parent = pictureBox1;
            checkBox1.BackColor = Color.Transparent;

            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;

            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox1;

            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the first form 
            Form2 SignUpForm = new Form2();
            SignUpForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Count(*) FROM employees1 WHERE username='" + textBox1.Text + "' and password='" + textBox2.Text + "' ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide(); //hides the first form 
                Form3 dashBoard = new Form3();
                dashBoard.ShowDialog();


            }
            else
            {
                MessageBox.Show("details didn't matched");

            }

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //to concele the password and show in asterick
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor= Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor= Color.Silver;
            }
        }
    }
}

      


