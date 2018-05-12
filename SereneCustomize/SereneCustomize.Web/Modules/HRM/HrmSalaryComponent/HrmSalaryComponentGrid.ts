
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmSalaryComponentGrid extends Serenity.EntityGrid<HrmSalaryComponentRow, any> {
        protected getColumnsKey() { return 'HRM.HrmSalaryComponent'; }
        protected getDialogType() { return HrmSalaryComponentDialog; }
        protected getIdProperty() { return HrmSalaryComponentRow.idProperty; }
        protected getLocalTextPrefix() { return HrmSalaryComponentRow.localTextPrefix; }
        protected getService() { return HrmSalaryComponentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}