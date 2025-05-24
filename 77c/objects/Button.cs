using System.ComponentModel;
using System.Numerics;
using Raylib_cs;

namespace SeventySevenC;

public class Button : Object2D
{
    public string Text { get; set; } = "Button";
    public int TextFontSize { get; set; } = 35;
    public Color TextColor { get; set; } = Color.White;

    public bool isPressed;
    public bool isHover;

    public bool drawColPoint;

    private Rectangle _buttonRec;

    public Button(string text, int x, int y, float width, float height, int fontSize = default, Color color = default)
    {
        Text = text;

        Position = new Vector2(x, y);
        _buttonRec = new Rectangle(Position.X, Position.Y, width, height);
        TextFontSize = fontSize;
        TextColor = color;

        AddToGroup("Buttons");
    }

    public void UpdateButton()
    {
        Raylib.DrawText(Text, (int)Position.X, (int)Position.Y, TextFontSize, TextColor);
        
        _buttonRec.X = (int)Position.X;
        _buttonRec.Y = (int)Position.Y;

        if (drawColPoint)
        {
            Raylib.DrawRectangle((int)_buttonRec.X, (int)_buttonRec.Y, (int)_buttonRec.Width, (int)_buttonRec.Height, Color.Brown);
        }

        if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), _buttonRec))
        {
            isHover = true;

            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                isPressed = true;
            else
                isPressed = false;
        }
        else
            isHover = false;
    }
}