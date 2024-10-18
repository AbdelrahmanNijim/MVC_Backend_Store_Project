namespace Store.PL.Areas.Dashboard.ViewModels
{
    public class ServiceDetailsVm
    {

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string ImageName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
