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
        public bool AsalSayiBulma(int numm) // asal sayi kontrol methodu
        {
            if (numm == 1)
            {
                return false;
            }
            
            for (int i = 2; i < numm ; i++)
            {    
                
                if (numm % i == 0)
                {
                    return false;
                }
                
            }
                return true;
        }


        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int maxnum=0;
            double ort,top=0;

            Random randomNumber = new Random(); // Soru 1 "Random sayı olusturma"
            int[] numbers = new int[25];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNumber.Next(1, 100);
                listBox1.Items.Add(numbers[i].ToString()); // Soru 1 "random sayıları listbox'a yazdırma"
                if (numbers[i] < 50) // Soru 2 "50'den kucuk sayıları alma"
                {
                    
                    listBox2.Items.Add(numbers[i].ToString());
                    label2.Text = listBox2.Items.Count.ToString(); // Soru 2 "50'den kucuk sayıları Label'a yazdırma"
                }
                if (numbers[i] > maxnum) // soru 4
                {
                    maxnum = numbers[i]; // Soru 4 Max number bulma
                   
                }
                top += numbers[i];

                if (AsalSayiBulma(numbers[i])) // soru 5
                {
                    listBox5.Items.Add(numbers[i]); // Asal sayi bulma (dizi ici)
                    label3.Text = listBox5.Items.Count.ToString(); // Asal sayiyi Label'a yazdırma
                }
            }
            ort = top / numbers.Length;
            listBox3.Items.Add(ort.ToString()); // Soru 3 "ortalama bulup listbox'a yazdırma
            listBox4.Items.Add(maxnum.ToString()); // Soru 4 max number bulma ve yazdırma
            label1.Text = listBox1.Items.Count.ToString(); // soru 1
           



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
 
        }


        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e) // veriyi yenileme butonu
        {
            RefreshDataViewers();      
        }
        public void RefreshDataViewers() // veriyi yenileme methodu
        {
            ClearAll();
            int maxnum = 0;
            double ort, sum = 0;
            Random randomNumber = new Random();
            int[] numbers = new int[25];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNumber.Next(1, 100);
                listBox1.Items.Add(numbers[i].ToString());
                if (numbers[i] < 50)
                {

                    listBox2.Items.Add(numbers[i].ToString());
                    label2.Text = listBox2.Items.Count.ToString();
                }
                if (numbers[i] > maxnum)
                {
                    maxnum = numbers[i];

                }
                sum += numbers[i];

                if (AsalSayiBulma(numbers[i]))
                {
                    listBox5.Items.Add(numbers[i]);
                    label3.Text = listBox5.Items.Count.ToString();
                }
            }
            ort = sum / 25;
            listBox3.Items.Add(ort.ToString());
            listBox4.Items.Add(maxnum.ToString());
            label1.Text = listBox1.Items.Count.ToString();
        }
        private void ClearAll() // form'u komple temizleme methodu
        { 
           
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearAll(); // Her seyi temizleme butonu
        }
    }
}
