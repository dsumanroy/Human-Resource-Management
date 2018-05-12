namespace SereneCustomize.Default {
    export interface EmployeeForm {
        Username: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Source: Serenity.StringEditor;
        PasswordHash: Serenity.StringEditor;
        PasswordSalt: Serenity.StringEditor;
        LastDirectoryUpdate: Serenity.DateEditor;
        UserImage: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        DesignationId: Serenity.StringEditor;
        BirthDate: Serenity.DateEditor;
        Gender: Serenity.StringEditor;
    }

    export class EmployeeForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Employee';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EmployeeForm.init)  {
                EmployeeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(EmployeeForm, [
                    'Username', w0,
                    'DisplayName', w0,
                    'Email', w0,
                    'Source', w0,
                    'PasswordHash', w0,
                    'PasswordSalt', w0,
                    'LastDirectoryUpdate', w1,
                    'UserImage', w0,
                    'InsertDate', w1,
                    'InsertUserId', w2,
                    'UpdateDate', w1,
                    'UpdateUserId', w2,
                    'IsActive', w2,
                    'DesignationId', w0,
                    'BirthDate', w1,
                    'Gender', w0
                ]);
            }
        }
    }
}

