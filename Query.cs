using System.Collections.Generic;
using System.Linq;
using gql1.Models;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace gql1
{
    public class Query
    {
        public Greetings GetGreetings() => new Greetings();
        public string HelloWorld() => "Hello";
        public Character GetCharacter() => new Character();
        
        // [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<VehicleDto> GetVehicle() => AppState.Vehicles.AsQueryable();
    }

    public class Greetings
    {
        public string Hello() => "World";
    }

    public class Character
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Luke";
    }
}


// gatsby new epa_vehicles https://github.com/dominicabela/gatsby-starter-material-ui
