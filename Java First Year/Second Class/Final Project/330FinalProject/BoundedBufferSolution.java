/*

 	ITS-330
 	Final Project
 	Problem ---
 	4/29/2021
 	Laquon Hamilton
 	
*/


// Java program to implement solution of producer/consumer problem.
  
import java.util.LinkedList; //used to store values into the buffer
import java.util.concurrent.*; //used for the execution of the threads
  
public class BoundedBufferSolution 
{
	
    public static void main(String[] args) throws InterruptedException
    {
        // Object of the buffer that contains the put and get methods
        Buffer theBuffer = new Buffer();
        
        ExecutorService theProducers = Executors.newFixedThreadPool(2); //thread pool for the producers
        ExecutorService theConsumers = Executors.newFixedThreadPool(2); //thread pool for the consumers
        
        Runnable newProducer = new Runnable() //runnable method for the producers
        {
			
			@Override
			public void run() 
			{
				// TODO Auto-generated method stub
                try 
                {
                    theBuffer.put(); //calls the put method to enter a value into the buffer
                }
                catch (InterruptedException e) 
                {
                    e.printStackTrace();
                }
				
			}
		};
		
		Runnable newConsumer = new Runnable() //runnable method for the consumers
		{
			
			@Override
			public void run() 
			{
				// TODO Auto-generated method stub
                try 
                {
                	 //identifies the thread as belonging to the first consumer
                    theBuffer.get(); //calls the get method to obtain the value from the buffer and sends the
                    						//thread number to the buffer
                }
                catch (InterruptedException e) 
                {
                    e.printStackTrace();
                }
			}
		};
  
        // Start both threads
		
        theProducers.execute(newProducer);
        theConsumers.execute(newConsumer);
  
        // Shutdown the threads when they are finished
        theProducers.shutdown();
        theConsumers.shutdown();
    }
    
    public static int getRandNum() //generate random thread numbers for producers and consumers
    {
    	int temp = (Math.random() <= 0.5) ? 1 : 2;
    	
    	return temp;
    }
    
    // The buffer contains a list with the put method which adds items to the list and the get method which removes items
    public static class Buffer 
    {
  
        // Create a list shared by the producers and consumers 
        LinkedList<Integer> theList = new LinkedList<>();
        
        int bufferCapacity = 1; //maximum number of items the buffer can hold
  
        // Method called by producer thread
        public void put() throws InterruptedException //thrown when thread is interrupted
        {
            int value = 0; //value to be entered into the buffer
            
            while (true) 
            {
                synchronized (this)
                {
                    // producer thread waits while the list is full
                    while (theList.size() == bufferCapacity)
                        wait();
  
                    System.out.println("Producer " + getRandNum() + " produced " + value);
  
                    // put values into the list/buffer
                    theList.add(value++);
  
                    // notifies the consumer thread that it can now start consuming
                    notify();
  
                    // Let the thread sleep for enough time to allow for demonstrating the producer consumer process
                    Thread.sleep(2000);
                    
                }
            }
        }
  
        // Method called by consumer thread
        public void get() throws InterruptedException
        {
            while (true) 
            {
                synchronized (this)
                {
                    // the consumer thread will wait while the list/buffer is empty
                    while (theList.size() == 0)
                        wait();
  
                    // gets the first value in the list/buffer
                    int val = theList.removeFirst();
  
                    System.out.println("Consumer " + getRandNum() + " consumed " + val);
  
                    // Wake up the producer thread
                    notify();
                    
                    // Let the thread sleep for enough time to allow for demonstrating the producer consumer process
                    Thread.sleep(1000); 
                    
                }
            }
        }
    }
}