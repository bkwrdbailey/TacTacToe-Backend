using Microsoft.AspNetCore.Mvc;
using TicTacToeCRUD.Services;

namespace TicTacToeCRUD.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task getUser()
    {

    }
}