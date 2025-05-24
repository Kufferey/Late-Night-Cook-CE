using Raylib_cs;
using static Raylib_cs.Raylib;
using SeventySevenC;
using System.Numerics;

public partial class SMainMenu : Scene
{
    ButtonStyle playButton = new ButtonStyle(
        "Play",
        0, 0,
        135, 45, 45, Color.White
    );

    ButtonStyle optionsButton = new ButtonStyle(
        "Options // Work in Progress",
        0, 0,
        200, 45, 45, Color.White
    );

    ButtonStyle achievementsButton = new ButtonStyle(
        "Achievements // Work in Progress",
        0, 0,
        200, 45, 45, Color.White
    );

    ButtonStyle exitButton = new ButtonStyle(
        "Exit",
        0, 0,
        135, 45, 45, Color.White
    );

    public override void SceneUpdate(double delta)
    {
        playButton.UpdateButton();
        optionsButton.UpdateButton();
        achievementsButton.UpdateButton();
        exitButton.UpdateButton();

        if (playButton.isPressed)
        {
            SetMouseCursor(MouseCursor.Arrow);
            ChangeCurrentScene(new SGame());
        }
        if (exitButton.isPressed)
            CloseWindow();

        if (playButton.isHover || exitButton.isHover )
        {
            SetMouseCursor(MouseCursor.PointingHand);
        }
        else
        {
            SetMouseCursor(MouseCursor.Arrow);
        }

        base.SceneUpdate(delta);
    }

    public override void SceneDraw(double delta)
    {
        playButton.Position = new Vector2(5, (int)WindowSize.Y / 1.5F);
        optionsButton.Position = new Vector2(5, playButton.Position.Y + 50);
        achievementsButton.Position = new Vector2(5, optionsButton.Position.Y + 50);
        exitButton.Position = new Vector2(5, achievementsButton.Position.Y + 50);

        if (playButton.isHover)
            playButton.Position = new Vector2(10 , playButton.Position.Y);
        else
            playButton.Position = new Vector2(5 , playButton.Position.Y);

        if (optionsButton.isHover)
            optionsButton.Position = new Vector2(10 , optionsButton.Position.Y);
        else
            optionsButton.Position = new Vector2(5 , optionsButton.Position.Y);

        if (exitButton.isHover)
            exitButton.Position = new Vector2(10 , exitButton.Position.Y);
        else
            exitButton.Position = new Vector2(5 , exitButton.Position.Y);

        base.SceneDraw(delta);
    }
}