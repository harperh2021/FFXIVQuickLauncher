﻿using System;

namespace XIVLauncher.Common.Game
{
    public class BinaryNotPresentException : Exception
    {
        public string Path { get; private set; }

        public BinaryNotPresentException(string path) : base("Game binary was not found")
        {
            Path = path;
        }
    }
}
