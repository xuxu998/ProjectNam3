using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Packet
    {
        public static readonly byte START_BYTE = 0x7A;
        public static readonly byte END_BYTE = 0x7F;
        protected static readonly byte CONTROL_CENTRE_PC_ADDRESS = 0xFE;
        protected static readonly byte ROUTE = 0x01;
        protected static readonly byte AGV_AVAILABLE = 0x02;


        protected static readonly byte AGV_01 = 0x01;

        protected byte startByte;
        protected byte frameLength;
        protected byte senderAdd;
        protected byte recieverAdd;
        protected byte messType;
        protected byte endByte;

        public static readonly int startByteOffset = 0;
        public static readonly int frameLengthOffset = 1;
        public static readonly int senderAddOffset = 2;
        public static readonly int recieverAddOffset = 3;
        public static readonly int messageTypeOffset = 4;
        public static readonly int payloadOffset = 5;

        protected byte[] header;
        protected byte[] payload;
        protected byte[] outputPacket;

        public byte[] OutputPacket { get => outputPacket; }

        public Packet()
        {
            startByte = START_BYTE;
            endByte = END_BYTE;
            frameLength = 7;
            recieverAdd = 0;
            senderAdd = 0;
            messType = 0;
            header = new byte[5] { startByte, frameLength, senderAdd, recieverAdd, messType };
            payload = new byte[1];
            payload[0] = 1;

        }

        protected void setOutputPacket()
        {
            if (this.payload.Length > 0)
            {
                frameLength = (byte)(header.Length + payload.Length + 1);
                outputPacket = new byte[frameLength];
                header[frameLengthOffset] = frameLength;

                Buffer.BlockCopy(header, 0, this.outputPacket, 0, header.Length);
                Buffer.BlockCopy(payload, 0, this.outputPacket, header.Length, payload.Length);
                this.outputPacket[frameLength - 1] = endByte;
            }
        }
        protected void parsePacketHeader(byte[] input)
        {
            if (input[startByteOffset] != START_BYTE)
            {
                return;
            }
            this.frameLength = input[frameLengthOffset];
            if (input.Length != this.frameLength)
            {
                return;
            }
            this.senderAdd = input[senderAddOffset];
            this.recieverAdd = input[recieverAddOffset];
            this.messType = input[messageTypeOffset];
            this.payload = new byte[input[payloadOffset]];
            this.endByte = input[input.Length - 1];
            Buffer.BlockCopy(input, payloadOffset, payload, 0, input[payloadOffset]);
        }

    }
    class Route : Packet
    {
        private byte payload_length;
        private byte[] tripRoute;

        public Route()
        {
            senderAdd = CONTROL_CENTRE_PC_ADDRESS;
            messType = 0x01;
            header[senderAddOffset] = senderAdd;
            header[messageTypeOffset] = messType;
            payload_length = 1;
        }
        public void setPayload()
        {
            payload = new byte[payload_length];
            payload[0] = payload_length;

            Buffer.BlockCopy(tripRoute, 0, payload, 1, tripRoute.Length);
        }
        public void setPayload(byte[] input)
        {
            payload_length = (byte)(input.Length + 1);
            tripRoute = new byte[input.Length];
            Buffer.BlockCopy(input, 0, tripRoute, 0, input.Length);
            setPayload();
        }
        public void setOutput(byte _recieverAdd, byte[] input)
        {
            recieverAdd = _recieverAdd;
            setPayload(input);
            frameLength = (byte)(header.Length + payload.Length + 1);
            header[recieverAddOffset] = recieverAdd;
            header[frameLengthOffset] = frameLength;

            setOutputPacket();
        }
         
    }
    class agvAvailable : Packet
    {
        public agvAvailable(byte agv) 
        {
            startByte = START_BYTE;
            endByte = END_BYTE;
            frameLength = 7;
            recieverAdd = agv;
            senderAdd = 0;
            messType = 0;
            header = new byte[5] { startByte, frameLength, senderAdd, recieverAdd, messType };
            payload = new byte[1];
            payload[0] = 1;
            senderAdd = CONTROL_CENTRE_PC_ADDRESS;
            recieverAdd = agv;
            messType = AGV_AVAILABLE;
            header[senderAddOffset] = senderAdd;
            header[messageTypeOffset] = messType;
            header[recieverAdd] = recieverAdd;
            payload = new byte[2];
            payload[0] = 0x02;
            payload[1] = 0x01;
            this.setOutputPacket();
        }
    }
    class replyAvailable : Packet
    {
        public bool isAvailable(byte[] input)
        {
            this.parsePacketHeader(input);
            if (this.payload[payloadOffset + 1] == 0x01)
                return true;
            else
                return false;
        }
    }
}
