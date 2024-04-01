using DoMain;

namespace Infrastructure;

public interface ISchoolServices
{

 List<Schools> GetSchools();
  Schools GetSchoolsByID(int Id);
  string AddSchools( Schools school);
  string UpdateSchools (Schools school );
  bool DeleteSchools (int Id);


}
