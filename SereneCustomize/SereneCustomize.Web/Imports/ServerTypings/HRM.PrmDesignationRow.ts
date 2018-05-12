namespace SereneCustomize.HRM {
    export interface PrmDesignationRow {
        Id?: number;
        Name?: string;
        ShortName?: string;
        SortingOrder?: number;
        Remarks?: string;
        IUser?: string;
        IDate?: string;
        EUser?: string;
        EDate?: string;
    }

    export namespace PrmDesignationRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HRM.PrmDesignation';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            ShortName = "ShortName",
            SortingOrder = "SortingOrder",
            Remarks = "Remarks",
            IUser = "IUser",
            IDate = "IDate",
            EUser = "EUser",
            EDate = "EDate"
        }
    }
}

