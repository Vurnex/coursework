/*

 	ITS-330
 	Lab 01
 	Problem 5 (1.2)
 	1/24/2021
 	Laquon Hamilton
 	
*/

public class PrintClient extends Client
{
	private String Location;
	
	public String getLocation()
	{
		return Location;
	}
	
	public void setLocation(String newLocation)
	{
		this.Location = newLocation;
	}
	
	public void PrintDate()
	{
		if (getLocation() == "null")
		{
			super.PrintDate();
		}
		else
		{
			System.out.println("Current Location: " + getLocation());
			//System.out.println("\nNot allowed to display PrintDate for clients");
		}
	}
	
}
