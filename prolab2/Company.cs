using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Company : User, IProfitable
    {

        // Company'ye özgü özellikler
        public string CompanyName { get; set; }
        public decimal DailyIncome { get; set; }
        public decimal OverallIncome { get; set; }

        public float serviceFee { get; set; }


        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        // Günün karını hesapla
        public void CalculateDailyProfit()
        { }

        public void CalculateOverallProfit()
        {
        }

        // Genel kar-zararı hesapla
        public void CalculateOverallProfitLoss()
        {
        }

        public override void Login()
        {
        }
    }
}
