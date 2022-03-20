namespace WebApi.Models.Accounts;

using System.Text.Json.Serialization;

public class LoginResponse
{
    public int Id { get; set; }
    public string Company { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string Country { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public bool IsVerified { get; set; }
    public bool VipStatus { get; set; }
    public string EnterpriseAgreement { get; set; }
    public string JwtToken { get; set; }

    [JsonIgnore] // refresh token is returned in http only cookie
    public string RefreshToken { get; set; }
}