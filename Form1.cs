using System.Numerics;
using System.Xml.Schema;

namespace Test_Score_List
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] scores = { 0, 0, 0, 0, 0, 0, 0, 0 };
        private void button1_Click(object sender, EventArgs e)
        {

            int testNumber = Convert.ToInt32(textBox1.Text);
            int grade = Convert.ToInt32(textBox2.Text);
            --testNumber;
            if (grade >= 0 && grade <= 100)
            {
                scores[testNumber] = grade;
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average = (scores[0] + scores[1] + scores[2] + scores[3] + scores[4] + scores[5] + scores[6] + scores[7]) / 8;
            for (int x = 0; x < scores.Length; ++x)
            {

                double difference = 0;
                if (scores[x] > average)
                {
                    difference = scores[x] - average;
                }
                else
                { 
                    difference = average - scores[x];
                }
                label9.Text += String.Format("Your score of {0} is {1} points away from your average test score.\n", scores[x] , difference);
                
            }
            
        }
    }
}
