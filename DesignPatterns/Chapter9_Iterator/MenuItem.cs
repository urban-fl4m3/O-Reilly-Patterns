namespace Chapter9_Iterator
{
    public class MenuItem
    {
        public readonly string Name;
        public readonly string Description;
        public readonly bool Vegeterian;
        public readonly double Price;

        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            Name = name;
            Description = description;
            Vegeterian = vegeterian;
            Price = price;
        }
    }
}
