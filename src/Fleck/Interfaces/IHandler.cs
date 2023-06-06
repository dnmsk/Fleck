using System.Collections.Generic;
using System.IO;

namespace Fleck
{
    public interface IHandler
    {
        byte[] CreateHandshake(string subProtocol = null);
        void Receive(IEnumerable<byte> data);
        MemoryStream FrameStreamText(MemoryStream stream);
        MemoryStream FrameStreamBytes(MemoryStream bytes);
        byte[] FrameText(string text);
        byte[] FrameByteText(byte[] text);
        byte[] FrameBinary(byte[] bytes);
        byte[] FramePing(byte[] bytes);
        byte[] FramePong(byte[] bytes);
        byte[] FrameClose(int code);
    }
}
