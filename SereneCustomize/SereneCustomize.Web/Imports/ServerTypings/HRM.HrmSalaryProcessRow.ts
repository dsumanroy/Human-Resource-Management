namespace SereneCustomize.HRM {
    export interface HrmSalaryProcessRow {
        Id?: number;
        EmployeeId?: number;
        SalaryTemplateId?: number;
        Year?: number;
        Month?: string;
        YearMonth?: string;
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

    export namespace HrmSalaryProcessRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Month';
        export const localTextPrefix = 'HRM.HrmSalaryProcess';

        export declare const enum Fields {
            Id = "Id",
            EmployeeId = "EmployeeId",
            SalaryTemplateId = "SalaryTemplateId",
            Year = "Year",
            Month = "Month",
            YearMonth = "YearMonth",
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

