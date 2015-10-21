  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fizz Buzz! What number do you want to go to?");
            //ask for input
            var input = Console.ReadLine();

            //if they gave us a valid number use it, otherwise default to 100
            int maxNumber;
            if (!int.TryParse(input, out maxNumber))
            {
                maxNumber = 100;
            }

            for (int i = 1; i <= maxNumber; i++)
            {
                //write the number out
                Console.Write(i);

                if (i % 3 == 0) //is the number divisible by 3?
                {
                    Console.Write(" fizz");
                }

                if (i % 5 == 0) //is the number divisible by 5?
                {
                    Console.Write(" buzz");
                }

                //put a line break after this 'row'
                Console.WriteLine();

            }

            //pause and wait for the user to hit enter before leaving the program
            Console.ReadLine();
        }
