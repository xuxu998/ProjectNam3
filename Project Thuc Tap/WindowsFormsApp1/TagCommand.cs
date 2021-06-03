using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TagCommand
    {
        private static readonly Dictionary<byte, string> commands = new Dictionary<byte, string>()
        {
            { 0x00, "Unknown" },
            { 0x01, "Straight" },
            { 0x02, "Left" },
            { 0x03, "Right" },
            { 0x04, "Collect 1"},
            { 0x05, "Collect 2"},
            { 0x06, "Deliver" },
            { 0x07, "Reverse" }
        };
        private byte tagId;
        private byte tagCmd;
        private byte[] idCmdPair;
        public TagCommand()
        {
            idCmdPair = new byte[2];
        }
        public byte TagId { get => tagId; set { tagId = (byte)value; } }
        public byte TagCmd { get => tagCmd; set { tagCmd = (byte)value; } }
        public byte setTagCommand(string strCommand)
        {
            var myCommandCode = commands.FirstOrDefault(x => x.Value == strCommand).Key;
            tagCmd = (byte)myCommandCode;
            return TagCmd;
        }
        public byte[] getIdCmdPair()
        {
            idCmdPair[0] = tagId;
            idCmdPair[1] = tagCmd;

            return idCmdPair;
        }
    }
}
