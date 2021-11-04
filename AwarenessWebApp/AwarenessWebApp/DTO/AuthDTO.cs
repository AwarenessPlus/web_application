using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Json;
using System.Net.Http;

public class AuthDTO
{
    [Required]
    private string userName;
    [Required]
    private string password;
    public string UserName { get => userName; set => userName = value; }
    public string Password { get => password; set => password = value; }

    public AuthDTO()
        {
            this.UserName = "";
            this.Password = "";
        }
    public AuthDTO(string userName, string password)
    {
        this.UserName = userName;
        this.Password = password;
    }
}
