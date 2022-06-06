using dsd01IFproject.Operations;

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

        [Required(ErrorMessage = "Pass Mark is required.")]
        [Display(Name = "Pass Mark")]
        public float PassMark { get; set; } = 50;

        [Display(Name = "All Student Average")]
        public float StudentAverage { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = "Grendal";
        [Display(Name = "Pass 1 ")]
        public bool Pass1 { get; set; }
        [Display(Name = "Pass All")]
        public bool PassAll { get; set; }
        [Display(Name = "Pass 3")]
        public bool Pass3 { get; set; }
        [Display(Name = "Student Results")]
        public List<string>? StudentResults { get; set; } = new List<string>();





        public void OnPost()
        {


            //this exerccise can be the first to show methods.

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



                StaticList.StaticStudentResults.Add(Name + " Pass 1 = " + Pass1 + ". Pass All = " + PassAll + ". Pass 3 = " + Pass3 + ".  Student Average = " + StudentAverage);

                StudentResults.AddRange(StaticList.StaticStudentResults);
            }


        }



        public void OnGet()
        {

        }
    }
}