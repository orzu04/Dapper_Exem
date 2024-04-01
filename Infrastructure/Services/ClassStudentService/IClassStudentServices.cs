using DoMain;

namespace Infrastructure;

public interface IClassStudentServices
{
 List<Class_Student> GetClass_Student();
  Class_Student GetClass_StudentByID(int Id);
  string AddClass_Student (Class_Student class_Student );
  string UpdateClass_Student (Class_Student class_Student );
  bool DeleteClass_Student (int Id);

}
