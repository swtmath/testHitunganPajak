using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPerhitunganPajak.BusinessDataLayer
{
    class PajakTypeData
    {
        public enum TaxCalculationMethod
        {
            Annually,
            Forecast,
            WeightedAverage
        };
        public enum TaxType
        {
            NoTax=1,
            TaxComp,
            TaxEmp,
            TaxAllowance
        };
    }
}
