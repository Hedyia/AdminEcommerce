namespace Infrastructure.Models
{
    public interface IJwtGenerator
    {
        string CreateToken(ApplicationUser user);
    }
}