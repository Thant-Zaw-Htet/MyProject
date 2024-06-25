namespace Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(8, 2);
            rectangle.Show();
          
        }


        public class Rectangle
        {
            private int length, width;

            public Rectangle(int length, int width)
            {
                this.length = length;
                this.width = width;
            
            }

            public int GetLength()
            {
                return length;
            }

            public void SetLength(int length)
            {
                this.length = length;
            }
            public int GetWidth()
            {
                return width;
            }
            public void SetWidth(int width)
            {
                this.width = width;
            }

            public int calculateArea()
            {
                return length * width;
            }

            public int calculatePerimeter()
            {
                return 2 * (length + width);
            }

            public void Show()
            {
                Console.WriteLine($"Length: {length}");
                Console.WriteLine($"Width: {width}");
                Console.WriteLine($"Area: {calculateArea()}");
                Console.WriteLine($"Perimeter: {calculatePerimeter()}");

                

            }

        }
    } 
}