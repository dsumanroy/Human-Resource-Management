
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class HrmSalaryProcessDialog extends Serenity.EntityDialog<HrmSalaryProcessRow, any> {
        protected getFormKey() { return HrmSalaryProcessForm.formKey; }
        protected getIdProperty() { return HrmSalaryProcessRow.idProperty; }
        protected getLocalTextPrefix() { return HrmSalaryProcessRow.localTextPrefix; }
        protected getNameProperty() { return HrmSalaryProcessRow.nameProperty; }
        protected getService() { return HrmSalaryProcessService.baseUrl; }

        protected form = new HrmSalaryProcessForm(this.idPrefix);

        protected getToolbarButtons() {

            var buttons = super.getToolbarButtons();
            buttons = [];
            buttons.push({
                title: "Process", cssClass: "send-button",

                onClick: (x) => {

                    let message = "Are you sure you want to Process?";

                    //Q.confirm(message, () => {
                    //    if (this.form.IntLeaveYearId.value == "") {
                    //        Q.alert("Please select leave year!");
                    //        return;
                    //    }
                    //    this.form.ProcessType.value = "LP";
                    //    this.save(p => { Q.notifySuccess("Process successfull."); this.dialogClose(); });
                    //}
                    //);
                }
            });

            buttons.push({
                title: "Roll back", cssClass: "send-button",

                onClick: (x) => {

                    let message = "Are you sure you want to Roll back?";

                    //Q.confirm(message, () => {
                    //    if (this.form.IntLeaveYearId.value == "") {
                    //        Q.alert("Please select leave year!");
                    //        return;
                    //    }
                    //    this.form.ProcessType.value = "RB";
                    //    this.save(p => { Q.notifySuccess("Roll back successfull."); this.dialogClose(); });
                    //}
                    //);
                }
            });
            return buttons;
        }

    }
}