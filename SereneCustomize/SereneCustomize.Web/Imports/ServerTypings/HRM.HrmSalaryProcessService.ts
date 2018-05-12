namespace SereneCustomize.HRM {
    export namespace HrmSalaryProcessService {
        export const baseUrl = 'HRM/HrmSalaryProcess';

        export declare function Create(request: Serenity.SaveRequest<HrmSalaryProcessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<HrmSalaryProcessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<HrmSalaryProcessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<HrmSalaryProcessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "HRM/HrmSalaryProcess/Create",
            Update = "HRM/HrmSalaryProcess/Update",
            Delete = "HRM/HrmSalaryProcess/Delete",
            Retrieve = "HRM/HrmSalaryProcess/Retrieve",
            List = "HRM/HrmSalaryProcess/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>HrmSalaryProcessService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

