namespace xArchUnit.Domains.Descriptors
{
    /// <summary>
    /// Domain descriptor defining entity as a name
    /// </summary>
    public interface IHasName
    {
        /// <summary>
        /// Gets the entity's name
        /// </summary>
        string Name { get; }
    }
}
