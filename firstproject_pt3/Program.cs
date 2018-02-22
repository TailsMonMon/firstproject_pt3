using System;

namespace firstproject_pt3
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 17;

            if ((age >= 5) && (age <= 7)) {
                Console.Write("Go to Elemetary school ");
            }

            else if ((age > 7) && (age <= 13)) {
                Console.Write("Go to Middle school ");
            }

            else if ((age > 13) && (age <= 19)) {
                Console.Write("Go to Highschool school ");
            }

            else {
                Console.Write("Go to Collage school ");
            }


            if ((age < 14) || (age < 19)) {
                Console.WriteLine("You shouldn't work ");
            }

            Console.WriteLine("! true = " + (!true));     // Makes true to false, and false to true.
            Console.WriteLine();


            //      Check if true or false
            bool canDrive = age >= 16 ? true : false;   // If age is greater than or equal to 16 it's going to be true. If not it's going to be false.


            switch (age) {   // Can't check ranges
                case 1:     // wut?
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;  // Ending
                case 3:
                case 4:
                    Console.WriteLine("Go to preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another scool");
                    goto OtherSchool;   // Another ending
            }

        OtherSchool:
            Console.WriteLine("Elementary, middle, high school");


            //      Compare strings
            string name = "Derek";
            string name2 = "Derek";
            
            if(name.Equals(name2, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal");
            }

            //      While Loops
            int i = 1;  // to give i an definition or startingpoint in the loop

            while(i <= 15) {  // stuff will happen as long as 'i' is smaller or equal to 10
                if(i % 2 == 0) {  // To return the remainder of a division. If 2 = 0 it's an even number. 
                    i++;        // Then with the even numbers we will add 1. 
                    continue;   // To make tha actual loop.
                }
                if (i == 13) break; //   When the loop reaches 13, it will end before it prints. If it's even, it won't break since 'i' never becomes even.
                Console.WriteLine(i);
                i++;
            }


            //      Do While Look
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;

            do
            {
                Console.Write("Enter a number between 1 and 10 : ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            }
            while (secretNumber != numberGuessed);
            Console.WriteLine("That's the number!");
            Console.WriteLine();


            //      Exeption handeling
            double num1 = 5;
            double num2 = 0;

            try {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }
            
            catch (DivideByZeroException ex) {      // Specific error
                Console.WriteLine("You can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            catch(Exception ex){    // All errors
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            finally {   
                Console.WriteLine("Cleaning Up");
            }



            Console.ReadLine();
        }

        static double DoDivision(double x, double y) {
            if(y == 0) {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
        
    }
}


/* Relation Operatiors: <   Bigger then
                        >   Smaller then
                        >=  Bigger or equal to
                        <=  Smaller or equal to
                        ==  Equal to
                        !=  Not equal to

Logical Operators:  &&  And
                    ||  Or
                    !   Not
*/