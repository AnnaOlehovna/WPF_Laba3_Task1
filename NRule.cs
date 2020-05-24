using System;
using System.Globalization;
using System.Windows.Controls;

namespace Laba3_ListBox
{
    class NRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int convertedValue;

            try
            {
                convertedValue = Int32.Parse((string)value);
            }
            catch
            {
                return new ValidationResult(false, "Недопустимые символы. N должно быть целым числом.");
            }

            return ValidationResult.ValidResult;
        }
    }
}
