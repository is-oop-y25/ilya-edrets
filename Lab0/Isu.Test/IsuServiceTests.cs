using Isu.Exceptions;
using Isu.Services;
using Xunit;

namespace Isu.Test;

public class IsuServiceTests
{
    [Fact]
    public void AddStudentToGroup_StudentHasGroupAndGroupContainsStudent()
    {
    }

    [Fact]
    public void ReachMaxStudentPerGroup_ThrowException()
    {
    }

    [Fact]
    public void CreateGroupWithInvalidName_ThrowException()
    {
        var service = new IsuService();

        Assert.Throws<InvalidGroupNameException>(() => service.AddGroup("asda"));
    }

    [Fact]
    public void TransferStudentToAnotherGroup_GroupChanged()
    {
    }
}