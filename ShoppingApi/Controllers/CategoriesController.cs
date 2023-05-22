using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModel;
using ShoppingApi.ViewModels;

namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/Categories")]
public class CategoriesController : ControllerBase
{
    private readonly IGenericRepository<Categories> _repository;

    public CategoriesController(IGenericRepository<Categories> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets a user account by id
    /// </summary>
    /// <param name="CategoryId">identification number of user</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(CategoriesModel), 200)]
    public async Task<IActionResult> Get(int CategoryId)
    {
        var data = await _repository.GetByIdAsync(CategoryId);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new Categories
        {
            
            CategoryName = data.CategoryName,
            Description = data.Description

        });
    }

    /// <summary>
    /// adds category
    /// </summary>
    /// <param name="CategoryId">Categories object</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddCategory(CategoriesModel Categories)
    {
        Categories cat = new Categories
        {
            CategoryName = Categories.CategoryName,
            Description = Categories.Description
        };
        await _repository.AddAsync(cat);
        await _repository.SaveAsync();

        return Created($"/api/Categories/{cat.CategoryId}", cat);
    }
}