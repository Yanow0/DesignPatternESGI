class Waiter{
    private PizzaBuilder pizzaBuilder;

    public void setPizzaBuilder(PizzaBuilder pb){
        pizzaBuilder = pb;
    }

    public Pizza getPizza(){
        return pizzaBuilder.getPizza();
    }

    public void cookPizza(){
        pizzaBuilder.createNewPizza();
        pizzaBuilder.buildTypeDough();
        pizzaBuilder.buildTypeBase();
        pizzaBuilder.buildToppers();
    }
}