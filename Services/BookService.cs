namespace MyLabraryProject.Services
{
    public class BookService : IBook
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public BookService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public IEnumerable<BookViewModel> Books { get; set; }
        public async  Task<IEnumerable<BookViewModel>> GetAll()
        {
            var response =  await _httpClient.GetAsync("https://localhost:7192/api/books");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };

                Books = JsonSerializer.Deserialize<IEnumerable<BookViewModel>>(json, jsonOptions)!;
            }

            return Books;
        }
    }
}

