namespace MyLabraryProject.Contracts
{
    public interface IBook
    {
        Task<IEnumerable<BookViewModel>> GetAll();
        Task Create(BookViewModelCreate model);
    }
}
