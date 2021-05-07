namespace UvodV_OOP_1
{
    class Person
    {
        public string name;

        public void IntroduceTo(string to)
        {
            System.Console.WriteLine("Hi {0}, my name is {1}",to, name);
        }
    }
}
