namespace FaceList.Models
{
    public class FaceListDatabaseSettings: IFaceListDatabaseSettings
    {
        public string FaceListCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IFaceListDatabaseSettings
    {
        string FaceListCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}