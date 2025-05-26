namespace InterviewPrep.DesignPattern.Abstract_Factory;

internal interface IDocumentService : IUploader,IDownloader
{
    
}

internal interface IDocumentFactory
{
    IUploader GetUploader();
    IDownloader GetDownloader();
}

interface IUploader
{
    bool Upload(string key, byte[] content);
    bool MultiPartUpload(string key, IEnumerable<byte[]> contentParts);
}

interface  IDownloader
{
    byte[] Download(string key);
}

internal class AWSUploader : IUploader
{
    public bool Upload(string key, byte[] content)
    {
        Console.WriteLine("Uploaded to AWS!");
        return true;
    }

    public bool MultiPartUpload(string key, IEnumerable<byte[]> contentParts)
    {
        Console.WriteLine("Uploaded to AWS! in Multipart");
        return true;
    }
}

internal class AWSS3Downloader : IDownloader
{
    public byte[] Download(string key)
    {
        Console.WriteLine("Downloaded from AWS S3!");
        return new byte[0];
    }
}

internal class FTPUploader : IUploader
{
    public bool Upload(string key, byte[] content)
    {
        Console.WriteLine("Uploaded to FTP!");
        return true;
    }

    public bool MultiPartUpload(string key, IEnumerable<byte[]> contentParts)
    {
        Console.WriteLine("Uploaded to FTP! in Multipart");
        return true;
    }
}

internal class FTPDownloader : IDownloader
{
    public byte[] Download(string key)
    {
        Console.WriteLine("Downloaded from FTP!");
        return new byte[0];
    }
}

internal class AWSStorageFactory : IDocumentFactory
{
    public IDownloader GetDownloader()
    {
        return new AWSS3Downloader();
    }

    public IUploader GetUploader()
    {
        return new AWSUploader();
    }
}

internal class FTPStorageFactory : IDocumentFactory
{
    public IDownloader GetDownloader()
    {
        return new FTPDownloader();
    }

    public IUploader GetUploader()
    {
        return new FTPUploader();
    }
}
