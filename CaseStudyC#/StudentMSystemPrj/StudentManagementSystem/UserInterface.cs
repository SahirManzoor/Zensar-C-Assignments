using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentManagementSystem
{
	abstract class UserInterface
	{
		public abstract void showFirstScreen();
		public abstract void showStudentScreen();
		public abstract void showAdminScreen();
		public abstract void showAllStudentsScreen();
		public abstract void showStudentRegistrationScreen(); // Execute the register method of AppEngine class
		public abstract void introduceNewCourseScreen();
		public abstract void showAllCoursesScreen();
	}
}
