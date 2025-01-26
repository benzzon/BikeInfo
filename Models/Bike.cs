using System.Text.Json.Serialization;

namespace BikeInfo.Models
{
    public class Bike
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("photo")]
        public string Photo { get; set; }

        [JsonPropertyName("submodel")]
        public string Submodel { get; set; }

        [JsonPropertyName("enginepowerhp")]
        public string EnginePowerHp { get; set; }

        [JsonPropertyName("accelerationto100")]
        public object AccelerationTo100 { get; set; }  // Can be string or boolean

        [JsonPropertyName("countryoforigin")]
        public string CountryOfOrigin { get; set; }

        [JsonPropertyName("cylindersalignment")]
        public object CylindersAlignment { get; set; }

        [JsonPropertyName("displacement")]
        public string Displacement { get; set; }

        [JsonPropertyName("dryweight")]
        public string DryWeight { get; set; }

        [JsonPropertyName("enginestroke")]
        public string EngineStroke { get; set; }

        [JsonPropertyName("fronttire")]
        public string FrontTire { get; set; }

        [JsonPropertyName("fuelcapacityliters")]
        public string FuelCapacityLiters { get; set; }

        [JsonPropertyName("fuelsystem")]
        public string FuelSystem { get; set; }

        [JsonPropertyName("oilcapacityliters")]
        public string OilCapacityLiters { get; set; }

        [JsonPropertyName("reartire")]
        public string RearTire { get; set; }

        [JsonPropertyName("topspeed")]
        public string TopSpeed { get; set; }

        [JsonPropertyName("valvespercylinder")]
        public string ValvesPerCylinder { get; set; }

        [JsonPropertyName("yearsformodelgen")]
        public string YearsForModelGen { get; set; }
    }
}
