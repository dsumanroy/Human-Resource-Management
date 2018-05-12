
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmSalaryProcessGrid extends Serenity.EntityGrid<HrmSalaryProcessRow, any> {
        protected getColumnsKey() { return 'HRM.HrmSalaryProcess'; }
        protected getDialogType() { return HrmSalaryProcessDialog; }
        protected getIdProperty() { return HrmSalaryProcessRow.idProperty; }
        protected getLocalTextPrefix() { return HrmSalaryProcessRow.localTextPrefix; }
        protected getService() { return HrmSalaryProcessService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}