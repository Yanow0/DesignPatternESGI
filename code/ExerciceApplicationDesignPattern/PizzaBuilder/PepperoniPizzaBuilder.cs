//Extends PizzaBuilder to create a new type of pizza and its ingredients
class PepperoniPizzaBuilder : PizzaBuilder
{
    public override void buildTypeDough()
    {
        pizza.typeDough = "Crust";
    }
    public override void buildTypeBase()
    {
        pizza.typeBase = "Tomato";
    }
    public override void buildToppers()
    {
        pizza.toppers = "Mozzarella, pepperoni, oregano";
    }
}