using FormattedConsole;
using System.Text.RegularExpressions;

namespace FormattedConsoleTest;

[TestClass]
public class ConsoleTest
{
    [TestMethod]
    public void TestFormatStringSingleTags()
    {
        byte previous_code = 0;

        foreach (string key in ANSIConsole.FORMAT_TAGS)
        {
            string formatted_string = ANSIConsole.FormatString($"{{{key}}}abc{{reset}}");
            byte code = Convert.ToByte(formatted_string.Replace("\u001b[", "").Replace("mabc0m", ""));

            Assert.IsTrue(Regex.IsMatch(formatted_string, @"\u001b\[\d+(;\d+)*m"), formatted_string);
            Assert.IsTrue(code >= previous_code, code.ToString());
            Console.WriteLine(formatted_string);
            previous_code = code;
        }
    }

    [TestMethod]
    public void TestFormatStringMultipleTags()
    {
        Random rand = new Random();

        for (int i = 0; i < ANSIConsole.FORMAT_TAGS.Length; i++)
        {
            string key = ANSIConsole.FORMAT_TAGS[i];
            string key2 = ANSIConsole.FORMAT_TAGS[rand.Next(ANSIConsole.FORMAT_TAGS.Length)];
            string key3 = ANSIConsole.FORMAT_TAGS[rand.Next(ANSIConsole.FORMAT_TAGS.Length)];
            string formatted_string = ANSIConsole.FormatString($"{{{key};{key2},{key3}}}abc{{reset}}");

            Assert.IsTrue(Regex.IsMatch(formatted_string, @"\u001b\[\d+(;\d+)*m"), formatted_string);
            Console.WriteLine(formatted_string);
        }
    }
}