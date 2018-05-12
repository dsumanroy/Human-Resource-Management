
namespace SereneCustomize.Default {

    @Serenity.Decorators.registerClass()
    export class DailyAttendanceDialog extends Serenity.EntityDialog<DailyAttendanceRow, any> {
        protected getFormKey() { return DailyAttendanceForm.formKey; }
        protected getIdProperty() { return DailyAttendanceRow.idProperty; }
        protected getLocalTextPrefix() { return DailyAttendanceRow.localTextPrefix; }
        protected getService() { return DailyAttendanceService.baseUrl; }

        protected form = new DailyAttendanceForm(this.idPrefix);

    }
}