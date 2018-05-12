namespace SereneCustomize.HRM {
    export interface HrmSalaryTemplateForm {
        SalaryGrade: Serenity.StringEditor;
        BasicSalary: Serenity.DecimalEditor;
        HourlyRate: Serenity.DecimalEditor;
    }

    export class HrmSalaryTemplateForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.HrmSalaryTemplate';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!HrmSalaryTemplateForm.init)  {
                HrmSalaryTemplateForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;

                Q.initFormType(HrmSalaryTemplateForm, [
                    'SalaryGrade', w0,
                    'BasicSalary', w1,
                    'HourlyRate', w1
                ]);
            }
        }
    }
}

