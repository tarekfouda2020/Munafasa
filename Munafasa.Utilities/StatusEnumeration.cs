using System;
namespace Munafasa.Utilities
{
	public enum StatusEnumeration
	{
		New = 0,
        PendingOwnerApproval = 1,
        PendingAdminApproval = 2,
        PendingTechnical = 3,
        TechnicalStartWork = 4,
        TechnicalFinished = 5,
        Done = 6,
        Canceled = 7,
    }
}

