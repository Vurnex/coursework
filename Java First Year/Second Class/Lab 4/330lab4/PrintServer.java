/*

 	ITS-330
 	Lab 04
 	Problem 1
 	2/25/2021
 	Laquon Hamilton
 	
*/

import java.net.*; 
import java.io.*; 
  
public class PrintServer extends ClientTest	//Server program, run before PrintClient
{ 
    //initialize socket and input stream  + port and max connection variables
    private Socket socket = null; 
    private ServerSocket server = null; 
    private DataInputStream in =  null;
    
    private int port;
	private int MaxConnections;
	
	public int getPort()
	{
		return port;
	}
	
	public void setPort(int newPort)
	{
		this.port = newPort;
	}
	
	public int getMaxConnections()
	{
		return MaxConnections;
	}
	
	public void setMaxConnections(int newMax)
	{
		this.MaxConnections = newMax;
	}
  
    public PrintServer(int port) 
    { 
        // starts the server and waits for a connection 
        try
        { 
            server = new ServerSocket(port); 
            System.out.println("Server started."); 
  
            System.out.println("\nListening for a client ..."); 
  
            socket = server.accept(); 
            System.out.println("\nNew Client found."); 
  
            // takes input from the client socket 
            in = new DataInputStream(new BufferedInputStream(socket.getInputStream())); 
  
            String line = ""; 
  
            // reads message from client until "exit" is sent 
            while (!line.equals("exit")) 
            { 
                try
                { 
                	super.TestServer();
                    line = in.readUTF(); 
                    System.out.println(line); 
  
                } 
                catch(IOException i) 
                { 
                    System.out.println(i); 
                } 
                
            } 
            System.out.println("\nClosing connection..."); 
  
            // close connection and stream
            socket.close(); 
            in.close(); 
        } 
        catch(IOException i) 
        { 
            System.out.println(i); 
        } 
    } 
  
    public static void main(String args[]) 
    { 
        @SuppressWarnings("unused") //object not needed inside main method
		PrintServer server = new PrintServer(5000); 
    } 
}
