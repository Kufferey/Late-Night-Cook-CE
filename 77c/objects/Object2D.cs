using System.Numerics;
using Raylib_cs;

namespace SeventySevenC;

public class Object2D : BaseObject
{
    public Vector2 Position { get; set; }
    public Vector2 Scale { get; set; }
    public float Rotation { get; set; }
}