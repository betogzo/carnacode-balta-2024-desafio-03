using Imc.Models;
using Math = System.Math;

namespace Imc.Services;

public class CalculadoraImc
{
    public float Calcula(float altura, float peso)
    {
        return (float)Math.Round((float)(peso / Math.Pow(altura, 2)), 2);
    }

    public ImcResult GeraResultadoInfo(float resultado)
    {
        if (resultado < 16)
            return new ImcResult(resultado, "Magreza grave", "Cuidado! Você está com o IMC muito baixo.");
        if (resultado is >= 16 and < 17)
            return new ImcResult(resultado, "Magreza moderada", "Atenção! Você está com o IMC baixo.");
        if (resultado is >= 17 and < 18.5f)
            return new ImcResult(resultado, "Magreza leve", "Atenção! Seu IMC está ligeiramente baixo.");
        if (resultado is >= 18.5f and < 25)
            return new ImcResult(resultado, "Saudável", "Parabéns! Seu IMC é considerado saudável!");
        if (resultado is >= 25 and < 30)
            return new ImcResult(resultado, "Sobrepeso", "Atenção! Seu IMC indica que você está acima do peso.");
        if (resultado is >= 30 and < 35)
            return new ImcResult(resultado, "Obesidade Grau I", "Cuidado! Seu IMC indica obesidade moderada.");
        if (resultado is >= 35 and < 40)
            return new ImcResult(resultado, "Obesidade Grau II", "Cuidado! Seu IMC indica obesidade severa.");
        if (resultado is >= 40)
            return new ImcResult(resultado, "Obesidade Grau III", "CUIDADO! Seu IMC já indica obesidade mórbida.");

        return new ImcResult(0f, "ERRO", "Verifique a altura e o peso informado.");
    }
}