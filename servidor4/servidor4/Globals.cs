using System;

namespace servidor
{

    [Flags]
    public enum Face64 : ulong // 64-bits
    {
        // COMMANDS
        STILL_CMD = 0L,
        COLOR_CMD = 1L << 55,
        XY_CMD = 1L << 56,
        SIZE_CMD = 1L << 57,
        XYSIZE_CMD = XY_CMD | SIZE_CMD,
        MOVE_CMD = 1L << 58,
        MASK_CMD = COLOR_CMD | XY_CMD | SIZE_CMD | MOVE_CMD,

        // FACE PROPERTIES
        EyeLeftOpen = 1L << 32,
        EyeLeftClosed = 1L << 33,
        EyeLeftMask = EyeLeftClosed | EyeLeftOpen,

        EyeRightOpen = 1L << 35,
        EyeRightClosed = 1L << 36,
        EyeRightMask = EyeRightClosed | EyeRightOpen,

        BrowLeftNone = 1L << 38,
        BrowLeftDown = 1L << 39,
        BrowLeftUp = 1L << 40,
        BrowLeftMask = BrowLeftNone | BrowLeftDown | BrowLeftUp,

        BrowRightNone = 1L << 41,
        BrowRightDown = 1L << 42,
        BrowRightUp = 1L << 43,
        BrowRightMask = BrowRightNone | BrowRightDown | BrowRightUp,

        Tongue = 1L << 44,
        MouthOpen = 1L << 45,
        MouthSmile = 1L << 46,
        MouthNeutral = 1L << 47,
        MouthNone = MouthNeutral | MouthSmile | MouthOpen | Tongue,
        MouthNeutralTongue = MouthNeutral | Tongue,
        MouthOpenTongue = MouthOpen | Tongue,
        MouthSmileOpen = MouthSmile | MouthOpen,
        MouthSmileTongue = MouthSmile | Tongue,
        MouthSmileOpenTongue = MouthSmile | MouthOpen | Tongue,
        MouthAngry = MouthNeutral | MouthSmile,
        MouthKiss = MouthNeutral | MouthSmile | MouthOpen,
        MouthMask = Tongue | MouthOpen | MouthSmile | MouthNeutral
    }
}