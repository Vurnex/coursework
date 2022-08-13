//import java.util.Calendar;

/*

 	ITS-330
 	Lab 01
 	Problem 5, 6, 8 (1.2 - 1, 2, 4)
 	1/24/2021
 	Laquon Hamilton
 	
*/

public class Time 
{
	private int hours;
	private int minutes;
	private int seconds;
	
	public int getHours()
	{
		return hours;
	}
	public void setHours(int newHours)
	{
		this.hours = newHours;
	}
	
	public int getMinutes()
	{
		return minutes;
	}
	public void setMinutes(int newMinutes)
	{
		this.minutes = newMinutes;
	}
	
	public int getSeconds()
	{
		return seconds;
	}
	public void setSeconds(int newSeconds)
	{
		this.seconds = newSeconds;
	}
	
	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		//Calendar calendar = Calendar.getInstance();
		
		/*
		
		System.out.println("Current Calendar's Year: " + calendar.get(Calendar.YEAR)); 
        System.out.println("Current Calendar's Day: " + calendar.get(Calendar.DATE));
        System.out.println("Current Calendar's Month: " + calendar.get(Calendar.MONTH));
        System.out.println("Current Hour: " + calendar.get(Calendar.HOUR_OF_DAY)); 
        System.out.println("Current Minute: " + calendar.get(Calendar.MINUTE)); 
        System.out.println("Current Second: " + calendar.get(Calendar.SECOND)); 
        
        */
				
		CourseTime OSStart = new CourseTime();
		OSStart.setOSStartHour(10);
		
		CourseTime OSLength = new CourseTime();
		OSLength.setOSLength(2);
		
		CourseTime SecurityStart = new CourseTime();
		SecurityStart.setSecurityStartHour(12);
		
		CourseTime SecurityLength = new CourseTime();
		SecurityLength.setSecurityLength(2);
		
		CourseTime ForensicsStart = new CourseTime();
		ForensicsStart.setForensicsStartHour(14);
		
		CourseTime ForensicsLength = new CourseTime();
		ForensicsLength.setForensicsLength(2);
        
        System.out.println("OS begins at " + OSStart.getOSStartHour() + ":00 and lasts for " + OSLength.getOSLength() + " hours.");
        System.out.println("\nSecurity begins at " + SecurityStart.getSecurityStartHour() + ":00 and lasts for " + SecurityLength.getSecurityLength() + " hours.");
        System.out.println("\nForensics begins at " + ForensicsStart.getForensicsStartHour() + ":00 and lasts for " + ForensicsLength.getForensicsLength() + " hours.");

        CourseTime inSession = new CourseTime();
        
        inSession.ClassTime();
        
	}

}
