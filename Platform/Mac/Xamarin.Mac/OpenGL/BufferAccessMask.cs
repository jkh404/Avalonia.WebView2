using System;

namespace OpenGL;

[Flags]
public enum BufferAccessMask
{
	MapReadBit = 1,
	MapWriteBit = 2,
	MapInvalidateRangeBit = 4,
	MapInvalidateBufferBit = 8,
	MapFlushExplicitBit = 0x10,
	MapUnsynchronizedBit = 0x20
}
