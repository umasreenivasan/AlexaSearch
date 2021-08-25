using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System.Collections.Generic;

namespace AlexaSearch.Models
{
    public class SearchModel : SearchResultItem
    {
        [IndexField("_name")]
        public virtual string ItemName { get; set; }

        [IndexField("author_t")]
        public virtual string Author { get; set; }

        [IndexField("description_t")]
        public virtual string Description { get; set; } // Custom field on my template

        [IndexField("title_t")]
        public virtual string Title { get; set; } // Custom field on my template
    }

    public class SearchResult
    {
        public string ItemName { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// Custom search result model for binding to front end
    /// </summary>
    public class SearchResults
    {
        public List<SearchResult> Results { get; set; }
    }
}