namespace CSharpInANutshell.Experiments.CustomIndexers;

public class ChessBoard
{
    private Square[ , ] _squares;

    /// <summary>
    /// Gets the <see cref="SquareInfo" /> of the given file and rank.
    /// 0 - based indexing!
    /// File: 0 = 'a', ..., 7 = 'h'.
    /// Rank: 0 = 1, ..., 7 = 8.
    /// </summary>
    /// <param name="file">The 0-based file (column) index.</param>
    /// <param name="rank">The 0-based rank (row) index.</param>
    /// <returns>The square information at the specified location.</returns>
    /// <exception cref="ArgumentOutOfRangeException">If file or rank is outside 0-7.</exception>
    internal SquareInfo this[int file, int rank]
    {
        get
        {
            if (file is < 0 or > 7 || rank is < 0 or > 7)
                throw new ArgumentOutOfRangeException(
                    $"Invalid square index, has to be between 0 and 7. File: {file}, Rank: {rank}");
            return _squares[file, rank].ToInfo();
        }
    }

    internal IEnumerable<SquareInfo> GetFile(int file)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<SquareInfo> GetFile(char file)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<SquareInfo> GetRankByChessNumber(int rank)
    {
        throw new NotImplementedException();
    }


    private ChessBoard(Square[,] squares)
    {
        _squares = squares;
    }

    public SquareInfo GetSquareInfo(int file, int rank)
    {
        // TODO: Add code to get SquareInfo via indices
        throw new NotImplementedException();
    }
    public SquareInfo GetSquareInfo(char file, int rank)
    {
        // TODO: Add code to get SquareInfo via chess notation
        throw new NotImplementedException();
    }
    
    internal static ChessBoard CreateEmptyBoard()
    {
        throw new NotImplementedException();
    }

    internal static ChessBoard CreateDefaultPosition()
    {
        throw new NotImplementedException();
    }

    internal static ChessBoard CreateCustomPosition()
    {
        throw new NotImplementedException();
    }
}
