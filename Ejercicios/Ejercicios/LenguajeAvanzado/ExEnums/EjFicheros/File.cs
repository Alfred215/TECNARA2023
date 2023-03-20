using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExEnums.EjFicheros
{
    class File
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public DateTime CreationDate { get; set; }
        public FileType FileType { get; set; }
        public int Size { get; set; }

        public File(string name, string extension, DateTime creationDate, FileType fileType)
        {
            Name = name;
            Extension = extension;
            CreationDate = creationDate;
            FileType = fileType;
            Size = CalculateSize();
        }

        public virtual int CalculateSize()
        {
            return new Random().Next(1, 1000);
        }

        public virtual int Duration()
        {
            return 0;
        }
    }

    enum FileType
    {
        Text,
        Image,
        Audio
    }

    class TextFile : File
    {
        public int NumberOfLines { get; set; }

        public TextFile(string name, string extension, DateTime creationDate, int numberOfLines)
        : base(name, extension, creationDate, FileType.Text)
        {
            NumberOfLines = numberOfLines;
        }
    }

    class ImageFile : File
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public ImageFile(string name, string extension, DateTime creationDate, int width, int height)
        : base(name, extension, creationDate, FileType.Image)
        {
            Width = width;
            Height = height;
        }
    }

    class AudioFile : File
    {
        public int DurationInSeconds { get; set; }
        public int BitRate { get; set; }

        public AudioFile(string name, string extension, DateTime creationDate, int durationInSeconds, int bitRate)
       : base(name, extension, creationDate, FileType.Audio)
        {
            DurationInSeconds = durationInSeconds;
            BitRate = bitRate;
        }

        public override int Duration()
        {
            return DurationInSeconds;
        }
    }

}
