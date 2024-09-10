namespace GhinImp;

// Класс для описания навыков персонажей
public class Skill
{
    private string SkillName;
    private int Damage;
    
    public Skill()
    {
        SkillName = "Unnamed Skill";
        Damage = 0;
    }

    public Skill(string Name, int d)
    {
        SkillName = Name;
        Damage = d;
    }

    // Метод для расчета урона навыка
    public int GetSkillDamage()
    {
        return Damage;
    }

    public void SetSkillDamage(int d)
    {
        Damage = d;
    }
}