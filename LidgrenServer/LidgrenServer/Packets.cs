﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lidgren.Network;
namespace LidgrenServer
{
    public enum PacketTypes
    {
        LocalPlayerPacket,
        PlayerDisconnectsPacket,
        PositionPacket,
        SpawnPacket
    }

    public interface IPacket
    {
        void PacketToNetOutGoingMessage(NetOutgoingMessage message);

        void NetIncomingMessageToPacket(NetIncomingMessage message);
    }

    public abstract class Packet : IPacket 
    {
        public abstract void PacketToNetOutGoingMessage(NetOutgoingMessage message);

        public abstract void NetIncomingMessageToPacket(NetIncomingMessage message);

    }

    public class LocalPlayerPacket : Packet 
    {
        public string ID {  get; set; }

        public override void PacketToNetOutGoingMessage(NetOutgoingMessage message)
        {
            message.Write((byte)PacketTypes.LocalPlayerPacket);
            message.Write(ID);
        }

        public override void NetIncomingMessageToPacket(NetIncomingMessage message)
        {
            ID = message.ReadString();
        }
    }

    public class PLayerDisconnectsPacket : Packet
    {
        public string player { get; set; }

        public override void PacketToNetOutGoingMessage(NetOutgoingMessage message)
        {
            message.Write((byte)PacketTypes.PlayerDisconnectsPacket);
            message.Write(player);
        }

        public override void NetIncomingMessageToPacket(NetIncomingMessage message)
        {
            player = message.ReadString();
        }
    }

    public class PositionPacket : Packet
    {
        public float X { get; set; }    
        public float Y { get; set; }
        public string player { get; set; }

        public override void PacketToNetOutGoingMessage(NetOutgoingMessage message)
        {
            message.Write((byte)PacketTypes.PositionPacket);
            message.Write(X);
            message.Write(Y);
            message.Write(player);
        }

        public override void NetIncomingMessageToPacket(NetIncomingMessage message)
        {
            X = message.ReadFloat();
            Y = message.ReadFloat();
            player = message.ReadString();
        }
    }

    public class SpawnPacket : Packet
    {
        public float X { get; set; }
        public float Y { get; set; }
        public string player { get; set; }

        public override void PacketToNetOutGoingMessage(NetOutgoingMessage message)
        {
            message.Write((byte)PacketTypes.SpawnPacket);
            message.Write(X);
            message.Write(Y);
            message.Write(player);
        }

        public override void NetIncomingMessageToPacket(NetIncomingMessage message)
        {
            X = message.ReadFloat();
            Y = message.ReadFloat();
            player = message.ReadString();
        }
    }
}
