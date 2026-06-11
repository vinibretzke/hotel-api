using hotel_api.Features.Rooms.Dtos;
using hotel_api.Features.Rooms.Services;
using Microsoft.AspNetCore.Mvc;

namespace hotel_api.Features.Rooms.Controllers;

[ApiController]
[Route("api/rooms")]
public class RoomsController : ControllerBase
{
    private readonly IRoomService _roomService;

    public RoomsController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<RoomResponse>>> GetAll()
    {
        var rooms = await _roomService.GetAllRoomsAsync();
        return Ok(rooms);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<RoomResponse>> GetById(int id)
    {
        var room = await _roomService.GetRoomByIdAsync(id);
        if (room is null) return NotFound();
        return Ok(room);
    }

    [HttpPost]
    public async Task<ActionResult<RoomResponse>> Create([FromBody] CreateRoomRequest request)
    {
        var room = await _roomService.CreateRoomAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = room.Id }, room);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<RoomResponse>> Update(int id, [FromBody] UpdateRoomRequest request)
    {
        var room = await _roomService.UpdateRoomAsync(id, request);
        if (room is null) return NotFound();
        return Ok(room);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _roomService.DeleteRoomAsync(id);
        if (!deleted) return NotFound();
        return NoContent();
    }
}
