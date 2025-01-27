﻿
Coordinate c = new Coordinate();
Coordinate d = new Coordinate { X = 12, Y = 42 };
Coordinate cChange = c with { X = 13, Y = 43 };
Console.WriteLine($"{c.X}, {c.Y}");
Console.WriteLine($"{d.X}, {d.Y}");
Console.WriteLine($"{cChange.X}, {cChange.Y}");

public readonly struct Coordinate
{
    //Default constructor is now allowed in C# 10
    public Coordinate()
    {
        X = 0;
        Y = 0;
    }
    // init keyword allows read-only structure properties to be set when constructed
    public int X { get; init; }
    public int Y { get; init; }
}