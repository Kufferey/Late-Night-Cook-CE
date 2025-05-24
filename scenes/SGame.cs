using Raylib_cs;
using SeventySevenC;

public partial class SGame : Scene
{
    public override void SceneUpdate(double delta)
    {
        Raylib.SetMouseCursor(MouseCursor.Arrow);
        base.SceneUpdate(delta);
    }
}