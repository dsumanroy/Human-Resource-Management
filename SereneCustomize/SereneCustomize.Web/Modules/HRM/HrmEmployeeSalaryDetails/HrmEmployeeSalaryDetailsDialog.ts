
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmEmployeeSalaryDetailsDialog extends Serenity.EntityDialog<HrmEmployeeSalaryDetailsRow, any> {
        protected getFormKey() { return HrmEmployeeSalaryDetailsForm.formKey; }
        protected getIdProperty() { return HrmEmployeeSalaryDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return HrmEmployeeSalaryDetailsRow.localTextPrefix; }
        protected getService() { return HrmEmployeeSalaryDetailsService.baseUrl; }

        protected form = new HrmEmployeeSalaryDetailsForm(this.idPrefix);

    }
}