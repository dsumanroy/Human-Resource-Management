namespace SereneCustomize.HRM {
    export namespace HrmSalaryTemplateDetailsService {
        export const baseUrl = 'HRM/HrmSalaryTemplateDetails';

        export declare function Create(request: Serenity.SaveRequest<HrmSalaryTemplateDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<HrmSalaryTemplateDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<HrmSalaryTemplateDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<HrmSalaryTemplateDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "HRM/HrmSalaryTemplateDetails/Create",
            Update = "HRM/HrmSalaryTemplateDetails/Update",
            Delete = "HRM/HrmSalaryTemplateDetails/Delete",
            Retrieve = "HRM/HrmSalaryTemplateDetails/Retrieve",
            List = "HRM/HrmSalaryTemplateDetails/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>HrmSalaryTemplateDetailsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

