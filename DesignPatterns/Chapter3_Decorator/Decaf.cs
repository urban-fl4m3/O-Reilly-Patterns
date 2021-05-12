namespace Chapter3_Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05d;
        }
    }
}
