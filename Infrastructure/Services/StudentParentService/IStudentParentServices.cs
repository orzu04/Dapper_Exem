using DoMain;

namespace Infrastructure;

public interface IStudentParentServices
{

List<Student_Parent> GetStudent_Parent();
  Schools GetStudent_ParentByID(int Id);
  string AddStudent_Parent( Student_Parent student_Parent);
  string UpdateStudent_Parent (Student_Parent student_Parent );
  bool DeleteStudent_Parent (int Id);

}
