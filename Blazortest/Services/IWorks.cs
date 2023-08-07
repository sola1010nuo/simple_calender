using Blazortest.Pages;


namespace Blazortest.Services
{
    public class Works
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Id { get; set; }
        public string Brief { get; set; }

    }
    public interface IWorks
    {
        List<Works> GetWorks();
    }
    public class Working : IWorks
    {
        private List<Works> works = new List<Works>();



        public List<Works> GetWorks()
        {
            return works;
        }
    }

}

