namespace GhinImp;


// Класс для вычисления среднего показателя силы атаки
public class AttackCalculator
{
    // Метод для вычисления среднего показателя силы атаки
    public Func<IEnumerable<int>, int> AverageAttackCalculation = (attacks) =>
    {
        if (attacks.Count() != 0)
            return attacks.Sum() / attacks.Count();
        else
            return 0;
    };

    
    // Метод для вычисления среднего показателя силы атаки
    public double CalculateAverageAttack(Character character)
    {
        return AverageAttackCalculation(new List<int> { character.AttackPower });
    }
}