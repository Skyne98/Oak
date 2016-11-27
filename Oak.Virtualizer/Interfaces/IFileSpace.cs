﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oak.Virtualizer.Interfaces
{
    public interface IFileSpace
    {
        void WriteByte(long position, byte value);
        byte ReadByte(long position);
        ISegment AllocateSegment(IBlockSpace blockSpace);
        void UnallocateSegment(ISegment segment);
        IBlockSpace GetBlockSpace(long id);
        IBlockSpace AllocateBlockSpace(long id);
        void UnallocateBlockSpace(IBlockSpace blockSpace);
        
    }
}