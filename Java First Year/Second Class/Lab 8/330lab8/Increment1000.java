/*

 	ITS-330
 	Lab 08
 	Problem 2
 	4/7/2021
 	Laquon Hamilton
 	
*/

import java.util.concurrent.*;

public class Increment1000 
{
  private static Increment incremental = new Increment();

  public synchronized static void main(String[] args) {
    ExecutorService executor = Executors.newCachedThreadPool(); //create thread pool

    // Create and launch 1000 threads
    for (int i = 0; i < 1001; i++) {
      executor.execute(new IncrementTask());
    }

    executor.shutdown();

    // Wait until all tasks are finished
    while (!executor.isTerminated()) {
    }

    System.out.println("Total value: " + incremental.getValue());
  }

  // A thread for adding a penny to the account
  private static class IncrementTask implements Runnable, java.lang.Runnable {
    public synchronized void run() {
      incremental.addValue(1);
    }
  }

  // An inner class for account
  private static class Increment {
    private int totalValue = 0;

    public int getValue() {
      return totalValue - 1;
    }

    public synchronized void addValue(int amount) {//synchronize so each thread only accesses this method one at a time
    	System.out.println("Thread " + totalValue + ":" + totalValue);
    	int newBalance = totalValue + amount;

      // This delay is deliberately added to magnify the
      // data-corruption problem and make it easy to see.
      try {
        Thread.sleep(5);
      }
      catch (InterruptedException ex) {
      }

      totalValue = newBalance;      

    }
  }
  
  public interface Runnable 
  {
  	
  	public abstract void run();

  }

}
