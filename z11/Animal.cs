using System.Reflection.PortableExecutable;

public abstract class Animal
{
    public abstract void Description();
    public class Capybara : Animal
    {
        public Capybara(string typeOfAnimal, string territory, string clas, int weightoffemales, int maleweight)
        {
            this.typeOfAnimal = typeOfAnimal;
            this.territory = territory;
            this.clas = clas;
            this.weightoffemales = weightoffemales;
            this.maleweight = maleweight;
        }
        public string typeOfAnimal;
        public string territory;
        public string clas;
        public int weightoffemales;
        public int maleweight;

        public override void Description()
        {
            Console.WriteLine("Тип животного: {0}. \nМесто обитания: {1}. Класс: {2}. Вес самок в кг: {3}. Вес самцов в кг: {4}.", typeOfAnimal, territory, clas, weightoffemales, maleweight);
        }
    }
    public class Platypus : Animal
    {
        public Platypus(string typeOfAnimal, string territory, string clas, int weightoffemales, int maleweight)
        {
            this.typeOfAnimal = typeOfAnimal;
            this.territory = territory;
            this.clas = clas;
            this.weightoffemales = weightoffemales;
            this.maleweight = maleweight;
        }
        public string typeOfAnimal;
        public string territory;
        public string clas;
        public int weightoffemales;
        public int maleweight;

        public override void Description()
        {
            Console.WriteLine("Тип животного: {0}. \nМесто обитания: {1}. Класс: {2}. Вес самок в кг: {3}. Вес самцов в кг: {4}.", typeOfAnimal, territory, clas, weightoffemales, maleweight);
        }
    }

    public class Manul : Animal
    {
        public Manul(string typeOfAnimal, string territory, string clas, int weightoffemales, int maleweight)
        {
            this.typeOfAnimal = typeOfAnimal;
            this.territory = territory;
            this.clas = clas;
            this.weightoffemales = weightoffemales;
            this.maleweight = maleweight;
        }
        public string typeOfAnimal;
        public string territory;
        public string clas;
        public int weightoffemales;
        public int maleweight;

        public override void Description()
        {
            Console.WriteLine("Тип животного: {0}. \nМесто обитания: {1}. Класс: {2}. Вес самок в кг: {3}. Вес самцов в кг: {4}.", typeOfAnimal, territory, clas, weightoffemales, maleweight);
        }
    }
}