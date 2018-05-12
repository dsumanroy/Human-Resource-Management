
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class AmsAttenanceDialog extends Serenity.EntityDialog<AmsAttenanceRow, any> {
        protected getFormKey() { return AmsAttenanceForm.formKey; }
        protected getIdProperty() { return AmsAttenanceRow.idProperty; }
        protected getLocalTextPrefix() { return AmsAttenanceRow.localTextPrefix; }
        protected getService() { return AmsAttenanceService.baseUrl; }

        protected form = new AmsAttenanceForm(this.idPrefix);

        constructor() {
            super();
            
            var objA: AmsAttenanceRow;
            objA = {};
            objA.EmployeeId = 1;
            objA.AttendanceDate = "2018-05-11";
            console.log(objA);
            AmsAttenanceService.Create({ Entity: objA }, p => {
                                    Q.notifySuccess('data save');                                  
                                });      

        }

    }
}