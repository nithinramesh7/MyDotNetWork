using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConceptArchitect.Wpf
{
    public class Currency : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return ToString();  //return this value to whoever ask.
        }



        public string currency;

        public string Value
        {
            get
            {
                return currency.ToString();
            }
            set
            {
                currency = value;
            }
        }


        public string Symbol { get; set; }

        public Currency()
        {

            Symbol = "₹";
        }
        public Currency(string value)
        {
            Value = Symbol + value;
        }


        public override string ToString()
        {
            return Symbol + "" + currency.ToString();
        }


    }
}
