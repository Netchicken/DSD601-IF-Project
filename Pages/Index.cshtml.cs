using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace dsd01IFproject.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        [Display(Name = "Marks 1")]
        public float Marks1 { get; set; } = 54;
        [Display(Name = "Marks 2")]
        public float Marks2 { get; set; } = 45;
        [Display(Name = "Marks 3")]
        public float Marks3 { get; set; } = 45;
        [Display(Name = "Marks 4")]
        public float Marks4 { get; set; } = 34;
        [Display(Name = "Pass Mark")]
        public float PassMark { get; set; } = 50;

        [Display(Name = "All Student Average")]
        public float StudentAverage { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; } = "Grendal";
        [Display(Name = "Pass 1 ")]
        public bool Pass1 { get; set; }
        [Display(Name = "Pass All")]
        public bool PassAll { get; set; }
        [Display(Name = "Pass 3")]
        public bool Pass3 { get; set; }
        [Display(Name = "Student Results")]
        public List<string> StudentResults { get; set; }





        public IndexModel()
        {
            StudentResults = new List<string>();

        }




        public void OnPost()
        {



            if (ModelState.IsValid)
            {

                StudentAverage = (Marks1 + Marks2 + Marks3 + Marks4) / 4;

                if (Marks1 > PassMark || Marks2 > PassMark || Marks3 > PassMark || Marks4 > PassMark)
                {
                    Pass1 = true;
                }

                if (Marks1 > PassMark && Marks2 > PassMark && Marks3 > PassMark && Marks4 > PassMark)
                {
                    PassAll = true;
                }

                if ((Marks1 > PassMark && Marks2 > PassMark && Marks3 > PassMark) || (Marks2 > PassMark && Marks3 > PassMark && Marks4 > PassMark) || (Marks3 > PassMark && Marks4 > PassMark && Marks1 > PassMark) || (Marks4 > PassMark && Marks1 > PassMark && Marks2 > PassMark))
                {
                    Pass3 = true;
                }

                StudentResults.Add(Name + " Pass 1 = " + Pass1 + ". Pass All = " + PassAll + ". Pass 3 = " + Pass3 + ".  Student Average = " + StudentAverage);
            }

            else
            {
                var error = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();


                if (error.Count > 0)
                {
                    StudentResults.AddRange((IEnumerable<string>)error);
                }

                StudentResults.Add("We have an error but don't know what it is");


            }


            //   return Page();
        }



        public void OnGet()
        {

        }
    }
}