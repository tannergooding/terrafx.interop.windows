// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class FILE
    {
        [NativeTypeName("#define FILE_DEVICE_BEEP 0x00000001")]
        public const int FILE_DEVICE_BEEP = 0x00000001;

        [NativeTypeName("#define FILE_DEVICE_CD_ROM 0x00000002")]
        public const int FILE_DEVICE_CD_ROM = 0x00000002;

        [NativeTypeName("#define FILE_DEVICE_CD_ROM_FILE_SYSTEM 0x00000003")]
        public const int FILE_DEVICE_CD_ROM_FILE_SYSTEM = 0x00000003;

        [NativeTypeName("#define FILE_DEVICE_CONTROLLER 0x00000004")]
        public const int FILE_DEVICE_CONTROLLER = 0x00000004;

        [NativeTypeName("#define FILE_DEVICE_DATALINK 0x00000005")]
        public const int FILE_DEVICE_DATALINK = 0x00000005;

        [NativeTypeName("#define FILE_DEVICE_DFS 0x00000006")]
        public const int FILE_DEVICE_DFS = 0x00000006;

        [NativeTypeName("#define FILE_DEVICE_DISK 0x00000007")]
        public const int FILE_DEVICE_DISK = 0x00000007;

        [NativeTypeName("#define FILE_DEVICE_DISK_FILE_SYSTEM 0x00000008")]
        public const int FILE_DEVICE_DISK_FILE_SYSTEM = 0x00000008;

        [NativeTypeName("#define FILE_DEVICE_FILE_SYSTEM 0x00000009")]
        public const int FILE_DEVICE_FILE_SYSTEM = 0x00000009;

        [NativeTypeName("#define FILE_DEVICE_INPORT_PORT 0x0000000a")]
        public const int FILE_DEVICE_INPORT_PORT = 0x0000000a;

        [NativeTypeName("#define FILE_DEVICE_KEYBOARD 0x0000000b")]
        public const int FILE_DEVICE_KEYBOARD = 0x0000000b;

        [NativeTypeName("#define FILE_DEVICE_MAILSLOT 0x0000000c")]
        public const int FILE_DEVICE_MAILSLOT = 0x0000000c;

        [NativeTypeName("#define FILE_DEVICE_MIDI_IN 0x0000000d")]
        public const int FILE_DEVICE_MIDI_IN = 0x0000000d;

        [NativeTypeName("#define FILE_DEVICE_MIDI_OUT 0x0000000e")]
        public const int FILE_DEVICE_MIDI_OUT = 0x0000000e;

        [NativeTypeName("#define FILE_DEVICE_MOUSE 0x0000000f")]
        public const int FILE_DEVICE_MOUSE = 0x0000000f;

        [NativeTypeName("#define FILE_DEVICE_MULTI_UNC_PROVIDER 0x00000010")]
        public const int FILE_DEVICE_MULTI_UNC_PROVIDER = 0x00000010;

        [NativeTypeName("#define FILE_DEVICE_NAMED_PIPE 0x00000011")]
        public const int FILE_DEVICE_NAMED_PIPE = 0x00000011;

        [NativeTypeName("#define FILE_DEVICE_NETWORK 0x00000012")]
        public const int FILE_DEVICE_NETWORK = 0x00000012;

        [NativeTypeName("#define FILE_DEVICE_NETWORK_BROWSER 0x00000013")]
        public const int FILE_DEVICE_NETWORK_BROWSER = 0x00000013;

        [NativeTypeName("#define FILE_DEVICE_NETWORK_FILE_SYSTEM 0x00000014")]
        public const int FILE_DEVICE_NETWORK_FILE_SYSTEM = 0x00000014;

        [NativeTypeName("#define FILE_DEVICE_NULL 0x00000015")]
        public const int FILE_DEVICE_NULL = 0x00000015;

        [NativeTypeName("#define FILE_DEVICE_PARALLEL_PORT 0x00000016")]
        public const int FILE_DEVICE_PARALLEL_PORT = 0x00000016;

        [NativeTypeName("#define FILE_DEVICE_PHYSICAL_NETCARD 0x00000017")]
        public const int FILE_DEVICE_PHYSICAL_NETCARD = 0x00000017;

        [NativeTypeName("#define FILE_DEVICE_PRINTER 0x00000018")]
        public const int FILE_DEVICE_PRINTER = 0x00000018;

        [NativeTypeName("#define FILE_DEVICE_SCANNER 0x00000019")]
        public const int FILE_DEVICE_SCANNER = 0x00000019;

        [NativeTypeName("#define FILE_DEVICE_SERIAL_MOUSE_PORT 0x0000001a")]
        public const int FILE_DEVICE_SERIAL_MOUSE_PORT = 0x0000001a;

        [NativeTypeName("#define FILE_DEVICE_SERIAL_PORT 0x0000001b")]
        public const int FILE_DEVICE_SERIAL_PORT = 0x0000001b;

        [NativeTypeName("#define FILE_DEVICE_SCREEN 0x0000001c")]
        public const int FILE_DEVICE_SCREEN = 0x0000001c;

        [NativeTypeName("#define FILE_DEVICE_SOUND 0x0000001d")]
        public const int FILE_DEVICE_SOUND = 0x0000001d;

        [NativeTypeName("#define FILE_DEVICE_STREAMS 0x0000001e")]
        public const int FILE_DEVICE_STREAMS = 0x0000001e;

        [NativeTypeName("#define FILE_DEVICE_TAPE 0x0000001f")]
        public const int FILE_DEVICE_TAPE = 0x0000001f;

        [NativeTypeName("#define FILE_DEVICE_TAPE_FILE_SYSTEM 0x00000020")]
        public const int FILE_DEVICE_TAPE_FILE_SYSTEM = 0x00000020;

        [NativeTypeName("#define FILE_DEVICE_TRANSPORT 0x00000021")]
        public const int FILE_DEVICE_TRANSPORT = 0x00000021;

        [NativeTypeName("#define FILE_DEVICE_UNKNOWN 0x00000022")]
        public const int FILE_DEVICE_UNKNOWN = 0x00000022;

        [NativeTypeName("#define FILE_DEVICE_VIDEO 0x00000023")]
        public const int FILE_DEVICE_VIDEO = 0x00000023;

        [NativeTypeName("#define FILE_DEVICE_VIRTUAL_DISK 0x00000024")]
        public const int FILE_DEVICE_VIRTUAL_DISK = 0x00000024;

        [NativeTypeName("#define FILE_DEVICE_WAVE_IN 0x00000025")]
        public const int FILE_DEVICE_WAVE_IN = 0x00000025;

        [NativeTypeName("#define FILE_DEVICE_WAVE_OUT 0x00000026")]
        public const int FILE_DEVICE_WAVE_OUT = 0x00000026;

        [NativeTypeName("#define FILE_DEVICE_8042_PORT 0x00000027")]
        public const int FILE_DEVICE_8042_PORT = 0x00000027;

        [NativeTypeName("#define FILE_DEVICE_NETWORK_REDIRECTOR 0x00000028")]
        public const int FILE_DEVICE_NETWORK_REDIRECTOR = 0x00000028;

        [NativeTypeName("#define FILE_DEVICE_BATTERY 0x00000029")]
        public const int FILE_DEVICE_BATTERY = 0x00000029;

        [NativeTypeName("#define FILE_DEVICE_BUS_EXTENDER 0x0000002a")]
        public const int FILE_DEVICE_BUS_EXTENDER = 0x0000002a;

        [NativeTypeName("#define FILE_DEVICE_MODEM 0x0000002b")]
        public const int FILE_DEVICE_MODEM = 0x0000002b;

        [NativeTypeName("#define FILE_DEVICE_VDM 0x0000002c")]
        public const int FILE_DEVICE_VDM = 0x0000002c;

        [NativeTypeName("#define FILE_DEVICE_MASS_STORAGE 0x0000002d")]
        public const int FILE_DEVICE_MASS_STORAGE = 0x0000002d;

        [NativeTypeName("#define FILE_DEVICE_SMB 0x0000002e")]
        public const int FILE_DEVICE_SMB = 0x0000002e;

        [NativeTypeName("#define FILE_DEVICE_KS 0x0000002f")]
        public const int FILE_DEVICE_KS = 0x0000002f;

        [NativeTypeName("#define FILE_DEVICE_CHANGER 0x00000030")]
        public const int FILE_DEVICE_CHANGER = 0x00000030;

        [NativeTypeName("#define FILE_DEVICE_SMARTCARD 0x00000031")]
        public const int FILE_DEVICE_SMARTCARD = 0x00000031;

        [NativeTypeName("#define FILE_DEVICE_ACPI 0x00000032")]
        public const int FILE_DEVICE_ACPI = 0x00000032;

        [NativeTypeName("#define FILE_DEVICE_DVD 0x00000033")]
        public const int FILE_DEVICE_DVD = 0x00000033;

        [NativeTypeName("#define FILE_DEVICE_FULLSCREEN_VIDEO 0x00000034")]
        public const int FILE_DEVICE_FULLSCREEN_VIDEO = 0x00000034;

        [NativeTypeName("#define FILE_DEVICE_DFS_FILE_SYSTEM 0x00000035")]
        public const int FILE_DEVICE_DFS_FILE_SYSTEM = 0x00000035;

        [NativeTypeName("#define FILE_DEVICE_DFS_VOLUME 0x00000036")]
        public const int FILE_DEVICE_DFS_VOLUME = 0x00000036;

        [NativeTypeName("#define FILE_DEVICE_SERENUM 0x00000037")]
        public const int FILE_DEVICE_SERENUM = 0x00000037;

        [NativeTypeName("#define FILE_DEVICE_TERMSRV 0x00000038")]
        public const int FILE_DEVICE_TERMSRV = 0x00000038;

        [NativeTypeName("#define FILE_DEVICE_KSEC 0x00000039")]
        public const int FILE_DEVICE_KSEC = 0x00000039;

        [NativeTypeName("#define FILE_DEVICE_FIPS 0x0000003A")]
        public const int FILE_DEVICE_FIPS = 0x0000003A;

        [NativeTypeName("#define FILE_DEVICE_INFINIBAND 0x0000003B")]
        public const int FILE_DEVICE_INFINIBAND = 0x0000003B;

        [NativeTypeName("#define FILE_DEVICE_VMBUS 0x0000003E")]
        public const int FILE_DEVICE_VMBUS = 0x0000003E;

        [NativeTypeName("#define FILE_DEVICE_CRYPT_PROVIDER 0x0000003F")]
        public const int FILE_DEVICE_CRYPT_PROVIDER = 0x0000003F;

        [NativeTypeName("#define FILE_DEVICE_WPD 0x00000040")]
        public const int FILE_DEVICE_WPD = 0x00000040;

        [NativeTypeName("#define FILE_DEVICE_BLUETOOTH 0x00000041")]
        public const int FILE_DEVICE_BLUETOOTH = 0x00000041;

        [NativeTypeName("#define FILE_DEVICE_MT_COMPOSITE 0x00000042")]
        public const int FILE_DEVICE_MT_COMPOSITE = 0x00000042;

        [NativeTypeName("#define FILE_DEVICE_MT_TRANSPORT 0x00000043")]
        public const int FILE_DEVICE_MT_TRANSPORT = 0x00000043;

        [NativeTypeName("#define FILE_DEVICE_BIOMETRIC 0x00000044")]
        public const int FILE_DEVICE_BIOMETRIC = 0x00000044;

        [NativeTypeName("#define FILE_DEVICE_PMI 0x00000045")]
        public const int FILE_DEVICE_PMI = 0x00000045;

        [NativeTypeName("#define FILE_DEVICE_EHSTOR 0x00000046")]
        public const int FILE_DEVICE_EHSTOR = 0x00000046;

        [NativeTypeName("#define FILE_DEVICE_DEVAPI 0x00000047")]
        public const int FILE_DEVICE_DEVAPI = 0x00000047;

        [NativeTypeName("#define FILE_DEVICE_GPIO 0x00000048")]
        public const int FILE_DEVICE_GPIO = 0x00000048;

        [NativeTypeName("#define FILE_DEVICE_USBEX 0x00000049")]
        public const int FILE_DEVICE_USBEX = 0x00000049;

        [NativeTypeName("#define FILE_DEVICE_CONSOLE 0x00000050")]
        public const int FILE_DEVICE_CONSOLE = 0x00000050;

        [NativeTypeName("#define FILE_DEVICE_NFP 0x00000051")]
        public const int FILE_DEVICE_NFP = 0x00000051;

        [NativeTypeName("#define FILE_DEVICE_SYSENV 0x00000052")]
        public const int FILE_DEVICE_SYSENV = 0x00000052;

        [NativeTypeName("#define FILE_DEVICE_VIRTUAL_BLOCK 0x00000053")]
        public const int FILE_DEVICE_VIRTUAL_BLOCK = 0x00000053;

        [NativeTypeName("#define FILE_DEVICE_POINT_OF_SERVICE 0x00000054")]
        public const int FILE_DEVICE_POINT_OF_SERVICE = 0x00000054;

        [NativeTypeName("#define FILE_DEVICE_STORAGE_REPLICATION 0x00000055")]
        public const int FILE_DEVICE_STORAGE_REPLICATION = 0x00000055;

        [NativeTypeName("#define FILE_DEVICE_TRUST_ENV 0x00000056")]
        public const int FILE_DEVICE_TRUST_ENV = 0x00000056;

        [NativeTypeName("#define FILE_DEVICE_UCM 0x00000057")]
        public const int FILE_DEVICE_UCM = 0x00000057;

        [NativeTypeName("#define FILE_DEVICE_UCMTCPCI 0x00000058")]
        public const int FILE_DEVICE_UCMTCPCI = 0x00000058;

        [NativeTypeName("#define FILE_DEVICE_PERSISTENT_MEMORY 0x00000059")]
        public const int FILE_DEVICE_PERSISTENT_MEMORY = 0x00000059;

        [NativeTypeName("#define FILE_DEVICE_NVDIMM 0x0000005a")]
        public const int FILE_DEVICE_NVDIMM = 0x0000005a;

        [NativeTypeName("#define FILE_DEVICE_HOLOGRAPHIC 0x0000005b")]
        public const int FILE_DEVICE_HOLOGRAPHIC = 0x0000005b;

        [NativeTypeName("#define FILE_DEVICE_SDFXHCI 0x0000005c")]
        public const int FILE_DEVICE_SDFXHCI = 0x0000005c;

        [NativeTypeName("#define FILE_DEVICE_UCMUCSI 0x0000005d")]
        public const int FILE_DEVICE_UCMUCSI = 0x0000005d;

        [NativeTypeName("#define FILE_DEVICE_PRM 0x0000005e")]
        public const int FILE_DEVICE_PRM = 0x0000005e;

        [NativeTypeName("#define FILE_DEVICE_EVENT_COLLECTOR 0x0000005f")]
        public const int FILE_DEVICE_EVENT_COLLECTOR = 0x0000005f;

        [NativeTypeName("#define FILE_ANY_ACCESS 0")]
        public const int FILE_ANY_ACCESS = 0;

        [NativeTypeName("#define FILE_SPECIAL_ACCESS (FILE_ANY_ACCESS)")]
        public const int FILE_SPECIAL_ACCESS = (0);

        [NativeTypeName("#define FILE_READ_ACCESS ( 0x0001 )")]
        public const int FILE_READ_ACCESS = (0x0001);

        [NativeTypeName("#define FILE_WRITE_ACCESS ( 0x0002 )")]
        public const int FILE_WRITE_ACCESS = (0x0002);

        [NativeTypeName("#define FILE_PREFETCH_TYPE_FOR_CREATE 0x1")]
        public const int FILE_PREFETCH_TYPE_FOR_CREATE = 0x1;

        [NativeTypeName("#define FILE_PREFETCH_TYPE_FOR_DIRENUM 0x2")]
        public const int FILE_PREFETCH_TYPE_FOR_DIRENUM = 0x2;

        [NativeTypeName("#define FILE_PREFETCH_TYPE_FOR_CREATE_EX 0x3")]
        public const int FILE_PREFETCH_TYPE_FOR_CREATE_EX = 0x3;

        [NativeTypeName("#define FILE_PREFETCH_TYPE_FOR_DIRENUM_EX 0x4")]
        public const int FILE_PREFETCH_TYPE_FOR_DIRENUM_EX = 0x4;

        [NativeTypeName("#define FILE_PREFETCH_TYPE_MAX 0x4")]
        public const int FILE_PREFETCH_TYPE_MAX = 0x4;

        [NativeTypeName("#define FILE_ZERO_DATA_INFORMATION_FLAG_PRESERVE_CACHED_DATA (0x00000001)")]
        public const int FILE_ZERO_DATA_INFORMATION_FLAG_PRESERVE_CACHED_DATA = (0x00000001);

        [NativeTypeName("#define FILE_SET_ENCRYPTION 0x00000001")]
        public const int FILE_SET_ENCRYPTION = 0x00000001;

        [NativeTypeName("#define FILE_CLEAR_ENCRYPTION 0x00000002")]
        public const int FILE_CLEAR_ENCRYPTION = 0x00000002;

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_IN_USE (0x0000000000000001)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_IN_USE = (0x0000000000000001);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_REUSED (0x0000000000000002)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_REUSED = (0x0000000000000002);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_EXIST (0x0000000000000004)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_EXIST = (0x0000000000000004);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_BASE_RECORD (0x0000000000000008)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_BASE_RECORD = (0x0000000000000008);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_SYSTEM_FILE (0x0000000000000010)")]
        public const int FILE_INITIATE_REPAIR_HINT1_SYSTEM_FILE = (0x0000000000000010);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_NOT_IMPLEMENTED (0x0000000000000020)")]
        public const int FILE_INITIATE_REPAIR_HINT1_NOT_IMPLEMENTED = (0x0000000000000020);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_UNABLE_TO_REPAIR (0x0000000000000040)")]
        public const int FILE_INITIATE_REPAIR_HINT1_UNABLE_TO_REPAIR = (0x0000000000000040);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_REPAIR_DISABLED (0x0000000000000080)")]
        public const int FILE_INITIATE_REPAIR_HINT1_REPAIR_DISABLED = (0x0000000000000080);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_RECURSIVELY_CORRUPTED (0x0000000000000100)")]
        public const int FILE_INITIATE_REPAIR_HINT1_RECURSIVELY_CORRUPTED = (0x0000000000000100);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ORPHAN_GENERATED (0x0000000000000200)")]
        public const int FILE_INITIATE_REPAIR_HINT1_ORPHAN_GENERATED = (0x0000000000000200);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_REPAIRED (0x0000000000000400)")]
        public const int FILE_INITIATE_REPAIR_HINT1_REPAIRED = (0x0000000000000400);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_NOTHING_WRONG (0x0000000000000800)")]
        public const int FILE_INITIATE_REPAIR_HINT1_NOTHING_WRONG = (0x0000000000000800);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_NOT_FOUND (0x0000000000001000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_NOT_FOUND = (0x0000000000001000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_POTENTIAL_CROSSLINK (0x0000000000002000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_POTENTIAL_CROSSLINK = (0x0000000000002000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_STALE_INFORMATION (0x0000000000004000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_STALE_INFORMATION = (0x0000000000004000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_CLUSTERS_ALREADY_IN_USE (0x0000000000008000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_CLUSTERS_ALREADY_IN_USE = (0x0000000000008000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_LCN_NOT_EXIST (0x0000000000010000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_LCN_NOT_EXIST = (0x0000000000010000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_RUN_LENGTH (0x0000000000020000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_INVALID_RUN_LENGTH = (0x0000000000020000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_ORPHAN (0x0000000000040000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_ORPHAN = (0x0000000000040000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_IS_BASE_RECORD (0x0000000000080000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_IS_BASE_RECORD = (0x0000000000080000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_ARRAY_LENGTH_COUNT (0x0000000000100000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_INVALID_ARRAY_LENGTH_COUNT = (0x0000000000100000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_SID_VALID (0x0000000000200000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_SID_VALID = (0x0000000000200000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_SID_MISMATCH (0x0000000000400000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_SID_MISMATCH = (0x0000000000400000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_PARENT (0x0000000000800000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_INVALID_PARENT = (0x0000000000800000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_IN_USE (0x0000000001000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_IN_USE = (0x0000000001000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_REUSED (0x0000000002000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_REUSED = (0x0000000002000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_EXIST (0x0000000004000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_EXIST = (0x0000000004000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_BASE_RECORD (0x0000000008000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_BASE_RECORD = (0x0000000008000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_INDEX (0x0000000010000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_INDEX = (0x0000000010000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_VALID_INDEX_ENTRY (0x0000000020000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_VALID_INDEX_ENTRY = (0x0000000020000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_OUT_OF_GENERIC_NAMES (0x0000000040000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_OUT_OF_GENERIC_NAMES = (0x0000000040000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_OUT_OF_RESOURCE (0x0000000080000000)")]
        public const uint FILE_INITIATE_REPAIR_HINT1_OUT_OF_RESOURCE = (0x0000000080000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_LCN (0x0000000100000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_INVALID_LCN = (0x0000000100000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_VCN (0x0000000200000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_INVALID_VCN = (0x0000000200000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_NAME_CONFLICT (0x0000000400000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_NAME_CONFLICT = (0x0000000400000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ORPHAN (0x0000000800000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_ORPHAN = (0x0000000800000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_TOO_SMALL (0x0000001000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_TOO_SMALL = (0x0000001000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_NON_RESIDENT (0x0000002000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_NON_RESIDENT = (0x0000002000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_DENY_DEFRAG (0x0000004000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_DENY_DEFRAG = (0x0000004000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PREVIOUS_PARENT_STILL_VALID (0x0000008000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_PREVIOUS_PARENT_STILL_VALID = (0x0000008000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INDEX_ENTRY_MISMATCH (0x0000010000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_INDEX_ENTRY_MISMATCH = (0x0000010000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_ORPHAN_RECOVERY_NAME (0x0000020000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_INVALID_ORPHAN_RECOVERY_NAME = (0x0000020000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_MULTIPLE_FILE_NAME_ATTRIBUTES (0x0000040000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_MULTIPLE_FILE_NAME_ATTRIBUTES = (0x0000040000000000);

        [NativeTypeName("#define FILE_TYPE_NOTIFICATION_FLAG_USAGE_BEGIN 0x00000001")]
        public const int FILE_TYPE_NOTIFICATION_FLAG_USAGE_BEGIN = 0x00000001;

        [NativeTypeName("#define FILE_TYPE_NOTIFICATION_FLAG_USAGE_END 0x00000002")]
        public const int FILE_TYPE_NOTIFICATION_FLAG_USAGE_END = 0x00000002;

        [NativeTypeName("#define FILE_LAYOUT_NAME_ENTRY_PRIMARY (0x00000001)")]
        public const int FILE_LAYOUT_NAME_ENTRY_PRIMARY = (0x00000001);

        [NativeTypeName("#define FILE_LAYOUT_NAME_ENTRY_DOS (0x00000002)")]
        public const int FILE_LAYOUT_NAME_ENTRY_DOS = (0x00000002);

        [NativeTypeName("#define FILE_REGION_USAGE_VALID_CACHED_DATA 0x00000001")]
        public const int FILE_REGION_USAGE_VALID_CACHED_DATA = 0x00000001;

        [NativeTypeName("#define FILE_REGION_USAGE_VALID_NONCACHED_DATA 0x00000002")]
        public const int FILE_REGION_USAGE_VALID_NONCACHED_DATA = 0x00000002;

        [NativeTypeName("#define FILE_REGION_USAGE_OTHER_PAGE_ALIGNMENT 0x00000004")]
        public const int FILE_REGION_USAGE_OTHER_PAGE_ALIGNMENT = 0x00000004;

        [NativeTypeName("#define FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT 0x00000008")]
        public const int FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT = 0x00000008;

        [NativeTypeName("#define FILE_STORAGE_TIER_NAME_LENGTH (256)")]
        public const int FILE_STORAGE_TIER_NAME_LENGTH = (256);

        [NativeTypeName("#define FILE_STORAGE_TIER_DESCRIPTION_LENGTH (512)")]
        public const int FILE_STORAGE_TIER_DESCRIPTION_LENGTH = (512);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_NO_SEEK_PENALTY (0x00020000)")]
        public const int FILE_STORAGE_TIER_FLAG_NO_SEEK_PENALTY = (0x00020000);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_WRITE_BACK_CACHE (0x00200000)")]
        public const int FILE_STORAGE_TIER_FLAG_WRITE_BACK_CACHE = (0x00200000);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_READ_CACHE (0x00400000)")]
        public const int FILE_STORAGE_TIER_FLAG_READ_CACHE = (0x00400000);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_PARITY (0x00800000)")]
        public const int FILE_STORAGE_TIER_FLAG_PARITY = (0x00800000);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_SMR (0x01000000)")]
        public const int FILE_STORAGE_TIER_FLAG_SMR = (0x01000000);

        [NativeTypeName("#define FILE_PROVIDER_CURRENT_VERSION (0x00000001)")]
        public const int FILE_PROVIDER_CURRENT_VERSION = (0x00000001);

        [NativeTypeName("#define FILE_PROVIDER_SINGLE_FILE (0x00000001)")]
        public const int FILE_PROVIDER_SINGLE_FILE = (0x00000001);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_XPRESS4K (0x00000000)")]
        public const int FILE_PROVIDER_COMPRESSION_XPRESS4K = (0x00000000);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_LZX (0x00000001)")]
        public const int FILE_PROVIDER_COMPRESSION_LZX = (0x00000001);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_XPRESS8K (0x00000002)")]
        public const int FILE_PROVIDER_COMPRESSION_XPRESS8K = (0x00000002);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_XPRESS16K (0x00000003)")]
        public const int FILE_PROVIDER_COMPRESSION_XPRESS16K = (0x00000003);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_MAXIMUM (0x00000004)")]
        public const int FILE_PROVIDER_COMPRESSION_MAXIMUM = (0x00000004);

        [NativeTypeName("#define FILE_PROVIDER_FLAG_COMPRESS_ON_WRITE (0x00000001)")]
        public const int FILE_PROVIDER_FLAG_COMPRESS_ON_WRITE = (0x00000001);
    }
}
