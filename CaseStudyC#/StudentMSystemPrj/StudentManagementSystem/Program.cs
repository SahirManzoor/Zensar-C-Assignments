using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class Course
    {
        public int Course_Id { get; set; }
        public string Course_Name { get; set; } 
        public int Course_Duration { get; set; }
        public float Course_Fees { get; set; }
        public Course()
        {

        }
        public Course(int id, string name, int duration, float fees)
        {
            Course_Id = id;
            Course_Name = name;
            Course_Duration = duration;
            Course_Fees = fees;
        }
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    class Student
    {
        public int S_Id { get; set; }
        public string S_Name { get; set; }
        public DateTime S_Dob { get; set; }
        public Student()
        {
        }
        public Student(int a, string b, DateTime dob)
        {
            S_Id = a;
            S_Name = b;
            S_Dob = dob;

        }
    }
    
    
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++==
    class Enroll
    {
        public Student student = new Student();
        public Course course = new Course();
        private DateTime enrollmentDate;
        
        public List<Course> CourseList = new List<Course>();
        public List<Student> StudentList = new List<Student>();
        public List<Enroll> EnrollList = new List<Enroll>();
           public Enroll()
        {


        }
        
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
    }
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class Program : UserInterface
    {
        public static Enroll enroll = new Enroll();
        private string userValue;
        public override void introduceNewCourseScreen()
        {
            Console.WriteLine("Welcome to Adding New Course Screen : ");
            AppEngine.introduce(enroll.CourseList);
        }
        public override void showAdminScreen()
        {
            do
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("                     Admin Screen                                          ");
                Console.WriteLine("---------------------------------------------------------------------------");


                Console.WriteLine("What do You  want to see ?Press \n1. All Student Info List \n2. New Student Registration\n3. All Courses Info List \n4. Add New Course \n5. Delete Existing Course \n6. Update Existing Course \n7. Enrollment List");
                Console.WriteLine("Enter your choice From (1--->6) : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showAllStudentsScreen();
                        break;
                    case 2:
                        showStudentRegistrationScreen();
                        break;

                    case 3:
                        showAllCoursesScreen();
                        break;
                    case 4:
                        introduceNewCourseScreen();
                        break;
                    case 5:
                        AppEngine.DeleteCourse();
                        break;
                    case 6:
                        AppEngine.UpdateCourseInfo();
                        break;
                    case 7:
                        AppEngine.ListOfEnrollment(enroll.EnrollList);
                        break;
                }
                Console.WriteLine("Do you want to continue in Admin Screen : Yes or No ");
                userValue = Console.ReadLine();
            } while (userValue == "Yes");
        }
     public override void showAllCoursesScreen()
        {
            Console.WriteLine("Welcome to All Courses Information List :");
            AppEngine.ListOfCourses(enroll.CourseList);
        }


        public override void showAllStudentsScreen()
        {
            Console.WriteLine("Student Information List");
            AppEngine.ListOfStudents(enroll.StudentList);
        }



        public override void showFirstScreen()
        {
            do
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("|*                    STUDENT MANAGEMENT SYSTEM                           *|");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("Tell us who you are : \n1.Student\n2. Admin");
                Console.WriteLine("Enter your choice  1 or 2 ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                }
                Console.WriteLine("Do you want to continue in Main Screen : Yes or No ");
                userValue = Console.ReadLine();
            } while (userValue == "Yes");
        }

        public override void showStudentRegistrationScreen()
        {
            Console.WriteLine("Welcome to Student Registration Screen : ");
            AppEngine.register(enroll.StudentList);
        }


        public override void showStudentScreen()
        {
            do
            {

                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("                    Student Screen                                         ");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Press any key  : \n1. Student Info  \n2. All Courses Available \n3. Change Date of Birth \n4. Delete Student Info \n5. Enroll in New Course \n6.Back To Admin Screen");
                Console.WriteLine("Enter your choice 1 or 2 or 3 or 4 or 5  : ");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        AppEngine.GetPerStudDetails();
                        break;
                    case 2:
                        showAllCoursesScreen();
                        break;
                    case 3:
                        AppEngine.UpdateStudInfo();
                        break;
                    case 4:
                        AppEngine.DeleteStudent();
                        break;
                    case 5:
                        Enrollment();
                        break;
                    case 6:
                        showAdminScreen();
                        break;
                }

                Console.WriteLine("Do you want to continue ??Please type : Yes or No ");
                userValue = Console.ReadLine();
            } 
            while (userValue == "Yes");
        }

        public void Enrollment()
        {
            AppEngine.enroll();
         
        }
    }
}
