using Microsoft.AspNetCore.Components;
using Radzen;

namespace ProyectoFinal.Utils;

public class Notifications
{
    public static NotificationMessage Info(string message)
    {
        return new NotificationMessage()
            {Severity = NotificationSeverity.Info, Summary = "Info", Detail = message, Duration = 4000};
    }

    public static NotificationMessage Success(string message)
    {
        return new NotificationMessage()
            {Severity = NotificationSeverity.Success, Summary = "Success", Detail = message, Duration = 4000};
    }

    public static NotificationMessage Error(string message)
    {
        return new NotificationMessage()
            {Severity = NotificationSeverity.Error, Summary = "Error", Detail = message, Duration = 4000};
    }
    
    public static NotificationMessage Warning(string message)
    {
        return new NotificationMessage()
            {Severity = NotificationSeverity.Warning, Summary = "Warning", Detail = message, Duration = 4000};
    }
}