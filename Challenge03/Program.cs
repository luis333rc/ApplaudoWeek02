using Challenge02;
using System.Text;

namespace Challenge03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var val = new Validator<int>(num => {

                var errors = new List<string>();

                if (num < 10)
                    return null;

                errors.Add("It's equals or greater than 10");

                if (num % 2 == 1)
                    errors.Add("It's odd");

                return errors;
            });

            Console.WriteLine(val.IsValid(15));
            Console.WriteLine(val.HasErrors());

            Console.WriteLine(val.GetErrors());
        }
    }

    public static class ValidatorExtensions
    {
        public static string GetErrors<T>(this Validator<T> validator)
        {
            var errors = validator.Errors.ToArray();

            return string.Join(", ", errors);
        }
    }
}