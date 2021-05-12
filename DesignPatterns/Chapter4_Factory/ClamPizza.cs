using System;

namespace Chapter4_Factory
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {_name}");
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
            _clam = _ingredientFactory.CreateClam();
        }
    }
}
