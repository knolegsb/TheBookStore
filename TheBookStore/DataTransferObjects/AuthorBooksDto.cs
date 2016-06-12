using Newtonsoft.Json;

namespace TheBookStore.DataTransferObjects
{
    public class AuthorBooksDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}