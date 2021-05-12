namespace Chapter3_Decorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99d;
        }
    }
}
