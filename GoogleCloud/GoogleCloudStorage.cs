using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;

namespace Iida.Shared.GoogleCloud;

public class GoogleCloudStorage {
	private readonly GoogleCredential _googleCredential;
	private readonly StorageClient _storageClient;
	private readonly string? _bucketName;
	public GoogleCloudStorage(Parameters parameters) {
		_googleCredential = GoogleCredential.FromJson(parameters.CredentialFile);
		_storageClient = StorageClient.Create(_googleCredential);
		_bucketName = parameters.StorageBucket;
	}
	public async Task<string> UploadFileAsync(FileStream imageFile, string fileNameForStorage) {
		using var memoryStream = new MemoryStream();
		await imageFile.CopyToAsync(memoryStream);
		var dataObject = await _storageClient.UploadObjectAsync(_bucketName, fileNameForStorage, null, memoryStream);
		return dataObject.MediaLink;
	}
	public async Task DeleteFileAsync(string fileNameForStorage) => await _storageClient.DeleteObjectAsync(_bucketName, fileNameForStorage);
	public async Task<Google.Apis.Storage.v1.Data.Object> CheckIfFileExists(string fileNameForStorage) {
		var check = await _storageClient.GetObjectAsync(_bucketName, fileNameForStorage, new GetObjectOptions {
			Projection = Projection.Full
		});
		return check;
	}
	public List<Google.Apis.Storage.v1.Data.Object> ListObjects(string prefix) {
		var request = _storageClient.ListObjects(_bucketName, prefix, new ListObjectsOptions {
			Projection = Projection.Full
		}).ToList();
		return request;
	}
}