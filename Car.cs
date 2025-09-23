namespace Bridge
{
    /// <summary>
    /// This is a Car class
    /// </summary>
    public class Car : BaseVehicle
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
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returns the type of vehicle
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
