using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [TimeValid]
        public string Time { get; set; }
        [Required]
        public string Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime getDateTime()
        {
            string datetime = Date + " " + Time;
            return DateTime.ParseExact(datetime, "dd/M/yyyy HH:mm", CultureInfo.InvariantCulture);
        }

    }
}