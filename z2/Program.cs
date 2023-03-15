namespace z2
{
    class Program
    {
        static void Main()
        {
            Reshenye.Figure figure1 = new Reshenye.Triangle(3, 2, 3);
            figure1.ShowInfo();

            Console.WriteLine(new string('-', 30));

            Reshenye.Figure figure2 = new Reshenye.Rectangle(4, 5);
            figure2.ShowInfo();

            Console.ReadKey();
        }
}   }