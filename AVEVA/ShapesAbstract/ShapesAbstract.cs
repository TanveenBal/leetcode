namespace ShapesAbstract
{
    abstract class Shape
    {
        protected string name { get; set; }
        public Shape(string name)
        {
            this.name = name;
        }

        public void print()
        {
            Console.WriteLine($"{this.name}");
        }

        public abstract void draw();

        public abstract double area();
    }

    class Square : Shape
    {
        private int Side { get; set; }

        public Square(int side) : base("Square")
        {
            this.Side = side;
        }

        public override void draw()
        {
            for (int i = 0; i < this.Side; i++)
            {
                for (int j = 0; j < this.Side; j++)
                {
                    if (i == 0 || i == this.Side - 1 || j == 0 || j == this.Side - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public override double area()
        {
            return this.Side * this.Side;
        }
    }

    class Triangle : Shape
    {
        private int Base { get; set; }
        private int Height { get; set; }

        public Triangle(int Base, int Height) : base("Triangle")
        {
            this.Base = Base;
            this.Height = Height;
        }

        public override void draw()
        {
            int maxStars = 1 + 2 * (Height - 1);

            for (int i = 0; i < Height; i++)
            {
                int stars = 1 + 2 * i;
                int spaces = (maxStars - stars) / 2;

                for (int j = 0; j < spaces; j++)
                    Console.Write(" ");

                for (int j = 0; j < stars; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        public override double area()
        {
            return (this.Base * this.Height) / 2;
        }
    }

    class Circle : Shape
    {
        private int Radius { get; set; }

        public Circle(int Radius) : base("Circle")
        {
            this.Radius = Radius;
        }

        public override void draw()
        {
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;

            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x <= Radius; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public override double area()
        {
            return 3.14 * this.Radius * this.Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape> { new Square(5), new Triangle(4, 6), new Circle(3) };

            foreach (Shape shape in shapes)
            {
                shape.print();
                shape.draw();
                Console.WriteLine($"Area: {shape.area()}\n");
            }
        }
    }
}
