
namespace SereneCustomize.HRM {

    @Serenity.Decorators.registerClass()
    export class PrmDesignationGrid extends Serenity.EntityGrid<PrmDesignationRow, any> {
        protected getColumnsKey() { return 'HRM.PrmDesignation'; }
        protected getDialogType() { return PrmDesignationDialog; }
        protected getIdProperty() { return PrmDesignationRow.idProperty; }
        protected getLocalTextPrefix() { return PrmDesignationRow.localTextPrefix; }
        protected getService() { return PrmDesignationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}