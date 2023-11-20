using EasyFileSignatures.Abstrations;
using EasyFileSignatures.FileTypes;
using System.Reflection;

namespace EasyFileSignatures;

public class Inspector
{
    private readonly Dictionary<string, IFileType> _fileTypes;

    public Inspector()
	{
        _fileTypes = new Dictionary<string, IFileType>();

        // Get all types in the current assembly
        var types = Assembly.GetExecutingAssembly().GetTypes();

        // Find types that inherit from FileTypeBase
        var fileTypeTypes = types
            .Where(type => type.IsSubclassOf(typeof(IFileType)) && !type.IsAbstract);

        // Instantiate objects of the found types
        foreach (var fileTypeType in fileTypeTypes)
        {
            var fileTypeInstance = Activator.CreateInstance(fileTypeType) as IFileType;
            if (fileTypeInstance != null)
            {
                _fileTypes.Add(fileTypeType.Name, fileTypeInstance);
            }
        }
    }


}