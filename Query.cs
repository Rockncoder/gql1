using System.Collections.Generic;
using System.Linq;
using gql1.Models;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace gql1
{
    public class Query
    {
        public string HelloWorld() => "Hello";
        
        //[UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<VehicleDto> GetVehicle() => AppState.Vehicles.AsQueryable();
    }
}


