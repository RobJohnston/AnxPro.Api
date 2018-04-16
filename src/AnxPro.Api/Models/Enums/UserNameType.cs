namespace AnxPro.Api.Models
{
    public enum UserNameType
    {
        /// <summary>
        /// Use phone number as username.
        /// </summary>
        PHONENUMBER,

        /// <summary>
        /// Use email as username.
        /// </summary>
        EMAIL,

        /// <summary>
        /// Use UUID as username.
        /// </summary>
        UUID
    }
}
