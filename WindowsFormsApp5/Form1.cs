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
            buttonZpet.Location = new Point(70, 70);
            buttonZpet.Text = "Zpět";
            buttonZpet.Size = new Size(100, 50);
            buttonZpet.DialogResult = DialogResult.OK;

            buttonKonec.Location = new Point(10, 70);
            buttonKonec.Text = "Konec";
            buttonKonec.Size = new Size(50, 20);
            buttonKonec.DialogResult = DialogResult.Cancel;

            Form form2 = new Form();
            form2.Size = new Size(vyska, sirka);
            form2.Controls.Add(label);
            form2.Controls.Add(buttonZpet);
            form2.Controls.Add(buttonKonec);
            form2.BackColor= Color.White;
            if(radioButton3.Checked == true)
            {
                form2.BackColor = Color.Red;
            }
            else if(radioButton4.Checked == true)
            {
                form2.BackColor = Color.Green;
            }
            else if(radioButton5.Checked == true)
            {
                form2.BackColor = Color.Blue;
            }
            if (checkBox1.Checked == false)
            {
                form2.MaximumSize = new Size(vyska, sirka);
                form2.MinimumSize = new Size(vyska, sirka);
            }
            this.Hide();
            form2.ShowDialog();
            
        }
    }
}
