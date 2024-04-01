


using DoMain;
using Infrastructure;

 var schoolServices = new SchoolServices();
 var schools = new Schools(){


SC_title = "LitseY 8",
Level_Cont = 55,
Creared_at= new DateTime(2011-02-01-12-10),
Update_at =new DateTime(2012-02-01-14-10)



 };

schoolServices.AddSchools(schools);
schoolServices.GetSchools();
//var getByidSC= schoolServices.GetSchoolsByID(2);
//var upSc = schoolServices.UpdateSchools(schools);
//schoolServices.DeleteSchools(1);





var studentServices = new StudentServices();
var student = new Students(){

St_code = "Orz0304",
St_fool_name ="Ruben Diash",
St_gender = "Men",
Dob=new DateTime(2020-09-01),
Email = "@oooo",
St_Phone = "99999999",
School_id = 1,
Created_at= new DateTime(2020-02-01-12-10),
Update_at =new DateTime(2020-02-01-14-10)

};
 
studentServices.AddStudent(student);
studentServices.GetStudents();
//var GetByIdS= studentServices.GetStudentByID(2);
//var upS= studentServices.UpdateStudent(student);
 // studentServices.DeleteStudent(1);




var classRoomServices = new ClassRoomServices();
var classRoom = new ClassRooms(){

Capacity=40,
Description = "Welcome",
Created_at= new DateTime(2020-02-01-12-10),
Update_at =new DateTime(2020-02-01-14-10)

};

classRoomServices.AddClassRooms(classRoom);
classRoomServices.GetClassRooms();
//var GetByIdCR = classRoomServices.GetClassRoomsByID(2);
//var upCR = classRoomServices.UpdateClassRooms(classRoom);
//classRoomServices.DeleteClassRooms(1);


var parentServices = new ParentServices();
var parenrs= new Parents(){
Pr_code = "Orz0304",
Pr_fool_name ="Ruben Diash",
Email = "@bbbbbnb",
Pr_Phone = "111111111111",
Created_at= new DateTime(2020-02-01-12-10),
Update_at =new DateTime(2020-02-01-14-10)


};


parentServices.AddParents(parenrs);
var GetPr=parentServices.GetParents();
foreach (var item in GetPr )
{
    System.Console.WriteLine(item.Pr_code);
    System.Console.WriteLine(item.Pr_fool_name);
    System.Console.WriteLine(item.Email);
    System.Console.WriteLine(item.Pr_Phone);
    System.Console.WriteLine(item.Created_at);
    System.Console.WriteLine(item.Update_at);
}

//var UpPr= parentServices.UpdateParents(parenrs);
//var GetByIdPr= parentServices.GetParentsByID(2);
//parentServices.DeleteParents(1);



var student_ParentServices = new StudentParentServices();
var student_Parent= new Student_Parent(){

Student_id = 1,
Parent_id = 2,
Reletionship = 2

};


var subjectServices= new SubjectServices();
var subject = new Subjects(){


Su_title= "Tojikon",
Su_stage = 4,
Su_term = 3,
Created_at= new DateTime(2020-02-01-12-10),
Update_at =new DateTime(2020-02-01-14-10)


};


subjectServices.AddSubjects(subject);
var GetSU= subjectServices.GetSubjects();

foreach (var item in GetSU)
{
    System.Console.WriteLine(item.Su_title);
    System.Console.WriteLine(item.Su_stage);
    System.Console.WriteLine(item.Su_term);
    System.Console.WriteLine(item.Created_at);
    System.Console.WriteLine(item.Update_at);

}

//var UpSu= subjectServices.UpdateSubjects(subject);
//subjectServices.DeleteSubjects(1);

var teacherServices= new TeacherServices();
var teacher = new Teachers(){

T_code = "Rub0304",
T_fool_name ="Ruben Diash",
T_gender = "Men",
Dab=new DateTime(2020-09-01),
Email = "@oooo",
T_Phone = "99999999",
Created_at= new DateTime(2020-02-01-12-10),
Update_at =new DateTime(2020-02-01-14-10)


};



teacherServices.AddTeachers(teacher);
var GetT= teacherServices.GetTeachers();
foreach (var item in GetT)
{
    System.Console.WriteLine(item.T_code);
    System.Console.WriteLine(item.T_fool_name);
    System.Console.WriteLine(item.T_gender);
    System.Console.WriteLine(item.Dab);
    System.Console.WriteLine(item.Email);
    System.Console.WriteLine(item.T_Phone);
    System.Console.WriteLine(item.Created_at);
    System.Console.WriteLine(item.Update_at);
}


//var UpT= teacherServices.UpdateTeachers(teacher);
//teacherServices.DeleteTeachers(1);



var classServices = new ClassServices();
var classes= new Class(){


Class_name ="C#",
subect_id = 1,
teacher_id = 2,
class_room_id = 1,

Created_at= new DateTime(2020-02-01-12-10),
Update_at =new DateTime(2020-02-01-14-10)

};



classServices.AddClass(classes);
var GetC= classServices.GetClasses();

foreach (var item in GetC)
{
    System.Console.WriteLine(item.Class_name);
    System.Console.WriteLine(item.subect_id);
    System.Console.WriteLine(item.teacher_id);
    System.Console.WriteLine(item.class_room_id);
    System.Console.WriteLine(item.Created_at);
    System.Console.WriteLine(item.Update_at);
}


//var UpC= classServices.UpdateClass(classes);
//classServices.DeleteClass(1);





var class_StudentServices= new ClassStudentServices();
var class_Student = new Class_Student(){

class_id = 1,
Student_id = 2


};

