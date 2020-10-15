using System;

namespace Quiz1_Console
{
    class Person
    {
        DateTime dateOfBirth = DateTime.Now.AddYears(-10);

        public Person(string fName, string lName, string mName, string nameSuffix)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.MiddleName = mName;
            this.NameSuffix = nameSuffix;

        }

        public string FirstName { get; }

        public string LastName { get; }
        public string MiddleName { get; }
        public string NameSuffix { get; }
        public string FullName => $"{FirstName} {MiddleName} {LastName} {NameSuffix}";

        public void SetBday(DateTime date)
        {
            if (date <= DateTime.Now.AddYears(-110))
            {
                throw new Exception("Invalid birth date");
            }

            this.dateOfBirth = date;
        }

        public DateTime GetBday() => dateOfBirth;

    }
}
