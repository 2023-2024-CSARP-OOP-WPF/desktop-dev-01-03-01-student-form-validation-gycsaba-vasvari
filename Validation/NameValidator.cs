using System.Globalization;
using System.Windows.Controls;

namespace Kreta.Desktop.Validation
{
    public class NameValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            return new ValidationResult(true, "");
        }
    }
}
