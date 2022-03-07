using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    class AppEngine
    {
        public static SqlCommand cmd;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static string connections = "data source=ADMW46ZLPC1200;initial catalog=SMS;integrated security=true";
        //connection string to sql
        public static void introduce(List<Course> course)
        {
            try
            {
                con = getConnection();
                int Id;
                string Name;
                int Duration;
                float Fee;
               
                Console.WriteLine("Enter Course_ID :");
                Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Course_Name :");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Course_Duration :");
                Duration = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Course Fees : ");
                Fee = float.Parse(Console.ReadLine());
                cmd = new SqlCommand("Insert into courseInfo values(@Cour_Id,@Cour_Name,@Cour_Duration,@Cour_Fee)");
                cmd.Parameters.AddWithValue("@Cour_Id", Id);
                cmd.Parameters.AddWithValue("@Cour_Name", Name);
                cmd.Parameters.AddWithValue("@Cour_Duration", Duration);
                cmd.Parameters.AddWithValue("@Cour_Fee", Fee);
                cmd.Connection = con;
                int no_ofrows = cmd.ExecuteNonQuery();
                if (no_ofrows > 0)
                {
                    course.Add(new Course(Id, Name, Duration, Fee));
                }
                else
                {
                    Console.WriteLine("OOps Not able to insert the course Details");
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
       
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static void register(List<Student> students)
        {
            try
            {
                con = getConnection();
                int Id;
                string Name;
                DateTime Dob;
                Console.WriteLine("Enter Student ID : ");
                Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Date of Birth :");
                Dob = Convert.ToDateTime(Console.ReadLine());
                cmd = new SqlCommand("Insert into StudentInfo values(@Stud_Id,@Stud_Name,@Stud_Dob)");
                cmd.Parameters.AddWithValue("@Stud_Id", Id);
                cmd.Parameters.AddWithValue("@Stud_Name", Name);
                cmd.Parameters.AddWithValue("@Stud_Dob", Dob);
                cmd.Connection = con;
                int no_ofrows = cmd.ExecuteNonQuery();
                if (no_ofrows > 0)
                {
                    students.Add(new Student(Id, Name, Dob));  
                }
                else
                {
                    Console.WriteLine("OOPS !! Encounterd Problem");
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static List<Student> ListOfStudents(List<Student> students)
        {
            con = getConnection();
            cmd = new SqlCommand("select * from StudentInfo", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Student Details.......");
                Console.WriteLine("************************");
                Console.WriteLine("Student ID : {0}", dr[0]);
                Console.WriteLine("Student Name : {0}", dr[1]);
                Console.WriteLine("Student Date of Birth : {0}", dr[2]);
                // Console.WriteLine("Enrolled Course ID : {0}", dr[3]);
                students.Add(new Student((int)dr[0], (string)dr[1], (DateTime)dr[2]));
            }
            dr.Close();
            con.Close();
            return students;
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static List<Course> ListOfCourses(List<Course> course)
        {
            con = getConnection();
            cmd = new SqlCommand("select * from CourseInfo", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Course Details.......");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Course ID : {0}", dr[0]);
                Console.WriteLine("Course Name : {0}", dr[1]);
                Console.WriteLine("Course Duration : {0}", dr[2]);
                Console.WriteLine("Course Fee : {0}", dr[3]);
              //  course.Add(new Course ((int)dr[0],(string)dr[1],(int)dr[2],(float)dr[3]));
            }
            dr.Close();
            con.Close();
            return course;
        }

      //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public static void enroll()
        {
            Enroll enroll = new Enroll();
            try
            {
                int sid, cid,eid;
             
                con = getConnection();
                Console.WriteLine("Enter your Student ID : ");
                sid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter ID of the Course to be selected : ");
                cid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter EnrollmentId to be selected : ");
                eid = int.Parse(Console.ReadLine());
                cmd = new SqlCommand("insert into EnrollInfo values(@eid,@stid,@coid,@dt)", con);
                cmd.Parameters.AddWithValue("@eid", eid);
                cmd.Parameters.AddWithValue("@stid", sid);
                cmd.Parameters.AddWithValue("@coid", cid);
                cmd.Parameters.AddWithValue("@dt", DateTime.UtcNow);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data Insertion Successfully !!!");
                }
                else
                {
                    Console.WriteLine("OOPS !!Something Went wrong while inserting ");
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        public static List<Enroll> ListOfEnrollment(List<Enroll> enrolls)
        {
            con = getConnection();
            cmd = new SqlCommand("select * from EnrollInfo", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("******************Student Enrollment Details************************");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Student ID : {0}", dr[0]);
                Console.WriteLine("Course ID : {0}", dr[1]);
                Console.WriteLine("Date of Enrollment : {0}", dr[2]);
           
                enrolls.Add(new Enroll());
            }
            dr.Close();
            con.Close();
            return enrolls;
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static SqlConnection getConnection()
        {
            con = new SqlConnection(connections);
            con.Open();
            return con;
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static void GetPerStudDetails()
        {
            Console.WriteLine("Enter your Student ID ");
            int Id = int.Parse(Console.ReadLine());
            con = getConnection();
            cmd = new SqlCommand("select * from StudentInfo where Stud_Id = @sid");
            cmd.Parameters.AddWithValue("@sid", Id);
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("************************Student Details****************************");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Student ID : {0}", dr[0]);
                Console.WriteLine("Student Name : {0}", dr[1]);
                Console.WriteLine("Student Date of Birth : {0}", dr[2]);
            }
            dr.Close();
            con.Close();
        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static void GetPerCourseDetails()
        {
            Console.WriteLine("Enter your Course ID : ");
            int id = int.Parse(Console.ReadLine());
            con = getConnection();
            cmd = new SqlCommand("select * from courseInfo where Cour_Id = @cid");
            cmd.Parameters.AddWithValue("@cid", id);
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Course Details.......");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Course ID : {0}", dr[0]);
                Console.WriteLine("Course Name : {0}", dr[1]);
                Console.WriteLine("Course Duration : {0}", dr[2]);
                Console.WriteLine("Course Fee : {0}", dr[3]);
            }
            dr.Close();
            con.Close();
        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static void DeleteCourse()
        {
            con = getConnection();
            Console.WriteLine("Enter the Course Id to be Deleted : ");
            int cid = int.Parse(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from courseInfo where Cour_Id = @cid",con);
            cmd1.Parameters.AddWithValue("@cid", cid);
            try
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                dr1.Close();
               

                Console.WriteLine("Are you sure you want to to Delete the above Data : yes or no");
                string status = Console.ReadLine();
                if ((status == "Yes"))
                {
                    cmd = new SqlCommand("delete from courseInfo where Cour_Id = @cid");
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Course  Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Something Went wrong in the Deletion Process");
                    }
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++================
        public static void UpdateCourseInfo()
        {
            con = getConnection();
            Console.WriteLine("Enter the Course Id to be Updated : ");
            int cid = int.Parse(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from courseInfo where Cour_Id = @cid", con);
            cmd1.Parameters.AddWithValue("@cid", cid);
            try
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                dr1.Close();
                // con.Close();

                Console.WriteLine("Are you sure you want to update Course Information : yes or no");
                string status = Console.ReadLine();
                if ((status == "yes") )
                {
                    Console.WriteLine(" Enter the Course Duration and Course Fee ");
                    int cd = int.Parse(Console.ReadLine());
                    float cf = float.Parse(Console.ReadLine());
                    cmd = new SqlCommand("update courseInfo set Cour_Duration = @cdur,Cour_Fee = @cfee where Cour_Id = @cid");
                    cmd.Parameters.AddWithValue("@cdur", cd);
                    cmd.Parameters.AddWithValue("@cfee", cf);
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Updated Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Something Went wrong in the Updation Procedure Process");
                    }
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static void UpdateStudInfo()
        {
            con = getConnection();
            Console.WriteLine("Enter the Student Id to be Updated : ");
            int sid = int.Parse(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from StudentInfo where Stud_Id = @stid", con);
            cmd1.Parameters.AddWithValue("@stid", sid);
            try
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                dr1.Close();
                // con.Close();
                Console.WriteLine("Please Re-Confirm to Update the Student Birth Date : yes or no");
                string status = Console.ReadLine();
                if ((status == "yes"))
                {
                    Console.WriteLine("Enter new Date of Birth : ");
                    DateTime dt = Convert.ToDateTime(Console.ReadLine());
                    cmd = new SqlCommand("update StudentInfo set Stud_Dob = @date where Stud_Id = @stid");
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@stid", sid);
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Updated Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Something Went wrong in the Updation Procedure Process");
                    }
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        public static void DeleteStudent()
        {
            con = getConnection();
            Console.WriteLine("Enter the Student Id to be Deleted : ");
            int sid = int.Parse(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from StudentInfo where Stud_Id = @stid", con);
            cmd1.Parameters.AddWithValue("@stid", sid);
            try
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                dr1.Close();
                // con.Close();
                Console.WriteLine("Are you sure you want to Delete the above Student : yes or no");
                string status = Console.ReadLine();
                if ((status == "yes"))
                {
                    cmd = new SqlCommand("delete from StudentInfo where Stud_Id = @stid");
                    cmd.Parameters.AddWithValue("@stid", sid);
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Something Went wrong in the Deletion Process");
                    }
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
}