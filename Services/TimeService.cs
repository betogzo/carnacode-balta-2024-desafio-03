namespace Imc.Services;

public class TimeService
{
    public string GetPassedTime(DateTime data)
    {
        TimeSpan diferenca = DateTime.Now - data;

        if (diferenca.TotalHours < 1)
        {
            int minutosPassados = (int)diferenca.TotalMinutes;
            return $"há {minutosPassados}m atrás";
        }
        else if (diferenca.TotalHours < 24)
        {
            int horasPassadas = (int)diferenca.TotalHours;
            return $"há {horasPassadas}h atrás";
        }
        else
        {
            return data.ToString("dd-MM-yy");
        }
    }
}


