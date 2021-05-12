namespace Chapter4_Factory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    {
                        pizza = new CheesePizza(ingredientFactory);
                        pizza.SetName("New York Style Cheese Pizza");
                        break;
                    }

                //case "veggie":
                //    {
                //        return new NYStyleVeggiePizza();
                //    }

                case "clam":
                    {
                        pizza = new ClamPizza(ingredientFactory);
                        pizza.SetName("New York Style Clam Pizza");
                        break;
                    }

                //case "pepperoni":
                //    {
                //        return new NYStylePepperoniPizza();
                //    }

                default:
                    {
                        pizza = null;
                        break;
                    }
            }

            return pizza;
        }
    }
}
