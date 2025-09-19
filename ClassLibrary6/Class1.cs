using System;

namespace ClassLibrary6
{
    public class DocumentWorker
    {
        public DocumentWorker() { }
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Edition of document is available in ProVersion");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving of document is available in ProVersion");
        }
    }
    public class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker() { }
        public override void OpenDocument()
        {
            Console.WriteLine("Document is opened");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Document have been edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in original format, saving of document in other formats is available in ExpertVersion");
        }
    }
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker() { }
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in new format");
        }
    }
}
