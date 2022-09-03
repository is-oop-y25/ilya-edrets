namespace Isu.Exceptions
{
    public class InvalidGroupNameException : Exception
    {
        public InvalidGroupNameException(string groupName)
        {
            GroupName = groupName;
        }

        public string GroupName { get; set; }
    }
}
