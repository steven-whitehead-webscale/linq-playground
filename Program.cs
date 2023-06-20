// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var actions = Utility.GetActionItemsFromCommand();

var newGroupList = actions
    .GroupBy(u => u.Group)
    .Select(grp => new ActionGroup { Group = grp.Key, Count = grp.Count(), Items = grp.ToList() }).ToList();

var x = "dddd";

public static class Utility
{
    public static List<ActionItem> GetActionItemsFromCommand()
    {
        List<ActionItem> actions = new List<ActionItem>();

        actions.Add(new ActionItem() { Group = "A", Title = "BLAH", Url = "http://somewhere" });
        actions.Add(new ActionItem() { Group = "A", Title = "BLAH", Url = "http://somewhere" });
        actions.Add(new ActionItem() { Group = "A", Title = "BLAH", Url = "http://somewhere" });
        actions.Add(new ActionItem() { Group = "B", Title = "BLAH", Url = "http://somewhere" });
        actions.Add(new ActionItem() { Group = "B", Title = "BLAH", Url = "http://somewhere" });
        actions.Add(new ActionItem() { Group = "B", Title = "BLAH", Url = "http://somewhere" });
        actions.Add(new ActionItem() { Group = "C", Title = "BLAH", Url = "http://somewhere" });
        actions.Add(new ActionItem() { Group = "C", Title = "BLAH", Url = "http://somewhere" });
        actions.Add(new ActionItem() { Group = "C", Title = "BLAH", Url = "http://somewhere" });

        return actions;
    }
}

public class ActionGroup
{
    public string Group { get; set; }
    public int Count { get; set; }
    public List<ActionItem> Items { get; set; }
}

public class ActionItem
{
    public string Group { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
}