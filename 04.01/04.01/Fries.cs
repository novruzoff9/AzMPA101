namespace _04._01
{
    internal class Fries : Food
    {
        public double Weight { get; set; }
        public bool IsSalty { get; set; }

        public override double Calcprice()
        {
            double price = Weight;
            if (IsSalty)
            {
                price += 0.8;
            }
            return price;
        }
    }
}
