namespace GhinImp;

// Record для хранения данных о персонаже

public record Character
{
    public string Name { get; init; }
    public int totalDamage = 0;
    public string Element { get; }
    public int AttackPower { get; init; }
    public List<Skill> Skills;

    public Character(string name, string element, int attackPower, List<Skill> skills)
    {
        Name = name;
        Element = element;
        AttackPower = attackPower;
        Skills = skills;
    }

    // Метод для проверки силы атаки
    public bool IsPowerful()
    {
        return AttackPower > 80;
    }
    
    public int CalculateTotalSkillDamage()
    {
        foreach (var skill in Skills)
        {
            totalDamage += skill.GetSkillDamage();
        }
        return totalDamage;
    }
}