using System.Text;

namespace CodeGenerator;

public class CodeGenerator
{
    private static readonly List<string> CharacterSet = new()
        {"A", "C", "D", "E", "F", "G", "H", "K", "L", "M", "N", "P", "R", "T", "X", "Y", "Z", "2", "3", "4", "5", "7", "9"};
    
     public static List<string> GenerateCodes()
    {
        var random = new Random();
        var passList = new List<string>();
        for (var i = 0; i < 1000; i++)
        {
            var first = CharacterSet[random.Next(23)];
            var second = CharacterSet[random.Next(23)];
            var pass = new StringBuilder();
            pass.Append(first);
            pass.Append(second);
            for (var j = 0; j < 6; j++)
            {
                var firstEncoded = Encoding.ASCII.GetBytes(first)[0];
                var secondEncoded = Encoding.ASCII.GetBytes(second)[0];
                var randomAdd = random.Next(4);
                var calculatedNext = CharacterSet[(firstEncoded + secondEncoded) % 20 + randomAdd];
                pass.Append(calculatedNext);
                first = second;
                second = calculatedNext;
            }

            passList.Add(pass.ToString());
        }

        return passList;
    }

    public static bool CheckCode(string code)
    {
        if (code.Length != 8) return false;
        var first = code[0].ToString();
        var second = code[1].ToString();
        if (!CharacterSet.Contains(first) || !CharacterSet.Contains(second)) return false;

        for (var i = 2; i < 8; i++)
        {
            var current = code[i].ToString();
            if (!CharacterSet.Contains(code[i].ToString())) return false;
            var firstEncoded = Encoding.ASCII.GetBytes(first)[0];
            var secondEncoded = Encoding.ASCII.GetBytes(second)[0];
            var encodedTotal = (firstEncoded + secondEncoded) % 20;
            if (CharacterSet[encodedTotal] == current ||
                CharacterSet[encodedTotal + 1] == current ||
                CharacterSet[encodedTotal + 2] == current ||
                CharacterSet[encodedTotal + 3] == current)
            {
                first = second;
                second = current;
                continue;
            }

            return false;
        }

        return true;
    }
}