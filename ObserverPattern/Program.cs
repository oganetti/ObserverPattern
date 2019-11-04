using System;
using ObserverPattern.Properties;

namespace ObserverPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Observer observerStudent = new ComputerStudent();
            Observer observerManagement = new ManagementStudent();

            Subject universityAnnouncement = new UniversityAnnouncement();
            universityAnnouncement.Register(observerStudent);
            universityAnnouncement.Register(observerManagement);
            universityAnnouncement.Notify("Tomorrow will be HOLIDAY!!!");

            universityAnnouncement.Remove(observerManagement);
            universityAnnouncement.Notify("Management Students are banned from the college.");

        }
    }
}
