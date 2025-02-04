﻿using Hi3Helper.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace Hi3Helper.EncTool.Parser.Cache
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CGPCKType : byte // TypeDefIndex: 34029
    {
        MustHave = 0,
        WithAll = 1,
        Needing = 2,
        All = 100
    }

    public class CgHash
    {
        public int Hash { get; set; }
    }

    public class CGMetadata
    {
        private static Encoding _encoding { get; set; }

        public int CgID { get; set; }
        public byte UnlockType { get; set; }
        public uint UnlockCondition { get; set; }
        public int LevelIDBegin { get; set; }
        public int LevelIDEnd { get; set; }
        public int CgCategory { get; set; }
        public int CgSubCategory { get; set; }
        public int[] CgGroupID { get; set; }
        public int WikiCgScore { get; set; }
        public bool InitialUnlock { get; set; }
        public string CgPath { get; set; }
        public string CgIconSpritePath { get; set; }
        public CgHash CgLockHint { get; set; }
        public bool InStreamingAssets { get; set; }
        public int CgPlayMode { get; set; }
        public string CgExtraKey { get; set; }
        public int FileSize { get; set; }
        public CGPCKType PckType { get; set; }
        public string DownloadLimitTime { get; set; }
        public uint AppointmentDownloadScheduleID { get; set; }

        public static CGMetadata[] GetArray(CacheStream stream, Encoding encoding)
        {
            // Set the encoding
            _encoding = encoding;

            // Get the entry count
            int entryCount = GetEntryCount(stream);

            // Initialize the return value of the instance
            CGMetadata[] entries = new CGMetadata[entryCount];

            // Assign the data to the return value
            for (int i = 0; i < entryCount; i++) entries[i] = Deserialize(stream);

            // Return the value
            return entries;
        }

        public static List<CGMetadata> GetList(CacheStream stream, Encoding encoding)
        {
            // Set the encoding
            _encoding = encoding;

            // Get the entry count
            int entryCount = GetEntryCount(stream);

            // Initialize the return value of the instance
            List<CGMetadata> entries = new List<CGMetadata>();

            // Assign the data to the return value
            for (int i = 0; i < entryCount; i++) entries.Add(Deserialize(stream));

            // Return the value
            return entries;
        }

        public static IEnumerable<CGMetadata> Enumerate(CacheStream stream, Encoding encoding)
        {
            // Set the encoding
            _encoding = encoding;

            // Get the entry count
            int entryCount = GetEntryCount(stream);

            // Assign the data to the return value and yield it
            for (int i = 0; i < entryCount; i++) yield return Deserialize(stream);
        }

        private static int GetEntryCount(Stream stream)
        {
            // Skip the file size information and skip to the entry count
            stream.Position += 4;
            int entryCount = ReadInt32(stream);

            // Skip the keys and data start offsets
            stream.Position += (entryCount * 4) * 2;

            return entryCount;
        }

        private static CGMetadata Deserialize(CacheStream stream)
        {
            CGMetadata entry = new CGMetadata();
            entry.CgID = ReadInt32(stream);

            entry.UnlockType = ReadByte(stream);
            entry.UnlockCondition = ReadUInt32(stream);
            entry.LevelIDBegin = ReadInt32(stream);
            entry.LevelIDEnd = ReadInt32(stream);
            entry.CgCategory = ReadInt32(stream);
            entry.CgSubCategory = ReadInt32(stream);

            int ptrToCgGroupIDArr = ReadInt32(stream);

            entry.WikiCgScore = ReadInt32(stream);
            entry.InitialUnlock = ReadBoolean(stream);

            int ptrToCgPath = ReadInt32(stream);
            int ptrToCgIconSpritePath = ReadInt32(stream);
            int ptrToPckType = ReadInt32(stream);

            entry.InStreamingAssets = ReadInt32(stream) == 1;
            entry.CgPlayMode = ReadInt32(stream);

            int ptrToCgExtraKey = ReadInt32(stream);

            entry.FileSize = ReadInt32(stream);

            entry.PckType = (CGPCKType)ReadByte(stream);
            int ptrToDownloadLimitTime = ReadInt32(stream);

            entry.AppointmentDownloadScheduleID = ReadUInt32(stream);

            stream.Position = ptrToCgGroupIDArr;
            uint CgGroupIDCount = ReadUInt32(stream);
            entry.CgGroupID = new int[CgGroupIDCount];
            for (int i = 0; i < CgGroupIDCount; i++)
            {
                entry.CgGroupID[i] = ReadInt32(stream);
            }

            stream.Position = ptrToCgPath;
            entry.CgPath = ReadString(stream);

            stream.Position = ptrToCgIconSpritePath;
            entry.CgIconSpritePath = ReadString(stream);

            stream.Position++;
            entry.CgLockHint = new CgHash { Hash = ReadInt32(stream) };

            stream.Position = ptrToPckType + 1;

            stream.Position = ptrToCgExtraKey;
            entry.CgExtraKey = ReadString(stream);

            stream.Position = ptrToDownloadLimitTime;
            entry.DownloadLimitTime = ReadString(stream);

#if DEBUG
            Console.WriteLine($"CG [Type: {entry.PckType}][IsBuiltIn: {entry.InStreamingAssets}]: {entry.CgPath} [{entry.FileSize} bytes]");
#endif

            return entry;
        }

        private static int ReadInt32(Stream stream)
        {
            Span<byte> buf = stackalloc byte[4];
            stream.Read(buf);
            return HexTool.BytesToInt32Unsafe(buf);
        }

        private static uint ReadUInt32(Stream stream)
        {
            Span<byte> buf = stackalloc byte[4];
            stream.Read(buf);
            return HexTool.BytesToUInt32Unsafe(buf);
        }

        private static short ReadInt16(Stream stream)
        {
            Span<byte> buf = stackalloc byte[2];
            stream.Read(buf);
            return HexTool.BytesToInt16Unsafe(buf);
        }

        private static ushort ReadUInt16(Stream stream)
        {
            Span<byte> buf = stackalloc byte[2];
            stream.Read(buf);
            return HexTool.BytesToUInt16Unsafe(buf);
        }

        private static string ReadString(Stream stream)
        {
            ushort len = ReadUInt16(stream);
            Span<byte> strArr = stackalloc byte[len];
            stream.Read(strArr);
            return _encoding.GetString(strArr);
        }

        private static byte ReadByte(Stream stream) => (byte)stream.ReadByte();

        private static bool ReadBoolean(Stream stream) => ReadByte(stream) == 1;
    }
}
