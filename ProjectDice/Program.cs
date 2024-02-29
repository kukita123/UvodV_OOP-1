namespace ProjectDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice D4 = new Dice();
            D4.SetFields();

            Dice D6 = new Dice();
            D6.SetFields("Cube", 6);

            D4.Roll();
            D4.Display();

            D6.Roll();
            D6.Display();

            Console.ReadKey();
        }
    }
}