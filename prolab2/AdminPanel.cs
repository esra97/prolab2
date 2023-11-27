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
    public partial class AdminPanel : UserControl
    {
        public Login login;

        public List<Company> companies = new List<Company>();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void firmaKayıtButonu_Click(object sender, EventArgs e)
        {
            Company yenişirket = new Company();
            yenişirket.CompanyName = textBox1.Text;
            yenişirket.Username = textBox2.Text;
            yenişirket.Password = textBox3.Text;
            yenişirket.serviceFee = float.Parse(textBox4.Text);

            companies.Add(yenişirket);
            listboxUpdate();

        }

        void listboxUpdate()
        {

            listBox1.Items.Clear();
            foreach (Company company in companies)
            {
                listBox1.Items.Add(company.CompanyName + " - " + company.Username + " - " + company.Password + " - " + company.serviceFee );// liste en başta sonra add sonra ne ekleyeceğin 
            }

        }

        private void CompanyDeleteButton_Click(object sender, EventArgs e)
        {
            companies.RemoveAt(listBox1.SelectedIndex);
            listboxUpdate();
        }

        private void çıkış_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login.Visible = true;
        }
    }
}
