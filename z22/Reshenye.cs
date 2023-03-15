using System.Reflection.PortableExecutable;
public abstract class Reshenye
{
   public abstract class Figure
   {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {ShapeName()}\n" + $"Площадь: {Area()}\n" + $"Периметр: {Perimeter()}");
        }
   }

    public class Triangle : Figure
    {
        double sideA, sideB, sideC;   

        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            SideA = triangleSideA;
            SideB = triangleSideB;
            SideC = triangleSideC;
        }

        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? -value : value; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value < 0 ? -value : value; }
        }

        public override string Area()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
        }

        public override string Perimeter()
        {
            return (sideA + sideB + sideC).ToString();
        }

        public override string ShapeName()
        {
            return "Треугольник";

        }

    }

     public class Rectangle : Figure
    {
        double width; 
        double height;   


        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }

        public double Width
        {
            get { return width; }
            set { width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value < 0 ? -value : value; }
        }

        public override string Area()
        {
            return (width * height).ToString();
        }

        public override string Perimeter()
        {
            return (width * 2 + height * 2).ToString();
        }

        public override string ShapeName()
        {
            return "Прямоугольник";
        }
     }
}