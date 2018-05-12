
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class PrmDesignationDialog extends Serenity.EntityDialog<PrmDesignationRow, any> {
        protected getFormKey() { return PrmDesignationForm.formKey; }
        protected getIdProperty() { return PrmDesignationRow.idProperty; }
        protected getLocalTextPrefix() { return PrmDesignationRow.localTextPrefix; }
        protected getNameProperty() { return PrmDesignationRow.nameProperty; }
        protected getService() { return PrmDesignationService.baseUrl; }

        protected form = new PrmDesignationForm(this.idPrefix);

    }
}