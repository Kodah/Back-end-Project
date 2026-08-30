struct Program
{
    public static void Main()
    {
        ProductDimensions P1 = new ProductDimensions(15, 30, 8.25);
        ProductDimensions P2 = P1;

        P2.Width = 17;

        Console.WriteLine($" The Width of P1 is: {P1.Width}, The Width of P2 is: {P2.Width}");


    }
    struct ProductDimensions
    {

    public double Width;
    public double Height;
    public double Depth;

    public ProductDimensions(double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }
    }

}
