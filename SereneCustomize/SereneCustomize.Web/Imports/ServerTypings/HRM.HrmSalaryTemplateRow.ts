namespace SereneCustomize.HRM {
    export interface HrmSalaryTemplateRow {
        Id?: number;
        SalaryGrade?: string;
        BasicSalary?: number;
        HourlyRate?: number;
    }

    export namespace HrmSalaryTemplateRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SalaryGrade';
        export const localTextPrefix = 'HRM.HrmSalaryTemplate';

        export declare const enum Fields {
            Id = "Id",
            SalaryGrade = "SalaryGrade",
            BasicSalary = "BasicSalary",
            HourlyRate = "HourlyRate"
        }
    }
}

