namespace SereneCustomize.HRM {
    export interface HrmEmployeeSalaryDetailsForm {
        EmployeeSalaryId: Serenity.IntegerEditor;
        EmployeeId: Serenity.IntegerEditor;
        SalaryComponentId: Serenity.IntegerEditor;
        Amount: Serenity.DecimalEditor;
    }

    export class HrmEmployeeSalaryDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.HrmEmployeeSalaryDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!HrmEmployeeSalaryDetailsForm.init)  {
                HrmEmployeeSalaryDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DecimalEditor;

                Q.initFormType(HrmEmployeeSalaryDetailsForm, [
                    'EmployeeSalaryId', w0,
                    'EmployeeId', w0,
                    'SalaryComponentId', w0,
                    'Amount', w1
                ]);
            }
        }
    }
}

