﻿using Newtonsoft.Json;
using System;

namespace Jojatekok.MoneroAPI.RpcManagers.Daemon.Json.Responses
{
    class BlockHeaderValueContainer : HttpRpcResponse, IValueContainer<BlockHeader>
    {
        [JsonProperty("block_header")]
        public BlockHeader Value { get; private set; }
    }

    public class BlockHeader
    {
        [JsonProperty("major_version")]
        public int VersionMajor { get; private set; }

        [JsonProperty("minor_version")]
        public int VersionMinor { get; private set; }

        [JsonProperty("timestamp")]
        private ulong TimestampUnix {
            set { Timestamp = Helper.UnixTimeStampToDateTime(value); }
        }
        public DateTime Timestamp { get; private set; }

        [JsonProperty("hash")]
        public string HashCurrent { get; private set; }
        [JsonProperty("prev_hash")]
        public string HashPrevious { get; private set; }

        [JsonProperty("height")]
        public ulong Height { get; private set; }
        [JsonProperty("depth")]
        public ulong Depth { get; private set; }

        [JsonProperty("difficulty")]
        public ulong Difficulty { get; private set; }
        [JsonProperty("reward")]
        public ulong Reward { get; private set; }

        [JsonProperty("nonce")]
        public ulong Nonce { get; private set; }

        [JsonProperty("orphan_status")]
        public bool IsOrphaned { get; private set; }
    }
}