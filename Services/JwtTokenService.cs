using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TravelWebBackEndCore.DTOs.Auth;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;

public class JwtTokenService : IJwtTokenService
{
    public string GenerateToken(UserAuthDTO userAuth)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes("AnPhan12121212!@#SuperSecretKey123456");



        // Create the token descriptor
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Email, userAuth.Email),
                new Claim(ClaimTypes.Name, userAuth.Username),
                new Claim(ClaimTypes.Role, userAuth.Role),
                new Claim(ClaimTypes.NameIdentifier, userAuth.Id),
            }),
            Expires = DateTime.UtcNow.AddHours(userAuth.ExpiryInHours), // Token expiration time
            //Issuer = "https://localhost:7025", // Issuer
            //Audience = "https://localhost:7025", // Audience
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        // Generate token
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token); // Return the token string
    }
}
