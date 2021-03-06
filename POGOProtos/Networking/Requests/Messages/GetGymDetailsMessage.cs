// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/Messages/GetGymDetailsMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages
{

    /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetGymDetailsMessage.proto</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class GetGymDetailsMessageReflection
    {

        #region Descriptor
        /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/GetGymDetailsMessage.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static GetGymDetailsMessageReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "CkJQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR2V0",
                  "R3ltRGV0YWlsc01lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2lu",
                  "Zy5SZXF1ZXN0cy5NZXNzYWdlcyKeAQoUR2V0R3ltRGV0YWlsc01lc3NhZ2US",
                  "DgoGZ3ltX2lkGAEgASgJEhcKD3BsYXllcl9sYXRpdHVkZRgCIAEoARIYChBw",
                  "bGF5ZXJfbG9uZ2l0dWRlGAMgASgBEhQKDGd5bV9sYXRpdHVkZRgEIAEoARIV",
                  "Cg1neW1fbG9uZ2l0dWRlGAUgASgBEhYKDmNsaWVudF92ZXJzaW9uGAYgASgJ",
                  "YgZwcm90bzM="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.GetGymDetailsMessage), global::POGOProtos.Networking.Requests.Messages.GetGymDetailsMessage.Parser, new[]{ "GymId", "PlayerLatitude", "PlayerLongitude", "GymLatitude", "GymLongitude", "ClientVersion" }, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GetGymDetailsMessage : pb::IMessage<GetGymDetailsMessage>
    {
        private static readonly pb::MessageParser<GetGymDetailsMessage> _parser = new pb::MessageParser<GetGymDetailsMessage>(() => new GetGymDetailsMessage());
        public static pb::MessageParser<GetGymDetailsMessage> Parser { get { return _parser; } }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Networking.Requests.Messages.GetGymDetailsMessageReflection.Descriptor.MessageTypes[0]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetGymDetailsMessage()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetGymDetailsMessage(GetGymDetailsMessage other) : this()
        {
            gymId_ = other.gymId_;
            playerLatitude_ = other.playerLatitude_;
            playerLongitude_ = other.playerLongitude_;
            gymLatitude_ = other.gymLatitude_;
            gymLongitude_ = other.gymLongitude_;
            clientVersion_ = other.clientVersion_;
        }

        public GetGymDetailsMessage Clone()
        {
            return new GetGymDetailsMessage(this);
        }

        /// <summary>Field number for the "gym_id" field.</summary>
        public const int GymIdFieldNumber = 1;
        private string gymId_ = "";
        public string GymId
        {
            get { return gymId_; }
            set
            {
                gymId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "player_latitude" field.</summary>
        public const int PlayerLatitudeFieldNumber = 2;
        private double playerLatitude_;
        public double PlayerLatitude
        {
            get { return playerLatitude_; }
            set
            {
                playerLatitude_ = value;
            }
        }

        /// <summary>Field number for the "player_longitude" field.</summary>
        public const int PlayerLongitudeFieldNumber = 3;
        private double playerLongitude_;
        public double PlayerLongitude
        {
            get { return playerLongitude_; }
            set
            {
                playerLongitude_ = value;
            }
        }

        /// <summary>Field number for the "gym_latitude" field.</summary>
        public const int GymLatitudeFieldNumber = 4;
        private double gymLatitude_;
        public double GymLatitude
        {
            get { return gymLatitude_; }
            set
            {
                gymLatitude_ = value;
            }
        }

        /// <summary>Field number for the "gym_longitude" field.</summary>
        public const int GymLongitudeFieldNumber = 5;
        private double gymLongitude_;
        public double GymLongitude
        {
            get { return gymLongitude_; }
            set
            {
                gymLongitude_ = value;
            }
        }

        /// <summary>Field number for the "client_version" field.</summary>
        public const int ClientVersionFieldNumber = 6;
        private string clientVersion_ = "";
        public string ClientVersion
        {
            get { return clientVersion_; }
            set
            {
                clientVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GetGymDetailsMessage);
        }

        public bool Equals(GetGymDetailsMessage other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (GymId != other.GymId) return false;
            if (PlayerLatitude != other.PlayerLatitude) return false;
            if (PlayerLongitude != other.PlayerLongitude) return false;
            if (GymLatitude != other.GymLatitude) return false;
            if (GymLongitude != other.GymLongitude) return false;
            if (ClientVersion != other.ClientVersion) return false;
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (GymId.Length != 0) hash ^= GymId.GetHashCode();
            if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
            if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
            if (GymLatitude != 0D) hash ^= GymLatitude.GetHashCode();
            if (GymLongitude != 0D) hash ^= GymLongitude.GetHashCode();
            if (ClientVersion.Length != 0) hash ^= ClientVersion.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (GymId.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(GymId);
            }
            if (PlayerLatitude != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(PlayerLatitude);
            }
            if (PlayerLongitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(PlayerLongitude);
            }
            if (GymLatitude != 0D)
            {
                output.WriteRawTag(33);
                output.WriteDouble(GymLatitude);
            }
            if (GymLongitude != 0D)
            {
                output.WriteRawTag(41);
                output.WriteDouble(GymLongitude);
            }
            if (ClientVersion.Length != 0)
            {
                output.WriteRawTag(50);
                output.WriteString(ClientVersion);
            }
        }

        public int CalculateSize()
        {
            int size = 0;
            if (GymId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(GymId);
            }
            if (PlayerLatitude != 0D)
            {
                size += 1 + 8;
            }
            if (PlayerLongitude != 0D)
            {
                size += 1 + 8;
            }
            if (GymLatitude != 0D)
            {
                size += 1 + 8;
            }
            if (GymLongitude != 0D)
            {
                size += 1 + 8;
            }
            if (ClientVersion.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientVersion);
            }
            return size;
        }

        public void MergeFrom(GetGymDetailsMessage other)
        {
            if (other == null)
            {
                return;
            }
            if (other.GymId.Length != 0)
            {
                GymId = other.GymId;
            }
            if (other.PlayerLatitude != 0D)
            {
                PlayerLatitude = other.PlayerLatitude;
            }
            if (other.PlayerLongitude != 0D)
            {
                PlayerLongitude = other.PlayerLongitude;
            }
            if (other.GymLatitude != 0D)
            {
                GymLatitude = other.GymLatitude;
            }
            if (other.GymLongitude != 0D)
            {
                GymLongitude = other.GymLongitude;
            }
            if (other.ClientVersion.Length != 0)
            {
                ClientVersion = other.ClientVersion;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            GymId = input.ReadString();
                            break;
                        }
                    case 17:
                        {
                            PlayerLatitude = input.ReadDouble();
                            break;
                        }
                    case 25:
                        {
                            PlayerLongitude = input.ReadDouble();
                            break;
                        }
                    case 33:
                        {
                            GymLatitude = input.ReadDouble();
                            break;
                        }
                    case 41:
                        {
                            GymLongitude = input.ReadDouble();
                            break;
                        }
                    case 50:
                        {
                            ClientVersion = input.ReadString();
                            break;
                        }
                }
            }
        }

    }

    #endregion

}

#endregion Designer generated code
