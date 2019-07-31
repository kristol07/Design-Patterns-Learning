单件模式： 

https://stackoverflow.com/questions/2155688/what-is-a-singleton-in-c
https://csharpindepth.com/articles/singleton
https://code-maze.com/singleton/

确保一个类只有一个实例，并提供一个全局访问点。

- thread unsafe:
```c#
public class Singleton {
	private static Singleton uniqueInstance;

	private Singleton() { }

	public static Singleton getInstance() {
		if (uniqueInstance == null) {
			uniqueInstance = new Singleton();
		}
		return uniqueInstance;    
	}
}
```