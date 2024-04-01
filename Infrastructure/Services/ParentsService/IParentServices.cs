using DoMain;

namespace Infrastructure;

public interface IParentServices
{
 List<Parents> GetParents();
  Parents GetParentsByID(int Id);
  string AddParents( Parents parent);
  string UpdateParents (Parents parent );
  bool DeleteParents (int Id);
}
