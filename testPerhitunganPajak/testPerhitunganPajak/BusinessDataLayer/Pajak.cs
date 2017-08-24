using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testPerhitunganPajak.DataAccessLayer;

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
    }
}
