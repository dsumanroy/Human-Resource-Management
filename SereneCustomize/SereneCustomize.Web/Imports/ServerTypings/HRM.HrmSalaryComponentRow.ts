namespace SereneCustomize.HRM {
    export interface HrmSalaryComponentRow {
        Id?: number;
        Name?: string;
    }

    export namespace HrmSalaryComponentRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HRM.HrmSalaryComponent';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name"
        }
    }
}

