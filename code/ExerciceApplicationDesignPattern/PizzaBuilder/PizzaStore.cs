using System;


class PizzaStore
{
    static void Main(string[] args)
    {
        //The waiter creates 2 types of pizza without needing to know the details of the ingredients thanks to the two builders
        Waiter waiter = new Waiter();
        PizzaBuilder easternPizzaBuilder = new EasternPizzaBuilder();
        PizzaBuilder pepperoniPizzaBuilder = new PepperoniPizzaBuilder();

        waiter.setPizzaBuilder(easternPizzaBuilder);
        waiter.cookPizza();

        Pizza pizza = waiter.getPizza();
        Console.WriteLine("Pizza: {1}" + pizza.toString());
        
        waiter.setPizzaBuilder(pepperoniPizzaBuilder);
        waiter.cookPizza();

        pizza = waiter.getPizza();
        Console.WriteLine("Pizza: {2}" + pizza.toString());
    }
}

