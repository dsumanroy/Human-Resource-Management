
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class PrmEmploymentInfoDialog extends Serenity.EntityDialog<PrmEmploymentInfoRow, any> {
        protected getFormKey() { return PrmEmploymentInfoForm.formKey; }
        protected getIdProperty() { return PrmEmploymentInfoRow.idProperty; }
        protected getLocalTextPrefix() { return PrmEmploymentInfoRow.localTextPrefix; }
        protected getNameProperty() { return PrmEmploymentInfoRow.nameProperty; }
        protected getService() { return PrmEmploymentInfoService.baseUrl; }

        protected form = new PrmEmploymentInfoForm(this.idPrefix);

    }
}