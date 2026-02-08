/*
    Exercício voltado à prática do uso de estruturas condicionais
    e operadores lógicos, simulando um programa capaz de identificar
    se três valores formam um triângulo e, em caso positivo, determinar
    o seu tipo.
*/
public static class Triangle
{
    // Verifica se os valores informados podem formar um triângulo válido
    public static bool IsTriangle(double side1, double side2, double side3)
    {
        if (side1 + side2 + side3 == 0) return false;

        return side1 + side2 > side3 &&
               side2 + side3 > side1 &&
               side1 + side3 > side2;
    }

    // Verifica se o triângulo é escaleno (todos os lados diferentes)
    public static bool IsScalene(double side1, double side2, double side3)
    {
        return IsTriangle(side1, side2, side3) &&
            (side1 != side2 && side2 != side3 && side1 != side3);
    }

    // Verifica se o triângulo é isósceles (dois lados iguais)
    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        return IsTriangle(side1, side2, side3) &&
            (side1 == side2 || side2 == side3 || side1 == side3);
    }

    // Verifica se o triângulo é equilátero (todos os lados iguais)
    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        return IsTriangle(side1, side2, side3) &&
            (side1 == side2 && side2 == side3);
    }
}