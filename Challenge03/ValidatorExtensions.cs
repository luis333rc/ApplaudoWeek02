using Challenge02;

namespace Challenge03
{
    public static class ValidatorExtensions
    {
        public static string GetErrors<T>(this Validator<T> validator)
        {
            var errors = validator.Errors.ToArray();

            return string.Join(", ", errors);
        }
    }
}