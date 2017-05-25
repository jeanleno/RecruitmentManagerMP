using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentManagerMP.Models
{
    public class Candidate
    {
        [Key]
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? HTML { get; set; }
        public int? JavaScript { get; set; }
        public int? CSS { get; set; }
        public int? Python { get; set; }
        public int? Django { get; set; }
        public int? DevIOS { get; set; }
        public int? DevAndroid { get; set; }
    }
}