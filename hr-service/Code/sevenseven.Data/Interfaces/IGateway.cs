using MongoDB.Driver;

namespace sevenseven.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
