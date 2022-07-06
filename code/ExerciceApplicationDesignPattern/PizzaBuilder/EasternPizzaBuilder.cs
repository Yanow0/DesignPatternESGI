//Extends PizzaBuilder to create a new type of pizza and its ingredients
class EasternPizzaBuilder : PizzaBuilder
{
    public override void buildTypeDough()
    {
        pizza.typeDough = "Thin crust";
    }

    public override void buildTypeBase()
    {
        pizza.typeBase = "Tomato sauce with oregano";
    }

    public override void buildToppers()
    {
        pizza.toppers = "Mozzarella, egg, merguez, pepper";
    }
}