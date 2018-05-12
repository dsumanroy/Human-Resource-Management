
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmSalaryTemplateDialog extends Serenity.EntityDialog<HrmSalaryTemplateRow, any> {
        protected getFormKey() { return HrmSalaryTemplateForm.formKey; }
        protected getIdProperty() { return HrmSalaryTemplateRow.idProperty; }
        protected getLocalTextPrefix() { return HrmSalaryTemplateRow.localTextPrefix; }
        protected getNameProperty() { return HrmSalaryTemplateRow.nameProperty; }
        protected getService() { return HrmSalaryTemplateService.baseUrl; }

        protected form = new HrmSalaryTemplateForm(this.idPrefix);

    }
}