
public class Character
{
    private string name;
    private int health;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            if (value > 100)
                health = 100;
            else if (value < 0)
                health = 0;
            else
                health = value;
        }
    }

    public Character(string n, int h)
    {
        this.name = n;
        this.health = h;
    }
}
