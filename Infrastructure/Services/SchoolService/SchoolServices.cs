using DoMain;
using Dapper;
namespace Infrastructure;

public class SchoolServices : ISchoolServices
{

    DapperContext dapperContext = new DapperContext();
    public string AddSchools(Schools school)
    {
           var sql = $"Insert into Schools(SC_title,Level_Cont,Created_at,updated_at)"+
                  $"values('{school.SC_title}',{school.Level_Cont},'{school.Creared_at}','{school.Update_at}')";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";


    }

    public bool DeleteSchools(int Id)
    {
        var sql = $"Delete from Schools where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

    public List<Schools> GetSchools()
    {
        var sql = "Select * from Schools";
        var selected = dapperContext.Connection().Query<Schools>(sql).ToList();
        return selected;
    }

    public Schools GetSchoolsByID(int Id)
    {
          var sql = $"Select * from Schools where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public string UpdateSchools(Schools school)
    {
          var sql = $"Update Schools  set SC_title = {school.SC_title},Level_Cont={school.Level_Cont},Created_at= '{school.Creared_at}',updated_at='{school.Update_at}'";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";
    }
}

   