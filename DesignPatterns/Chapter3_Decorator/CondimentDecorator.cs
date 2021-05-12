namespace Chapter3_Decorator
{
    public class CondimentDecorator : Beverage
    {
        public override string GetDescription()
        {
            return string.Empty;
        }

        public override double Cost()
        {
            return 0;
        }
    }
}
