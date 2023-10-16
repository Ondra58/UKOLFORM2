using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vyska = trackBar1.Value;
            int sirka = trackBar2.Value;
            string text = textBox1.Text;

            Label label = new Label();
            label.Text = text;

            Button buttonZpet = new Button();
            Button buttonKonec = new Button();

            Form form2 = new Form();
            form2.Size = new Size(vyska, sirka);
            form2.Controls.Add(label);
            form2.Controls.Add(buttonZpet);
            form2.Controls.Add(buttonKonec);
            this.Hide();
            form2.ShowDialog();
            
        }
    }
}
