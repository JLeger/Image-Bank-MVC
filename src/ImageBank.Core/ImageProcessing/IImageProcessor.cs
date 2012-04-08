﻿using System.IO;

namespace ImageBank.Core.ImageProcessing
{
    public interface IImageProcessor
    {
        void ProcessChunkedImage(ImageChunk imageChunk, FileMode fileMode, string uploadDir);
        void GenerateMipMaps(string filePath);
    }
}