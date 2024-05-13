public class CodeManager
{
    public CodeManager() { }

    public string CrearCodigoPaciente(Code code)
    {
        string codeRes;

        codeRes = $"{code.Name[0]}{code.LastName[0]}-{code.CI}";

        return codeRes;
    }
}