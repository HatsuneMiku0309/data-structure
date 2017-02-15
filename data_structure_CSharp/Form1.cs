using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_structure_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] A = new int[] { 50, 60, 70, 80, 90, 100 };
            int sun = 0;
            float average = 0;
            // int? sun = null;
            
            for (int i = 0; i < (A.Length-1); i++)
            {
                sun += (int)A[i];
            }

            average = sun / A.Length;

            richTextBox1.AppendText("your sun :" + sun.ToString() + "  and average : " + average.ToString() + Environment.NewLine );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] A = new int[] { 10, 20, 30 };
            int index, value = 0;
            int count = 1;
            string resultStr = "";

            if (!int.TryParse(textBox1.Text,out index) || !int.TryParse(textBox2.Text, out value))
            {
                richTextBox1.AppendText("your input is error" + Environment.NewLine);
                return;
            }

            if (index < 0 || index > A.Length-1)
            {
                richTextBox1.AppendText("your index is overflow" + Environment.NewLine);
                return;
            }

            for (int i = A.Length-1; i > index; i--)
            {
                A[i] = A[i - 1];
            }

            A[index] = value;
            
            foreach (var myValue in A) {
                resultStr += "{" + count + ": " + myValue + "}";
                ++count;
            }

            richTextBox1.AppendText(resultStr + Environment.NewLine);

        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] A = new int[] { 10, 20, 30 };
            int index = 0;
            int count = 1;
            string resultStr = "";

            if (!int.TryParse(textBox3.Text, out index))
            {
                richTextBox1.AppendText("your input is error!" + Environment.NewLine);
                return;
            }

            if (index < 0 || index > A.Length-1)
            {
                richTextBox1.AppendText("your index is overflow" + Environment.NewLine);
                return;
            }

            for (var i = index; i < A.Length - 1; i++)
            {
                A[i] = A[i + 1];
            }

            A[A.Length - 1] = 0;

            foreach (var myValue in A)
            {
                resultStr += "{" + count + ": " + myValue + "}";
                ++count;
            }

            richTextBox1.AppendText(resultStr + Environment.NewLine);
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }
        
    }
}
