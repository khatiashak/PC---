using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModel;
using ShoppingApi.ViewModels;

namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/Transaction")]
public class TransactionController : ControllerBase
{
    private readonly IGenericRepository<Transaction> _repository;

    public TransactionController(IGenericRepository<Transaction> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets a Transaction by id
    /// </summary>
    /// <param name="TransactionId">identification number of Transaction</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(UserAccountsModel), 200)]
    public async Task<IActionResult> Get(int TransactionId)
    {
        var data = await _repository.GetByIdAsync(TransactionId);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new Transaction
        {
            TransactionType = data.TransactionType,
            Description = data.Description,
            UserId = data.UserId,
            Date = data.Date

        });
    }

    /// <summary>
    /// adds transaction
    /// </summary>
    /// <param name="TransactionId">Transaction object</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddCart(TransactionModel Transaction)
    {
        Transaction tra = new Transaction
        {
            TransactionType = Transaction.TransactionType,
            Description = Transaction.Description,
            UserId = Transaction.UserId,
            Date = Transaction.Date
.Date
        };
        await _repository.AddAsync(tra);
        await _repository.SaveAsync();

        return Created($"/api/Transaction/{tra.UserId}", tra);
    }
}