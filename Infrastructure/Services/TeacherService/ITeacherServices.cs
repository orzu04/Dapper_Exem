using DoMain;

namespace Infrastructure;

public interface ITeacherServices
{

List<Teachers> GetTeachers();
  Subjects GetTeachersByID(int Id);
  string AddTeachers( Teachers teacher);
  string UpdateTeachers (Teachers teacher );
  bool DeleteTeachers(int Id);


}
