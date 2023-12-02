using EasyFileSignatures.Abstrations;
using System.Reflection;

namespace EasyFileSignatures;

public class Inspector
{
    private readonly Dictionary<byte[], IFileDetails> _fileTypes;

    public Inspector()
	{
        _fileTypes = new Dictionary<byte[], IFileDetails>();

        // Get all types in the current assembly
        var types = Assembly.GetExecutingAssembly().GetTypes();

        // Find types that inherit from FileTypeBase
        var fileTypeTypes = types
            .Where(type => type.IsSubclassOf(typeof(IFileDetails)) && !type.IsAbstract);

        // Instantiate objects of the found types
        foreach (var fileTypeType in fileTypeTypes)
        {
            var fileTypeInstance = Activator.CreateInstance(fileTypeType) as IFileDetails;
            if (fileTypeInstance != null)
            {
                foreach(var byteArray in fileTypeInstance.Singnatures)
                {
                    //var signature = Convert.ToHexString(byteArray);
                    _fileTypes.Add(byteArray, fileTypeInstance);
                }
            }
        }
    }

    private IFileDetails InspectDetails(string filePath)
    {
        byte[] fileBytes;
        using (var ms = new MemoryStream())
        {
            using (var fs = File.OpenRead(filePath))
            {
                fs.CopyTo(ms);
            }

            fileBytes = ms.ToArray();
        }

        return InspectDetails(fileBytes);
    }

    private IFileDetails InspectDetails(byte[] fileBytes)
    {
        IFileDetails file = null;
        foreach (var signature in _fileTypes.Keys)
        {
            var tempType = _fileTypes[signature];
            if (signature.SequenceEqual(fileBytes.Take(tempType.Range)))
            {
                file = tempType;
                break;
            }
        }

        return file;
    }

    public InspectResult Inspect(string filePath)
    {
        var file = InspectDetails(filePath);
        if (file != null)
        {
            var result = new InspectResult
            {
                Name = file.Name,
                MediaType = file.MediaType,
                Category = file.Category,
                Extension = file.Extension
            };

            return result;
        }


        return null;
    }

    public InspectResult Inspect(byte[] fileBytes)
    {
        var file = InspectDetails(fileBytes);
        if (file != null)
        {
            var result = new InspectResult
            {
                Name = file.Name,
                MediaType = file.MediaType,
                Category = file.Category,
                Extension = file.Extension
            };

            return result;
        }


        return null;
    }
}