/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    /// Information that identifies an item.
    /// </summary>
    [DataContract]
    public partial class ItemIdentifier : IEquatable<ItemIdentifier>, IValidatableObject
    {
        /// <summary>
        /// The condition of the item.
        /// </summary>
        /// <value>The condition of the item.</value>
        [DataMember(Name = "ItemCondition", EmitDefaultValue = false)]
        public ConditionType ItemCondition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdentifier" /> class.
        /// </summary>
        /// <param name="MarketplaceId">A marketplace identifier. Specifies the marketplace from which prices are returned. (required).</param>
        /// <param name="ASIN">The Amazon Standard Identification Number (ASIN) of the item..</param>
        /// <param name="SellerSKU">The seller stock keeping unit (SKU) of the item..</param>
        /// <param name="ItemCondition">The condition of the item. (required).</param>
        public ItemIdentifier(string MarketplaceId = default(string), string ASIN = default(string), string SellerSKU = default(string), ConditionType ItemCondition = default(ConditionType))
        {
            // to ensure "MarketplaceId" is required (not null)
            if (MarketplaceId == null)
            {
                throw new InvalidDataException("MarketplaceId is a required property for ItemIdentifier and cannot be null");
            }
            else
            {
                this.MarketplaceId = MarketplaceId;
            }
            // to ensure "ItemCondition" is required (not null)
            if (ItemCondition == null)
            {
                throw new InvalidDataException("ItemCondition is a required property for ItemIdentifier and cannot be null");
            }
            else
            {
                this.ItemCondition = ItemCondition;
            }
            this.ASIN = ASIN;
            this.SellerSKU = SellerSKU;
        }

        /// <summary>
        /// A marketplace identifier. Specifies the marketplace from which prices are returned.
        /// </summary>
        /// <value>A marketplace identifier. Specifies the marketplace from which prices are returned.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item.</value>
        [DataMember(Name = "ASIN", EmitDefaultValue = false)]
        public string ASIN { get; set; }

        /// <summary>
        /// The seller stock keeping unit (SKU) of the item.
        /// </summary>
        /// <value>The seller stock keeping unit (SKU) of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemIdentifier {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  ASIN: ").Append(ASIN).Append("\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("  ItemCondition: ").Append(ItemCondition).Append("\n");
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
            return this.Equals(input as ItemIdentifier);
        }

        /// <summary>
        /// Returns true if ItemIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemIdentifier input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.ASIN == input.ASIN ||
                    (this.ASIN != null &&
                    this.ASIN.Equals(input.ASIN))
                ) &&
                (
                    this.SellerSKU == input.SellerSKU ||
                    (this.SellerSKU != null &&
                    this.SellerSKU.Equals(input.SellerSKU))
                ) &&
                (
                    this.ItemCondition == input.ItemCondition ||
                    (this.ItemCondition != null &&
                    this.ItemCondition.Equals(input.ItemCondition))
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
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.ASIN != null)
                    hashCode = hashCode * 59 + this.ASIN.GetHashCode();
                if (this.SellerSKU != null)
                    hashCode = hashCode * 59 + this.SellerSKU.GetHashCode();
                if (this.ItemCondition != null)
                    hashCode = hashCode * 59 + this.ItemCondition.GetHashCode();
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