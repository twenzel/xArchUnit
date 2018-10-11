namespace xArchUnit.Domains.Descriptors
{
    /// <summary>
    /// Domain descriptor defining entity as a namespace
    /// </summary>
    public interface IHasNamespace
    {
        /// <summary>
        /// Gets the entity's namespace
        /// </summary>
        string Namespace { get; }
    }
}
