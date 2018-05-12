
namespace SereneCustomize.Default {
    export class DesignationForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Designation';
    }

    export interface DesignationForm {
        Name: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
    }

    [,
        ['Name', () => Serenity.StringEditor],
        ['Remarks', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(DesignationForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}