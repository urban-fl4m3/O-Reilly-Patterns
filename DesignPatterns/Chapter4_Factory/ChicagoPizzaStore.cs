namespace Chapter4_Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                //case "cheese":
                //    {
                //        return new CheesePizza();
                //    }

                //case "veggie":
                //    {
                //        return new ChicagoStyleVeggiePizza();
                //    }

                //case "clam":
                //    {
                //        return new ChicagoStyleClamPizza();
                //    }

                //case "pepperoni":
                //    {
                //        return new ChicagoStylePepperoniPizza();
                //    }

                default: return null;
            }
        }
    }
}
