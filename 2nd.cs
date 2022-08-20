using System;

public class Program {
  public static void Main() {
    float floatValue;
    int IntValue;

    Console.WriteLine("Enter a float value :");
    floatValue = float.Parse(Console.ReadLine());

    IntValue =Convert.ToInt32(floatValue);

    Console.WriteLine(IntValue);
  }
}