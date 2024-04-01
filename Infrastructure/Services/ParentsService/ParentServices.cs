using DoMain;
using Dapper;
namespace Infrastructure;

public class ParentServices : IParentServices
{

    DapperContext dapperContext = new DapperContext();
    public string AddParents(Parents parent)
    {
            var sql = $"Insert into Parents(Pr_code,Pr_fool_name,Email,Pr_Phone,created_at,updated_at)"+
                  $"values('{parent.Pr_code}','{parent.Pr_fool_name}','{parent.Email}','{parent.Pr_Phone}','{parent.Created_at}','{parent.Update_at}')";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";


    }

    public bool DeleteParents(int Id)
    {
           var sql = $"Delete from Parents where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

    public List<Parents> GetParents()
    {
       var sql = "Select * from Parents";
        var selected = dapperContext.Connection().Query<Parents>(sql).ToList();
        return selected;
    }

    public Parents GetParentsByID(int Id)
    {
         var sql = $"Select * from Parents where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;  
    }

    public string UpdateParents(Parents parent)
    {
    var sql = $"Update Parents  set Pr_code = '{parent.Pr_code}',Pr_fool_name='{parent.Pr_fool_name}',Email='{parent.Email}',Pr_Phone='{parent.Pr_Phone}',created_at= '{parent.Created_at}',updated_at='{parent.Update_at}'";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";
    }
}
