namespace ProjectSalesPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first object -> create and manipulate:
            SalesPerson salesPerson1 = new SalesPerson();
            salesPerson1.Name = "Mariana";
            salesPerson1.Family = "Hristozkova";

            salesPerson1.CreateRadomSalesData();
            salesPerson1.DisplaySales();
            Console.WriteLine(salesPerson1.SalesSum());
            Console.WriteLine(salesPerson1.SalesAverage());
            Console.WriteLine();


            //second object -> create and manipulate:
            SalesPerson salesPerson2 = new SalesPerson("Ivan", "Ivanov");
            salesPerson2.EnterSalesData();
            salesPerson2.DisplaySales();
            Console.WriteLine(salesPerson2.SalesSum());
            Console.WriteLine(salesPerson2.SalesAverage());



            Console.ReadKey();
        }
    }
}