using DoMain;
using Dapper;
namespace Infrastructure;

public class TeacherServices : ITeacherServices
{

    DapperContext dapperContext =new  DapperContext();
    public string AddTeachers(Teachers teacher)
    {
           var sql = $"Insert into Teachers(T_code,T_fool_name,T_gender,Dob,Email,T_Phone,created_at,updated_at)"+
                  $"values('{teacher.T_code}','{teacher.T_fool_name}','{teacher.T_gender}','{teacher.Dab}','{teacher.Email}','{teacher.T_Phone}','{teacher.Created_at}','{teacher.Update_at}')";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";

   
    }

    public bool DeleteTeachers(int Id)
    {
         var sql = $"Delete from Teachers where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

    public List<Teachers> GetTeachers()
    {
         var sql = "Select * from Teachers ";
        var selected = dapperContext.Connection().Query<Teachers>(sql).ToList();
        return selected;
    }

    public Subjects GetTeachersByID(int Id)
    {
          var sql = $"Select * from Teachers where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public string UpdateTeachers(Teachers teacher)
    {
        var sql = $"Update  Teachers set T_code = {teacher.T_code},T_fool_name='{teacher.T_fool_name}',T_gender='{teacher.T_gender}',Dob='{teacher.Dab}',Email='{teacher.Email}',T_Phone='{teacher.T_Phone}',created_at= '{teacher.Created_at}',updated_at='{teacher.Update_at}'";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";

    }
}
