

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
            return "image/jpeg";
        }
    }

    public string Extension
    {
        get
        {
            return "jpeg";
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
