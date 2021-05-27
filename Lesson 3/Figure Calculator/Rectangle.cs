namespace Figure_Calculator
{
    class Rectangle : Figure
    {
        private int side1, side2;
        public Rectangle(int side1, int side2) // rectangle constructor
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double AreaCalculator()
        {
            return side1 * side2;
        }

        public override double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
}
