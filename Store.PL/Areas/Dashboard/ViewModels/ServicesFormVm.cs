namespace Store.PL.Areas.Dashboard.ViewModels
{
    public class ServicesFormVm
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; } 

        public IFormFile? Image { get; set; }

        public string? Imagename { get; set; }

        public bool IsDeleted { get; set; }
    }
}
