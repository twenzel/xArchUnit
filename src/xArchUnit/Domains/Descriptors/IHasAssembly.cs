namespace xArchUnit.Domains.Descriptors
{
    /// <summary>
    /// Domain descriptor defining entity as an assembly
    /// </summary>
    public interface IHasAssembly
    {
        /// <summary>
        /// Gets the assembly
        /// </summary>
        Assembly Assembly { get; }
    }
}
