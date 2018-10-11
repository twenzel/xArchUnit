using xArchUnit.Domains.Descriptors;

namespace xArchUnit.Domains
{
    /// <summary>
    /// The .NET class domain
    /// </summary>
    public class Class : Domain, IHasName, IHasNamespace, IHasAssembly//, IHasAnnotations, IHasModifiers
    {
        /// <summary>
        /// Gets or sets the class name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the namespace the class resides in
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets the class's assembly
        /// </summary>
        public Assembly Assembly { get; set; }
    }
}
