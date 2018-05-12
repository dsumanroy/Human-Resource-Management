
namespace SereneCustomize.Default {

    @Serenity.Decorators.registerClass()
    export class EmployeeGrid extends Serenity.EntityGrid<EmployeeRow, any> {
        protected getColumnsKey() { return 'Default.Employee'; }
        protected getDialogType() { return EmployeeDialog; }
        protected getIdProperty() { return EmployeeRow.idProperty; }
        protected getLocalTextPrefix() { return EmployeeRow.localTextPrefix; }
        protected getService() { return EmployeeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            let buttons = super.getButtons();

            var hasInsertPermission = Authorization.hasPermission('HRM:Employee:Insert');
            if (!hasInsertPermission) {
                buttons.splice(0, 1);
            }


            return buttons;
        }
    }
}