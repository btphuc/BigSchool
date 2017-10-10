using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        // Entity FrameWork Code First trường "Id" mặc định là khóa chính tự động tăng
        public int Id { get; set; }

        // Khóa ngoại đi theo 1 cặp  public tên class và public tên class - id
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        
        public DateTime DateTime { get; set; }

        // Khóa ngoại đi theo 1 cặp  public tên class và public tên class - id
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}