/* 
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FbaInventory
{
    /// <summary>
    /// The quantity of reserved inventory.
    /// </summary>
    [DataContract]
    public partial class FutureSupplyQuantity : IEquatable<FutureSupplyQuantity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FutureSupplyQuantity" /> class.
        /// </summary>
        /// <param name="ReservedFutureSupplyQuantity">The total number of units in Amazon&#39;s fulfillment network that are currently being picked, packed, and shipped; or are sidelined for measurement, sampling, or other internal processes..</param>
        /// <param name="FutureSupplyBuyableQuantity">The number of units reserved for customer orders..</param>
        public FutureSupplyQuantity(int? ReservedFutureSupplyQuantity = default(int?), int? FutureSupplyBuyableQuantity = default(int?))
        {
            this.ReservedFutureSupplyQuantity = ReservedFutureSupplyQuantity;
            this.FutureSupplyBuyableQuantity = FutureSupplyBuyableQuantity;
        }

        /// <summary>
        /// The total number of units in Amazon&#39;s fulfillment network that are currently being picked, packed, and shipped; or are sidelined for measurement, sampling, or other internal processes.
        /// </summary>
        /// <value>The total number of units in Amazon&#39;s fulfillment network that are currently being picked, packed, and shipped; or are sidelined for measurement, sampling, or other internal processes.</value>
        [DataMember(Name = "reservedFutureSupplyQuantity", EmitDefaultValue = false)]
        public int? ReservedFutureSupplyQuantity { get; set; }

        /// <summary>
        /// The number of units reserved for customer orders.
        /// </summary>
        /// <value>The number of units reserved for customer orders.</value>
        [DataMember(Name = "futureSupplyBuyableQuantity", EmitDefaultValue = false)]
        public int? FutureSupplyBuyableQuantity { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FutureSupplyQuantity {\n");
            sb.Append("  ReservedFutureSupplyQuantity: ").Append(ReservedFutureSupplyQuantity).Append("\n");
            sb.Append("  FutureSupplyBuyableQuantity: ").Append(FutureSupplyBuyableQuantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FutureSupplyQuantity);
        }

        /// <summary>
        /// Returns true if FutureSupplyQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of FutureSupplyQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FutureSupplyQuantity input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ReservedFutureSupplyQuantity == input.ReservedFutureSupplyQuantity ||
                    (this.ReservedFutureSupplyQuantity != null &&
                    this.ReservedFutureSupplyQuantity.Equals(input.ReservedFutureSupplyQuantity))
                ) &&
                (
                    this.FutureSupplyBuyableQuantity == input.FutureSupplyBuyableQuantity ||
                    (this.FutureSupplyBuyableQuantity != null &&
                    this.FutureSupplyBuyableQuantity.Equals(input.FutureSupplyBuyableQuantity))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ReservedFutureSupplyQuantity != null)
                    hashCode = hashCode * 59 + this.ReservedFutureSupplyQuantity.GetHashCode();
                if (this.FutureSupplyBuyableQuantity != null)
                    hashCode = hashCode * 59 + this.FutureSupplyBuyableQuantity.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}