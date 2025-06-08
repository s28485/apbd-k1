using Kolokwium_1.Data;
using Kolokwium_1.DTOs;

namespace Kolokwium_1.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _dbContext;

    public DbService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PurchasedTicketDto> GetPurchasedTicket(int userId)
    {
        //var client = await _dbContext.Clients.
        
        // var tickets = await _dbContext.PurchasedTickets.Select();

        return null;
    }
}