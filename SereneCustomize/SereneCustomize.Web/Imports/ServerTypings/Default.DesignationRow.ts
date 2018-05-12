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

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Remarks = "Remarks"
        }
    }
}

