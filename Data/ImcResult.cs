namespace Imc.Data;

public class ImcResult
{
    public float ImcValue { get; set; }
    public string ImcResultTitle { get; set; } = string.Empty;
    public string ImcResultInfo { get; set; } = string.Empty;
    public DateTime CalculatedAt { get; set; } = DateTime.Now;

    public ImcResult()
    {
        
    }

    public ImcResult(float imcvalue, string resulttitle, string resultinfo)
    {
        ImcValue = imcvalue;
        ImcResultTitle = resulttitle;
        ImcResultInfo = resultinfo;
    }
}


