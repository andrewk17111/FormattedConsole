using FormattedConsole;
using System.Text.RegularExpressions;

namespace FormattedConsoleTest;

[TestClass]
public class ConsoleTest
{
    [TestMethod]
    public void TestFormatString()
    {
        byte previous_code = 0;

        foreach (string key in ANSIConsole.FORMAT_TAGS)
        {
            string formatted_string = ANSIConsole.FormatString($"{{{key}}}abc{{reset}}");
            byte code = Convert.ToByte(formatted_string.Replace("ESC[", "").Replace("mabc0m", ""));

            Assert.IsTrue(Regex.IsMatch(formatted_string, @"ESC\[\d+(;\d+)*m"), formatted_string);
            Assert.IsTrue(code >= previous_code, code.ToString());
            Console.WriteLine(formatted_string);
            previous_code = code;
        }
    }
}