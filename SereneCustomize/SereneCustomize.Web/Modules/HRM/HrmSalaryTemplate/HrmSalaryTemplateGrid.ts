
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmSalaryTemplateGrid extends Serenity.EntityGrid<HrmSalaryTemplateRow, any> {
        protected getColumnsKey() { return 'HRM.HrmSalaryTemplate'; }
        protected getDialogType() { return HrmSalaryTemplateDialog; }
        protected getIdProperty() { return HrmSalaryTemplateRow.idProperty; }
        protected getLocalTextPrefix() { return HrmSalaryTemplateRow.localTextPrefix; }
        protected getService() { return HrmSalaryTemplateService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}