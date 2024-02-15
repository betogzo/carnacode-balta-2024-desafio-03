using System.ComponentModel.DataAnnotations;
using Imc.Models.Enums;

namespace Imc.Models;

public class CalcInput
{
    private const string RequiredErrorMessage = "O campo {0} é obrigatório.";
    
    [Required(ErrorMessage = RequiredErrorMessage)]
    [Range(1, 2.5, ErrorMessage = "A altura deve ser um valor entre 1 e 2.5")]
    public float? Altura { get; set; }
    
    [Required(ErrorMessage = RequiredErrorMessage)]
    [Range(5, 500, ErrorMessage = "O peso deve ser um valor entre 5 e 500")]
    public float? Peso { get; set; }
    
    public ESexo Sexo { get; set; }
}