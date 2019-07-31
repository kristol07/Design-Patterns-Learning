﻿披萨店

如果现在考虑各地的加盟店，每个地方有自己的工厂，而每个地方自己的制作披萨的流程。

在SimplePizzaFactory代码中，制作披萨的代码是绑定在PizzaStore里的，这么做缺乏弹性。

可以将PizzaStore抽象化，OrderPizza部分代码不变，同时CreatePizza方法从OrderPizza中抽离出来放在PizzaStore中。
这样CreatePizza的方法就和PizzaStore在一起了，每个Store都有自己的CreatePizza实现。

在CreatePizza方法中，可以加入IngredientFactory，新的抽象工厂， 使得每个披萨制作的方法不同。
store -> pizza -> ingredientFactory