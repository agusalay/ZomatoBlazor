using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
        public int MaxResult { get; set; } = 100;
    }
}
