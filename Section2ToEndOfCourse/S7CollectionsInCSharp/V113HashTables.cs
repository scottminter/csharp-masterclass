using System;
using System.Collections;

namespace S7CollectionsInCSharp
{
	public class V113HashTables
	{
		public static void Lesson()
		{
            Hashtable studentTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 3.74f);
            Student stud2 = new Student(2, "Jason", 4.01f);
            Student stud3 = new Student(3, "Jessie", 3.92f);

            studentTable.Add(stud1.id, stud1);
            studentTable.Add(stud2.id, stud2);
            studentTable.Add(stud3.id, stud3);

            Student storedStud1 = (Student)studentTable[stud1.id];
            storedStud1.Display();

            foreach(DictionaryEntry entry in studentTable)
            {
                Student temp = (Student)entry.Value;
                temp.Display();
            }
		}

        public static void Challenge()
        {
            Student[] students = new Student[6];
            students[0] = new Student(1, "Scott", 3.84f);
            students[1] = new Student(2, "Jessie", 4.02f);
            students[2] = new Student(6, "Rudy", 3.95f);
            students[3] = new Student(1, "Katie", 2.76f);
            students[4] = new Student(4, "Jon", 3.25f);
            students[5] = new Student(6, "Ev", 3.81f);


            Hashtable studentsTable = new Hashtable();
            for(int i = 0; i < students.Length; i++)
            {
                //students[i].Display();
                if (!studentsTable.ContainsKey(students[i].id))
                {
                    studentsTable.Add(students[i].id, students[i]);
                }
                else
                {
                    Console.WriteLine($"A student with ID {students[i].id} already exists.");
                }
            }

            foreach(DictionaryEntry student in studentsTable)
            {
                Student temp = (Student)student.Value;
                temp.Display();
            }
        }
	}

    class Student
    {
        public int id { get; set; }

        public string name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.id = id;
            this.name = name;
            this.GPA = GPA;
        }

        public void Display()
        {
            Console.WriteLine($"id : {this.id}");
            Console.WriteLine($"name: {this.name}");
            Console.WriteLine($"GPA: {this.GPA}");
        }
    }
}

