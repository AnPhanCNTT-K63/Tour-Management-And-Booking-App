using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToUserDTO(this User userModel)
        {
            return new UserDTO
            {
                Username = userModel.Username,
                Email = userModel.Email,
                Role = "user",
                CreatedAt = DateTime.Now,
            };
        }

        public static User ToUser(this CreateUserDTO userDTO)
        {
            return new User
            {
                Username = userDTO.Username,
                Email = userDTO.Email,
                Password = userDTO.Password,
                Role = "user",
            };
        }
    }
}
