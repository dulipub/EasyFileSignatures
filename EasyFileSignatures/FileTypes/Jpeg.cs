

namespace EasyFileSignatures.FileTypes;

public class Jpeg
{
    public int[] Singnature
    {
        get
        {
            return new int[] { };
        }
    }

    public string MediaType
    {
        get
        {
            return string.Empty;
        }
    }

    public string Extension
    {
        get
        {
            return string.Empty;
        }
    }

    public FileType Type
    {
        get
        {
            return FileType.Image;
        }
    }
}
