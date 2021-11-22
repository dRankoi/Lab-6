﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._2
{
    class PlayerItem
    {
        public IMedia MediaFile { get; }

        public PlayerItem(IMedia file)
        {
            MediaFile = file;
        }

        public void PrintOptions()
        {
            Console.Write($"File \"{MediaFile.FileName}\": ");

            if (MediaFile is IPlayable)
                Console.Write("Play(), ");

            if (MediaFile is IRecordable)
                Console.Write("Record(), ");

            Console.WriteLine("Pause(), Stop()");
        }
    }
}
