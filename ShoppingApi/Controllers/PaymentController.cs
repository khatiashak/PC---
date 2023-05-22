using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModel;
using ShoppingApi.ViewModels;

namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/Payment")]
public class PaymentController : ControllerBase
{
    private readonly IGenericRepository<Payment> _repository;

    public PaymentController(IGenericRepository<Payment> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets a Payment by id
    /// </summary>
    /// <param name="PaymentId">identification number of Payment</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(PaymentModel), 200)]
    public async Task<IActionResult> Get(int PaymentId)
    {
        var data = await _repository.GetByIdAsync(PaymentId);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new Payment
        {
            ProductId = data.ProductId,
            Quantity = data.Quantity,
            Amount = data.Amount,
            Date = data.Date,
            UserId = data.UserId

        });
    }

    public int PaymentId { get; set; }
    /// <summary>
    /// adds Payment
    /// </summary>
    /// <param name="PaymentId">User Accounts object</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddPayment(PaymentModel Payment)
    {
        Payment pa = new Payment
        {
            ProductId = Payment.ProductId,
            Quantity = Payment.Quantity,
            Amount = Payment.Amount,
            Date = Payment.Date,
            UserId = Payment.UserId
        };
        await _repository.AddAsync(pa);
        await _repository.SaveAsync();

        return Created($"/api/Payment/{pa.UserId}", pa);
    }
}