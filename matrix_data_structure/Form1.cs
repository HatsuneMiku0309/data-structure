using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix_data_structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // row, col
            int[,] A = new int[4, 3] { { 5, 0, 0 }, { 0, 0, -1 }, { 3, 0, 0 }, { 0, 9, 10 } };
            int[,] sparseMatix = new int[6, 3]; // row+1 , because index 0 is matix data;
            int totalData = 0;
            int k = 1;
            string result = "";
            sparseMatix[0, 0] = A.GetLength(0);
            sparseMatix[0, 1] = A.GetLength(1);
            for (int i = 0; i < A.GetLength(0); i++) // row = 4
            {
                for (int j = 0; j < A.GetLength(1); j++) // col = 3
                {
                    Console.WriteLine("{0}{1}", i, j);
                    if (A[i, j] != 0)
                    {
                        
                        sparseMatix[k, 0] = i;
                        sparseMatix[k, 1] = j;
                        sparseMatix[k, 2] = A[i,j];
                        ++totalData;
                        ++k;
                    }
                }
            }
            sparseMatix[0, 2] = totalData;

            for (int i = 0; i < sparseMatix.GetLength(0); i++)
            {
                result += "row: " + sparseMatix[i, 0] + ", col: " + sparseMatix[i, 1] + ", data: " + sparseMatix[i, 2] + Environment.NewLine;                
            }

            richTextBox1.AppendText(result);
        }
    }
}
