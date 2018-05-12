namespace SereneCustomize.Default {
    export namespace DailyAttendanceService {
        export const baseUrl = 'Default/DailyAttendance';

        export declare function Create(request: Serenity.SaveRequest<DailyAttendanceRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<DailyAttendanceRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DailyAttendanceRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DailyAttendanceRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function setAttendance(request: Serenity.SaveRequest<DailyAttendanceRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Default/DailyAttendance/Create",
            Update = "Default/DailyAttendance/Update",
            Delete = "Default/DailyAttendance/Delete",
            Retrieve = "Default/DailyAttendance/Retrieve",
            List = "Default/DailyAttendance/List",
            setAttendance = "Default/DailyAttendance/setAttendance"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'setAttendance'
        ].forEach(x => {
            (<any>DailyAttendanceService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

