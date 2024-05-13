public class Code
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int CI { get; set; }

    public Code(string name, string lastName, int cI)
    {
        Name = name;
        LastName = lastName;
        CI = cI;
    }
}