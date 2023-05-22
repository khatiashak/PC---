using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModel;


namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/Cart")]

public class CartController : ControllerBase 
{
    private readonly IGenericRepository<Cart> _repository;

    public CartController(IGenericRepository<Cart> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets a cart
    /// </summary>
    /// <param name="CartId">identification number of cart</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(CartModel), 200)]
    public async Task<IActionResult> Get(int CartId)
    {
        var data = await _repository.GetByIdAsync(CartId);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new CartModel
        {
            //ProductId = 12,
            //UserId=13,
            //Count=1
            ProductId = data.ProductId,
            UserId = data.UserId,
            Count = data.Count
        }) ;
    }

    /// <summary>
    /// deletes a cart
    /// </summary>
    /// <param name="CartId">identification number of cart</param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> Delete(int CartId)
    {
        _repository.Delete(CartId);
        await _repository.SaveAsync();

        return Ok("Cart deleted");
    }


    /// <summary>
    /// updates cart
    /// </summary>
    /// <param name="CartId">Cart object</param>
    /// <returns></returns>
    /// 
    [HttpPut]
    public async Task<IActionResult> Update(int CartId, [FromBody]CartModel updatedModel)
    {
        var CurrentValue = await _repository.GetByIdAsync(CartId);

        // Check if the record exists
        if (CurrentValue == null)
        {
            return NotFound();
        }

        // Update the properties of the existing record with the new values
        CurrentValue.ProductId = updatedModel.ProductId;
        CurrentValue.UserId = updatedModel.UserId;
        CurrentValue.Count = updatedModel.Count;

        await _repository.SaveAsync();

        return Ok();
    }
    /// <summary>
    /// adds cart
    /// </summary>
    /// <param name="CartId">Cart object</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddCart(CartModel Cart)
    {
        Cart ca = new Cart
        {
            ProductId = Cart.ProductId,
            UserId = Cart.UserId,
            Count = Cart.Count
        };
        await _repository.AddAsync(ca);
        await _repository.SaveAsync();

        return Created($"/api/Cart/{ca.CartId}", ca);
    }
}