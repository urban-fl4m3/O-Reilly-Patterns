namespace Chapter3_Decorator
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Soy";
        }

        public override double Cost()
        {
            return .15d + _beverage.Cost();
        }
    }
}
