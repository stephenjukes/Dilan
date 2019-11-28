using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    public class Speed
    {

        private string formattedvalue;
        public string FormattedValue
        {
            get { return $"{formattedvalue}mph"; }

            set { formattedvalue = value; }
        }

        public Speed(string formattedValue)
        {
            formattedvalue = formattedValue;
        }
    }
}
