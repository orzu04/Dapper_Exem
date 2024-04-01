using DoMain;

namespace Infrastructure;

public interface ISubjectServices
{

List<Subjects> GetSubjects();
  Subjects GetSubjectsByID(int Id);
  string AddSubjects( Subjects subject);
  string UpdateSubjects (Subjects subject );
  bool DeleteSubjects(int Id);

}
