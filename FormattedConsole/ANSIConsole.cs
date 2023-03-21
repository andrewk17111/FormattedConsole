using System.Text.RegularExpressions;

namespace FormattedConsole;

public static class ANSIConsole
{
    private static readonly Dictionary<string, byte> ANSI_CODES = new Dictionary<string, byte>
    {
        { "reset", 0 },
        { "bold", 1 },
        { "intense", 1 },
        { "faint", 2 },
        { "dim", 2 },
        { "dark", 2 },
        { "italic", 3 },
        { "underline", 4 },
        { "slowblink", 5 },
        { "fastblink", 6 },
        { "reverse", 7 },
        { "invert", 7 },
        { "conceal", 8 },
        { "hide", 8 },
        { "crossed", 9 },
        { "strike", 9 },
        { "dunderline", 21 },
        { "rintensity", 22 },
        { "ritalic", 23 },
        { "runderline", 24 },
        { "rblink", 25 },
        { "rreverse", 27 },
        { "rinvert", 27 },
        { "reveal", 28 },
        { "rcrossed", 29 },
        { "rstrike", 29 },
        { "fg1", 30 },
        { "fgblack", 30 },
        { "fg2", 31 },
        { "fgred", 31 },
        { "fg3", 32 },
        { "fggreen", 32 },
        { "fg4", 33 },
        { "fgyellow", 33 },
        { "fg5", 34 },
        { "fgblue", 34 },
        { "fg6", 35 },
        { "fgmagenta", 35 },
        { "fg7", 36 },
        { "fgcyan", 36 },
        { "fg8", 37 },
        { "fgwhite", 37 },
        { "fgx", 38 },
        { "fgrgb", 38 },
        { "fg", 39 },
        { "fg0", 39 },
        { "bg1", 40 },
        { "bgblack", 40 },
        { "bg2", 41 },
        { "bgred", 41 },
        { "bg3", 42 },
        { "bggreen", 42 },
        { "bg4", 43 },
        { "bgyellow", 43 },
        { "bg5", 44 },
        { "bgblue", 44 },
        { "bg6", 45 },
        { "bgmagenta", 45 },
        { "bg7", 46 },
        { "bgcyan", 46 },
        { "bg8", 47 },
        { "bgwhite", 47 },
        { "bgx", 48 },
        { "bgrgb", 48 },
        { "bg", 49 },
        { "bg0", 49 },
        { "overline", 53 },
        { "roverline", 55 },
        { "fg9", 90 },
        { "fgbrightblack", 90 },
        { "fggrey", 90 },
        { "fggray", 90 },
        { "fg10", 91 },
        { "fgbrightred", 91 },
        { "fg11", 92 },
        { "fgbrightgreen", 92 },
        { "fg12", 93 },
        { "fgbrightyellow", 93 },
        { "fg13", 94 },
        { "fgbrightblue", 94 },
        { "fg14", 95 },
        { "fgbrightmagenta", 95 },
        { "fg15", 96 },
        { "fgbrightcyan", 96 },
        { "fg16", 97 },
        { "fgbrightwhite", 97 },
        { "bg9", 100 },
        { "bgbrightblack", 100 },
        { "bggrey", 100 },
        { "bggray", 100 },
        { "bg10", 101 },
        { "bgbrightred", 101 },
        { "bg11", 102 },
        { "bgbrightgreen", 102 },
        { "bg12", 103 },
        { "bgbrightyellow", 103 },
        { "bg13", 104 },
        { "bgbrightblue", 104 },
        { "bg14", 105 },
        { "bgbrightmagenta", 105 },
        { "bg15", 106 },
        { "bgbrightcyan", 106 },
        { "bg16", 107 },
        { "bgbrightwhite", 107 }
    };

    public static string[] FORMAT_TAGS
        => ANSI_CODES.Keys.ToArray();

    public static void Write(string text)
        => Console.Write(FormatString(text));

    public static void WriteLine(string text)
        => Console.WriteLine(FormatString(text));

    /// <summary>
    /// Replaces format tags with their corresponding ANSI escape codes.
    /// </summary>
    /// <param name="text">The text to be formatted.</param>
    /// <returns>A string with the proper ANSI escape codes.</returns>
    public static string FormatString(string text)
        => Regex.Replace(text, @"\{[A-Za-z0-9;,]+\}", new MatchEvaluator(ReplaceTag), RegexOptions.IgnoreCase);

    /// <summary>
    /// Replaces the format tag with the proper ANSI escape code.
    /// </summary>
    /// <param name="match">The matched format tag.</param>
    /// <returns>The ANSI escape code to apply the proper formats.</returns>
    private static string ReplaceTag(Match match)
    {
        string clean = Regex.Replace(match.Value, @"[\{\}\s]", "").Replace(',', ';');
        string[] tags = clean.Split(';');

        for (int i = 0; i < tags.Length; i++)
        {
            if (ANSI_CODES.ContainsKey(tags[i]))
                tags[i] = ANSI_CODES[tags[i]].ToString();
            else if (!Byte.TryParse(tags[i], out _))
                // TODO Implement exception.
                continue;
        }

        return $"\u001b[{String.Join(";", tags)}m";
    }
}
