/*

 	ITS-330
 	Lab 01
 	Problem 4
 	1/24/2021
 	Laquon Hamilton
 	
*/


import java.time.LocalDate; // import the LocalDate class
import java.time.LocalTime; // import the LocalTime class

public class Client {
	
	private int id;
	private int port;
	private String Name;
	
	public Client()
	{
		
	}
	public Client(int id)
	{
		
	}
	public Client(int id, int p)
	{
		
	}
	public Client(int id, int p, String n)
	{
		
	}
	
	public int getID()
	{
		return id;
	}
	public void setID(int newID)
	{
		this.id = newID;
	}
	public int getPort()
	{
		return port;
	}
	public void setPort(int newPort)
	{
		this.port = newPort;
	}
	public String getName()
	{
		return Name;
	}
	public void setName(String newName)
	{
		this.Name = newName;
	}
	
	public void PrintDate()
	{
		LocalDate myDate = LocalDate.now(); // Create a date object
	    System.out.println("\nCurrent Date: " + myDate); // Display the current date
	    
	    LocalTime myTime = LocalTime.now();
	    System.out.println("\nCurrent Time (Military): " + myTime);
	}
	

	public static void main(String[] args) //TestClient
	{
		// TODO Auto-generated method stub
		
		PrintClient pc = new PrintClient();
		
		pc.setLocation("Classroom");
		
		pc.PrintDate();
		
		Client date = new Client();
		
		date.PrintDate();

	}

}