using Kreta.Desktop.Validation.ValidationRules;
using System.Globalization;
using System.Windows.Controls;

namespace Kreta.Desktop.Validation
{
    public class NameValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string)
            {
                string nameToValidate = (string)value;
                NameValidationRules nvr = new NameValidationRules(nameToValidate);
            }
            return new ValidationResult(true, "");
        }
    }
}
