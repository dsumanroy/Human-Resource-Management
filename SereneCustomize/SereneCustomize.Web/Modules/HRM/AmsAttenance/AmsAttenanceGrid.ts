
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class AmsAttenanceGrid extends Serenity.EntityGrid<AmsAttenanceRow, any> {
        protected getColumnsKey() { return 'HRM.AmsAttenance'; }
        protected getDialogType() { return AmsAttenanceDialog; }
        protected getIdProperty() { return AmsAttenanceRow.idProperty; }
        protected getLocalTextPrefix() { return AmsAttenanceRow.localTextPrefix; }
        protected getService() { return AmsAttenanceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}