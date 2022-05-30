using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace dsd01IFproject.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        [Display(Name = "Marks 1")]
        public float Marks1 { get; set; }
        [Display(Name = "Marks 2")]
        public float Marks2 { get; set; }
        [Display(Name = "Marks 3")]
        public float Marks3 { get; set; }
        [Display(Name = "Marks 4")]
        public float Marks4 { get; set; }
        [Display(Name = "Pass Mark")]
        public float PassMark { get; set; }
        [Display(Name = "All Student Average")]
        public float StudentAverage { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Pass 1 ")]
        public string Pass1 { get; set; }
        [Display(Name = "Pass All")]
        public string PassAll { get; set; }
        [Display(Name = "Pass 3")]
        public string Pass3 { get; set; }
        [Display(Name = "Student Results")]
        public List<string> StudentResults { get; set; }




        public IndexModel()
        {
            StudentResults = new List<string>();
        }

        public void OnGet()
        {

        }
    }
}