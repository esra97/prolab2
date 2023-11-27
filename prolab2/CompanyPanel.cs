using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2
{

    public partial class CompanyPanel : UserControl
    {
        public Login login;
        public Company Company { get; set; }
        public CompanyPanel()
        {
            InitializeComponent();
            comboBox1.Items.Add("Tren");
            comboBox1.Items.Add("Uçak");
            comboBox1.Items.Add("Otabüs");

        }

        private void vehicleAddButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Otabüs")
            {
                Bus bus = new Bus();
                bus.Model=textBox1.Text;
                bus.id=textBox4.Text;
                bus.fuelType=textBox3.Text;
                bus.Capacity= int.Parse(textBox2.Text);
                Company.Vehicles.Add(bus);

            }
            if(comboBox1.Text == "Tren")
            {
                Train train = new Train();
                train.Model=textBox1.Text;
               train.id = textBox4.Text;
                train.fuelType = textBox3.Text;
                train.Capacity  = int.Parse(textBox2.Text); 
                Company.Vehicles.Add(train);

            }
            if (comboBox1.Text == "Uçak")
            {
                Airplane plane = new Airplane();
                plane.Model = textBox1.Text;
                plane.id = textBox4.Text;
                plane.fuelType = textBox3.Text;
                plane.Capacity = int.Parse(textBox2.Text);
                Company.Vehicles.Add(plane);

            }
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            listboxUpdate();
        }

        private void çıkışButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            Company.Vehicles.RemoveAt(listBox1.SelectedIndex);
            listboxUpdate();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if(listBox1.SelectedIndex != -1 && listBox1.SelectedItem.ToString().Contains("Bus"))
            {
                listBox2.Items.Add("3.sefer Karayolu: Istanbul - Kocaeli - Ankara - Kocaeli - Istanbul - Kocaeli- Ankara - Kocaeli - Istanbul ");
                listBox2.Items.Add("4.sefer Karayolu: Istanbul - Kocaeli - Eskisehir - Konya - Eskisehir - Kocaeli-Istanbul");
            }
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedItem.ToString().Contains("Train"))
            {
                listBox2.Items.Add("1.sefer Demiryolu: Istanbul - Kocaeli - Bilecik - Eski¸sehir - Ankara - Eskisehir- Bilecik - Kocaeli - Istanbul ");
                listBox2.Items.Add("2.sefer Demiryolu: Istanbul - Kocaeli - Bilecik - Eski¸sehir - Konya - Eskisehir- Bilecik - Kocaeli - Istanbul");
            }
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedItem.ToString().Contains("Airplane"))
            {
                listBox2.Items.Add("5.sefer Havayolu: Istanbul - Konya - Istanbul ");
                listBox2.Items.Add("∗ 6.sefer Havayolu: Istanbul - Ankara - Istanbul");
            }
        }
        void listboxUpdate()
        {
            listBox3.Items.Clear();

            listBox1.Items.Clear();
            foreach (Vehicle vehicle in Company.Vehicles)
            {
                listBox1.Items.Add(vehicle.Capacity + " - " + vehicle.Model + " - " + vehicle.GetType().ToString().Split('.')[1]);
            }

        }

        private void CompanyPanel_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seferEkle_Click(object sender, EventArgs e)
        {
            string selectedRoute = listBox2.Items[listBox2.SelectedIndex].ToString();
            int length = selectedRoute.Length - selectedRoute.IndexOf(':') - 1;
                int index = selectedRoute.IndexOf(':') + 1;
            selectedRoute = selectedRoute.Substring(index, length);
            string[] routeParts = selectedRoute.Split('-');
            if (routeParts.Length > 0)
            {
                for(int i = 0; i< routeParts.Length-1; i++)
                {
                    Route route = new Route();
                    route.DepartureLocation = routeParts[i].Trim();
                    route.ArrivalLocation = routeParts[i+1].Trim();
                    Company.Vehicles[listBox1.SelectedIndex].trip.RouteList.Add(route);
                }
              
            }
            listbox3Update();
        }
        void listbox3Update()
        {
            listBox3.Items.Clear();
            int count = Company.Vehicles[listBox1.SelectedIndex].trip.RouteList.Count;
            string fullTrip = "";
            int x = 0;
            for(int i = 0; i< count;i++)
            {
                if (i == 0)
                {
                    fullTrip += $"{Company.Vehicles[listBox1.SelectedIndex].trip.RouteList[i].DepartureLocation} - {Company.Vehicles[listBox1.SelectedIndex].trip.RouteList[i].ArrivalLocation}";
                }
                else if (i > 0)
                {
                    fullTrip += $" - {Company.Vehicles[listBox1.SelectedIndex].trip.RouteList[i].ArrivalLocation}";
                }
                
            }
            listBox3.Items.Add(fullTrip);
        }

        private void seferSil_Click(object sender, EventArgs e)
        {
  
                Company.Vehicles[listBox1.SelectedIndex].trip.RouteList.Clear();
            
            listBox3.Items.Clear();
        }
    }
}
