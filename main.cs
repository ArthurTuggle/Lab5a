using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 1;
    while(counter <= 7)
  {
    Console.WriteLine ("Enter the distance covered by the car");
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter the time taken by Car#1");
    double time = Convert.ToDouble(Console.ReadLine());
    counter++;
  

    Console.WriteLine (distance * time);
  }
    
    
    
    
    
    
    
    
    
    
    
    
  }
}