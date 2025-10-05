namespace CSharpInANutshell.Experiments.CustomIndexers;

internal readonly struct Square
{
    internal int File { get; init; }      // 0 - 7 (a - h)
    internal int Rank { get; init; }      // 0 - 7 (1 - 8)
    
    public PieceColor Color { get; init; } = PieceColor.None;
    public PieceType Piece { get; init; } = PieceType.None;

    internal Square(int file, int rank) : this(file, rank, PieceColor.None, PieceType.None)
    {
        
    }
    
    internal Square(int file, int rank, PieceColor color, PieceType pieceType)
    {
        ValidateArguments(file, rank, color, pieceType);
        File = file;
        Rank = rank;
        Color = color;
        Piece = pieceType;
    }

    private static void ValidateArguments(int file, int rank, PieceColor color, PieceType pieceType)
    {
        if (file is < 0 or > 7)
            throw new ArgumentOutOfRangeException(nameof(file), file, "File must be between 0 and 7.");
        if (rank is < 0 or > 7)
            throw new ArgumentOutOfRangeException(nameof(rank), rank, "Rank must be between 0 and 7.");
        
        var hasColor = color != PieceColor.None;
        var hasPiece = pieceType != PieceType.None;

        if (hasColor != hasPiece)
            throw new ArgumentException(
                $"Invalid square initialization: file={file}, rank={rank}, color={color}, pieceType={pieceType}. " + 
                "Piece information was passed incomplete - either both color and piece type have to be None, " +
                "or they both need a valid value, e.g., Black and Rook!");
    }
}