namespace SereneCustomize.HRM {
    export interface AmsAttenanceRow {
        Id?: number;
        EmployeeId?: number;
        AttendanceDate?: string;
        EmployeeDesignationId?: number;
        EmployeeEmpId?: string;
        EmployeeFullName?: string;
        EmployeeDateofJoining?: string;
        EmployeeGender?: string;
        EmployeeDateofBirth?: string;
    }

    export namespace AmsAttenanceRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'HRM.AmsAttenance';

        export declare const enum Fields {
            Id = "Id",
            EmployeeId = "EmployeeId",
            AttendanceDate = "AttendanceDate",
            EmployeeDesignationId = "EmployeeDesignationId",
            EmployeeEmpId = "EmployeeEmpId",
            EmployeeFullName = "EmployeeFullName",
            EmployeeDateofJoining = "EmployeeDateofJoining",
            EmployeeGender = "EmployeeGender",
            EmployeeDateofBirth = "EmployeeDateofBirth"
        }
    }
}

