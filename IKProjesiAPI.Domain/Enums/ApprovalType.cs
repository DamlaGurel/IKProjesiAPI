using System.ComponentModel.DataAnnotations;

namespace IKProjesiAPI.Domain.Enums
{
	public enum ApprovalType
	{
		[Display(Name ="Onay Bekliyor")]
		Waiting = 1,
        [Display(Name = "Onaylandı")]
        Done,
        [Display(Name = "Onay Reddedildi")]
        Deny,
        [Display(Name = "Onay İptal Edildi")]
        Reject
    }
}

