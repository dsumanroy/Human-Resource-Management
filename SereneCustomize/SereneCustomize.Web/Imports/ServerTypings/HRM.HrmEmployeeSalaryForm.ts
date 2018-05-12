namespace SereneCustomize.HRM {
    export interface HrmEmployeeSalaryForm {
        EmployeeId: Serenity.IntegerEditor;
        SalaryTemplateId: Serenity.IntegerEditor;
        BasicSalary: Serenity.DecimalEditor;
        HourlyRate: Serenity.DecimalEditor;
    }

    export class HrmEmployeeSalaryForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.HrmEmployeeSalary';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!HrmEmployeeSalaryForm.init)  {
                HrmEmployeeSalaryForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DecimalEditor;

                Q.initFormType(HrmEmployeeSalaryForm, [
                    'EmployeeId', w0,
                    'SalaryTemplateId', w0,
                    'BasicSalary', w1,
                    'HourlyRate', w1
                ]);
            }
        }
    }
}

