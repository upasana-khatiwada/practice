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

        //public void button_tsp (button button3)
        //{
        //    button3.flatstyle = flatstyle.flat;
        //    button3.backcolor = color.transparent;
        //    button3.flatappearance.bordersize = 0;
        //}

        
    }
}
