namespace SereneCustomize.HRM {
    export namespace HrmSalaryComponentService {
        export const baseUrl = 'HRM/HrmSalaryComponent';

        export declare function Create(request: Serenity.SaveRequest<HrmSalaryComponentRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<HrmSalaryComponentRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<HrmSalaryComponentRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<HrmSalaryComponentRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "HRM/HrmSalaryComponent/Create",
            Update = "HRM/HrmSalaryComponent/Update",
            Delete = "HRM/HrmSalaryComponent/Delete",
            Retrieve = "HRM/HrmSalaryComponent/Retrieve",
            List = "HRM/HrmSalaryComponent/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>HrmSalaryComponentService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

