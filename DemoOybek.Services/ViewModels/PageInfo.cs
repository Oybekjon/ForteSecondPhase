namespace DemoOybek.Services.ViewModels
{
    public class PageInfo
    {
        public bool NextButton { get; set; }
        public bool PreviousButton { get; set; }
        public int[] Pages { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        
        public int TotalCount { get; set; }
    }
}