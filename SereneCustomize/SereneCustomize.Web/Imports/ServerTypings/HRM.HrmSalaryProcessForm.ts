namespace SereneCustomize.HRM {
    export interface HrmSalaryProcessForm {
        EmployeeId: Serenity.IntegerEditor;
        SalaryTemplateId: Serenity.IntegerEditor;
        Year: Serenity.IntegerEditor;
        Month: Serenity.StringEditor;
        YearMonth: Serenity.StringEditor;
    }

    export class HrmSalaryProcessForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.HrmSalaryProcess';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!HrmSalaryProcessForm.init)  {
                HrmSalaryProcessForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;

                Q.initFormType(HrmSalaryProcessForm, [
                    'EmployeeId', w0,
                    'SalaryTemplateId', w0,
                    'Year', w0,
                    'Month', w1,
                    'YearMonth', w1
                ]);
            }
        }
    }
}

