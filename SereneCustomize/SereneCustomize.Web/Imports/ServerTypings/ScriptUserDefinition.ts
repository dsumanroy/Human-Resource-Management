namespace SereneCustomize {
    export interface ScriptUserDefinition {
        Username?: string;
        DisplayName?: string;
        IsAdmin?: boolean;
        Permissions?: { [key: string]: boolean };
        ClockButtonText?: string;
        ClockTime?: string;
        strClockTime?: string;
    }
}

