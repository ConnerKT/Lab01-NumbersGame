class Numbersgame
{
    static void Main(string[] args)
    {
        try
        {
            StartSequence(); // Call the StartSequence method
        }
        catch (Exception e)
        {
            Console.WriteLine("There was an error in starting the sequence.");
        }
    }

    static void StartSequence()
    {
        Console.WriteLine("Enter a Number Greater than Zero.");
        int userInput = Convert.ToInt32(Console.ReadLine()); // Read user input as an integer
        int[] numberArray = new int[userInput]; // Create an array of size userInput
        int[] populatedArray = Populate(numberArray); // Call the Populate method to fill the array with user inputs
        int sum = GetSum(populatedArray); // Call the GetSum method to calculate the sum of array elements

        int product = GetProduct(populatedArray, sum); // Call the GetProduct method to calculate the product
        GetQuotient(product); // Call the GetQuotient method to calculate the quotient
    }

    static int[] Populate(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Please Enter a number " + (i + 1) + "/" + array.Length);
            array[i] = Convert.ToInt32(Console.ReadLine()); // Read user input and store it in the array
        }
        return array; // Return the populated array
    }

    static int GetSum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i]; // Add each element of the array to the sum variable
        }

        if (sum < 20)
        {
            throw new Exception("Value of " + sum + " is too low"); // Throw an exception if the sum is less than 20
        }

        return sum; // Return the sum
    }

    static int GetProduct(int[] array, int sum)
    {
        Console.WriteLine("Enter a number between 1 and " + array.Length);
        int userInput = Convert.ToInt32(Console.ReadLine()); // Read user input as an integer

        if (userInput > 1 && userInput < array.Length)
        {
            throw new IndexOutOfRangeException("The number you selected is out of range"); // Throw an exception if the user input is out of range
        }

        int product = userInput * sum; // Calculate the product

        return product; // Return the product
    }

    static decimal GetQuotient(int product)
    {
        Console.WriteLine("Enter a Number to divide the product by. Current Product: " + product);
        int userInput = Convert.ToInt32(Console.ReadLine()); // Read user input as an integer

        if (userInput == 0)
        {
            Console.WriteLine("Cannot Divide By Zero!");
            throw new DivideByZeroException("Cannot Divide By Zero"); // Throw an exception if the user input is zero
        }

        int dividedProduct = product / userInput; // Calculate the quotient

        return dividedProduct; // Return the quotient
    }
}

