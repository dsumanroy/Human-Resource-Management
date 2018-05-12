namespace SereneCustomize.HRM {
    export interface HrmEmployeeSalaryRow {
        Id?: number;
        EmployeeId?: number;
        SalaryTemplateId?: number;
        BasicSalary?: number;
        HourlyRate?: number;
        EmployeeDesignationId?: number;
        EmployeeEmpId?: string;
        EmployeeFullName?: string;
        EmployeeDateofJoining?: string;
        EmployeeGender?: string;
        EmployeeDateofBirth?: string;
        SalaryTemplateSalaryGrade?: string;
        SalaryTemplateBasicSalary?: number;
        SalaryTemplateHourlyRate?: number;
    }

    export namespace HrmEmployeeSalaryRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'HRM.HrmEmployeeSalary';

        export declare const enum Fields {
            Id = "Id",
            EmployeeId = "EmployeeId",
            SalaryTemplateId = "SalaryTemplateId",
            BasicSalary = "BasicSalary",
            HourlyRate = "HourlyRate",
            EmployeeDesignationId = "EmployeeDesignationId",
            EmployeeEmpId = "EmployeeEmpId",
            EmployeeFullName = "EmployeeFullName",
            EmployeeDateofJoining = "EmployeeDateofJoining",
            EmployeeGender = "EmployeeGender",
            EmployeeDateofBirth = "EmployeeDateofBirth",
            SalaryTemplateSalaryGrade = "SalaryTemplateSalaryGrade",
            SalaryTemplateBasicSalary = "SalaryTemplateBasicSalary",
            SalaryTemplateHourlyRate = "SalaryTemplateHourlyRate"
        }
    }
}

