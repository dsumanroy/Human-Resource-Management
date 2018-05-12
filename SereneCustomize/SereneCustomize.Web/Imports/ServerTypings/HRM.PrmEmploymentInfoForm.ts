namespace SereneCustomize.HRM {
    export interface PrmEmploymentInfoForm {
        DesignationId: Serenity.IntegerEditor;
        EmpId: Serenity.StringEditor;
        FullName: Serenity.StringEditor;
        DateofJoining: Serenity.DateEditor;
        Gender: Serenity.StringEditor;
        DateofBirth: Serenity.DateEditor;
    }

    export class PrmEmploymentInfoForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.PrmEmploymentInfo';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PrmEmploymentInfoForm.init)  {
                PrmEmploymentInfoForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(PrmEmploymentInfoForm, [
                    'DesignationId', w0,
                    'EmpId', w1,
                    'FullName', w1,
                    'DateofJoining', w2,
                    'Gender', w1,
                    'DateofBirth', w2
                ]);
            }
        }
    }
}

