using System;
public class MainClass
{
    public static void Main()
    {
        int m;
        int q;
        int n;
        int sum = 0;
        Console.WriteLine("m:");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("q:");
        q = int.Parse(Console.ReadLine());
        Console.WriteLine("длина массива:");
        n= int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        var random = new Random();
        for (int i = 0; i < nums.Length; i++) 
        {
            nums[i]= random.Next(0,1000);
            sum += nums[i];
            break;
        }
        if (m>=sum && q<sum)
        {
            Console.WriteLine("Истина:");
        }
        else
        {
            Console.WriteLine("Ложь:");
        }
    }
}
