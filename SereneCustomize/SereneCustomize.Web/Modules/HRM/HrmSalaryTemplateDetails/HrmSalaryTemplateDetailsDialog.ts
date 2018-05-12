
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmSalaryTemplateDetailsDialog extends Serenity.EntityDialog<HrmSalaryTemplateDetailsRow, any> {
        protected getFormKey() { return HrmSalaryTemplateDetailsForm.formKey; }
        protected getIdProperty() { return HrmSalaryTemplateDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return HrmSalaryTemplateDetailsRow.localTextPrefix; }
        protected getService() { return HrmSalaryTemplateDetailsService.baseUrl; }

        protected form = new HrmSalaryTemplateDetailsForm(this.idPrefix);

    }
}