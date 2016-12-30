/// <inheritdoc/>
namespace Alogrithm
{
    /// <summary>
    /// The API defines the command/query methods for the UnionFind algorithm.
    /// </summary>
    public interface IUnionFind
    {
        /// <summary>
        /// Add connection between p and q.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        void Union(int p, int q);

        /// <summary>
        /// Are p and q in the same component?
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        bool Connected(int p, int q);

        /// <summary>
        /// Return the component id for p.        
        /// </summary>
        /// <postcondition>
        /// Id value must be limited to 0 to N - 1.
        /// </postcondition>
        /// <param name="p"></param>
        /// <returns></returns>
        int Find(int p);

        /// <summary>
        /// Return the number of components.
        /// </summary>
        /// <returns></returns>
        int Count();
    }
}
