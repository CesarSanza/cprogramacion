
namespace ShapesApp
{

    class Shape
    {
        public virtual int CalculateArea()
        {
            return 0;
        }
    }


    class Rectangle : Shape
    {
        private int base_;
        private int height;

        public Rectangle(int base_, int height)
        {
            this.base_ = base_;
            this.height = height;
        }

        public override int CalculateArea()
        {
            return base_ * height;
        }
    }


    class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override int CalculateArea()
        {

            return (int)(3.1416 * radius * radius);
        }
    }
}