﻿using EventBus.Interface;

namespace EventBus
{
    internal class NullLogger
    {
        public static ILogger Instance { get; internal set; }
    }
}