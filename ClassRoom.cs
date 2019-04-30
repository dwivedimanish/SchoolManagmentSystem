using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class ClassRoom
    {
        private string className;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();

        public ClassRoom()
        {
            this.setClassname();
            this.addTeachers();
            this.addStudents();
        }

        private void setClassname()
        {
            Console.WriteLine("Enter Class Name");
            this.className = Console.ReadLine();
        }

        public string getClassName()
        {
            return this.className;
        }

        public void addStudents()
        {
            do
            {
                Console.WriteLine("Adding Students to Class Room");
                students.Add(new Student());
                Console.WriteLine("Do You want to add more Students : Y/N");
            } while (Console.ReadLine().ToUpper().Equals("Y"));
        }

        public List<Student> getStudents()
        {
            return this.students;
        }

        public void addTeachers()
        {
            Console.WriteLine("Adding Teachers to Class Room");
            do
            {
                teachers.Add(new Teacher());
                Console.WriteLine("Do You want to add more Teachers : Y/N");
            } while (Console.ReadLine().ToUpper().Equals("Y"));
        }

        public List<Teacher> getTeachers()
        {
            return this.teachers;
        }

        public void deleteTeacher(String teacherName)
        {
            List<Teacher> temp = new List<Teacher>();
            foreach(Teacher sTeacher in teachers)
            {
                if (!sTeacher.getName().Equals(teacherName))
                {
                    temp.Add(sTeacher);
                }
            }
            Console.WriteLine(teacherName + " Teacher Deleted");
            this.teachers = temp;
        }

        public void deleteStudent(String studentName)
        {
            List<Student> temp = new List<Student>();
            foreach (Student student in students)
            {
                if (!student.getName().Equals(studentName))
                {
                    temp.Add(student);
                }
            }
            Console.WriteLine(studentName + " Student Deleted");
            this.students = temp;
        }

        public void displayClassroom(ClassRoom classroom)
        {
            Console.WriteLine("Class Name : " + classroom.getClassName());
            foreach(Teacher teacher in classroom.getTeachers())
            {
                teacher.displayTeacherInformation();
            }

            foreach (Student student in classroom.getStudents())
            {
                student.displayStudentInformation();
            }
        }
    }
}
