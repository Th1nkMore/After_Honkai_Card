public class Card
{
    public string name;
    public Card(string _name)
    {
        this.name = _name;
    }
}
public class MonsterCard : Card
{
    public int HealthPointMax;
    public int HealthPoint;
    public float MissRate;
    public MonsterCard(string _name, int _HealthPointMax, float _Missrate): base(_name)
    {
        this.HealthPointMax = _HealthPointMax;
        this.HealthPoint = _HealthPointMax;
        this.MissRate = _Missrate;
    }
}

public class CharacterCard : Card
{
    public int HealthPointMax;
    public int HealthPoint;
    public float MissRate;
    public int defence;
    public int attack;
    public CharacterCard(string _name, int _HealthPointMax, float _Missrate, int _defence, int _attack): base(_name)
    {
        this.HealthPointMax = _HealthPointMax;
        this.HealthPoint = _HealthPointMax;
        this.MissRate = _Missrate;
        this.defence = _defence;
        this.attack = _attack;
    }
}