namespace FormattedConsole;

public static class ANSICodes
{
    public const string reset = "\u001b[0m";
    public const string bold = "\u001b[1m";
    public const string intense = bold;
    public const string faint = "\u001b[2m";
    public const string dim = faint;
    public const string dark = faint;
    public const string italic = "\u001b[3m";
    public const string underline = "\u001b[4m";
    public const string slowblink = "\u001b[5m";
    public const string fastblink = "\u001b[6m";
    public const string reverse = "\u001b[7m";
    public const string invert = reverse;
    public const string conceal = "\u001b[8m";
    public const string hide = conceal;
    public const string crossed = "\u001b[9m";
    public const string strike = crossed;
    public const string dunderline = "\u001b[21m";
    public const string rintensity = "\u001b[22m";
    public const string ritalic = "\u001b[23m";
    public const string runderline = "\u001b[24m";
    public const string rblink = "\u001b[25m";
    public const string rreverse = "\u001b[27m";
    public const string rinvert = rreverse;
    public const string reveal = "\u001b[28m";
    public const string rcrossed = "\u001b[29m";
    public const string rstrike = rcrossed;
    public const string fg1 = "\u001b[30m";
    public const string fgblack = fg1;
    public const string fg2 = "\u001b[31m";
    public const string fgred = fg2;
    public const string fg3 = "\u001b[32m";
    public const string fggreen = fg3;
    public const string fg4 = "\u001b[33m";
    public const string fgyellow = fg4;
    public const string fg5 = "\u001b[34m";
    public const string fgblue = fg5;
    public const string fg6 = "\u001b[35m";
    public const string fgmagenta = fg6;
    public const string fg7 = "\u001b[36m";
    public const string fgcyan = fg7;
    public const string fg8 = "\u001b[37m";
    public const string fgwhite = fg8;
    public const string fg = "\u001b[39m";
    public const string fg0 = fg;
    public const string bg1 = "\u001b[40m";
    public const string bgblack = bg1;
    public const string bg2 = "\u001b[41m";
    public const string bgred = bg2;
    public const string bg3 = "\u001b[42m";
    public const string bggreen = bg3;
    public const string bg4 = "\u001b[43m";
    public const string bgyellow = bg4;
    public const string bg5 = "\u001b[44m";
    public const string bgblue = bg5;
    public const string bg6 = "\u001b[45m";
    public const string bgmagenta = bg6;
    public const string bg7 = "\u001b[46m";
    public const string bgcyan = bg7;
    public const string bg8 = "\u001b[47m";
    public const string bgwhite = bg8;
    public const string bg = "\u001b[49m";
    public const string bg0 = bg;
    public const string overline = "\u001b[53m";
    public const string roverline = "\u001b[55m";
    public const string fg9 = "\u001b[90m";
    public const string fgbrightblack = fg9;
    public const string fggrey = fg9;
    public const string fggray = fg9;
    public const string fg10 = "\u001b[91m";
    public const string fgbrightred = fg10;
    public const string fg11 = "\u001b[92m";
    public const string fgbrightgreen = fg11;
    public const string fg12 = "\u001b[93m";
    public const string fgbrightyellow = fg12;
    public const string fg13 = "\u001b[94m";
    public const string fgbrightblue = fg13;
    public const string fg14 = "\u001b[95m";
    public const string fgbrightmagenta = fg14;
    public const string fg15 = "\u001b[96m";
    public const string fgbrightcyan = fg15;
    public const string fg16 = "\u001b[97m";
    public const string fgbrightwhite = fg16;
    public const string bg9 = "\u001b[100m";
    public const string bgbrightblack = bg9;
    public const string bggrey = bg9;
    public const string bggray = bg9;
    public const string bg10 = "\u001b[101m";
    public const string bgbrightred = bg10;
    public const string bg11 = "\u001b[102m";
    public const string bgbrightgreen = bg11;
    public const string bg12 = "\u001b[103m";
    public const string bgbrightyellow = bg12;
    public const string bg13 = "\u001b[104m";
    public const string bgbrightblue = bg13;
    public const string bg14 = "\u001b[105m";
    public const string bgbrightmagenta = bg14;
    public const string bg15 = "\u001b[106m";
    public const string bgbrightcyan = bg15;
    public const string bg16 = "\u001b[107m";
    public const string bgbrightwhite = bg16;

    public static string ForegroundRgb(byte r, byte g, byte b)
        => $"\u001b[38;2;{r};{g};{b}m";

    public static string ForegroundN(byte n)
        => $"\u001b[38;5;{n}m";

    public static string BackgroundRgb(byte r, byte g, byte b)
        => $"\u001b[48;2;{r};{g};{b}m";

    public static string BackgroundN(byte n)
        => $"\u001b[48;5;{n}m";
}
