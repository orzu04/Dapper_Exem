using DoMain;

namespace Infrastructure;

public interface IClassServices
{
  List<Class> GetClasses();
  Students GetClassByID(int Id);
  string AddClass (Class classe);
  string UpdateClass (Class classe);
  bool DeleteClass (int Id);
}
