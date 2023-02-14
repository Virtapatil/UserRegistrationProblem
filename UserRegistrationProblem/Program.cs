namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem");
            Console.WriteLine("Enter the number");
            Console.WriteLine("1.FirstName \n2.LastName \n3.ValidEmail \n4.PreDefinedMobile \n5.Pre-DefinedPassRule1 \n6.Pre-DefinedPassRule2 \n7.NumericNumRule \n8.SpecialCharacter \n9.exit");
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
                case 4:
                    PreDefinedMobileFormat.PreDefMobile();
                    break;
                case 5:
                    Pre_DefinedPasswordRule1.PreDefPassRule1();
                    break;
                case 6:
                    Pre_DefinedPassRule2.PreDefPassRule2();
                    break;
                case 7:
                    NumericNumRule3.NumericRule3();
                    break;
                case 8:
                    SpecialCharacterRule4.SpecialChar4();
                    break;
                default:
                    Console.WriteLine("Please Enter the option from Above");
                    break;
            }
            Console.ReadLine();
        }
    }
}