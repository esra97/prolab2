using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2
{
    public partial class Login : UserControl
    {
        public AdminPanel adminPanel;
        public CompanyPanel companyPanel;
        public Login()
        {
            InitializeComponent();
        }

        private void girişButonu_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (true)//textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    adminPanel.Visible = true;
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }

            }
            if (checkBox2.Checked)
            {
                int a = 0;
                foreach (Company company in adminPanel.companies)
                {
                    if (company.Username == textBox1.Text && company.Password == textBox2.Text)
                    {
                        companyPanel.Visible = true;
                        this.Visible = false;
                        companyPanel.Company = company;
                        a++;
                    }

                }
                if (a == 0)
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");

            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }
        }
    }
}
