﻿Q: 设计一个鸭子超类，并让各种鸭子继承此超类。
鸭子会呱呱叫(quack)，也会游泳(swim)，还有展示自己外观(display)的功能。
每个鸭子都有自己的display功能实现。

1. 有的鸭子能飞，有的不能。
2. 有的鸭子既不会飞，也不会叫，比如木头假鸭。

在超类中定义所有功能，并使用继承在子类中覆盖重写实现。
=> 这并不是一种好的做法。因为有些鸭子不应当有某些行为，覆盖为什么事都不做的做法很笨，也避免不了重复。

使用接口？ 将飞行能力和叫的能力都定义为接口呢？
=> 还是不太好。比如，如果我们的鸭子种类很多，大多数能飞，那么我们要重复写很多不同或相同的飞行行为。
这是因为接口里没有代码的实现，无法复用代码。

**设计原则**：
- 找出应用中变化的部分，把它们独立出来，不要和那些不需要变化的代码混在一起。
- 针对接口编程，而不是针对实现编程。

分开实现变化和不会变化的部分
=> 建立两组类（完全远离Duck类），一类fly相关，一类quack相关，每一组类实现各自的动作。
鸭子类不会负责实现fly和quack接口，而是制造一组行为类专门实现行为接口。

以前： 
行为来自duck超类的具体实现，或是继承某个接口并由子类自行实现而来。
这两种做法都依赖“实现”， 我们被实现绑死，没办法更改行为，除非写更多代码。
现在：
鸭子的子类将使用接口所表示的行为，特定的具体行为编写在实现了flybehavior和quackbehavior的类中。