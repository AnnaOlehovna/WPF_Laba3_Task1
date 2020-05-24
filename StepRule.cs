using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Laba3_ListBox
{
    class StepRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double convertedValue;

            try
            {
                convertedValue = Double.Parse((string)value, new NumberFormatInfo());
            }
            catch
            {
                return new ValidationResult(false, "Недопустимые символы. Step должно быть числом");
            }

            if (convertedValue <= 0)
            {
                return new ValidationResult(false, "Шаг не может быть меньше или равен 0.");
            }
            return ValidationResult.ValidResult;
        }
    }
}
