namespace Chapter3_Decorator
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";
    
        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract double Cost();
    }
}
