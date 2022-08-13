/*

 	ITS-330
 	Lab 04
 	Problem 1
 	2/25/2021
 	Laquon Hamilton
 	
*/


import java.net.*; 
import java.io.*;
import java.util.Scanner;
  
public class PrintClient extends ClientTest	//Client program, run after PrintServer
{ 
    // initialize socket and input output streams + host variable
    private Socket socket = null; 
    private Scanner input = null; 
    private DataOutputStream out = null; 
    
    private String host;
    
	public String getHost()
	{
		return host;
	}
	
	public void setHost(String newHost)
	{
		this.host = newHost;
	}
  
    public PrintClient(String address, int port) 
    {
        // create connection 
        try
        { 
            socket = new Socket(address, port); 
            System.out.println("Connection successful."); 
  
            // takes input from terminal 
            input = new Scanner(System.in);
  
            // sends output to the socket 
            out = new DataOutputStream(socket.getOutputStream()); 
        } 
        catch(UnknownHostException u) 
        { 
            System.out.println(u); 
        } 
        catch(IOException i) 
        { 
            System.out.println(i); 
        } 
  
        // string to read message from input 
        String line = ""; 
  
        // keep reading until "Over" is input 
        while (!line.equals("exit")) 
        { 
            try
            { 
            	super.TestClient();
                line = input.nextLine();
                
                System.out.println("\nMessage sent."); 
                
                out.writeUTF(line); 
            } 
            catch(IOException i) 
            { 
                System.out.println(i); 
            }
            
        } 
  
        // close connections and streams 
        
        System.out.println("\nClosing connection..."); 
        
        try
        { 
            input.close(); 
            out.close(); 
            socket.close(); 
        } 
        catch(IOException i) 
        { 
            System.out.println(i); 
        } 
    } 
  
    public static void main(String args[]) 
    { 
        @SuppressWarnings("unused") //object not needed in main method
		PrintClient client = new PrintClient("127.0.0.1", 5000); 
    } 
} 
