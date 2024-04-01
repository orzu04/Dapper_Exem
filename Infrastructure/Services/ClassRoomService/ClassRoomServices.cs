using DoMain;
using Dapper;
namespace Infrastructure;

public class ClassRoomServices : IClassRoomServices
{

    DapperContext dapperContext= new DapperContext();
    public string AddClassRooms(ClassRooms classRoom)
    {
          var sql = $"Insert into ClassRooms(Capacity,Description,created_at,updated_at)"+
                  $"values({classRoom.Capacity},'{classRoom.Description}','{classRoom.Created_at}','{classRoom.Update_at}')";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";

    }

    public bool DeleteClassRooms(int Id)
    {
          var sql = $"Delete from ClassRooms where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

    public List<ClassRooms> GetClassRooms()
    {
       var sql = "Select * from ClassRooms";
        var selected = dapperContext.Connection().Query<ClassRooms>(sql).ToList();
        return selected;
    }

    public ClassRooms GetClassRoomsByID(int Id)
    {
          var sql = $"Select * from ClassRooms where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public string UpdateClassRooms(ClassRooms classRoom)
    {
      var sql = $"Update ClassRooms  set Capacity = {classRoom.Capacity},Description='{classRoom.Description}',created_at= '{classRoom.Created_at}',updated_at='{classRoom.Update_at}'";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";


    }
}
