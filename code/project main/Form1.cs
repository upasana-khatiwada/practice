using System.Drawing.Drawing2D;

namespace project_main
{
    public partial class Form1 : Form
    {
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

            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox1;

            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;








        }

        private void button3_Click(object sender, EventArgs e)
        {
            




        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "Username")
            {
                textBox2.Text = "";
                textBox2.ForeColor= Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Username";
                textBox2.ForeColor= Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password")
            {
                textBox1.Text = "";
                textBox1.ForeColor= Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
                textBox1.ForeColor= Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the first form 
            Form2 SignUpForm = new Form2();
            SignUpForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

      

    }
