namespace SereneCustomize.HRM {
    export interface PrmDesignationForm {
        Name: Serenity.StringEditor;
        ShortName: Serenity.StringEditor;
        SortingOrder: Serenity.IntegerEditor;
        Remarks: Serenity.StringEditor;
        IUser: Serenity.StringEditor;
        IDate: Serenity.DateEditor;
        EUser: Serenity.StringEditor;
        EDate: Serenity.DateEditor;
    }

    export class PrmDesignationForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.PrmDesignation';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PrmDesignationForm.init)  {
                PrmDesignationForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(PrmDesignationForm, [
                    'Name', w0,
                    'ShortName', w0,
                    'SortingOrder', w1,
                    'Remarks', w0,
                    'IUser', w0,
                    'IDate', w2,
                    'EUser', w0,
                    'EDate', w2
                ]);
            }
        }
    }
}

