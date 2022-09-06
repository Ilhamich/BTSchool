using System.ComponentModel.DataAnnotations;

namespace BTSchool.Core.BindingModels
{
    public class AccountRegister : AccountCredential
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password isn't correct")]
        public string ConfirmPassword { get; set; }
    }
}
