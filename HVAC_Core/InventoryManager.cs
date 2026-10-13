using System.Collections.Generic;
using System.Linq;

namespace HVAC_Core
{
    public class InventoryManager
    {
        private readonly List<HVACUnit> _units = new()
        {
            new HVACUnit("Carrier", "Infinity 20", "Heat Pump", 3.0, 20.0),
            new HVACUnit("Trane", "XV20i", "Central Air", 4.0, 20.0),
            new SmartHVACUnit("Nest", "Learning Thermostat Pro", "Smart Split System", 2.5, 18.0, true)
        };

        public List<HVACUnit> GetAllUnits()
        {
            return _units;
        }

        public List<HVACUnit> GetUnitsByBrand(string brand)
        {
            return _units.Where(u => u.Brand.Equals(brand, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}