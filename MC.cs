using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// This is a MC class
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Licenseplate for the MC
        /// </summary>
        public string Licenseplate;

        /// <summary>
        /// Date of entry
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// Returns price
        /// </summary>
        /// <returns>120</returns>
        public double Price()
        {
            return 120;
        }

        /// <summary>
        /// Returns Vehicle type
        /// </summary>
        /// <returns>"MC"</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
