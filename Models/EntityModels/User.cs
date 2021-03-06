namespace LibraryAPI.Models.EntityModels {
    /// <summary>
    /// An entity model of a user that is used as the 
    /// data structure in our database.
    /// This model should not be exposed to the user!
    /// </summary>
    public class User {
        /// <summary>
        /// The Id of the user.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Home address of the user.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// The email of the user.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The phone number of the user.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// If true, the user has been deleted and should not show up in any get request
        /// </summary>
        public bool Deleted { get; set; }

    }
}