namespace _6_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов конструктора без параметров
            Rectangle rectangle1 = new Rectangle();
            Console.WriteLine($"Площадь прямоугольника с размерами {rectangle1.a}x{rectangle1.b}: {rectangle1.Square()}");

            // Вызов конструктора с одним параметром
            Rectangle rectangle2 = new Rectangle(5);
            Console.WriteLine($"Площадь квадрата со стороной {rectangle2.a}: {rectangle2.Square()}");

            // Вызов конструктора с двумя параметрами
            Rectangle rectangle3 = new Rectangle(3, 7);
            Console.WriteLine($"Площадь прямоугольника с размерами {rectangle3.a}x{rectangle3.b}: {rectangle3.Square()}");

            Console.ReadKey();
        }
    }

    public class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int side)
        {
            a = side;
            b = side;
        }

        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        public int Square()
        {
            int result = a * b;
            return result;
        }
    }
}