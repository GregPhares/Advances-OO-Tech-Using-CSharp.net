using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This program is designed to show how delagates and events work together allowingr for them to be used
/// in mutliple classes and be called in multiple methods
/// </summary>
namespace Hw5
{
    class Program
    {
        // The executable of the program
        static void Main(string[] args)
        {
            Course theCourse = new Course("CS 3020 001");
            Student theStudent1 = new Student("Neytiri");
            theCourse.SubscribeAnnouncements(theStudent1.NewAnnouncement);

            Student theStudent2 = new Student("Jake Sully");
            theCourse.SubscribeAnnouncements(theStudent2.NewAnnouncement);

            Program program = new Program();
            theCourse.SubscribeAnnouncements(program.Annonymous);
            theCourse.StartCourse();
        }

        //This method will pass in the Annonymous string to the main
        public void Annonymous(AnnouncementEventArgs eventArgs)
        {
            string announce = eventArgs.GetAnnouncement();
            Console.WriteLine("Anonymous method received announcement: {0}", announce);
        }
    }

    //This class Creates the annouencement object
    class AnnouncementEventArgs : EventArgs
    {
        private readonly string announcement;

        //constructor
        public AnnouncementEventArgs(string announcement)
        {
            this.announcement = announcement;
        }

        //gets the announcement
        public string GetAnnouncement()
        {
            return this.announcement;
        }
    }

    //This class creates the course object
    class Course
    {
        public delegate void CourseAnnouncementHandler(AnnouncementEventArgs eventArgs);
        public event CourseAnnouncementHandler Announcement;
        private readonly string name;

        //constructor
        public Course(string name)
        {
            this.name = name;
        }
        
        //inicializes the course
        public void StartCourse()
        {
            Announcement(new AnnouncementEventArgs("The course "+name+" has started for the Fall 2019 semester"));
        }

        //Keeps track of the annoucement
        public void SubscribeAnnouncements(CourseAnnouncementHandler courseHandler)
        {
            this.Announcement += courseHandler;
        }
    }

    //creates the student object
    class Student
    {
        private string name;

        //contructor
        public Student(string name)
        {
            this.name = name;
        }

        //Prints out the full announcement
        public void NewAnnouncement(AnnouncementEventArgs eventArgs)
        {
            string announce = eventArgs.GetAnnouncement();
            Console.WriteLine("{0} received announcement: {1}", name, announce);
        }
    }
}
