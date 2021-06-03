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

        public static readonly byte AGV_PARAM_TYPE = 0x03;

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
        public byte getMessageType(byte[] inputPacket)
        {
            byte type = 0;

            if (inputPacket.Length > 0)
            {
                this.parsePacketHeader(inputPacket);
                type = this.messType;
            }

            return type;
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
    class agvParam : Packet
    {
        private byte position_agv;
        private static readonly int position_agvOffset = 1;

        private byte status_agv;
        private static readonly int status_agvOffset = 2;

        private byte speed_agv;
        private static readonly int speed_agvOffset = 3;

        private byte batt_agv;
        private static readonly int batt_agvOffset = 4;

        public void parsePacket(byte[] input)
        {
            this.parsePacketHeader(input);
            if (this.payload.Length != this.payload[0])
                return;
            this.position_agv = this.payload[position_agvOffset];
            this.status_agv = this.payload[status_agvOffset];
            this.speed_agv = this.payload[speed_agvOffset];
            this.batt_agv = this.payload[batt_agvOffset];
        }
        public byte Position_agv { get => position_agv; }
        public byte Speed_agv { get => speed_agv; }
        public string Status_agv()
        {
            string s = "";
            switch (this.status_agv)
            {
                case 0x01:
                    s = "Go Straigth";
                    break;
                case 0x04:
                    s = "Collect 1"; 
                    break;
                case 0x05:
                    s = "Collect 2";
                    break;
                case 0x03:
                    s = "Turn right";
                    break;
                case 0x06:
                    s = "Delivery";
                    break;
                case 0x02:
                    s = "Turn left";
                    break;
                case 0x09:
                    s = "Stop";
                    break;
                case 0x08: s = "Start"; break;
                case 0x0A: s ="Go"; break;
                   // { 0x00, "Unknown" },
      /*      { 0x01, "Straight" },
            { 0x02, "Left" },
            { 0x03, "Right" },
            { 0x04, "Collect 1"},
            { 0x05, "Collect 2"},
            { 0x06, "Deliver" },
            { 0x07, "Reverse" },
            { 0x08, "Start" },
            { 0x09,"Stop" }*/
            }
            return s;
        }
        public byte Battery_agv { get => batt_agv; }
    
    }
}
