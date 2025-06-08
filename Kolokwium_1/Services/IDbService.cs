using Kolokwium_1.DTOs;

namespace Kolokwium_1.Services;

public interface IDbService
{
    Task<PurchasedTicketDto> GetPurchasedTicket(int userId);
}