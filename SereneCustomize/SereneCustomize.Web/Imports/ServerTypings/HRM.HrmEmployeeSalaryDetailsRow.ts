namespace SereneCustomize.HRM {
    export interface HrmEmployeeSalaryDetailsRow {
        Id?: number;
        EmployeeSalaryId?: number;
        EmployeeId?: number;
        SalaryComponentId?: number;
        Amount?: number;
        EmployeeSalaryEmployeeId?: number;
        EmployeeSalarySalaryTemplateId?: number;
        EmployeeSalaryBasicSalary?: number;
        EmployeeSalaryHourlyRate?: number;
        EmployeeDesignationId?: number;
        EmployeeEmpId?: string;
        EmployeeFullName?: string;
        EmployeeDateofJoining?: string;
        EmployeeGender?: string;
        EmployeeDateofBirth?: string;
        SalaryComponentName?: string;
    }

    export namespace HrmEmployeeSalaryDetailsRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'HRM.HrmEmployeeSalaryDetails';

        export declare const enum Fields {
            Id = "Id",
            EmployeeSalaryId = "EmployeeSalaryId",
            EmployeeId = "EmployeeId",
            SalaryComponentId = "SalaryComponentId",
            Amount = "Amount",
            EmployeeSalaryEmployeeId = "EmployeeSalaryEmployeeId",
            EmployeeSalarySalaryTemplateId = "EmployeeSalarySalaryTemplateId",
            EmployeeSalaryBasicSalary = "EmployeeSalaryBasicSalary",
            EmployeeSalaryHourlyRate = "EmployeeSalaryHourlyRate",
            EmployeeDesignationId = "EmployeeDesignationId",
            EmployeeEmpId = "EmployeeEmpId",
            EmployeeFullName = "EmployeeFullName",
            EmployeeDateofJoining = "EmployeeDateofJoining",
            EmployeeGender = "EmployeeGender",
            EmployeeDateofBirth = "EmployeeDateofBirth",
            SalaryComponentName = "SalaryComponentName"
        }
    }
}

