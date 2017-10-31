using PMS.DTO.DataObjects;

namespace PMS.WEB.UI.Models
{
    public class RegisterViewModel
    {
        public UserDO User { get; set; }
        public bool HiddenValue { get; set; }
        public bool RememberMe { get; set; }
        public bool IsInviteAvailable { get; set; }
    }
}
