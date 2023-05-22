using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModel;
using ShoppingApi.ViewModels;

namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/UserAccounts")]
public class UserAccountsController : ControllerBase
{
    private readonly IGenericRepository<UserAccounts> _repository;

    public UserAccountsController(IGenericRepository<UserAccounts> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets a user account by id
    /// </summary>
    /// <param name="UserId">identification number of user</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(UserAccountsModel), 200)]
    public async Task<IActionResult> Get(int UserId)
    {
        var data = await _repository.GetByIdAsync(UserId);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new UserAccounts
        {
            TypeId = data.TypeId,
            Name = data.Name,
            Age = data.Age,
            Gender = data.Gender,
            Address = data.Address,
            ContactNumber = data.ContactNumber,
            UserName = data.UserName,
            Password = data.Password

        });
    }

    /// <summary>
    /// adds user
    /// </summary>
    /// <param name="UserId">User Accounts object</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddCart(UserAccountsModel UserAccounts)
    {
        UserAccounts us = new UserAccounts
        {
            TypeId = UserAccounts.TypeId,
            Name = UserAccounts.Name,
            Age = UserAccounts.Age,
            Gender = UserAccounts.Gender,
            Address = UserAccounts.Address,
            ContactNumber = UserAccounts.ContactNumber,
            UserName = UserAccounts.UserName,
            Password = UserAccounts.Password
        };
        await _repository.AddAsync(us);
        await _repository.SaveAsync();

        return Created($"/api/Cart/{us.UserId}", us);
    }
}