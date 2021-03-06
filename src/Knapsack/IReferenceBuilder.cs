﻿using System;
using System.Collections.Generic;

namespace Knapsack
{
    public interface IReferenceBuilder
    {
        void AddReference(string filename);
        void AddExternalReference(string externalUrl, string location);
        IEnumerable<Module> GetRequiredModules();
    }
}
