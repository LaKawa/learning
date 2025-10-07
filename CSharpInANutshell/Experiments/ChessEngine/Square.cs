// ReSharper disable MemberCanBePrivate.Global
namespace CSharpInANutshell.Experiments.CustomIndexers;

// TODO: eventually implement super tight 64-bit board approach to allow memory efficient chess engine calculation

internal class Square
{
    internal int File { get; }      // 0 - 7 (a - h)
    internal int Rank { get; }      // 0 - 7 (1 - 8)
    
    public PieceColor Color { get; private set; } 
    public Piece Piece { get; private set; }

    public string Name => $"{(char)('a' + File)}{Rank + 1}";

    public string FullName => Piece == Piece.None
        ? Name
        : $"{Piece.ToSymbol()}{Name}";

    public SquareInfo ToInfo() => new(File, Rank, Color, Piece);

    // avoided optional parameters in case we make this public (prevent user dll recompilation on change)
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

    internal static Square CreateEmpty(int file, int rank)
    {
        return new Square(file, rank) { Color = PieceColor.Black };
    }

    internal static Square CreateWithPiece(int file, int rank, PieceColor color, Piece piece)
    {
        return new Square(file, rank, color, piece);
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