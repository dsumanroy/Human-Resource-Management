namespace SereneCustomize.HRM {
    export interface HrmSalaryComponentForm {
        Name: Serenity.StringEditor;
    }

    export class HrmSalaryComponentForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.HrmSalaryComponent';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!HrmSalaryComponentForm.init)  {
                HrmSalaryComponentForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(HrmSalaryComponentForm, [
                    'Name', w0
                ]);
            }
        }
    }
}

