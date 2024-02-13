using System.ComponentModel.DataAnnotations;

namespace Imc.Data;

public class CalcInput
{
    [Range(5, 500, ErrorMessage = "O peso deve ser um valor entre 5 e 500")]
    public float? Peso { get; set; }
    [Range(1, 2.5, ErrorMessage = "A altura deve ser um valor entre 1 e 2.5")]
    public float? Altura { get; set; }
    [RegularExpression("^[mMfF]$", ErrorMessage = "Apenas 'M' ou 'F' são permitidos no campo Sexo.")]
    public string Sexo { get; set; } = string.Empty;
}