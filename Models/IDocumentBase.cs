using System;
using MongoRepository;

namespace hcono.Models
{
    public interface IDocumentBase
    {
       IDocumentBase Save();

       void Delete();

       IDocumentBase  Insert();
    }
}