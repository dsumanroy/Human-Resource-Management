
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmSalaryComponentDialog extends Serenity.EntityDialog<HrmSalaryComponentRow, any> {
        protected getFormKey() { return HrmSalaryComponentForm.formKey; }
        protected getIdProperty() { return HrmSalaryComponentRow.idProperty; }
        protected getLocalTextPrefix() { return HrmSalaryComponentRow.localTextPrefix; }
        protected getNameProperty() { return HrmSalaryComponentRow.nameProperty; }
        protected getService() { return HrmSalaryComponentService.baseUrl; }

        protected form = new HrmSalaryComponentForm(this.idPrefix);

    }
}