using DoMain;
using Dapper;
namespace Infrastructure;

public class StudentServices : IStudentServices
{

    DapperContext dapperContext = new DapperContext();
    public string AddStudent(Students student)
    {
          var sql = $"Insert into Students(St_code,St_fool_name,St_gender,Dob,Email,St_Phone,School_id,created_at,updated_at)"+
                  $"values('{student.St_code}','{student.St_fool_name}','{student.St_gender}','{student.Dob}','{student.Email}','{student.St_Phone}',{student.School_id}'{student.Created_at}','{student.Update_at}')";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";

    }

    public bool DeleteStudent(int Id)
    {
         var sql = $"Delete from Students where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

    public Students GetStudentByID(int Id)
    {
        
          var sql = $"Select * from Students where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public List<Students> GetStudents()
    {
         var sql = "Select * from Students";
        var selected = dapperContext.Connection().Query<Students>(sql).ToList();
        return selected;
    }

    public string UpdateStudent(Students student)
    {
        var sql = $"Update  Students set St_code = '{student.St_code}',St_fool_name='{student.St_fool_name}',St_gender='{student.St_gender}',Dob='{student.Dob}',Email='{student.Email}',St_Phone='{student.St_Phone}',School_id={student.School_id},created_at= '{student.Created_at}',updated_at='{student.Update_at}'";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";
    }
}
