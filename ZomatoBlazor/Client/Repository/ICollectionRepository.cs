using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZomatoBlazor.Shared.Dto;

namespace ZomatoBlazor.Client.Repository
{
    public interface ICollectionRepository
    {
        Task<CollectionList> GetCollection(string cityId);
    }
}
