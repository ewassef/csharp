// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Policy defines the configuration of how audit events are logged
    /// </summary>
    public partial class V1alpha1Policy
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1Policy class.
        /// </summary>
        public V1alpha1Policy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1Policy class.
        /// </summary>
        /// <param name="level">The Level that all requests are recorded at.
        /// available options: None, Metadata, Request, RequestResponse
        /// required</param>
        /// <param name="stages">Stages is a list of stages for which events
        /// are created.</param>
        public V1alpha1Policy(string level, IList<string> stages = default(IList<string>))
        {
            Level = level;
            Stages = stages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Level that all requests are recorded at. available
        /// options: None, Metadata, Request, RequestResponse required
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets stages is a list of stages for which events are
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "stages")]
        public IList<string> Stages { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Level == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Level");
            }
        }
    }
}
