namespace HVAC_Core
{
    public class HVACUnit
    {
        public string Brand { get; set; } = string.Empty;
        public string ModelNumber { get; set; } = string.Empty;
        public string SystemType { get; set; } = string.Empty;
        public double Tonnage { get; set; }
        public double SeerRating { get; set; }

        // Required parameterless constructor for XML serialization
        public HVACUnit()
        {
        }

        public HVACUnit(string brand, string modelNumber, string systemType, double tonnage, double seerRating)
        {
            Brand = brand;
            ModelNumber = modelNumber;
            SystemType = systemType;
            Tonnage = tonnage;
            SeerRating = seerRating;
        }

        public virtual double CalculateBtuCapacity()
        {
            return Tonnage * 12000;
        }
    }
}