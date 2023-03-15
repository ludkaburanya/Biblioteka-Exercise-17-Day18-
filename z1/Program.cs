namespace animals
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;
            Animal[] character = new Animal[n];
            character[0] = new Animal.Capybara("Capybara", "South and North America", "rodents", 55, 43);
            character[1] = new Animal.Platypus("Platypus", "Eastern Australia", "single pass", 2, 8);
            character[2] = new Animal.Manul("Manul", "Central and Central Asia", "predatory", 4, 5);
            foreach (Animal elem in character)
            {
                elem.Description();
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}