using System.Collections.Generic;
namespace ComicsStore.Models.ViewModels
{
    public class ComicsListViewModel
    {
        public IEnumerable<Comic> Comics { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}