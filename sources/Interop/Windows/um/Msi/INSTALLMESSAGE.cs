// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum INSTALLMESSAGE
    {
        INSTALLMESSAGE_FATALEXIT = 0x00000000,
        INSTALLMESSAGE_ERROR = 0x01000000,
        INSTALLMESSAGE_WARNING = 0x02000000,
        INSTALLMESSAGE_USER = 0x03000000,
        INSTALLMESSAGE_INFO = 0x04000000,
        INSTALLMESSAGE_FILESINUSE = 0x05000000,
        INSTALLMESSAGE_RESOLVESOURCE = 0x06000000,
        INSTALLMESSAGE_OUTOFDISKSPACE = 0x07000000,
        INSTALLMESSAGE_ACTIONSTART = 0x08000000,
        INSTALLMESSAGE_ACTIONDATA = 0x09000000,
        INSTALLMESSAGE_PROGRESS = 0x0A000000,
        INSTALLMESSAGE_COMMONDATA = 0x0B000000,
        INSTALLMESSAGE_INITIALIZE = 0x0C000000,
        INSTALLMESSAGE_TERMINATE = 0x0D000000,
        INSTALLMESSAGE_SHOWDIALOG = 0x0E000000,
        INSTALLMESSAGE_PERFORMANCE = 0x0F000000,
        INSTALLMESSAGE_RMFILESINUSE = 0x19000000,
        INSTALLMESSAGE_INSTALLSTART = 0x1A000000,
        INSTALLMESSAGE_INSTALLEND = 0x1B000000,
    }
}