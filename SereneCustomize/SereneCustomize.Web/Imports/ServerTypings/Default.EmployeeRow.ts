namespace SereneCustomize.Default {
    export interface EmployeeRow {
        UserId?: number;
        Username?: string;
        DisplayName?: string;
        Email?: string;
        Source?: string;
        PasswordHash?: string;
        PasswordSalt?: string;
        LastDirectoryUpdate?: string;
        UserImage?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsActive?: number;
        DesignationId?: number;
        BirthDate?: string;
        Gender?: string;
        DesignationName?: string;
        DesignationRemarks?: string;
    }

    export namespace EmployeeRow {
        export const idProperty = 'UserId';
        export const nameProperty = 'Username';
        export const localTextPrefix = 'Default.Employee';

        export declare const enum Fields {
            UserId = "UserId",
            Username = "Username",
            DisplayName = "DisplayName",
            Email = "Email",
            Source = "Source",
            PasswordHash = "PasswordHash",
            PasswordSalt = "PasswordSalt",
            LastDirectoryUpdate = "LastDirectoryUpdate",
            UserImage = "UserImage",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsActive = "IsActive",
            DesignationId = "DesignationId",
            BirthDate = "BirthDate",
            Gender = "Gender",
            DesignationName = "DesignationName",
            DesignationRemarks = "DesignationRemarks"
        }
    }
}

