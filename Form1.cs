using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, str, pass;
            login = textBox_Login.Text;
            pass = textBox_Password.Text;
            if (login == "Andriy")
            {
                if (pass == "vfvf2002")
                {
                    str = "hello " + login;
                    label3.BackColor = Color.Green;
                    label4.BackColor = Color.Green;
                    MessageBox.Show(str, "Назва вікна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count--;
                    str = "Невірний логін чи пароль. У вас залишилось " + count + " спроб";
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Red;
                    if (count == 0)
                    {
                        button1.Enabled = false;
                    }
                    MessageBox.Show(str, "Назва вікна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (login != "Andriy")
            {
                str = "Невірний логін чи пароль. У вас залишилось " + count + " спроб";
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                MessageBox.Show(str, "Назва вікна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

        
        

        
    

