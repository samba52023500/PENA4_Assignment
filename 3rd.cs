using System;
  
public class Program {
      
    public static void Main(String[] args)
    {
    	try
    	{
    		char[] array = {'P','E','N','A','4'};
          
        for (int i = 0; i <= array.Length; i++)
            Console.WriteLine(array[i]);
    	}
    	catch(Exception e)
    	{
    		Console.WriteLine(e.GetType().Name);
    	}
    	
    }
}