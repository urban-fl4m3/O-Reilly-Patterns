namespace Chapter3_Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99d;
        }
    }
}
