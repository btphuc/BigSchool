using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModels
    {
        [Required(ErrorMessage = "Địa điểm không thể bỏ trống")]
        [Display(Name ="Địa điểm")]
        public string Place { get; set; }

        [Required(ErrorMessage = "Ngày không thể bỏ trống")]
        [FutureDate(ErrorMessage = "Ngày phải có dạng dd/M/yyyy và phải lớn hơn ngày hiện tại")]
        [Display(Name = "Ngày")]
        public string Date { get; set; }
        
        [Required(ErrorMessage = "Giờ không thể bỏ trống")]
        [ValidTime(ErrorMessage = "Giở phải có dạng HH:mm")]
        [Display(Name = "Giờ")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Category không thể bỏ trống")]
        [Display(Name = "Category")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date, Time));
        }
    }
}