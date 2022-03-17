using System;
using System.Collections.Generic;
using System.Text;

namespace _17032022
{
    internal class Group
    {
        private string _no;
        private int _studentLimit;
        public Student[] students = new Student[0];

        public string No
        {
            get => _no;
            set
            {
                if (CheckNo(value))
                    _no = value;
            }
        }

        public int StudentLimit
        {
            get => _studentLimit;
            set
            {
                if (value >= 5 && value <= 18)
                    _studentLimit = value;
            }
        }


        public bool CheckNo(string no)
        {
            if (!string.IsNullOrWhiteSpace(no) && no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]))
            {
                for (int i = 2; i < 5; i++)
                {
                    if (!char.IsDigit(no[i]))
                        return false;
                }

                return true;
            }

            return false;
        }

        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
        }

        public Student[] FilterStudentByName(string search)
        {
            Student[] filteredStudents = new Student[0];
            for (int i = 0; i < students.Length; i++)
            {
                if ($"{students[i].Name} {students[i].Surname}".ToLower().Contains(search.ToLower()))
                {
                    Array.Resize(ref filteredStudents, filteredStudents.Length + 1);
                    filteredStudents[filteredStudents.Length - 1] = students[i];
                }
            }

            return filteredStudents;
        }
    }
}
