using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaOdev
{
    public partial class Form1 : Form
    {
                    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int[] numbers = new int[25];
            for (int i = 0; i < numbers.Length; i++)
            {
                
                numbers[i] = randomNumber.Next(1,100);
                listBox1.Items.Add(numbers[i].ToString());
            }
           


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
 
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Items.Count.ToString();  

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
