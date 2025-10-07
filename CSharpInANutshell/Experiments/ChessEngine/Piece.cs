namespace CSharpInANutshell.Experiments.CustomIndexers;

public enum Piece
{
    None,
    Pawn,
    Knight,
    Bishop,
    Rook,
    Queen,
    King
}

public static class PieceExtensions
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