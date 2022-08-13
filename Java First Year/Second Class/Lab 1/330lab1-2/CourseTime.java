import java.util.Calendar;

/*

 	ITS-330
 	Lab 01
 	Problem 9 (1.2 #5)
 	1/25/2021
 	Laquon Hamilton
 	
*/

public class CourseTime extends Time
{
	private int lengthOfOS;
	private int OSStartHour;
	private int lengthOfSecurity;
	private int securityStartHour;
	private int lengthOfForensics;
	private int forensicsStartHour;
	
	public int getOSLength()
	{
		return lengthOfOS;
	}
	public void setOSLength(int newOSLength)
	{
		this.lengthOfOS = newOSLength;
	}
	
	public int getOSStartHour()
	{
		return OSStartHour;
	}
	public void setOSStartHour(int newOSStartHour)
	{
		this.OSStartHour = newOSStartHour;
	}
	
	public int getSecurityLength()
	{
		return lengthOfSecurity;
	}
	public void setSecurityLength(int newSecurityLength)
	{
		this.lengthOfSecurity = newSecurityLength;
	}
	
	public int getSecurityStartHour()
	{
		return securityStartHour;
	}
	public void setSecurityStartHour(int newSecurityStartHour)
	{
		this.securityStartHour = newSecurityStartHour;
	}
	
	public int getForensicsLength()
	{
		return lengthOfForensics;
	}
	public void setForensicsLength(int newForensicsLength)
	{
		this.lengthOfForensics = newForensicsLength;
	}
	
	public int getForensicsStartHour()
	{
		return forensicsStartHour;
	}
	public void setForensicsStartHour(int newForensicsStartHour)
	{
		this.forensicsStartHour = newForensicsStartHour;
	}
	
	public void ClassTime()
	{
		Calendar calendar = Calendar.getInstance();
		
		if (calendar.get(Calendar.HOUR_OF_DAY) >= 10 && calendar.get(Calendar.HOUR_OF_DAY) <= 11)
		{
			System.out.println("\nOS class is currently in session.");
		}
		else if (calendar.get(Calendar.HOUR_OF_DAY) >= 12 && calendar.get(Calendar.HOUR_OF_DAY) <= 13)
		{
			System.out.println("\nSecurity class is currently in session.");
		}
		else if (calendar.get(Calendar.HOUR_OF_DAY) >= 14 && calendar.get(Calendar.HOUR_OF_DAY) < 16)
		{
			System.out.println("\nForensics class is currently in session.");
		}
		else
		{
			System.out.println("\nNo classes are currently in session.");
		}
	}

}

