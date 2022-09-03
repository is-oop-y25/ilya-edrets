using Isu.Models;

namespace Isu.Entities;

public class Group
{
    private Group(string groupName, CourseNumber courseNumber)
    {
        GroupName = groupName;
        CourseNumber = courseNumber;
    }

    public CourseNumber CourseNumber { get; }

    public string GroupName { get; }

    public static bool TryParse(string groupName, out Group? group)
    {
        group = null;

        if (!groupName.StartsWith("M"))
        {
            return false;
        }

        group = new Group(groupName, CourseNumber.First);
        return true;
    }
}