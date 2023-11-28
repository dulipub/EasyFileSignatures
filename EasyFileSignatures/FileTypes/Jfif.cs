﻿using EasyFileSignatures.Abstrations;

namespace EasyFileSignatures.FileTypes;

public class Jfif : IFileType
{
    public List<byte[]> Singnatures { get; private set; }

    public string MediaType { get; private set; }

    public string Extension { get; private set; }

    public ContentCategory Type { get; private set; }

    public Range Range { get; private set; }

    public string Name {get; private set;}

    public Jfif()
    {
        Singnatures = new List<byte[]> {
             new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 }
        };

        MediaType = "image/jpeg";
        Extension = "jpeg";
        Type = ContentCategory.StillImage;
        Range = new Range(0, 4);

        Name = "JFIF_1_02";
    }
}
