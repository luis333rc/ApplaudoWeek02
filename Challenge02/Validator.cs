namespace Challenge02
{
    public class Validator<T> {

        private readonly List<string> _errors = new List<string>();

        public delegate List<string>? ValidationDelegate(T value);

        private ValidationDelegate validationDelegate;

        public Validator(ValidationDelegate validator)
        {
            validationDelegate = validator;
        }

        public bool IsValid(T value)
        {
            var errors = validationDelegate(value);

            if (errors is null || errors.Count < 1)
                return true;

            foreach(var error in errors)
            {
                _errors.Add(error);
            }

            return false;
        }

        public bool HasErrors()
        {
            return (_errors.Count>0);
        }

    }

  

}