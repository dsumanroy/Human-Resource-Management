namespace SereneCustomize.HRM {
    export namespace HrmEmployeeSalaryService {
        export const baseUrl = 'HRM/HrmEmployeeSalary';

        export declare function Create(request: Serenity.SaveRequest<HrmEmployeeSalaryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<HrmEmployeeSalaryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<HrmEmployeeSalaryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<HrmEmployeeSalaryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "HRM/HrmEmployeeSalary/Create",
            Update = "HRM/HrmEmployeeSalary/Update",
            Delete = "HRM/HrmEmployeeSalary/Delete",
            Retrieve = "HRM/HrmEmployeeSalary/Retrieve",
            List = "HRM/HrmEmployeeSalary/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>HrmEmployeeSalaryService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

