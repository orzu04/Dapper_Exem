using DoMain;

namespace Infrastructure;

public interface IStudentServices
{

  List<Students> GetStudents();
  Students GetStudentByID(int Id);
  string AddStudent (Students student);
  string UpdateStudent (Students student);
  bool DeleteStudent (int Id);

}
