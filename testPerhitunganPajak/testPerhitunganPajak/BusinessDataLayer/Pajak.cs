using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testPerhitunganPajak.DataAccessLayer;
using static System.Math;


namespace testPerhitunganPajak.BusinessDataLayer
{
    class Pajak
    {
        //menghitung bruto dari 1 baris salary employee payment
        public static decimal CountBruto(DataAccessLayer.SalaryEmployeePayment salaryEmployeePayment)
        {
            decimal bruto = 0;
			bruto += salaryEmployeePayment.RBasicSalary.Value;
			bruto += salaryEmployeePayment.RAllowance.Value;
			bruto -= salaryEmployeePayment.RDeduction.Value;
			bruto += salaryEmployeePayment.ROverTime.Value;
			bruto += salaryEmployeePayment.RJKM.Value;
			bruto += salaryEmployeePayment.RJKK.Value;
			bruto += salaryEmployeePayment.RBPJSComp.Value;
			bruto += salaryEmployeePayment.TunjPPH21Emp.Value;
			return bruto;
        }
        //menghitung bruto dari 1 baris salary employee payment
        public static decimal CountBrutoWithBonus(SalaryEmployeePayment salaryEmployeePayment)
        {
            decimal bruto = 0;
            bruto += CountBruto(salaryEmployeePayment);
            bruto += salaryEmployeePayment.RBonusTHR.Value;
            bruto += salaryEmployeePayment.RBackPayBasicSalary.Value;
            bruto += salaryEmployeePayment.RBackPayAllowanceDeduction.Value;
            bruto += salaryEmployeePayment.RBackPayOverTime.Value;
            bruto += salaryEmployeePayment.RAllowanceOnce.Value;
            bruto -= salaryEmployeePayment.RDeductionOnce.Value;
            bruto += salaryEmployeePayment.RClaim.Value;
            bruto += salaryEmployeePayment.RLeave.Value;
            return bruto;
        }
        //menghitung bruto dari 1 baris salary employee payment
        public static decimal CountBrutoBonus(SalaryEmployeePayment salaryEmployeePayment)
        {
            decimal bruto = 0;
            bruto += salaryEmployeePayment.RBonusTHR.Value;
            bruto += salaryEmployeePayment.RBackPayBasicSalary.Value;
            bruto += salaryEmployeePayment.RBackPayAllowanceDeduction.Value;
            bruto += salaryEmployeePayment.RBackPayOverTime.Value;
            bruto += salaryEmployeePayment.RAllowanceOnce.Value;
            bruto -= salaryEmployeePayment.RDeductionOnce.Value;
            bruto += salaryEmployeePayment.RClaim.Value;
            bruto += salaryEmployeePayment.RLeave.Value;
            return bruto;
        }
        //mengitung total bruto dari list employee payment
        public static decimal CountBrutoWithBonusListPayment (List<DataAccessLayer.SalaryEmployeePayment> listPayment)
		{
			decimal sumBruto = 0;
			foreach(var a in listPayment)
			{
				sumBruto += CountBrutoWithBonus(a);
			}
			return sumBruto;
		}
        public static decimal CountBrutoListPayment(List<DataAccessLayer.SalaryEmployeePayment> listPayment)
        {
            decimal sumBruto = 0;
            foreach (var a in listPayment)
            {
                sumBruto += CountBruto(a);
            }
            return sumBruto;
        }
        public static decimal CountBrutoBonusListPayment(List<DataAccessLayer.SalaryEmployeePayment> listPayment)
        {
            decimal sumBruto = 0;
            foreach (var a in listPayment)
            {
                sumBruto += CountBrutoBonus(a);
            }
            return sumBruto;
        }
        public static decimal CalculateBrutoYearly(Guid employeeId, PajakTypeData.TaxCalculationMethod taxCalculationMethod,decimal brutoCurrent,decimal brutoPrev,decimal brutoPrevBonus,int periodStart,int periodEnd, int periodCurrent)
        {
            decimal hasil = 0;
            int lengthCalculationPeriod = periodEnd - periodStart + 1;
            int lengthCurrentPeriod = periodCurrent - periodStart + 1;
            int lengthForecastPeriod = periodEnd - periodCurrent + 1;
            if (periodCurrent == periodEnd)
            {
                hasil = brutoPrev + brutoPrevBonus + brutoCurrent;
            }
            else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.WeightedAverage)
            {
                decimal brutoAvg = (brutoPrev + brutoCurrent) / lengthCurrentPeriod;
                hasil = brutoAvg * lengthCalculationPeriod;
                hasil = hasil + brutoPrevBonus;
            }
            else if(taxCalculationMethod== PajakTypeData.TaxCalculationMethod.Forecast)
            {
                hasil = brutoPrev + brutoPrevBonus + brutoCurrent * lengthForecastPeriod;
            }
            else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.Annually)
            {
                hasil = brutoCurrent * lengthCalculationPeriod;
            }
            return hasil;
        }
		public static decimal CalculateBpjsOrPensionYearly(PajakTypeData.TaxCalculationMethod taxCalculationMethod, decimal pensionCurrent, decimal pensionPrev, int periodStart, int periodEnd, int periodCurrent)
		{
			decimal hasil = 0;
			int lengthCalculationPeriod = periodEnd - periodStart + 1;
			int lengthCurrentPeriod = periodCurrent - periodStart + 1;
			int lengthForecastPeriod = periodEnd - periodCurrent + 1;
			if (periodCurrent == periodEnd)
			{
				hasil = pensionPrev + pensionCurrent;
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.WeightedAverage)
			{
				decimal brutoAvg = (pensionPrev + pensionCurrent) / lengthCurrentPeriod;
				hasil = brutoAvg * lengthCalculationPeriod;
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.Forecast)
			{
				hasil = pensionPrev + pensionCurrent * lengthForecastPeriod;
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.Annually)
			{
				hasil = pensionCurrent * lengthCalculationPeriod;
			}
			return hasil;
		}
		public static decimal CalculateBiayaJabatan(decimal bruto,int periodStart, int periodEnd)
		{
			decimal hasil = 0;
			int lengthCalculationPeriod = periodEnd - periodStart + 1;
			hasil = Min(PajakTypeData.MaxBiayaJabatan * lengthCalculationPeriod / 12, bruto * PajakTypeData.PersentaseBiayaJabatan / 100);
			return hasil;
		}
        public static decimal CalculateNettoYearly(decimal brutoYearly, decimal JHTYearly, decimal JPYearly, decimal pensionYearly, decimal biayaJabatan, decimal begSalaryNetto)
        {
            return brutoYearly - biayaJabatan - JHTYearly - JPYearly - pensionYearly + begSalaryNetto;
        }
        public static decimal CalculatePTKP (bool kawin,int tanggungan)
        {
            decimal hasil = PajakTypeData.PTKPIndividu;
            if (kawin) hasil += PajakTypeData.PTKPAddOn;
            hasil = hasil + PajakTypeData.PTKPAddOn * tanggungan;
            return hasil;
        }
        public static decimal CalculatePKP(decimal nettoYearly, decimal PTKP)
        {
            decimal hasil = 0;
            hasil = nettoYearly - PTKP;
            int hasil2 = (int)hasil / 1000;
            hasil2 = hasil2 * 1000;
            return hasil2;
        }
		public static decimal CalculateTaxYearly(decimal PKP,bool fNPWP)
		{
			decimal hasil = 0;
			hasil = hasil + Max(0, Min(PKP, PajakTypeData.TaxBracketNominal1)) * PajakTypeData.TaxBracketPercentage1 / 100;
			if (PKP > PajakTypeData.TaxBracketNominal1) hasil = hasil + Max(0, Min(PKP, PajakTypeData.TaxBracketNominal2) - PajakTypeData.TaxBracketNominal1) * PajakTypeData.TaxBracketPercentage2 / 100;
			if (PKP > PajakTypeData.TaxBracketNominal2) hasil = hasil + Max(0, Min(PKP, PajakTypeData.TaxBracketNominal3) - PajakTypeData.TaxBracketNominal2) * PajakTypeData.TaxBracketPercentage3 / 100;
			if (PKP > PajakTypeData.TaxBracketNominal3) hasil = hasil + Max(0, PKP - PajakTypeData.TaxBracketNominal3) * PajakTypeData.TaxBracketPercentage4 / 100;
			if (!fNPWP) hasil = hasil * (100 + PajakTypeData.NoNPWPPercentage) / 100;
			return hasil;
		}
		public static decimal CalculateTaxMonthly(decimal taxYearly,decimal sumTaxPrev, decimal sumTaxPrevbonus, int periodStart, int periodEnd, int periodCurrent,decimal begSalaryPPh21, PajakTypeData.TaxCalculationMethod taxCalculationMethod)
		{
			decimal hasil = 0;
			int lengthCalculationPeriod = periodEnd - periodStart + 1;
			int lengthCurrentPeriod = periodCurrent - periodStart + 1;
			int lengthForecastPeriod = periodEnd - periodCurrent + 1;
			if (periodCurrent == periodEnd)
			{
				hasil = taxYearly - sumTaxPrev- sumTaxPrevbonus - begSalaryPPh21;
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.WeightedAverage)
			{
				hasil = taxYearly - sumTaxPrevbonus - begSalaryPPh21;
				hasil = hasil * lengthCurrentPeriod / lengthCalculationPeriod;
				hasil = hasil - sumTaxPrev;
			}

			return hasil;
		}

	}
}
