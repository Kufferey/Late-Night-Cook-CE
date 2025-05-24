namespace SeventySevenC;

public class BaseObject : GameData
{
    public string Name { get; set; } = "Object";
    public bool IsActive { get; set; } = true;
    public bool IsVisible { get; set; } = true;

    public List<string> TagGroup { get; set; } = ["Objects"];

    public void AddToGroup(string group) => TagGroup.Add(group);

    public bool IsInGroup(string group)
    {
        foreach (var groupName in TagGroup)
        {
            if (groupName == group)
                return true;
        }

        return false;
    }
}