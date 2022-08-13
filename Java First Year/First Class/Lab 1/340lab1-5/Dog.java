/*

 	ITS-340
 	Lab 01
 	Problem 5
 	1/26/2021
 	Laquon Hamilton
 	
*/

public class Dog 
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
	
	public void bark()
	{
		System.out.print("and barks.");
	}
	
	public void DogInfo()
	{
		name = "Bolt";
		age = 9;
		weight = 70;
		
		System.out.println("-------------Dog-------------");
		System.out.println("Name: " + name + " Age: " + age + " Weight: " + weight + "lb");
		System.out.print("Bolt ");
		eat();
		sleep();
		bark();
	}
}
