namespace SereneCustomize.HRM {
    export namespace HrmSalaryTemplateService {
        export const baseUrl = 'HRM/HrmSalaryTemplate';

        export declare function Create(request: Serenity.SaveRequest<HrmSalaryTemplateRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<HrmSalaryTemplateRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<HrmSalaryTemplateRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<HrmSalaryTemplateRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "HRM/HrmSalaryTemplate/Create",
            Update = "HRM/HrmSalaryTemplate/Update",
            Delete = "HRM/HrmSalaryTemplate/Delete",
            Retrieve = "HRM/HrmSalaryTemplate/Retrieve",
            List = "HRM/HrmSalaryTemplate/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>HrmSalaryTemplateService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

