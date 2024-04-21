using API.Contracts.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator mediator;
    public UsersController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public Task<IActionResult> Getall()
    {

    }

    [HttpGet("id")]
    public Task<IActionResult> GetById(Guid userId)
    {

    }

    [HttpGet("email")]
    public Task<IActionResult> GetByEmail(string userEmail)
    {

    }

    [HttpGet("userName")]
    public Task<IActionResult> GetByUsreName(string userName)
    {

    }

    [HttpPost]
    public Task<IActionResult> Post(CreateUserRequest request)
    {
        
    }

    [HttpPut]
    public Task<IActionResult> Put(UpdateUserRequest request)
    {

    }
    [HttpGet]
    public Task<IActionResult> Delete(Guid userId)
    {

    }
}
