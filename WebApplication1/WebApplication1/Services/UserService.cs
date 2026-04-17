using WebApplication1.Data;
using WebApplication1.Models;
using System.Collections.Generic;
using System.Linq;

public class UserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;
    }

    // GET ALL USERS
    public List<User> GetAllUsers()
    {
        return _context.Users.ToList();
    }

    // GET USER BY ID
    public User GetUserById(int id)
    {
        return _context.Users.FirstOrDefault(x => x.Id == id);
    }
}