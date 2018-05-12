namespace SereneCustomize.HRM {
    export interface PrmEmploymentInfoRow {
        Id?: number;
        DesignationId?: number;
        EmpId?: string;
        FullName?: string;
        DateofJoining?: string;
        Gender?: string;
        DateofBirth?: string;
        DesignationName?: string;
        DesignationShortName?: string;
        DesignationSortingOrder?: number;
        DesignationRemarks?: string;
        DesignationIUser?: string;
        DesignationIDate?: string;
        DesignationEUser?: string;
        DesignationEDate?: string;
    }

    export namespace PrmEmploymentInfoRow {
        export const idProperty = 'Id';
        export const nameProperty = 'EmpId';
        export const localTextPrefix = 'HRM.PrmEmploymentInfo';

        export declare const enum Fields {
            Id = "Id",
            DesignationId = "DesignationId",
            EmpId = "EmpId",
            FullName = "FullName",
            DateofJoining = "DateofJoining",
            Gender = "Gender",
            DateofBirth = "DateofBirth",
            DesignationName = "DesignationName",
            DesignationShortName = "DesignationShortName",
            DesignationSortingOrder = "DesignationSortingOrder",
            DesignationRemarks = "DesignationRemarks",
            DesignationIUser = "DesignationIUser",
            DesignationIDate = "DesignationIDate",
            DesignationEUser = "DesignationEUser",
            DesignationEDate = "DesignationEDate"
        }
    }
}

