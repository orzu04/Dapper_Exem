using DoMain;
using Dapper;
namespace Infrastructure;

public class StudentParentServices : IStudentParentServices
{


    DapperContext dapperContext = new DapperContext();
    public string AddStudent_Parent(Student_Parent student_Parent)
    {
           var sql = $"Insert intoStudent_Parent (Student_id,Parent_id,reletionship)"+
                  $"values({student_Parent.Student_id},{student_Parent.Parent_id},{student_Parent.Reletionship})";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";

 
    }

    public bool DeleteStudent_Parent(int Id)
    {
        var sql = $"Delete from Student_Parent where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

    public List<Student_Parent> GetStudent_Parent()
    {
          var sql = "Select * from Student_Parent";
        var selected = dapperContext.Connection().Query<Student_Parent>(sql).ToList();
        return selected; 
    }

    public Schools GetStudent_ParentByID(int Id)
    {
            var sql = $"Select * from Student_Parent where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public string UpdateStudent_Parent(Student_Parent student_Parent)
    {
          var sql = $"Update  Student_Parent set Student_id = {student_Parent.Student_id},Parent_id={student_Parent.Parent_id},reletionship={student_Parent.Reletionship}";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";
    }
}
  