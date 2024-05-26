namespace CodeGenerator;

class Program
{
    static void Main(string[] args)
    {
        var passCodes = CodeGenerator.GenerateCodes();
        // Oluşturulan kodların kontrolü
        foreach (var pass in passCodes)
        {
            Console.WriteLine(CodeGenerator.CheckCode(pass));
        }
    }
}