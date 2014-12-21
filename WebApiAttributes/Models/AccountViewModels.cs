using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiAttributes.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "ユーザー名")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "パスワード")]
        public string Password { get; set; }

    }

}
