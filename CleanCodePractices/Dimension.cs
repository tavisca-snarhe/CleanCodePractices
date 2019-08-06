namespace CleanCodePractices
{
    public class Dimension
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Dimension(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public void Change(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
