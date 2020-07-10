using System.ComponentModel;
using Newtonsoft.Json;

namespace gql1.Models
{
    // VehicleDto myDeserializedClass = JsonConvert.DeserializeObject<VehicleDto>(myJsonResponse); 

    public class VehicleDto
    {
        public decimal Barrels08 { get; set; }
        public decimal BarrelsA08 { get; set; }
        public int Charge120 { get; set; }
        public int Charge240 { get; set; }
        public double City08 { get; set; }
        public double City08U { get; set; }
        public double CityA08 { get; set; }
        public double CityA08U { get; set; }
        public double CityCd { get; set; }
        public double CityE { get; set; }
        public double CityUf { get; set; }
        public double Co2 { get; set; }
        public double Co2A { get; set; }
        public decimal Co2TailpipeAGpm { get; set; }
        public decimal Co2TailpipeGpm { get; set; }
        public double Comb08 { get; set; }
        public double Comb08U { get; set; }
        public double CombA08 { get; set; }
        public double CombA08U { get; set; }
        public double CombE { get; set; }
        public double CombinedCd { get; set; }
        public double CombinedUf { get; set; }
        [DefaultValue(0)]
        public int? Cylinders { get; set; }
        [DefaultValue(0.0)]
        public double? Displ { get; set; }
        public string? Drive { get; set; }
        public int EngId { get; set; }
        public string? EngDscr { get; set; }
        public int FeScore { get; set; }
        public int FuelCost08 { get; set; }
        public int FuelCostA08 { get; set; }
        public string? FuelType { get; set; }
        public string? FuelType1 { get; set; }
        public double GhgScore { get; set; }
        public double GhgScoreA { get; set; }
        public double Highway08 { get; set; }
        public double Highway08U { get; set; }
        public double HighwayA08 { get; set; }
        public double HighwayA08U { get; set; }
        public double HighwayCd { get; set; }
        public double HighwayE { get; set; }
        public double HighwayUf { get; set; }
        public int Hlv { get; set; }
        public int Hpv { get; set; }
        public int Id { get; set; }
        public int Lv2 { get; set; }
        public int Lv4 { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? MpgData { get; set; }
        public bool PhevBlended { get; set; }
        public int Pv2 { get; set; }
        public int Pv4 { get; set; }
        public int Range { get; set; }
        public int RangeCity { get; set; }
        public int RangeCityA { get; set; }
        public int RangeHwy { get; set; }
        public int RangeHwyA { get; set; }
        public string? Trany { get; set; }
        [DefaultValue(0.0)]
        public double UCity { get; set; }
        public double UCityA { get; set; }
        public double UHighway { get; set; }
        public double UHighwayA { get; set; }
        public string? VClass { get; set; }
        public int Year { get; set; }
        public int YouSaveSpend { get; set; }
        [JsonProperty("guzzler")]
        public string? Guzzler { get; set; }
        public string? TransDscr { get; set; }
        public string? TCharger { get; set; }
        public string? SCharger { get; set; }
        public string? AtvType { get; set; }
        public string? FuelType2 { get; set; }
        public string? RangeA { get; set; }
        public string? EvMotor { get; set; }
        public string? MfrCode { get; set; }
        public string? C240Dscr { get; set; }
        public int Charge240B { get; set; }
        public string? C240BDscr { get; set; }
        public string? CreatedOn { get; set; }
        public string? ModifiedOn { get; set; }
        public string? StartStop { get; set; }
        public int PhevCity { get; set; }
        public int PhevHwy { get; set; }
        public int PhevComb { get; set; }
    }
}
