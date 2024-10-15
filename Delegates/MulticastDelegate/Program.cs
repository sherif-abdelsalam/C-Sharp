namespace multicast_delegate{

    public delegate void RecDelg(int height, int width);

    class Program{

        public static void Main(string[] args)
        {
            Rectange rec = new Rectange();
            // rec.getPerimeter(10,10);
            // rec.getrea(10,10);

            RecDelg helper;
            helper = rec.getPerimeter;
            helper+=rec.getrea;
            helper(10,10);
            helper -= rec.getPerimeter;
            helper(10,10);
        }
    }

    class Rectange{
        public void getrea(int height, int width){
            System.Console.WriteLine("Area = " + height*width);
        }
        public void getPerimeter(int height, int width){
            System.Console.WriteLine("Perimeter = " + (width+height)*2);
        }
    }
}