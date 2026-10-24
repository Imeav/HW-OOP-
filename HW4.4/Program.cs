using System;

GeographicObject river = new River(
    "Dnipro",
    "River in Ukraine",
    50.45,
    30.52,
    1.5,
    2201
);


GeographicObject mountain = new Mountain(
    "Hoverla",
    "The highest mountain in Ukraine",
    48.16,
    24.50,
    2061
);

Console.WriteLine("RIVER");
Console.WriteLine(river.GetInfo());
Console.WriteLine();
Console.WriteLine("MOUNTAIN");
Console.WriteLine(mountain.GetInfo());
Console.ReadKey();

