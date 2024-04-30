using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalesPerson
{
    internal class SalesPerson
    {
        private string _name;
        private string _family;
        private double[] sales;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value.Length < 3)
                    _name = "name";
                else
                    _name = value; 
            }
        }
        public string Family
        {
            get { return _family; }
            set
            {
                if (value.Length < 3)
                    _family = "family";
                else
                    _family = value;
            }
        }

        public SalesPerson()
        {
            sales = new double[12];
            _name = "";
            _family = "";
        }
        public SalesPerson(string name, string family)
        {
            sales = new double[12];
            Name = name;
            Family = family;
        }

        private string GetMonthName(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    return "януари";
                case 2:
                    return "февруари";
                case 3:
                    return "март";
                case 4:
                    return "април";
                case 5:
                    return "май";
                case 6:
                    return "юни";
                case 7:
                    return "юли";
                case 8:
                    return "август";
                case 9:
                    return "септември";
                case 10:
                    return "октомври";
                case 11:
                    return "ноември";
                case 12:
                    return "декември";
                default:
                    return "Невалиден месец";
            }
        }     

        public void EnterSalesData()
        {
            Console.WriteLine("Enter {0} {1}'s sales data for every month:", Name, Family);
            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write("Enter sales data for {0}: ", GetMonthName(i + 1));
                double x = double.Parse(Console.ReadLine());
                if (x >= 0)
                    sales[i] = x;
            }
        }
        public void CreateRadomSalesData()
        {
            Random random = new Random();
            for (int i = 0; i < sales.Length; i++)
            {
                sales[i] = random.NextDouble() * random.Next(1, int.MaxValue);
            }
        }

        public void DisplaySales()
        {
            Console.WriteLine("{0} {1}'s sales data: ", Name, Family);
            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine(GetMonthName(i + 1) + " " + sales[i]);
            }
        }        
        public double SalesSum()
        {
            double sum = 0;
            foreach (var item in sales)
                sum += item;

            return sum;
        }
        public double SalesAverage()
        {
            return SalesSum() / 12;
        }
    }
}
