// This is our Method for our Main
class Numbersgame
{
    static void Main(string[] args)
    {
        // code to be executed
        StartSequence();
    }
    static void StartSequence() {
        Console.WriteLine("Enter a Number Greater than Zero.");
        int userInput = Convert.ToInt32(Console.ReadLine());
        int[] numberArray = new int[userInput];
        Populate(numberArray);
    }
    static int[] Populate(int[] array)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Please Enter a number " + (i+1)+"/"+ array.Length);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }
    //static int GetSum(int[] array)
    //{

    //}
    //static int GetProduct(int[] array, int sum)
    //{
    //}
    //static decimal GetQuotient(int product)
    //{

    //}
}
