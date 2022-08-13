/*

 	ITS-340
 	Lab 01
 	Problem 6
 	1/26/2021
 	Laquon Hamilton
 	
*/	

interface IsEmergency
{
	public void soundSiren();
}

interface IsVehicle
{
	public void drive();
}

public class PoliceCar implements IsEmergency, IsVehicle
{
	public void soundSiren()
	{
		System.out.print("can sound a siren. ");
	}
	public void drive()
	{
		System.out.print("can drive ");
	}
	
	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		PoliceCar PNWCar = new PoliceCar();
		System.out.print("The PNW Car ");
		PNWCar.drive();
		System.out.print("and ");
		PNWCar.soundSiren();
	}

}
