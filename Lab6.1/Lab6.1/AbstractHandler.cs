using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab6._1
{
    abstract class AbstractHandler
    {
        FileStream _fileStream;
        FileInfo _fileInfo;
        public AbstractHandler(FileStream fileStream, FileInfo fileInfo)
        {
            _fileStream = fileStream;
            _fileInfo = fileInfo;
        }
        void Open()
        {
            _fileStream = _fileInfo.Open(FileMode.Open);
        }

        void Create()
        {
            _fileStream = _fileInfo.Create();
        }

        void Edit(byte[] array)
        {
            _fileStream.Write(array, 0, array.Length);
        }
    }
}
