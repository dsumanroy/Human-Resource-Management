
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class PrmEmploymentInfoGrid extends Serenity.EntityGrid<PrmEmploymentInfoRow, any> {
        protected getColumnsKey() { return 'HRM.PrmEmploymentInfo'; }
        protected getDialogType() { return PrmEmploymentInfoDialog; }
        protected getIdProperty() { return PrmEmploymentInfoRow.idProperty; }
        protected getLocalTextPrefix() { return PrmEmploymentInfoRow.localTextPrefix; }
        protected getService() { return PrmEmploymentInfoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}