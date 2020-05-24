using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Laba3_ListBox
{
    [ContentProperty("Wrapper")]
    class XStopRule : ValidationRule
    {
        public Wrapper Wrapper { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double convertedValue;
            try
            {
                convertedValue = Double.Parse((string)value, new NumberFormatInfo());
            }
            catch
            {
                return new ValidationResult(false, "Недопустимые символы. XStop должно быть целым числом.");
            }

            if (convertedValue < Wrapper.start)
            {

                return new ValidationResult(false, "Конечное значение не может быть меньше начального значения аргумента.");
            }
       
            return ValidationResult.ValidResult;
        }
    }
}
