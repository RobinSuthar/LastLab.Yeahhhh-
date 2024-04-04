namespace LastLab.Yeahhhh_
{
    public class Program
    {
        public static int count;
        public static int total = 0;

        static void Main(string[] args)
        {
            //------CALLING THE ADDITION FUNCTIONS-----//
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n:");
            int startpoind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number m:");
            int endworked = Convert.ToInt32(Console.ReadLine());
            Applicatiosn1(startpoind, endworked);

            //------CALLING THE DIVSION FUNCTION-------//
            Console.WriteLine("Enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Application2(number);
        }

        public static void Applicatiosn1(int startpoint, int endpoint)
        {
            //Base condition 
            if (startpoint == endpoint)
            {
                total = total + endpoint;
                Console.WriteLine("Total is: " + total);
            }

            //Using recurision's
            else
            {
                total = total + startpoint;
                startpoint++;

                //Calling the function again till it meets the base condition
                Applicatiosn1(startpoint, endpoint);
            }
        }

        public static int Application2(int number)
        {
            // Base condition
            if (number % 2 != 0)
            {
                Console.WriteLine("Total number of divisions: " + count);
                return 0; // If the number is odd, it cannot be divided by 2 evenly
            }
            else
            {
                count++;
                // Dividing by 2
                number = number / 2;
                return 1 + Application2(number);
            }
        }
    }
}
