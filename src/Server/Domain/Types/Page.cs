namespace Domain.Types
{
    public class Page<TEntity> where TEntity : Entity
    {
        public IEnumerable<TEntity>? Results { get; init; }
        public long TotalResults { get; init; }
        public long TotalPages { get; init; }
        public long CurrentPage { get; init; }
        public long PreviousPage { get; init; }
        public long NextPage { get; init; }
        public bool IsLast { get; init; }
        public bool IsEmpty { get; init; }


        private Page ()
        {

        }

        private Page (IEnumerable<TEntity>? results, long totalResults, 
            long totalPages, long currentPage, bool isLast, bool isEmpty)
        {
            Results = results;
            TotalResults = totalResults;
            TotalPages = totalPages;
            CurrentPage = currentPage;
            IsLast = isLast;
            IsEmpty = isEmpty;
        }


        public Page<TEntity> Empty() => new(new List<TEntity>(), 0, 0, 0, false, true);

        public Page<TEntity> CreatePage(IEnumerable<TEntity>? results, long totalResults, long totalPages, long currentPage, bool isLast, bool isEmpty) 
            => new(results, totalResults, totalPages, currentPage, isLast, isEmpty);
    }
}
