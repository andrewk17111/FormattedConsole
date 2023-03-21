# FormattedConsole
Adds functionality to the console to allow for embedded color and format tags for console output. This ia a personal project and is not intended for use in production environments. This project does not come with any warranty or support.

ANSI Code | Name(s) | Tag Code(s) | Windows Terminal | Ubuntu
--- | --- | --- | --- | ---
0 | Reset or normal | reset | Reset | Reset
1 | Bold/Increased intensity | bold, intense | Bright | Bold
2 | Faint/Decreased intensity/Dim | faint, dim, dark | Dark | Dark
3 | Italic | italic | Italics | Italics
4 | Underline | underline | Underline | Underline
5 | Slow blink | slowblink | Blink | Blink
6 | Rapid blink | fastblink | Blink | Blink
7 | Reverse video/Invert | reverse, invert | Invert | Invert
8 | Conceal/Hide | conceal, hide | Conceal | Conceal
9 | Crossed-Out/Strike | crossed, strike | Strike | Strike
21 | Double Underline | dunderline | Double Underline | Double Underline
22 | Normal intensity | rintensity | Normal Intensity | Normal Intensity
23 | Neither italic, nor blackletter | ritalic | Not Italic | Not Italic
24 | Not underlined | runderline | Not Underlined | Not Underlined
25 | Not blinking | rblink | Not Blinking | Not Blinking
27 | Not reversed | rreverse, rinvert | Not Reversed | Not Reversed
28 | Reveal | reveal | Not Concealed | Not Concealed
29 | Not crossed out | rcrossed, rstrike | Not Striked | Not Striked
30 | Set foreground color 1 | fg1, fgblack | Foreground Color 1 (Black) | Foreground Color 1 (Black)
31 | Set foreground color 2 | fg2, fgred | Foreground Color 2 (Red) | Foreground Color 2 (Red)
32 | Set foreground color 3 | fg3, fggreen | Foreground Color 3 (Green) | Foreground Color 3 (Green)
33 | Set foreground color 4 | fg4, fgyellow | Foreground Color 4 (Yellow) | Foreground Color 4 (Yellow)
34 | Set foreground color 5 | fg5, fgblue | Foreground Color 5 (Blue) | Foreground Color 5 (Blue)
35 | Set foreground color 6 | fg6, fgmagenta | Foreground Color 6 (Magenta) | Foreground Color 6 (Magenta)
36 | Set foreground color 7 | fg7, fgcyan | Foreground Color 7 (Cyan) | Foreground Color 7 (Cyan)
37 | Set foreground color 8 | fg8, fgwhite | Foreground Color 8 (White) | Foreground Color 8 (White)
38 | Set foreground color | fgx, fgrgb | Set Foreground Color (0-255 or rgb) | Set Foreground Color (0-255 or rgb)
39 | Default foreground color | fg, fg0 | Default Foreground Color | Default Foreground Color
40 | Set background color 1 | bg1, bgblack | Background Color 1 (Black) | Background Color 1 (Black)
41 | Set background color 2 | bg2, bgred | Background Color 2 (Red) | Background Color 2 (Red)
42 | Set background color 3 | bg3, bggreen | Background Color 3 (Green) | Background Color 3 (Green)
43 | Set background color 4 | bg4, bgyellow | Background Color 4 (Yellow) | Background Color 4 (Yellow)
44 | Set background color 5 | bg5, bgblue | Background Color 5 (Blue) | Background Color 5 (Blue)
45 | Set background color 6 | bg6, bgmagenta | Background Color 6 (Magenta) | Background Color 6 (Purple)
46 | Set background color 7 | bg7, bgcyan | Background Color 7 (Cyan) | Background Color 7 (Cyan)
47 | Set background color 8 | bg8, bgwhite | Background Color 8 (White) | Background Color 8 (White)
48 | Set background color | bgx, bgrgb | Set Background Color (0-255 or rgb) | Set Background Color (0-255 or rgb)
49 | Default background color | bg, bg0 | Default Background Color | Default Background Color
53 | Overlined | overline | Overline | Overline
55 | Not overlined | roverline | Not Overlined | Not Overlined
90 | Set foreground color 9 | fg9, fgbrightblack, fggrey, fggray | Foreground Color 9 (Bright Black) | Foreground Color 9 (Bright Black)
91 | Set foreground color 10 | fg10, fgbrightred | Foreground Color 10 (Bright Red) | Foreground Color 10 (Bright Red)
92 | Set foreground color 11 | fg11, fgbrightgreen | Foreground Color 11 (Bright Green) | Foreground Color 11 (Bright Green)
93 | Set foreground color 12 | fg12, fgbrightyellow | Foreground Color 12 (Bright Yellow) | Foreground Color 12 (Bright Yellow)
94 | Set foreground color 13 | fg13, fgbrightblue | Foreground Color 13 (Bright Blue) | Foreground Color 13 (Bright Blue)
95 | Set foreground color 14 | fg14, fgbrightmagenta | Foreground Color 14 (Bright Magenta) | Foreground Color 14 (Bright Purple)
96 | Set foreground color 15 | fg15, fgbrightcyan | Foreground Color 15 (Bright Cyan) | Foreground Color 15 (Bright Cyan)
97 | Set foreground color 16 | fg16, fgbrightwhite | Foreground Color 16 (Bright White) | Foreground Color 16 (Bright White)
100 | Set background color 9 | bg9, bgbrightblack, bggrey, bggray | Background Color 9 (Bright Black) | Background Color 9 (Bright Black)
101 | Set background color 10 | bg10, bgbrightred | Background Color 10 (Bright Red) | Background Color 10 (Bright Red)
102 | Set background color 11 | bg11, bgbrightgreen | Background Color 11 (Bright Green) | Background Color 11 (Bright Green)
103 | Set background color 12 | bg12, bgbrightyellow | Background Color 12 (Bright Yellow) | Background Color 12 (Bright Yellow)
104 | Set background color 13 | bg13, bgbrightblue | Background Color 13 (Bright Blue) | Background Color 13 (Bright Blue)
105 | Set background color 14 | bg14, bgbrightmagenta | Background Color 14 (Bright Magenta) | Background Color 14 (Bright Purple)
106 | Set background color 15 | bg15, bgbrightcyan | Background Color 15 (Bright Cyan) | Background Color 15 (Bright Cyan)
107 | Set background color 16 | bg16, bgbrightwhite | Background Color 16 (Bright White) | Background Color 16 (Bright White)
