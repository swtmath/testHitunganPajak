using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPerhitunganPajak.BusinessDataLayer
{
	public class PajakTypeData
    {
        public const decimal MaxBiayaJabatan = 6000000;
        public const int PersentaseBiayaJabatan = 5;
		public const decimal PTKPIndividu = 54000000;
        public const decimal PTKPAddOn = 4500000;
		public const decimal TaxBracketNominal1 = 50000000;
		public const decimal TaxBracketNominal2 = 250000000;
		public const decimal TaxBracketNominal3 = 500000000;
		public const int TaxBracketPercentage1 = 5;
		public const int TaxBracketPercentage2 = 15;
		public const int TaxBracketPercentage3 = 25;
		public const int TaxBracketPercentage4 = 30;
		public const int NoNPWPPercentage = 20;
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
		public enum EmployeeCondition
		{
			Normal,
			NewEmployee,
			Resign,
			Transfer
		};
    }
}
