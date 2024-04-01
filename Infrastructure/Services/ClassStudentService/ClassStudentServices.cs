using DoMain;
using Dapper;
namespace Infrastructure;

public class ClassStudentServices : IClassStudentServices
{

    DapperContext dapperContext = new DapperContext();
    public string AddClass_Student(Class_Student class_Student)
    {
         var sql = $"Insert into Class_Student (class_id,Student_id)"+
                  $"values({class_Student.class_id},{class_Student.Student_id})";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";

    
    }

    public bool DeleteClass_Student(int Id)
    {
            var sql = $"Delete from Class_Student where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

    public List<Class_Student> GetClass_Student()
    {
        var sql = "Select * from Class_Student";
        var selected = dapperContext.Connection().Query<Class_Student>(sql).ToList();
        return selected;
    }

    public Class_Student GetClass_StudentByID(int Id)
    {
          var sql = $"Select * from Class_Student where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public string UpdateClass_Student(Class_Student class_Student)
    {
     var sql = $"Update ClassRooms  set class_id = {class_Student.class_id},Student_id={class_Student.Student_id}";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";
  
    }
}
