namespace FabianMusic.Models.ViewModels
{
    public abstract class GridData
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 4;
        public string SortDirection { get; set; } = "asc";
        public string SortField { get; set; } = string.Empty;

        public int GetTotalPages(int count) => (count + PageSize - 1) / PageSize;

        public void SetSortAndDirection(string newSortField, GridData current)
        {
            SortField = newSortField;

            if (current.SortField.EqualsNoCase(newSortField) && current.SortDirection == "asc")
                SortDirection = "desc";
            else
                SortDirection = "asc";
        }

        public GridData Clone() => (GridData)MemberwiseClone();

        public virtual Dictionary<string, string> ToDictionary() => new Dictionary<string, string>()
    {
        { nameof(PageNumber), PageNumber.ToString() },
        { nameof(PageSize), PageSize.ToString() },
        { nameof(SortField), SortField.ToString() },
        { nameof(SortDirection), SortDirection.ToString() },

    };



    }
}
