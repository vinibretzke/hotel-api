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
    /// <example>1</example>
    [Required(ErrorMessage = "O ID é obrigatório")]
    public int Id { get; set; }

}