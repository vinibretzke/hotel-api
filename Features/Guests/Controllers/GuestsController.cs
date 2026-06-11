using hotel_api.Features.Guests.Dtos;
using hotel_api.Features.Guests.Services;
using Microsoft.AspNetCore.Mvc;

namespace hotel_api.Features.Guests.Controllers;

/// <summary>
/// Endpoints de gerenciamento de hóspedes.
/// </summary>
[ApiController]
[Route("api/guests")]
public class GuestsController : ControllerBase
{
    private readonly IGuestService _guestService;

    public GuestsController(IGuestService guestService)
    {
        _guestService = guestService;
    }

    /// <summary>
    /// Obtém todos os hóspedes.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<GuestResponse>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<GuestResponse>>> GetAll()
    {
        var guests = await _guestService.GetAllGuestsAsync();
        return Ok(guests);
    }

    /// <summary>
    /// Obtém um hóspede pelo identificador.
    /// </summary>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GuestResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GuestResponse>> GetById(int id)
    {
        var guest = await _guestService.GetGuestByIdAsync(id);
        if (guest is null)
            return NotFound();

        return Ok(guest);
    }

    /// <summary>
    /// Cria um novo hóspede.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(typeof(GuestResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<GuestResponse>> Create([FromBody] CreateGuestRequest request)
    {
        var guest = await _guestService.CreateGuestAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = guest.Id }, guest);
    }

    /// <summary>
    /// Atualiza um hóspede existente.
    /// </summary>
    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(GuestResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GuestResponse>> Update(int id, [FromBody] UpdateGuestRequest request)
    {
        var guest = await _guestService.UpdateGuestAsync(id, request);
        if (guest is null)
            return NotFound();

        return Ok(guest);
    }

    /// <summary>
    /// Remove um hóspede.
    /// </summary>
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _guestService.DeleteGuestAsync(id);
        if (!deleted)
            return NotFound();

        return NoContent();
    }
}
