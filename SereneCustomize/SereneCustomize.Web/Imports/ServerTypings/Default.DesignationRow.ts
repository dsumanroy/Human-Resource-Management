
namespace SereneCustomize.Default {
    export interface DesignationRow {
        Id?: number;
        Name?: string;
        Remarks?: string;
    }

    export namespace DesignationRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.Designation';

        export namespace Fields {
            export declare const Id;
            export declare const Name;
            export declare const Remarks;
        }

        [
            'Id',
            'Name',
            'Remarks'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}