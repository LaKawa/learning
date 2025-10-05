namespace CSharpInANutshell.Experiments.CustomIndexers;

internal enum Piece
{
    None,
    Pawn,
    Knight,
    Bishop,
    Rook,
    Queen,
    King
}

internal static class PieceExtensions
{
    public static char ToSymbol(this Piece piece) => piece switch
    {
        Piece.Pawn => 'P',
        Piece.Knight => 'N',
        Piece.Bishop => 'B',
        Piece.Rook => 'R',
        Piece.Queen => 'Q',
        Piece.King => 'K',
        _ => ' '
    };
}