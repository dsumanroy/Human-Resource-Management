namespace SereneCustomize.Default {
    export interface DailyAttendanceForm {
        UserId: Serenity.IntegerEditor;
        AttendanceDate: Serenity.DateEditor;
    }

    export class DailyAttendanceForm extends Serenity.PrefixedContext {
        static formKey = 'Default.DailyAttendance';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DailyAttendanceForm.init)  {
                DailyAttendanceForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(DailyAttendanceForm, [
                    'UserId', w0,
                    'AttendanceDate', w1
                ]);
            }
        }
    }
}

