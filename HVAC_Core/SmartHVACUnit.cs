namespace HVAC_Core
{
    public class SmartHVACUnit : HVACUnit, IDiagnosable
    {
        public bool IsWifiEnabled { get; set; }

        // Required parameterless constructor for XML serialization
        public SmartHVACUnit() : base()
        {
        }

        public SmartHVACUnit(string brand, string modelNumber, string systemType, double tonnage, double seerRating, bool isWifiEnabled)
            : base(brand, modelNumber, systemType, tonnage, seerRating)
        {
            IsWifiEnabled = isWifiEnabled;
        }

        public string RunSystemDiagnostics()
        {
            return $"Initiating diagnostics on {Brand} {ModelNumber}... Network Status: {(IsWifiEnabled ? "Connected" : "Offline")}. All systems nominal.";
        }
    }
}