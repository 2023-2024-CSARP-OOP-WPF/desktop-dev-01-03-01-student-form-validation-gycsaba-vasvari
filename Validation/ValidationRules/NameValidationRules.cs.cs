namespace Kreta.Desktop.Validation.ValidationRules
{
    public class NameValidationRules
    {
        private readonly string _nameToValidate;
        public NameValidationRules(string name)
        {
            _nameToValidate = name;
        }

        public bool IsNameShort
        {
            get
            {
                if (_nameToValidate.Length <= 3)
                    return true;
                else
                    return false;
            }
        }
    }
}
