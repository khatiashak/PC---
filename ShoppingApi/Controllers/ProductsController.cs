using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModel;
using ShoppingApi.ViewModels;

namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/Products")]
public class ProductsController : ControllerBase
{
    private readonly IGenericRepository<Products> _repository;

    public ProductsController(IGenericRepository<Products> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets a product by id
    /// </summary>
    /// <param name="ProductId">identification number of a product</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(ProductsModel), 200)]
    public async Task<IActionResult> Get(int ProductId)
    {
        var data = await _repository.GetByIdAsync(ProductId);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new Products
        {
            CategoryID = data.CategoryID,
            Name = data.Name,
            Price = data.Price,
            Count = data.Count,
            Description = data.Description,
            UserId = data.UserId

        });
    }


    /// <summary>
    /// adds product
    /// </summary>
    /// <param name="ProductId">Products object</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddProductId(ProductsModel Products)
    {
        Products pro = new Products
        {
            CategoryID = Products.CategoryID,
            Name = Products.Name,
            Price = Products.Price,
            Count = Products.Count,
            Description = Products.Description,
            UserId = Products.UserId
        };
        await _repository.AddAsync(pro);
        await _repository.SaveAsync();

        return Created($"/api/Products/{pro.UserId}", pro);
    }
}