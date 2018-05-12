
namespace SereneCustomize.Default {
    export class DailyAttendanceForm extends Serenity.PrefixedContext {
        static formKey = 'Default.DailyAttendance';
    }

    export interface DailyAttendanceForm {
        UserId: Serenity.IntegerEditor;
        AttendanceDate: Serenity.DateEditor;
    }

    [,
        ['UserId', () => Serenity.IntegerEditor],
        ['AttendanceDate', () => Serenity.DateEditor]
    ].forEach(x => Object.defineProperty(DailyAttendanceForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}