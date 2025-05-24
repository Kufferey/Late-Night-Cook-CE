using System.ComponentModel;
using System.Numerics;
using Raylib_cs;

namespace SeventySevenC;

public class Sprite2D : Object2D
{
    public Texture2D Texture { get; set; }

    private string _textureFilePath;


    public Sprite2D(string texture, Vector2 position, Vector2 scale, float rotation)
    {
        Texture = Raylib.LoadTexture(texture);
        Position = position;
        Scale = scale;
        Rotation = rotation;

        _textureFilePath = texture;
    }

    public string GetTextureFilePath() => _textureFilePath;
}