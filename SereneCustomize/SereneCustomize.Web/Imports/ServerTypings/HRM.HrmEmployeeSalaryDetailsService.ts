namespace SereneCustomize.HRM {
    export namespace HrmEmployeeSalaryDetailsService {
        export const baseUrl = 'HRM/HrmEmployeeSalaryDetails';

        export declare function Create(request: Serenity.SaveRequest<HrmEmployeeSalaryDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<HrmEmployeeSalaryDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<HrmEmployeeSalaryDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<HrmEmployeeSalaryDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "HRM/HrmEmployeeSalaryDetails/Create",
            Update = "HRM/HrmEmployeeSalaryDetails/Update",
            Delete = "HRM/HrmEmployeeSalaryDetails/Delete",
            Retrieve = "HRM/HrmEmployeeSalaryDetails/Retrieve",
            List = "HRM/HrmEmployeeSalaryDetails/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>HrmEmployeeSalaryDetailsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

