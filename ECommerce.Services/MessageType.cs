using System;

namespace ECommerce.Services
{
    [Flags]
    public enum MessageType
    {
        Success,
        UnSuccess,
        Info,
        Warning,
        NotAllowed,
        Error
    }
}
