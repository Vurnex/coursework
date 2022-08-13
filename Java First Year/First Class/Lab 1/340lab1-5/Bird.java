/*

 	ITS-340
 	Lab 01
 	Problem 5
 	1/26/2021
 	Laquon Hamilton
 	
*/

public class Bird 
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
	
	public void chirp()
	{
		System.out.print("and chirps.");
	}
	
	public void BirdInfo()
	{
		name = "Sam";
		age = 3;
		weight = 0.4;
		
		System.out.println("-------------Bird-------------");
		System.out.println("Name: " + name + " Age: " + age + " Weight: " + weight + "oz");
		System.out.print("Sam ");
		eat();
		sleep();
		chirp();
	}
}
