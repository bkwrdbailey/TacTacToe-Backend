using Microsoft.EntityFrameworkCore;

namespace TicTacToeCRUD.DatabaseRepo;

public class UserDbCalls : IUserDbCalls
{
    private readonly DBContext _context;
    public UserDbCalls(DBContext context)
    {
        _context = context;
    }
}