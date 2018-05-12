
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmEmployeeSalaryDialog extends Serenity.EntityDialog<HrmEmployeeSalaryRow, any> {
        protected getFormKey() { return HrmEmployeeSalaryForm.formKey; }
        protected getIdProperty() { return HrmEmployeeSalaryRow.idProperty; }
        protected getLocalTextPrefix() { return HrmEmployeeSalaryRow.localTextPrefix; }
        protected getService() { return HrmEmployeeSalaryService.baseUrl; }

        protected form = new HrmEmployeeSalaryForm(this.idPrefix);

    }
}