namespace Quiz1_Console
{
    class Student : Person
    {
        readonly string studentNumber;

        public Student(string fName, string lName, string mName, string nameSuffix, string studentNumber) : base(fName, lName, mName, nameSuffix)
        {
            this.studentNumber = studentNumber;

        }

        public string StudentNumber => studentNumber;


    }
}
