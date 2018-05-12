namespace SereneCustomize.Default {
    export interface DailyAttendanceForm {
        UserId: Serenity.LookupEditor;
        AttendanceDate: Serenity.DateTimeEditor;
    }

    export class DailyAttendanceForm extends Serenity.PrefixedContext {
        static formKey = 'Default.DailyAttendance';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DailyAttendanceForm.init)  {
                DailyAttendanceForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateTimeEditor;

                Q.initFormType(DailyAttendanceForm, [
                    'UserId', w0,
                    'AttendanceDate', w1
                ]);
            }
        }
    }
}

