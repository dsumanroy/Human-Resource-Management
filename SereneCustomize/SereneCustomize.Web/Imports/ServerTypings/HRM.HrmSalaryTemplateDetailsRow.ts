namespace SereneCustomize.HRM {
    export interface HrmSalaryTemplateDetailsRow {
        Id?: number;
        SalaryTemplateId?: number;
        SalaryComponentId?: number;
        ComponentAmount?: number;
        SalaryTemplateSalaryGrade?: string;
        SalaryTemplateBasicSalary?: number;
        SalaryTemplateHourlyRate?: number;
        SalaryComponentName?: string;
    }

    export namespace HrmSalaryTemplateDetailsRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'HRM.HrmSalaryTemplateDetails';

        export declare const enum Fields {
            Id = "Id",
            SalaryTemplateId = "SalaryTemplateId",
            SalaryComponentId = "SalaryComponentId",
            ComponentAmount = "ComponentAmount",
            SalaryTemplateSalaryGrade = "SalaryTemplateSalaryGrade",
            SalaryTemplateBasicSalary = "SalaryTemplateBasicSalary",
            SalaryTemplateHourlyRate = "SalaryTemplateHourlyRate",
            SalaryComponentName = "SalaryComponentName"
        }
    }
}

