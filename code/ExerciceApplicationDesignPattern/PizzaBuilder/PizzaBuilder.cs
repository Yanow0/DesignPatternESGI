//Allows to create different types of pizza
abstract class PizzaBuilder
{
    protected Pizza pizza;
    public Pizza getPizza()
    {
        return pizza;
    }

    public void createNewPizza(){
        pizza = new Pizza();
    }    
    public abstract void buildTypeDough();
    public abstract void buildTypeBase();
    public abstract void buildToppers();
}