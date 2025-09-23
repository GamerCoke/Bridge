namespace Bridge
{
    /// <summary>
    /// This is a Car class
    /// </summary>
    public class Car
    {
        /// <summary>
        /// The license on the licenseplate, of the car
        /// </summary>
        public string Licenseplate;

        /// <summary>
        /// The Date for registration of transaction
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// Returns the price for crossing the bridge
        /// </summary>
        /// <returns>230</returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returns the type of vehicle
        /// </summary>
        /// <returns>"Car"</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
