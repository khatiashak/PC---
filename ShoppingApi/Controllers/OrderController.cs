using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModels;


namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/Order")]

public class OrderController : ControllerBase
{
    private readonly IGenericRepository<Order> _repository;

    public OrderController(IGenericRepository<Order> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets order by Id
    /// </summary>
    /// <param name="OrderId">identification number of order</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(OrderModel), 200)]
    public async Task<IActionResult> Get(int OrderId)
    {
        var orderData = await _repository.GetByIdAsync(OrderId);

        if (orderData == null)
        {
            return NotFound();
        }

        return Ok(new OrderModel
        {
            UserId = orderData.UserId,
            CartId = orderData.CartId,
            Date = orderData.Date
        });
    }

    /// <summary>
    /// deletes order
    /// </summary>
    /// <param name="OrderId">identification number of cart</param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> Delete(int OrderId)
    {
        _repository.Delete(OrderId);
        await _repository.SaveAsync();

        return Ok("Order deleted");
    }


    /// <summary>
    /// updates order
    /// </summary>
    /// <param name="OrderId">Cart object</param>
    /// <returns></returns>
    /// 
    [HttpPut]
    public async Task<IActionResult> Update(int OrderId, [FromBody] OrderModel updatedModel)
    {
        var CurrentValue = await _repository.GetByIdAsync(OrderId);

        // Check if the record exists
        if (CurrentValue == null)
        {
            return NotFound();
        }

        // Update the properties of the existing record with the new values
        CurrentValue.UserId = updatedModel.UserId;
        CurrentValue.CartId = updatedModel.CartId;
        CurrentValue.Date = updatedModel.Date;

        await _repository.SaveAsync();

        return Ok();
    }
    /// <summary>
    /// adds order
    /// </summary>
    /// <param name="OrderId">Order object</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddOrder(OrderModel Order)
    {
        Order ord = new Order
        {
            UserId = Order.UserId,
            CartId = Order.CartId,
            Date = Order.Date
        };
        await _repository.AddAsync(ord);
        await _repository.SaveAsync();

        return Created($"/api/Order/{ord.OrderId}", ord);
    }
<<<<<<< HEAD
}
=======


    /// <summary>
    /// returns the list of orders today by userid
    /// </summary>
    /// <param name="UserId">Order object</param>
    /// <returns></returns>


    [HttpGet]
    [ProducesResponseType(typeof(OrderModel), 200)]
    public async Task<IActionResult> GetOrderToday(int UserId)
    {
        var currentDate = DateTime.Today;
        var data = await _repository.GetByIdAsync(UserId);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new Order
        {

            UserId = data.UserId,
            CartId = data.CartId,
            Date = data.Date

        });

   // [HttpGet]
    //[ProducesResponseType(typeof(OrderModel), 200)]
    // IActionResult GetOrders(int userId, DateOnly date)
      //  {
      //      var orders = _repository.GetOrdersByUserIdAndDate(userId, date);
      //
      //      return Ok(orders);
      //  }
    }
}
