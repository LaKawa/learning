// ReSharper disable MemberCanBePrivate.Global
namespace CSharpInANutshell.Experiments.CustomIndexers;

internal readonly struct Square
{
    internal int File { get; init; }      // 0 - 7 (a - h)
    internal int Rank { get; init; }      // 0 - 7 (1 - 8)
    
    public PieceColor Color { get; init; } = PieceColor.None;
    public Piece Piece { get; init; } = Piece.None;

    public string Name => $"{(char)('a' + File)}{Rank + 1}";

    public string FullName => Piece == Piece.None
        ? Name
        : $"{Piece.ToSymbol()}{Name}";

    // avoided optional parameters in case we make this public
    // could also use factory methods and keep constructor internal / private
    internal Square(int file, int rank) : this(file, rank, PieceColor.None, Piece.None)
    {
        
    }
    
    internal Square(int file, int rank, PieceColor color, Piece piece)
    {
        ValidateArguments(file, rank, color, piece);
        File = file;
        Rank = rank;
        Color = color;
        Piece = piece;
    }

    private static void ValidateArguments(int file, int rank, PieceColor color, Piece piece)
    {
        if (file is < 0 or > 7)
            throw new ArgumentOutOfRangeException(nameof(file), file, "File must be between 0 and 7.");
        if (rank is < 0 or > 7)
            throw new ArgumentOutOfRangeException(nameof(rank), rank, "Rank must be between 0 and 7.");
        
        var hasColor = color != PieceColor.None;
        var hasPiece = piece != Piece.None;

        if (hasColor != hasPiece)
            throw new ArgumentException(
                $"Invalid square initialization: file={file}, rank={rank}, color={color}, pieceType={piece}. " + 
                "Piece information was passed incomplete - either both color and piece type have to be None, " +
                "or they both need a valid value, e.g., Black and Rook!");
    }
}