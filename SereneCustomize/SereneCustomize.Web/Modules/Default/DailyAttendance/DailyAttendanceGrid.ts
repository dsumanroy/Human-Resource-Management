
namespace SereneCustomize.Default {

    @Serenity.Decorators.registerClass()
    export class DailyAttendanceGrid extends Serenity.EntityGrid<DailyAttendanceRow, any> {
        protected getColumnsKey() { return 'Default.DailyAttendance'; }
        protected getDialogType() { return DailyAttendanceDialog; }
        protected getIdProperty() { return DailyAttendanceRow.idProperty; }
        protected getLocalTextPrefix() { return DailyAttendanceRow.localTextPrefix; }
        protected getService() { return DailyAttendanceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}