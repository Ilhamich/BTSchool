using System.ComponentModel.DataAnnotations;

namespace BTSchool.Core.BindingModels
{
    public class AccountCredential
    {
        [Required(ErrorMessage = "Email isn't specified")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password isn't specified")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
