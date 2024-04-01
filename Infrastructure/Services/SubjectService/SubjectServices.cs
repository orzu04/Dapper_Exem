using DoMain;
using Dapper;
namespace Infrastructure;

public class SubjectServices : ISubjectServices
{

    DapperContext dapperContext = new DapperContext();
    public string AddSubjects(Subjects subject)
    {
             var sql = $"Insert into Subjects(Su_title,Su_stage,Su_term,Created_at,updated_at)"+
                  $"values('{subject.Su_title}',{subject.Su_stage},{subject.Su_term},'{subject.Created_at}','{subject.Update_at}')";
        var inserted = dapperContext.Connection().Execute(sql);
        if (inserted > 0) return "Added Ok";
        return "Error";

 
    }

    public bool DeleteSubjects(int Id)
    {
           var sql = $"Delete from Subjects where id = {@Id}";
        var deleted = dapperContext.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false; 
    }

    public List<Subjects> GetSubjects()
    {
         var sql = "Select * from Subjects";
        var selected = dapperContext.Connection().Query<Subjects>(sql).ToList();
        return selected;
    }

    public Subjects GetSubjectsByID(int Id)
    {
             var sql = $"Select * from Subjects where id = {@Id}";
        var selected = dapperContext.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public string UpdateSubjects(Subjects subject)
    {
         var sql = $"Update  Subjects set Su_title = '{subject.Su_title}',Su_stage={subject.Su_stage},Su_term={subject.Su_term},Created_at= '{subject.Created_at}',updated_at='{subject.Update_at}'";
        var updated = dapperContext.Connection().Execute(sql);
        if(updated > 0) return "Updated Ok";
        return "Error";
    }
}
    