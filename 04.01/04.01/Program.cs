using _04._01;

Pizza[] pizzas = new Pizza[5]
{
    new Pizza { Name = "Margherita", Radius = 12, Calories = 250, IsHot = false, PrepareTime = TimeSpan.FromMinutes(15), Created = DateTime.Now },
    new Pizza { Name = "Pepperoni", Radius = 14, Calories = 320, IsHot = true, PrepareTime = TimeSpan.FromMinutes(18), Created = DateTime.Now },
    new Pizza { Name = "BBQ Chicken", Radius = 16, Calories = 400, IsHot = true, PrepareTime = TimeSpan.FromMinutes(20), Created = DateTime.Now },
    new Pizza { Name = "Veggie", Radius = 10, Calories = 220, IsHot = false, PrepareTime = TimeSpan.FromMinutes(12), Created = DateTime.Now },
    new Pizza { Name = "Hawaiian", Radius = 13, Calories = 280, IsHot = false, PrepareTime = TimeSpan.FromMinutes(17), Created = DateTime.Now }
};

Pizza pizza1 = pizzas[0];
Pizza pizza2 = pizzas[1];

DateTime WhenWillPrepared(Food food)
{
    return food.Created + food.PrepareTime;
}
//Console.WriteLine(WhenWillPrepared(pizza1));

int GetFoods (Food[] foods, int n)
{
    int count = 0;
    foreach (Food food in foods)
    {
        if (food.Calories > n)
        {
            count += 1;
        }
    }
    return count;
}
//Console.WriteLine(GetFoods (pizzas, 300));

Pizza BigRadius(Pizza[] pizzalarinsiyahisi)
{
    Pizza max = pizzas[0];
    foreach (Pizza pizza in pizzalarinsiyahisi)
    {
        if (pizza.Radius > max.Radius)
            max = pizza;
    }
    return max;
}

Console.WriteLine(BigRadius(pizzas));

Console.WriteLine(pizza2);