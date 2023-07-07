// This is our Method for our Main
class Numbersgame
{
    static void Main(string[] args)
    {
        // code to be executed
        try
        {
          StartSequence();  
        }
        catch (Exception e)
        {
            Console.WriteLine("There was an error in starting the sequence.");
        }
        
    }
    static void StartSequence() {
        Console.WriteLine("Enter a Number Greater than Zero.");
        int userInput = Convert.ToInt32(Console.ReadLine());
        int[] numberArray = new int[userInput];
        int[] populatedArray = Populate(numberArray);
        int sum = GetSum(populatedArray);
        
        int product = GetProduct(populatedArray, sum);
        GetQuotient(product);
        
       

       
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
    static int GetSum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            
        }
        if (sum < 20)
        {
            throw new Exception("Value of " + sum + " is too low");
        }
        return sum;
    }
    static int GetProduct(int[] array, int sum)
    {
        Console.WriteLine("Enter a number between 1 and " + array.Length);
        int userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput > 1 && userInput < array.Length)
        {
            throw new IndexOutOfRangeException("The number you selected is out of range");
        }
        int product = userInput * sum;
        return product;


    }
    static decimal GetQuotient(int product)
    {
        Console.WriteLine("Enter a Number to divide the product by. Current Product: " + product);
        int userInput = Convert.ToInt32(Console.ReadLine());
        int dividedProduct = product / userInput;
        
        
        if (userInput == 0)
        {
            Console.WriteLine("Cannot Divide By Zero!");
            return 0;
            throw new DivideByZeroException("Cannot Divide By Zero");
           
            
        }
        return dividedProduct;
    }
}
