using System.Collections.Generic;
using MongoDB.Driver;
using NodepadCS.Models;

namespace NodepadCS
{
    public class MongoNoteRepository : INoteRepository
    {
        private MongoClient client;


        public MongoNoteRepository()
        {
            client = new MongoClient("mongodb://localhost/nodepad");
        }
        public void Create(Note note)
        {
            IMongoDatabase db = client.GetDatabase("nodepad");
            IMongoCollection<Note> collection = db.GetCollection<Note>("notes");

            collection.InsertOne(note);
        }

        public Note Get(string id)
        {
            IMongoDatabase db = client.GetDatabase("nodepad");
            IMongoCollection<Note> collection = db.GetCollection<Note>("notes");

            return collection.FindAsync(n => n.Id == id).Result;
        }

        public List<Note> GetAll()
        {
            IMongoDatabase db = client.GetDatabase("nodepad");
            IMongoCollection<Note> collection = db.GetCollection<Note>("notes");

            return collection.FindAsync().Result.ToList();
        }

        public void Update(Note note)
        {
            IMongoDatabase db = client.GetDatabase("nodepad");
            IMongoCollection<Note> collection = db.GetCollection<Note>("notes");

            collection.UpdateOne(note);
        }
    }
}