namespace SereneCustomize.Default {
    export interface DesignationForm {
        Name: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
    }

    export class DesignationForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Designation';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DesignationForm.init)  {
                DesignationForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(DesignationForm, [
                    'Name', w0,
                    'Remarks', w0
                ]);
            }
        }
    }
}

