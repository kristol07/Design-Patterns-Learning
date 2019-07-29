官方例子： https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern （待理解...）


### 气象监测应用

系统分为三个部分：
- 气象站，获取实际气象数据的物理装置
- WeatherData对象，追踪来自气象站的数据，并更新布告板
- 布告板， 显示目前天气状况（目前状况，气象统计，天气预报）给用户看

目的是实现WeatherData中的measurementsChanged方法，一旦气象更新，此方法就会被调用，以更新布告板。

在此例实现中，subject 和 observer 都作为接口。
在其他例子中，是写成抽象类的。 https://exceptionnotfound.net/the-daily-design-pattern-observer/
但是设计成抽象类不是很好，因为必须设计一个类来继承它，如果某个类想同时具有此类和另一个超类的行为，就会有问题，因为C#不支持多重继承。
