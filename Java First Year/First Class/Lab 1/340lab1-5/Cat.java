/*

 	ITS-340
 	Lab 01
 	Problem 5
 	1/26/2021
 	Laquon Hamilton
 	
*/

public class Cat 
{
	public String name;
	public int age;
	public double weight;
	
	public void eat() 
	{
		System.out.print("eats, ");
	}
	
	public void sleep()
	{
		System.out.print("sleeps, ");
	}
	
	public void meow()
	{
		System.out.print("and meows.");
	}
	
	public void CatInfo()
	{
		name = "Tom";
		age = 7;
		weight = 9.9;
		
		System.out.println("-------------Cat-------------");
		System.out.println("Name: " + name + " Age: " + age + " Weight: " + weight + "lb");
		System.out.print("Tom ");
		eat();
		sleep();
		meow();
	}
}
