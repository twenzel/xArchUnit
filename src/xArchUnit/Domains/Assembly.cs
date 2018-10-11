using xArchUnit.Domains.Descriptors;

namespace xArchUnit.Domains
{
    /// <summary>
    /// The .NET assembly domain
    /// </summary>
    public class Assembly : Domain, IHasName
    {
        /// <summary>
        /// Gets or sets the assembly name
        /// </summary>
        public string Name { get; set; }
    }
}
