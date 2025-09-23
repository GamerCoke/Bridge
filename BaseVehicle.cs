using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// This is a Base class for Vehicle classes to inherit from
    /// </summary>
    public abstract class BaseVehicle
    {
        /// <summary>
        /// This is the licenseplate of the vehicle
        /// </summary>
        public string Licenseplate;

        /// <summary>
        /// This is the registered entry date
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// This is the price for the vehicle
        /// </summary>
        /// <returns>double</returns>
        public abstract double Price();

        /// <summary>
        /// This is the vehicle type
        /// </summary>
        /// <returns>string</returns>
        public abstract string VehicleType();
    }
}
