namespace DoMain;

//Create table Schools(

  //SC_id serial primary key,
  //SC_title varchar(50) not null ,
  //Level_Cont  int,
  //Created_at Date,	
 // updated_at Date


//)


//Create table Students(

  //St_id serial primary key,
  //St_code varchar(12) not null ,
  //St_fool_name varchar (50) not null
  //St_gender varchar(5),
  //Dob Date,
  //Email varchar(30) not null unique,
  //St_Phone varchar(15) unique,
  //School_id int references Schools(SC_id),
//created_at Date,
//	 updated_at Date
//)


//Create table Parents (

 //Pr_id serial primary key,
  //Pr_code  varchar(30) not null unique,
  //Pr_fool_name varchar (50) not null ,
//	Email varchar(30) not null unique,
///	Pr_Phone varchar(15) unique,
 // Created_at Date,	
 // updated_at Date


//)


//Create table Student_Parent(

//SP_id serial primary key,
 //Student_id int references Students(St_id),
 //Parent_id int references Parents(Pr_id),
	//reletionship int 

//)



//Create table Subjects(

//SU_id serial primary key,
//Su_title varchar(50) not null ,
 //Su_stage int ,
	//Su_term int,
  //Created_at Date,	
  //updated_at Date


//)




//Create table Teachers(

 //T_id serial primary key,
 //T_code varchar(12) not null ,
 //T_fool_name varchar (50) not null,
 //T_gender varchar(5),
  //Dob Date,
  //Email varchar(30) not null unique,
 //T_Phone varchar(15) unique,
//created_at Date,
//	 updated_at Date
//)


//Create table Classrooms(

//C_id serial primary key,
//Capacity int  not null,
//	Description varchar(50),
//	created_at Date,
//	 updated_at Date
//)


//Create table Class(

//C_id serial primary key,
//	Class_name varchar (50) not null,
  // section varchar(2),
	//subect_id int references Subjects(SU_id),
//	teacher_id int references Teachers(T_id),
//	class_room_id int references Classrooms(C_id),
//	created_at Date,
//	 updated_at Date
//)


//create table Class_Student(
 
//CS_id serial primary key,
//	class_id int references Class(C_id),
//	 Student_id int references Students(St_id)

//)