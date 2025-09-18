using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socketUDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            var msg = Encoding.ASCII.GetBytes("Texte à envoyer");

        }

        private void textBoxenvoi_TextChanged(object sender, EventArgs e)
        {  
            var buffer = new byte[1024];
            this.textBox1.Text += Encoding.ASCII.GetString(buffer, 0, buffer.Length);
        
        }

        private void textBox_recp_messa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
           
            
        }

        private void button4_CLS_Click(object sender, EventArgs e)
        {

        }

        private void buttonFemer_Click(object sender, EventArgs e)
        {
          
        }

        private void textBoxRecp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
