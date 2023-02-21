using System;

namespace Challenge02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var val = new Validator<string>( message => {

                var errors = new List<string>();

                if (message == "Hello")
                    return null;

                errors.Add("It's not Hello");

                if (message.Length > 5)
                    errors.Add("No more than 5 character");

                return errors;
            });

            Console.WriteLine(val.IsValid("Buenos días"));
            Console.WriteLine(val.HasErrors());

            Console.WriteLine("----------------------------------------------");

            var val2 = new Validator<int>(x => (x % 2 == 0) ? null : new List<string> { "no es entero" });

            Console.WriteLine(val2.IsValid(5));
            Console.WriteLine(val2.HasErrors());
        }
    }

}