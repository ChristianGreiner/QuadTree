using Microsoft.Xna.Framework;

namespace QuadTrees.QTreePoint
{
    /// <summary>
    /// Interface to define Rect, so that QuadTree knows how to store the object.
    /// </summary>
    public interface IPointQuadStorable
    {
        /// <summary>
        /// The Vector2 that defines the object's boundaries.
        /// </summary>
        Vector2 Point { get; }
    }
}