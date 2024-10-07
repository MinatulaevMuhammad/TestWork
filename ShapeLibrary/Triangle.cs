namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public bool IsRightAngle()
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                   Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2) ||
                   Math.Pow(SideC, 2) + Math.Pow(SideA, 2) == Math.Pow(SideB, 2);
        }
        public double HeronsFormula()
        {
            double p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public double CalculateArea()
        {
            return HeronsFormula();
        }
    }
}
