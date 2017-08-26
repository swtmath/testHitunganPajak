using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace testPerhitunganPajak.BusinessDataLayer
{
	class PajakCalculation
	{
		public static decimal CalculateBrutoYearly(PajakTypeData.TaxCalculationMethod taxCalculationMethod, decimal brutoCurrent, decimal brutoPrev, decimal brutoPrevBonus, int periodStart, int periodEnd, int periodCurrent,PajakTypeData.EmployeeCondition employeeCondition)
		{
			decimal hasil = 0;
			int lengthCalculationPeriod = periodEnd - periodStart + 1;
			int lengthCurrentPeriod = periodCurrent - periodStart + 1;
			int lengthForecastPeriod = periodEnd - periodCurrent + 1;
			if (periodCurrent == periodEnd)
			{
				if (employeeCondition == PajakTypeData.EmployeeCondition.Transfer)
				{
					hasil = (brutoCurrent + brutoPrev) * 12 / lengthCalculationPeriod + brutoPrevBonus;
				}
				else
				{
					hasil = brutoPrev + brutoPrevBonus + brutoCurrent;
				}
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.WeightedAverage)
			{
				decimal brutoAvg = (brutoPrev + brutoCurrent) / lengthCurrentPeriod;
				hasil = brutoAvg * lengthCalculationPeriod;
				hasil = hasil + brutoPrevBonus;
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.Forecast)
			{
				hasil = brutoPrev + brutoPrevBonus + brutoCurrent * lengthForecastPeriod;
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.Annually)
			{
				hasil = brutoCurrent * lengthCalculationPeriod;
			}
			return hasil;
		}
		public static decimal CalculateBpjsOrPensionYearly(PajakTypeData.TaxCalculationMethod taxCalculationMethod, decimal pensionCurrent, decimal pensionPrev, int periodStart, int periodEnd, int periodCurrent, PajakTypeData.EmployeeCondition employeeCondition)
		{
			decimal hasil = 0;
			int lengthCalculationPeriod = periodEnd - periodStart + 1;
			int lengthCurrentPeriod = periodCurrent - periodStart + 1;
			int lengthForecastPeriod = periodEnd - periodCurrent + 1;
			if (periodCurrent == periodEnd)
			{
				if (employeeCondition == PajakTypeData.EmployeeCondition.Transfer)
				{
					hasil = (pensionCurrent + pensionPrev) * 12 / lengthCalculationPeriod;
				}
				else
				{
					hasil = pensionPrev + pensionCurrent;
				}
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
		public static decimal CalculateBiayaJabatan(decimal bruto, int periodStart, int periodEnd, PajakTypeData.EmployeeCondition employeeCondition)
		{
			decimal hasil = 0;
            int lengthCalculationPeriod;
            if (employeeCondition == PajakTypeData.EmployeeCondition.Transfer) lengthCalculationPeriod = 12 - periodStart + 1;
            else lengthCalculationPeriod = periodEnd - periodStart + 1;
            hasil = Min(PajakTypeData.MaxBiayaJabatan * lengthCalculationPeriod / 12, bruto * PajakTypeData.PersentaseBiayaJabatan / 100);
			return hasil;
		}
		public static decimal CalculateNettoYearly(decimal brutoYearly, decimal JHTYearly, decimal JPYearly, decimal pensionYearly, decimal biayaJabatan, decimal begSalaryNetto)
		{
			return brutoYearly - biayaJabatan - JHTYearly - JPYearly - pensionYearly + begSalaryNetto;
		}
		public static decimal CalculatePTKP(bool kawin, int tanggungan)
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
		public static decimal CalculateTaxYearly(decimal PKP, bool fNPWP)
		{
			decimal hasil = 0;
			hasil = hasil + Max(0, Min(PKP, PajakTypeData.TaxBracketNominal1)) * PajakTypeData.TaxBracketPercentage1 / 100;
			if (PKP > PajakTypeData.TaxBracketNominal1) hasil = hasil + Max(0, Min(PKP, PajakTypeData.TaxBracketNominal2) - PajakTypeData.TaxBracketNominal1) * PajakTypeData.TaxBracketPercentage2 / 100;
			if (PKP > PajakTypeData.TaxBracketNominal2) hasil = hasil + Max(0, Min(PKP, PajakTypeData.TaxBracketNominal3) - PajakTypeData.TaxBracketNominal2) * PajakTypeData.TaxBracketPercentage3 / 100;
			if (PKP > PajakTypeData.TaxBracketNominal3) hasil = hasil + Max(0, PKP - PajakTypeData.TaxBracketNominal3) * PajakTypeData.TaxBracketPercentage4 / 100;
			if (!fNPWP) hasil = hasil * (100 + PajakTypeData.NoNPWPPercentage) / 100;
			return hasil;
		}
		public static decimal CalculateTaxMonthly(decimal taxYearly, decimal sumTaxPrev, decimal sumTaxPrevbonus, int periodStart, int periodEnd, int periodCurrent, decimal begSalaryPPh21, PajakTypeData.TaxCalculationMethod taxCalculationMethod, PajakTypeData.EmployeeCondition employeeCondition)
		{
			decimal hasil = 0;
			int lengthCalculationPeriod = periodEnd - periodStart + 1;
			int lengthCurrentPeriod = periodCurrent - periodStart + 1;
			int lengthForecastPeriod = periodEnd - periodCurrent + 1;
			if (periodCurrent == periodEnd)
			{
                if (employeeCondition == PajakTypeData.EmployeeCondition.Transfer)
                {
                    hasil = taxYearly * lengthCalculationPeriod / 12;
                    hasil = hasil - sumTaxPrev - sumTaxPrevbonus - begSalaryPPh21;
                }
                else
                {
                    hasil = taxYearly - sumTaxPrev - sumTaxPrevbonus - begSalaryPPh21;
                }
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.WeightedAverage)
			{
				hasil = taxYearly - sumTaxPrevbonus - begSalaryPPh21;
				hasil = hasil * lengthCurrentPeriod / lengthCalculationPeriod;
				hasil = hasil - sumTaxPrev;
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.Forecast)
			{
				hasil = taxYearly - sumTaxPrevbonus - sumTaxPrev - begSalaryPPh21;
				hasil = hasil / lengthForecastPeriod;
			}
			else if (taxCalculationMethod == PajakTypeData.TaxCalculationMethod.Annually)
			{
				hasil = taxYearly / lengthCalculationPeriod;
			}
            hasil = Round(hasil, 0);
			return hasil;
		}
		public static decimal CalculateBrutoWithBonusYearly(decimal brutoYearly, decimal brutoBonus)
		{
			decimal hasil = 0;
			hasil = brutoYearly + brutoBonus;
			return hasil;
		}
	}
}
