using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;

namespace gql1.Models
{
    public static class AppState
    {
        public static List<int> Years;
        public static List<string?> Makes;
        private static List<VehicleDto> _vehicles = null;
        private static readonly Semaphore EnsureOnlyOne = new Semaphore(1, 1);
        public static int VehicleCount { get; private set; }

        public static List<VehicleDto> Vehicles
        {
            get => _vehicles;
            set
            {
                _vehicles = value;
                VehicleCount = (value?.Count ?? 0);
                Years = _vehicles.Select(vehicle => vehicle.Year)
                    .Distinct()
                    .OrderBy(year => year)
                    .ToList();
                Makes = _vehicles
                    .Where(x => x.Make != null)
                    .Select(x => x.Make)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
            }
        }

        public static void Load()
        {
            if (IsValid()) return;
            EnsureOnlyOne.WaitOne();
            using StreamReader file = File.OpenText(@"assets/vehicles.json");
            var serializer = new JsonSerializer();
            serializer.Error += (sender, args) => { args.ErrorContext.Handled = true; };

            Vehicles = (List<VehicleDto>) serializer.Deserialize(file, typeof(List<VehicleDto>));
            Console.WriteLine($"Loaded {_vehicles?.Count ?? 0} vehicles.");
            EnsureOnlyOne.Release();
        }

        public static bool IsValid()
        {
            return Vehicles != null && Vehicles.Count > 0;
        }
    }
}
