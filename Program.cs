using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Program
    {
        public static List<ClassRoom> classRooms = new List<ClassRoom>();

        static void Main(string[] args)
        {
            try
            {
                displayMenu();
            }
            catch (Exception e)
            {
                var path = Directory.GetCurrentDirectory() + @"\Aplication Exceptions.txt";
                File.WriteAllText(path, e.ToString());
                Console.WriteLine("Application Exception Occured, Launching Menu Again");
                displayMenu();
            }
        }

        static void displayMenu()
        {
            Console.WriteLine("Please select an Option from options provided below : "
                + "\n 1. Create/Add Classrooms"
                + "\n 2. Update Classrooms"
                + "\n 3. Delete Classrooms"
                + "\n 4. Diplay Classrooms"
                );
            string userInput = Console.ReadLine();
            performOperation(userInput);
        }

        public  static void performOperation(string operation)
        {
            switch (operation) {

                case "1":
                    Console.WriteLine("Starting Classroom Creation");
                    addClassRooms();
                    break;
                case "2":
                    Console.WriteLine("Starting Classroom Update");
                    updateClassrooms();
                    break;
                case "3":
                    Console.WriteLine("Starting Classroom Deleting Opretion");
                    deleteClassrooms();
                    break;
                case "4":
                    Console.WriteLine("Starting to Display Classrooms");
                    displayClassRooms();
                    break;
                default:
                    Console.WriteLine("Wrong Input \nGo Back to main Menu");
                    displayMenu();
                    break;
            }
            Console.WriteLine("Do You want To Launch Menu Again and Perform More Operations : Y/N" +
                "\nY : Display Menu" +
                "\nN : Quit Application");
            if(Console.ReadLine().ToUpper().Equals("Y"))
            {
                displayMenu();
            }
        }

        public static void addClassRooms()
        {
            do
            {
                classRooms.Add(new ClassRoom());
                Console.WriteLine("Do You want to add more Classrooms : Y/N");
            } while (Console.ReadLine().ToUpper().Equals("Y"));
        }

        public static void updateClassrooms()
        {
            Console.WriteLine("Enter The Class Name You want to Update");
            string className = Console.ReadLine();
            Console.WriteLine("Chose the Below Menu Option to Update"
                + "\n 1. Add Teacher"
                + "\n 2. Delete Teacher"
                + "\n 3. Add Students"
                + "\n 4. Delete Students");
            string userInput = Console.ReadLine();
            performUpdateClassroomOperations(className,userInput);
        }

        public static void performUpdateClassroomOperations(string className,string userInput)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Starting to Add Teacher");
                    addTeachers(className);
                    break;
                case "2":
                    Console.WriteLine("Starting to delete Teacher");
                    deleteTeachers(className);
                    break;
                case "3":
                    Console.WriteLine("Starting to Add Students");
                    addStudents(className);
                    break;
                case "4":
                    Console.WriteLine("Starting to delete Students");
                    deleteStudents(className);
                    break;
                default:
                    Console.WriteLine("Wrong Inputs \n Provide Inputs Again");
                    updateClassrooms();
                    break;

            }
            Console.WriteLine("Do You want To Update More Classes : Y/N" +
                "\nY : Display Update Class Menu" +
                "\nN : Quit Updating Classes");
            if (Console.ReadLine().ToUpper().Equals("Y"))
            {
                updateClassrooms();
            }
        }

        public static void addTeachers(string className)
        {
            foreach(ClassRoom classRoom in classRooms)
            {
                if (classRoom.getClassName().Equals(className))
                {
                    classRoom.addTeachers();
                }
            }
        }

        public static void deleteTeachers(string className)
        {
            Console.WriteLine("Enter Teacher Name to Remove");
            String teacherName = Console.ReadLine();
            foreach (ClassRoom classRoom in classRooms)
            {
                if (classRoom.getClassName().Equals(className))
                {
                    classRoom.deleteTeacher(teacherName);
                }
            }
        }

        public static void addStudents(string className)
        {
            foreach (ClassRoom classRoom in classRooms)
            {
                if (classRoom.getClassName().Equals(className))
                {
                    classRoom.addStudents();
                }
            }
        }

        public static void deleteStudents(string className)
        {
            Console.WriteLine("Enter Student Name to Remove");
            String studentName = Console.ReadLine();
            foreach (ClassRoom classRoom in classRooms)
            {
                if (classRoom.getClassName().Equals(className))
                {
                    classRoom.deleteStudent(studentName);
                }
            }
        }

        public static void deleteClassrooms()
        {
            List<ClassRoom> temp = new List<ClassRoom>();
            Console.WriteLine("Enter Name of the Class You want to Delete");
            String className = Console.ReadLine();
            foreach (ClassRoom classroom in classRooms)
            {
                if (!className.Equals(classroom.getClassName()))
                {
                    temp.Add(classroom);
                }
            }
            Console.WriteLine(className+" class Deleted");
            classRooms = temp;
        }

        public static void displayClassRooms()
        {
            if (classRooms.Count == 0)
            {
                Console.WriteLine("You have not created any Class room, Please create at least one class room and then select display option");
            }
            foreach(ClassRoom classroom in classRooms)
            {
                classroom.displayClassroom(classroom);
            }
        }
    }
}
