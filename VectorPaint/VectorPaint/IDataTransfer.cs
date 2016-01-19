using VectorPaint.Customs;

namespace VectorPaint
{
    internal interface IDataTransfer
    {
        void FromFigureToBars(object figure);
        XData FromBarsToFigure();
    }
}