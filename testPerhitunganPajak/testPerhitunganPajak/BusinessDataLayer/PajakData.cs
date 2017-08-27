using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testPerhitunganPajak.DataAccessLayer;
using static System.Math;


namespace testPerhitunganPajak.BusinessDataLayer
{
	public class PajakData
    {

        //menghitung bruto dari 1 baris salary employee payment
        public static decimal CountBruto(SalaryEmployeePayment salaryEmployeePayment)
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
			bruto += salaryEmployeePayment.TunjPPH21BonusTHR.Value;
			bruto += salaryEmployeePayment.TunjPPH21BackPay.Value;
			bruto += salaryEmployeePayment.TunjPPH21Once.Value;
			bruto += salaryEmployeePayment.TunjPPH21Claim.Value;
			bruto += salaryEmployeePayment.TunjPPH21Leave.Value;
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
			bruto += salaryEmployeePayment.TunjPPH21BonusTHR.Value;
			bruto += salaryEmployeePayment.TunjPPH21BackPay.Value;
			bruto += salaryEmployeePayment.TunjPPH21Once.Value;
			bruto += salaryEmployeePayment.TunjPPH21Claim.Value;
			bruto += salaryEmployeePayment.TunjPPH21Leave.Value;
			return bruto;
        }
		public static decimal CountJHT(SalaryEmployeePayment salaryEmployeePayment)
		{
			decimal jht = 0;
			jht = salaryEmployeePayment.RJHTEmp.Value;
			return jht;
		}
		public static decimal CountJP(SalaryEmployeePayment salaryEmployeePayment)
		{
			decimal jp = 0;
			jp = salaryEmployeePayment.RJPEmp.Value;
			return jp;
		}
		public static decimal CountPension(SalaryEmployeePayment salaryEmployeePayment)
		{
			decimal pension = 0;
			pension = salaryEmployeePayment.RPensionEmp.Value;
			return pension;
		}
		public static decimal CountJHTListPayment(List<SalaryEmployeePayment> listPayment)
		{
			return listPayment.Sum(a => CountJHT(a));
		}
		public static decimal CountJPListPayment(List<SalaryEmployeePayment> listPayment)
		{
			return listPayment.Sum(a => CountJP(a));
		}
		public static decimal CountPensionListPayment(List<SalaryEmployeePayment> listPayment)
		{
			return listPayment.Sum(a => CountPension(a));
		}
		//mengitung total bruto dari list employee payment
		public static decimal CountBrutoWithBonusListPayment (List<DataAccessLayer.SalaryEmployeePayment> listPayment)
		{
			return listPayment.Sum(a => CountBrutoWithBonus(a));
		}
        public static decimal CountBrutoListPayment(List<DataAccessLayer.SalaryEmployeePayment> listPayment)
        {
	        return listPayment.Sum(a => CountBruto(a));
        }
        public static decimal CountBrutoBonusListPayment(List<DataAccessLayer.SalaryEmployeePayment> listPayment)
        {
	        return listPayment.Sum(a => CountBrutoBonus(a));
        }
		public static PajakTypeData.EmployeeCondition GetEmployeeCondition(SalaryEmployeePayment salaryEmployeePayment)
		{
			PajakTypeData.EmployeeCondition employeeCondition= PajakTypeData.EmployeeCondition.Normal;
			if (salaryEmployeePayment.EmployeeCondition == null) return employeeCondition;
			switch (salaryEmployeePayment.EmployeeCondition.Value)
			{
				case 0:
					employeeCondition = PajakTypeData.EmployeeCondition.Normal;
					break;
				case 1:
					employeeCondition = PajakTypeData.EmployeeCondition.NewEmployee;
					break;
				case 2:
					employeeCondition = PajakTypeData.EmployeeCondition.Resign;
					break;
				case 3:
					employeeCondition = PajakTypeData.EmployeeCondition.Transfer;
					break;
				default:
					employeeCondition = PajakTypeData.EmployeeCondition.Normal;
					break;
			}
			return employeeCondition;
		}
		public static int GetFirstPeriod(List<SalaryEmployeePayment> listPayment)
		{
			int period = 0;
			period = listPayment.Count == 0 ? 1 : int.Parse(listPayment.First().PaymentPeriod.Substring(4, 2));
			return period;
		}
		public static int GetCurrentPeriod(SalaryEmployeePayment salaryEmployeePayment)
		{
			int period = 0;
			period = int.Parse(salaryEmployeePayment.PaymentPeriod.Substring(4, 2));
			return period;
		}
        public static int GetEndPeriod(PajakTypeData.EmployeeCondition employeeCondition, int periodCurrent)
        {
            int period = 0;
            if (employeeCondition == PajakTypeData.EmployeeCondition.Resign || employeeCondition == PajakTypeData.EmployeeCondition.Transfer) period = periodCurrent;
            else period = 12;
            return period;
        }
        public static decimal GetBegSalaryNetto(SalaryEmployeePayment salaryEmployeePayment)
        {
            decimal begNetto = 0;
            begNetto = salaryEmployeePayment.BegRSalaryNetto.Value;
            return begNetto;
        }
        public static decimal GetBegSalaryPPh21(SalaryEmployeePayment salaryEmployeePayment)
        {
            decimal begNetto = 0;
            begNetto = salaryEmployeePayment.BegRPPH21.Value;
            return begNetto;
        }
        public static decimal CountPPh21(SalaryEmployeePayment salaryEmployeePayment)
        {
            decimal pph21 = 0;
            pph21 += salaryEmployeePayment.PPH21Emp.Value;
            return pph21;
        }
        public static decimal CountPPh21Bonus(SalaryEmployeePayment salaryEmployeePayment)
        {
            decimal pph21 = 0;
            pph21 += salaryEmployeePayment.PPH21BonusTHR.Value;
            pph21 += salaryEmployeePayment.PPH21BackPay.Value;
            pph21 += salaryEmployeePayment.PPH21Once.Value;
            pph21 += salaryEmployeePayment.PPH21Claim.Value;
            pph21 += salaryEmployeePayment.PPH21Leave.Value;
            return pph21;
        }
        public static decimal CountPPh21ListPayment(List<DataAccessLayer.SalaryEmployeePayment> listPayment)
        {
	        return listPayment.Sum(a => CountPPh21(a));
        }
        public static decimal CountPPh21BonusListPayment(List<DataAccessLayer.SalaryEmployeePayment> listPayment)
        {
	        return listPayment.Sum(a => CountPPh21Bonus(a));
        }
    }
}
