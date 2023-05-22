using ShoppingApi.Models;
using ShoppingApi.Repository;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.ViewModel;
using ShoppingApi.ViewModels;

namespace ShoppingApi.Controllers;

[ApiController]
[Route("api/Deliveries")]
public class DeliveriesController : ControllerBase
{
    private readonly IGenericRepository<Deliveries> _repository;

    public DeliveriesController(IGenericRepository<Deliveries> repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// gets a user account by id
    /// </summary>
    /// <param name="DeliveryId">identification number of user</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(DeliveriesModel), 200)]
    public async Task<IActionResult> Get(int DeliveryId)
    {
        var data = await _repository.GetByIdAsync(DeliveryId);

        if (data == null)
        {
            return NotFound();
        }

        return Ok(new Deliveries
        {
            UserId = data.UserId,
            Date = data.Date

        });
    }

    /// <summary>
    /// adds delivery
    /// </summary>
    /// <param name="DeliveryId">Deliveries object</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddDeliveries(DeliveriesModel Deliveries)
    {
        Deliveries de = new Deliveries
        {
            UserId = Deliveries.UserId,
            Date = Deliveries.Date
        };
        await _repository.AddAsync(de);
        await _repository.SaveAsync();

        return Created($"/api/Deliveries/{de.DeliveryId}", de);
    }
}