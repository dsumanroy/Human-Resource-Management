
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmSalaryTemplateDetailsGrid extends Serenity.EntityGrid<HrmSalaryTemplateDetailsRow, any> {
        protected getColumnsKey() { return 'HRM.HrmSalaryTemplateDetails'; }
        protected getDialogType() { return HrmSalaryTemplateDetailsDialog; }
        protected getIdProperty() { return HrmSalaryTemplateDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return HrmSalaryTemplateDetailsRow.localTextPrefix; }
        protected getService() { return HrmSalaryTemplateDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}