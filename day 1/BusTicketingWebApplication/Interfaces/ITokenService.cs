using BusTicketingWebApplication.Models.DTOs;
using BusTicketingWebApplication.Models.DTOs;

namespace BusTicketingWebApplication.Interfaces
{
    public interface ITokenService
    {
        string GetToken(UserDTO user);
    }
}
