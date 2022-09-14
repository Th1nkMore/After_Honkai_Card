public class Skill{
    public string name;
    public string Cosume;
    public int Damage;
    public int Cure;
    public string Description;
    public int[] AllowedPoint;

    public Skill(string _name, string _Consume, int _Damage, int _Cure, string _Description)
    {
        this.name = _name;
        this.Cosume = _Consume;
        this.Damage = _Damage;
        this.Description = _Description;
        this.Cure = _Cure;
    }
    public bool ValidUsage(int _input)
    {
        switch(this.Cosume.Length)
        {
            case 0:
                break;
            case 1:
                if(!_input.ToString().Equals(this.Cosume)) return false;
                break;
            case 2:
                
                break;
            default:
                break;
        }
        return true;
    }

}