using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPerhitunganPajak.BusinessDataLayer
{
    class Pajak
    {
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
		public static decimal CountBrutoListPayment (List<DataAccessLayer.SalaryEmployeePayment> listPayment)
		{
			decimal sumBruto = 0;
			foreach(var a in listPayment)
			{
				sumBruto += CountBruto(a);
			}
			return sumBruto;
		}
    }
}
