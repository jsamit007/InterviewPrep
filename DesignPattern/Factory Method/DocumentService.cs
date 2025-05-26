using InterviewPrep.DesignPattern.Abstract_Factory;

namespace InterviewPrep.DesignPattern.Factory_Method;

internal class DocumentService : IDocumentService
{
    private readonly IUploader _uploader;
    private readonly IDownloader _downloader;

    public DocumentService(IDocumentFactory documentFactory)
    {
        _uploader = documentFactory.GetUploader();
        _downloader = documentFactory.GetDownloader();
    }

    public byte[] Download(string key)
    {
        return _downloader.Download(key);
    }

    public bool MultiPartUpload(string key, IEnumerable<byte[]> contentParts)
    {
        return _uploader.MultiPartUpload(key, new List<byte[]> { });
    }

    public bool Upload(string key, byte[] content)
    {
        return _uploader.Upload(key, content);
    }
}
