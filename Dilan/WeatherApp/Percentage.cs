using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    public class Percentage
    {
        private string formattedValue;
        public string FormattedValue
        {
            get { return $"{formattedValue}%"; }

            set
            { if (value.Equals(0 > 100))
                    formattedValue = value;
                else
                    throw new System.ArgumentException($"{FormattedValue} must be between 0% and 100%");
            }
        }

        public Percentage(string formattedvalue)
        {
            formattedValue = formattedvalue;
        }

    }
}
