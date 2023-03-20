using FormattedConsole;

namespace FormattedConsoleTest;

[TestClass]
public class ConsoleTest
{
    [TestMethod]
    public void WriteTest()
    {
        ANSIConsole.Write("Hello, World!");
    }
}