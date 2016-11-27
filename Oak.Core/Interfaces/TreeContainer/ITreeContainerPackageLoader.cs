﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oak.Core.Interfaces.TreeContainer
{
    public interface ITreeContainerPackageLoader
    {
        ITreePackage Load(ITreePackage treePackage);
    }
}
