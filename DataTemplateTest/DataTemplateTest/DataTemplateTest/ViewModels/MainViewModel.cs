using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;

namespace DataTemplateTest.ViewModels
{
    public class MainViewModel : BaseModel
    {
        public MainViewModel()
        {
            ObservableCollection<Course> courseList = new ObservableCollection<Course>();

            for (int i = 0; i < 100; i++)
            {
                Course course = new Course()
                {
                    CourseName = "Course " + i,
                    CategoryName = "category " + i,
                    CompletionPercentage = i,
                    CourseImage = "https://thumbs-prod.si-cdn.com/qXrJJ-l_jMrQbARjnToD0fi-Tsg=/800x600/filters:no_upscale()/https://public-media.si-cdn.com/filer/d6/93/d6939718-4e41-44a8-a8f3-d13648d2bcd0/c3npbx.jpg"
                };

                courseList.Add(course);
            }

            this.Courses = courseList;
        }

        private ObservableCollection<Course> courses;
        public ObservableCollection<Course> Courses
        {
            get => this.courses;
            set
            {
                this.courses = value;
                this.RaisePropertyChanged("Courses");
            }
        }
    }

    public class Course
    {
        public string CourseName { get; set; }

        public string CategoryName { get; set; }

        public double CompletionPercentage { get; set; }

        public string CourseImage { get; set; }

        public static T ConvertValue<T>(object value)
        {
            if (typeof(T) == typeof(int))
            {
                return (T)(object)Convert.ToInt32(value, CultureInfo.InvariantCulture);
            }
            else if (typeof(T) == typeof(bool))
            {
                return (T)(object)Convert.ToBoolean(value, CultureInfo.InvariantCulture);
            }
            else if (typeof(T) == typeof(double))
            {
                return (T)(object)Convert.ToDouble(value, CultureInfo.InvariantCulture);
            }
            else if (typeof(T) == typeof(DateTime))
            {
                return (T)(object)Convert.ToDateTime(value, CultureInfo.InvariantCulture);
            }
            else if (typeof(T) == typeof(string))
            {
                return (T)(object)Convert.ToString(value, CultureInfo.InvariantCulture);
            }

            return default(T);
        }
    }

    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
