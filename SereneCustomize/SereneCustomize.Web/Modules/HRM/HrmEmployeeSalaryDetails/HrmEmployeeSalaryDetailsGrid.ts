
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmEmployeeSalaryDetailsGrid extends Serenity.EntityGrid<HrmEmployeeSalaryDetailsRow, any> {
        protected getColumnsKey() { return 'HRM.HrmEmployeeSalaryDetails'; }
        protected getDialogType() { return HrmEmployeeSalaryDetailsDialog; }
        protected getIdProperty() { return HrmEmployeeSalaryDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return HrmEmployeeSalaryDetailsRow.localTextPrefix; }
        protected getService() { return HrmEmployeeSalaryDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}