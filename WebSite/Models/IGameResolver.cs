namespace WebSite.Models
{
    public interface IGameResolver
    {
        GameResult ResolveGame(Move move1, Move move2);
    }
}