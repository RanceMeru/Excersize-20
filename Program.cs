internal class Program
{
    private static void Main(string[] args)
    {
        //20.Soulution 
        //write a program that prompts the user for an hourly pay rate .
        //if the value entered is less than $7.50 or greater that $ 49.00
        // display an error message 

        Console.WriteLine("What is your hourly pay?");

         double hourlyRate = double.Parse(Console.ReadLine());

         if(hourlyRate < 7.50 || hourlyRate > 49.00)
         {
             Console.WriteLine("Invalid Rate");
         }
         else
         {
             Console.Write("The rate is valid");
         }
        
    }
}