using NetCoreJwtRsaDemo.Models;

namespace NetCoreJwtRsaDemo
{
    public interface IJwtHandler
    {
        JwtResponse CreateToken(JwtCustomClaims claims);
        bool ValidateToken(string token);
    }
}
