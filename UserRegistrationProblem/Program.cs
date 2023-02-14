namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem");
            Console.WriteLine("Enter the number");
            Console.WriteLine("1.FirstName \n2.LastName \n3.ValidEmail \n9.exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    FirstName.FirstN();
                    break;
                case 2:
                    LastName.LastN();
                    break;
                case 3:
                    ValidEmail.ValidEmailId();
                    break;
                default:
                    Console.WriteLine("Please Enter the option from Above");
                    break;
            }
            Console.ReadLine();
        }
    }
}