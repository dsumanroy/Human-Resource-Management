namespace SereneCustomize.HRM {
    export interface AmsAttenanceForm {
        EmployeeId: Serenity.IntegerEditor;
        AttendanceDate: Serenity.DateEditor;
    }

    export class AmsAttenanceForm extends Serenity.PrefixedContext {
        static formKey = 'HRM.AmsAttenance';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AmsAttenanceForm.init)  {
                AmsAttenanceForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(AmsAttenanceForm, [
                    'EmployeeId', w0,
                    'AttendanceDate', w1
                ]);
            }
        }
    }
}

