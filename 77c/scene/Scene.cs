using System.Formats.Asn1;
using Raylib_cs;

namespace SeventySevenC;

public class Scene : SceneBase
{
    public void ChangeCurrentScene(Scene to)
    {
        SceneExit();

        SceneChange(CurrentScene != null ? CurrentScene : new Scene(), to);
        CurrentScene = to;
    }

    public override void SceneChange(Scene from, Scene to)
    {

    }


    public override void SceneExit()
    {

    }

    public override void SceneStart()
    {

    }

    public override void SceneDraw(double delta)
    {

    }

    public override void SceneUpdate(double delta)
    {

    }
}