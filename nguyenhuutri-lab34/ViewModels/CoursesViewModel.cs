using nguyenhuutri_lab34.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenhuutri_lab34.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}