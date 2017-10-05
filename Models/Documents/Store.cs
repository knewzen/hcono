using System;
using MongoRepository;
using hcono.Models;

namespace hcono.Models.Documents
{

    public class Store : Entity, IDocumentBase
    {

        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime Edited { get; set; }
        public string StoreName { get; set; }
        public string Description { get; set; }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        IDocumentBase IDocumentBase.Insert()
        {
            throw new NotImplementedException();
        }

        IDocumentBase IDocumentBase.Save()
        {
            throw new NotImplementedException();
        }
    }

}