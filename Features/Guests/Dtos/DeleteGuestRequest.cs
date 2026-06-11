using System.ComponentModel.DataAnnotations;

namespace hotel_api.Features.Guests.Dtos;

/// <summary>
/// Dados necessários para deletar um hospede.
/// </summary>
public class DeleteGuestRequest
{
    /// <summary>
    /// ID do hóspede.
    /// </summary>
    /// <example>3fa85f64-5717-4562-b3fc-2c963f66afa6</example>
    [Required(ErrorMessage = "O ID é obrigatório")]
    public Guid Id { get; set; }

}