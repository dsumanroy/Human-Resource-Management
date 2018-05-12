namespace SereneCustomize.HRM {
    export interface HrmSalaryTemplateDetailsForm {
        SalaryTemplateId: Serenity.IntegerEditor;
        SalaryComponentId: Serenity.IntegerEditor;
        ComponentAmount: Serenity.DecimalEditor;
    }

    export class HrmSalaryTemplateDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.HrmSalaryTemplateDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!HrmSalaryTemplateDetailsForm.init)  {
                HrmSalaryTemplateDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DecimalEditor;

                Q.initFormType(HrmSalaryTemplateDetailsForm, [
                    'SalaryTemplateId', w0,
                    'SalaryComponentId', w0,
                    'ComponentAmount', w1
                ]);
            }
        }
    }
}

