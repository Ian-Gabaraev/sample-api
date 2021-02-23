using FaceList.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;


namespace FaceList.Services
{
    public class FaceListService
    {
        private readonly IMongoCollection<Face> _faces;

        public FaceListService(IFaceListDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _faces = database.GetCollection<Face>(settings.FaceListCollectionName);
        }

        public List<Face> Get() =>
            _faces.Find(face => true).ToList();

        public Face Get(string id) =>
            _faces.Find<Face>(face => face.Id == id).FirstOrDefault();
    }
}