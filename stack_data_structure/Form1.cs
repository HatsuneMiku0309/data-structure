using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_data_structure
{
    public partial class Form1 : Form
    {
        const int N = 10;
        int top = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender , EventArgs e )
        {
            int[] stack = new int[N];
            int item = int.Parse( textBox1.Text );
            push( item , ref stack );
        }
        private void push( int item , ref int[] stack )
        {
            if ( top == ( N - 1 ) )
            {                      
                MessageBox.Show( "Stack is full" );
            }
            else {

            }
        }
    }
}
