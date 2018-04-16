using System;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class VerifyPersonalCommand
    {
        /// <summary>
        /// First name.
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// M for male or F for female.
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Address line 1 (max 35 characters)
        /// </summary>
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// Address line 2 (max 35 characters) (optional)
        /// </summary>
        [JsonProperty("line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// Address line 3 (max 35 characters) (optional)
        /// </summary>
        [JsonProperty("line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// ZIP code.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Country calling code.
        /// </summary>
        [JsonProperty("callingCode")]
        public string CallingCode { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Nature of activity.
        /// </summary>
        [JsonProperty("natureOfActivity")]
        public string NatureOfActivity { get; set; }

        /// <summary>
        /// Nature of activity detail.
        /// </summary>
        [JsonProperty("natureOfActivityDetail")]
        public string NatureOfActivityDetail { get; set; }

        /// <summary>
        /// Declaration.
        /// </summary>
        [JsonProperty("declaration")]
        public bool Declaration { get; set; }

        /// <summary>
        /// Number of id document.
        /// </summary>
        [JsonProperty("idNumber")]
        public string IdNumber { get; set; }

        /// <summary>
        /// Date that id document valid from.
        /// </summary>
        [JsonProperty("idValidFrom")]
        public DateTime IdValidFrom { get; set; }

        /// <summary>
        /// Expired date of id document.  Optional by default. Mandatory if <c>IdValidToHasNoExpiryDate</c> set to false.
        /// </summary>
        [JsonProperty("idValidTo")]
        public DateTime? IdValidTo { get; set; }

        /// <summary>
        /// Id Valid To Has No Expiry Date.
        /// </summary>
        [JsonProperty("idValidToHasNoExpiryDate")]
        public bool IdValidToHasNoExpiryDate { get; set; }

        /// <summary>
        /// Additional instruction.
        /// </summary>
        [JsonProperty("additionalInstructions")]
        public string AdditionalInstructions { get; set; }

        /// <summary>
        /// Occupation in predefined list.
        /// </summary>
        [JsonProperty("occupation")]
        public string Occupation { get; set; }

        /// <summary>
        /// 'Other' occupation (required only if '<c>Occupation</c>' is 'other').
        /// </summary>
        [JsonProperty("occupationOther")]
        public string OccupationOther { get; set; }

        /// <summary>
        /// Occupation detail (optional).
        /// </summary>
        [JsonProperty("occupationDetail")]
        public string OccupationDetail { get; set; }

        /// <summary>
        /// True if income is from salary. False otherwise.
        /// </summary>
        [JsonProperty("sourceOfFundsSalary")]
        public bool SourceOfFundsSalary { get; set; }

        /// <summary>
        /// True if income is from savings. False otherwise.
        /// </summary>
        [JsonProperty("sourceOfFundsSaving")]
        public bool SourceOfFundsSaving { get; set; }

        /// <summary>
        /// True if income is from inheritance. False otherwise.
        /// </summary>
        [JsonProperty("sourceOfFundsInheritance")]
        public bool SourceOfFundsInheritance { get; set; }

        /// <summary>
        /// True if income is from other source. False otherwise.
        /// </summary>
        [JsonProperty("sourceOfFundsOther")]
        public bool SourceOfFundsOther { get; set; }

        /// <summary>
        /// Fund detail. (required if <c>SourceOfFundsOther</c> is true).
        /// </summary>
        [JsonProperty("sourceOfFundsOtherDetail")]
        public string SourceOfFundsOtherDetail { get; set; }

        /// <summary>
        /// Annual income.
        /// </summary>
        [JsonProperty("annualIncome")]
        public string AnnualIncome { get; set; }

        /// <summary>
        /// Number of file uploaded (min of 1).
        /// </summary>
        [JsonProperty("numOfFile")]
        public int NumOfFile { get; set; }
    }
}
