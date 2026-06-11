using hotel_api.Features.ReservationStatus.Dtos;
using hotel_api.Features.ReservationStatus.Services;
using Microsoft.AspNetCore.Mvc;

namespace hotel_api.Features.ReservationStatus.Controllers;

[ApiController]
[Route("api/reservation-statuses")]
public class ReservationStatusesController : ControllerBase
{
    private readonly IReservationStatusService _service;

    public ReservationStatusesController(IReservationStatusService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ReservationStatusResponse>>> GetAll()
    {
        var items = await _service.GetAllAsync();
        return Ok(items);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ReservationStatusResponse>> GetById(int id)
    {
        var item = await _service.GetByIdAsync(id);
        if (item is null) return NotFound();
        return Ok(item);
    }
}
