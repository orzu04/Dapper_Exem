using DoMain;

namespace Infrastructure;

public interface IClassRoomServices
{
 List<ClassRooms> GetClassRooms();
  ClassRooms GetClassRoomsByID(int Id);
  string AddClassRooms (ClassRooms classRoom );
  string UpdateClassRooms (ClassRooms classRoom );
  bool DeleteClassRooms (int Id);
}
