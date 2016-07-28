using Microsoft.Xna.Framework;
using QuadTree;
using QuadTree.Common;

namespace QuadTrees.QTreeRect
{
    public class QuadTreeRectPointInvNode<T> : QuadTreeRectNode<T, Vector2> where T : IRectQuadStorable
    {
        public QuadTreeRectPointInvNode(RectangleF rect) : base(rect)
        {
        }

        public QuadTreeRectPointInvNode(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }

        internal QuadTreeRectPointInvNode(QuadTreeRectNode<T, Vector2> parent, RectangleF rect)
            : base(parent, rect)
        {
        }

        protected override QuadTreeRectNode<T, Vector2> CreateNode(RectangleF rectangleF)
        {
            VerifyNodeAssertions(rectangleF);
            return new QuadTreeRectPointInvNode<T>(this, rectangleF);
        }

        protected override bool CheckIntersects(Vector2 searchRect, T data)
        {
            return data.Rect.Contains(searchRect);
        }

        public override bool ContainsObject(QuadTreeObject<T, QuadTreeRectNode<T, Vector2>> qto)
        {
            return CheckContains(QuadRect, qto.Data);
        }

        protected override bool QueryContains(Vector2 search, RectangleF rect)
        {
            return false;
        }

        protected override bool QueryIntersects(Vector2 search, RectangleF rect)
        {
            return rect.Contains(search);
        }

        protected override Vector2 GetMortonPoint(T p)
        {
            return p.Rect.Location;
            //todo: center?
        }
    }
}