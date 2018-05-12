
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmEmployeeSalaryGrid extends Serenity.EntityGrid<HrmEmployeeSalaryRow, any> {
        protected getColumnsKey() { return 'HRM.HrmEmployeeSalary'; }
        protected getDialogType() { return HrmEmployeeSalaryDialog; }
        protected getIdProperty() { return HrmEmployeeSalaryRow.idProperty; }
        protected getLocalTextPrefix() { return HrmEmployeeSalaryRow.localTextPrefix; }
        protected getService() { return HrmEmployeeSalaryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}