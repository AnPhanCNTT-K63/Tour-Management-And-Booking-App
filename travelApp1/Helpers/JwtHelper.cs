using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

public class JwtHelper
{
    public static Dictionary<string, object> DecodeJwt(string token)
    {
        try
        {
            // Create a JwtSecurityTokenHandler
            var handler = new JwtSecurityTokenHandler();

            // Read the JWT
            var jwtToken = handler.ReadJwtToken(token);

            // Decode the payload (claims)
            var claims = jwtToken.Payload;

            // Convert to a dictionary and return
            return claims.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error decoding JWT: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }
}
