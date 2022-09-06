using System.ComponentModel.DataAnnotations;

namespace BTSchool.Core.DTOs
{
    public class AccountRegister : AccountCredential
    {
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
