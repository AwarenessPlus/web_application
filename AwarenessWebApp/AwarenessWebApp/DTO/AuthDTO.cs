using System.ComponentModel.DataAnnotations;

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
