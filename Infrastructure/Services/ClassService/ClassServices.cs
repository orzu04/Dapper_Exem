using DoMain;
using Dapper;
namespace Infrastructure;

public class ClassServices : IClassServices
{


    DapperContext dapperContext = new DapperContext();
    public string AddClass(Class classe)
    {
           var sql = $"Insert into Class (Class_name,section,subect_id,teacher_id,class_room_id,created_at,updated_at)"+
                  $"values({classe.Class_name},'{classe.section}',{classe.subect_id},{classe.teacher_id},{classe.class_room_id},'{classe.Created_at}','{classe.Update_at}')";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";

     
    }

    public bool DeleteClass(int Id)
    {
          var sql = $"Delete from Class where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

    public Students GetClassByID(int Id)
    {
            var sql = $"Select * from Class where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public List<Class> GetClasses()
    {
       var sql = "Select * from Class";
        var selected = dapperContext.Connection().Query<Class>(sql).ToList();
        return selected;
    }

    public string UpdateClass(Class classe)
    {
       var sql = $"Update Class  set Class_name = {classe.Class_name},section='{classe.section}',subect_id={classe.subect_id},teacher_id=,class_room_id,created_at= '{classe.Created_at}',updated_at='{classe.Update_at}'";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";
    }
}

