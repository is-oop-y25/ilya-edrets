using Isu.Entities;
using Isu.Exceptions;
using Isu.Models;

namespace Isu.Services
{
    public class IsuService : IIsuService
    {
        private readonly Dictionary<int, Student> _students;
        private readonly Dictionary<string, Group> _groups;

        public IsuService()
        {
            _students = new Dictionary<int, Student>();
            _groups = new Dictionary<string, Group>();
        }

        public Group AddGroup(string name)
        {
            if (!Group.TryParse(name, out Group? group))
            {
                throw new InvalidGroupNameException(name);
            }

            _groups.Add(group!.GroupName, group);

            return group;
        }

        public Student AddStudent(Group @group, string name)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student? FindStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindStudents(GroupName groupName)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindStudents(CourseNumber courseNumber)
        {
            throw new NotImplementedException();
        }

        public Group? FindGroup(string groupName)
        {
            if (_groups.ContainsKey(groupName))
            {
                return _groups[groupName];
            }

            return null;
        }

        public List<Group> FindGroups(CourseNumber courseNumber)
        {
            throw new NotImplementedException();
        }

        public void ChangeStudentGroup(Student student, Group newGroup)
        {
            throw new NotImplementedException();
        }
    }
}
