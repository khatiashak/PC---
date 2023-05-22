using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModel;
using ShoppingApi.ViewModels;

namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/UserTypes")]
public class UserTypesController : ControllerBase
{
    private readonly IGenericRepository<UserTypes> _repository;

    public UserTypesController(IGenericRepository<UserTypes> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets a type by id
    /// </summary>
    /// <param name="TypeID">identification number of type</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(UserTypesModel), 200)]
    public async Task<IActionResult> Get(int TypeID)
    {
        var data = await _repository.GetByIdAsync(TypeID);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new UserTypes
        {
            TypeID = data.TypeID,
            TypeName = data.TypeName,
            Description = data.Description

        });
    }


/// <summary>
/// adds user type
/// </summary>
/// <param name="TypeID">User Type object</param>
/// <returns></returns>
[HttpPost]
    public async Task<IActionResult> AddUserTypes(UserTypesModel UserTypes)
    {
        UserTypes use = new UserTypes
    {
            TypeName = UserTypes.TypeName,
            Description = UserTypes.Description
        };

        await _repository.AddAsync(use);
        await _repository.SaveAsync();

        return Created($"/api/UserTypes/{use.TypeID}", use);
    }
}