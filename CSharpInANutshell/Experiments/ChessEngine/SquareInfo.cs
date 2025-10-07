namespace CSharpInANutshell.Experiments.CustomIndexers;

public readonly record struct SquareInfo(int File, int Rank, PieceColor Color, Piece Piece)
{
    public string Name => $"{(char)('a' + File)}{Rank + 1}";
}