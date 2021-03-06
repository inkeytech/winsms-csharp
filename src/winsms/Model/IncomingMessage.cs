/* 
 * WINSMS
 *
 * WinSMS RESTful API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@winsms.co.za
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = winsms.Client.SwaggerDateConverter;

namespace winsms.Model
{
    /// <summary>
    /// IncomingMessage
    /// </summary>
    [DataContract]
    public partial class IncomingMessage :  IEquatable<IncomingMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomingMessage" /> class.
        /// </summary>
        /// <param name="incomingApiMessageId">The unique API message id assigned to this incoming message. .</param>
        /// <param name="mobileNumber">The mobile number that sent the SMS message, displayed using the international E164 (without the plus) format .</param>
        /// <param name="receiveTime">The date and time the message was received by WinSMS, in the format YYYYMMDDHHmm. .</param>
        /// <param name="messageText">The text of the incoming SMS message. .</param>
        /// <param name="outgoingApiMessageId">The API message id of the most recent message sent to the mobile number that responded. .</param>
        public IncomingMessage(decimal? incomingApiMessageId = default(decimal?), string mobileNumber = default(string), string receiveTime = default(string), string messageText = default(string), decimal? outgoingApiMessageId = default(decimal?))
        {
            this.IncomingApiMessageId = incomingApiMessageId;
            this.MobileNumber = mobileNumber;
            this.ReceiveTime = receiveTime;
            this.MessageText = messageText;
            this.OutgoingApiMessageId = outgoingApiMessageId;
        }
        
        /// <summary>
        /// The unique API message id assigned to this incoming message. 
        /// </summary>
        /// <value>The unique API message id assigned to this incoming message. </value>
        [DataMember(Name="incomingApiMessageId", EmitDefaultValue=false)]
        public decimal? IncomingApiMessageId { get; set; }

        /// <summary>
        /// The mobile number that sent the SMS message, displayed using the international E164 (without the plus) format 
        /// </summary>
        /// <value>The mobile number that sent the SMS message, displayed using the international E164 (without the plus) format </value>
        [DataMember(Name="mobileNumber", EmitDefaultValue=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// The date and time the message was received by WinSMS, in the format YYYYMMDDHHmm. 
        /// </summary>
        /// <value>The date and time the message was received by WinSMS, in the format YYYYMMDDHHmm. </value>
        [DataMember(Name="receiveTime", EmitDefaultValue=false)]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// The text of the incoming SMS message. 
        /// </summary>
        /// <value>The text of the incoming SMS message. </value>
        [DataMember(Name="messageText", EmitDefaultValue=false)]
        public string MessageText { get; set; }

        /// <summary>
        /// The API message id of the most recent message sent to the mobile number that responded. 
        /// </summary>
        /// <value>The API message id of the most recent message sent to the mobile number that responded. </value>
        [DataMember(Name="outgoingApiMessageId", EmitDefaultValue=false)]
        public decimal? OutgoingApiMessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncomingMessage {\n");
            sb.Append("  IncomingApiMessageId: ").Append(IncomingApiMessageId).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  ReceiveTime: ").Append(ReceiveTime).Append("\n");
            sb.Append("  MessageText: ").Append(MessageText).Append("\n");
            sb.Append("  OutgoingApiMessageId: ").Append(OutgoingApiMessageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as IncomingMessage);
        }

        /// <summary>
        /// Returns true if IncomingMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomingMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomingMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncomingApiMessageId == input.IncomingApiMessageId ||
                    (this.IncomingApiMessageId != null &&
                    this.IncomingApiMessageId.Equals(input.IncomingApiMessageId))
                ) && 
                (
                    this.MobileNumber == input.MobileNumber ||
                    (this.MobileNumber != null &&
                    this.MobileNumber.Equals(input.MobileNumber))
                ) && 
                (
                    this.ReceiveTime == input.ReceiveTime ||
                    (this.ReceiveTime != null &&
                    this.ReceiveTime.Equals(input.ReceiveTime))
                ) && 
                (
                    this.MessageText == input.MessageText ||
                    (this.MessageText != null &&
                    this.MessageText.Equals(input.MessageText))
                ) && 
                (
                    this.OutgoingApiMessageId == input.OutgoingApiMessageId ||
                    (this.OutgoingApiMessageId != null &&
                    this.OutgoingApiMessageId.Equals(input.OutgoingApiMessageId))
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
                if (this.IncomingApiMessageId != null)
                    hashCode = hashCode * 59 + this.IncomingApiMessageId.GetHashCode();
                if (this.MobileNumber != null)
                    hashCode = hashCode * 59 + this.MobileNumber.GetHashCode();
                if (this.ReceiveTime != null)
                    hashCode = hashCode * 59 + this.ReceiveTime.GetHashCode();
                if (this.MessageText != null)
                    hashCode = hashCode * 59 + this.MessageText.GetHashCode();
                if (this.OutgoingApiMessageId != null)
                    hashCode = hashCode * 59 + this.OutgoingApiMessageId.GetHashCode();
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
