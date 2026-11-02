/// <summary>
/// The 40-metre trail chunks, as flat lane codes read three at a time
/// (lane 0, lane 1, lane 2 per row).
///   0 empty   1 geyser   2 cinder bomb   3 ember   4 frost geode
/// Returned fresh every call: no static array can be reordered out from under a
/// reader by the obfuscator (C.52), and a caller may mutate its copy freely.
/// </summary>
public static class _0x63083ceb
{
    public const int Switchback = 5;
    public const int EmberArc = 4;
    public const int Empty = 0;
    public const int OpenRun = 0;
    public const int CinderFall = 2;
    public const int Cinder = 2;
    public const int GeodeAlcove = 3;
    public const int Count = 7;
    /// <summary>True when the chunk is drawn on pale crust tiles instead of basalt.</summary>
    public static bool IsCrust(int _0xa230e26c)
    {
        return _0xa230e26c == CrustBridge;
    }

    public const int Geyser = 1;
    public static int[] Rows(int _0xe074649f)
    {
        switch (_0xe074649f)
        {
            case GeyserPair:
                return new int[]
                {
                    0,
                    0,
                    0,
                    1,
                    1,
                    3,
                    0,
                    0,
                    3,
                    3,
                    1,
                    1,
                    0,
                    0,
                    0,
                };
            case CinderFall:
                return new int[]
                {
                    2,
                    0,
                    0,
                    0,
                    3,
                    0,
                    0,
                    0,
                    2,
                    0,
                    3,
                    0,
                    2,
                    0,
                    0,
                };
            case GeodeAlcove:
                return new int[]
                {
                    0,
                    0,
                    0,
                    0,
                    1,
                    0,
                    0,
                    4,
                    0,
                    3,
                    0,
                    3,
                    0,
                    0,
                    0,
                };
            case EmberArc:
                return new int[]
                {
                    3,
                    0,
                    0,
                    0,
                    3,
                    0,
                    0,
                    0,
                    3,
                    0,
                    3,
                    2,
                    3,
                    0,
                    0,
                    0,
                    3,
                    0,
                };
            case Switchback:
                return new int[]
                {
                    0,
                    1,
                    1,
                    3,
                    0,
                    0,
                    1,
                    1,
                    0,
                    0,
                    0,
                    3,
                    2,
                    0,
                    0,
                    0,
                    3,
                    3,
                };
            case CrustBridge:
                return new int[]
                {
                    0,
                    0,
                    0,
                    0,
                    1,
                    0,
                    3,
                    0,
                    3,
                    0,
                    1,
                    0,
                    0,
                    0,
                    0,
                };
            default:
                return new int[]
                {
                    0,
                    0,
                    0,
                    0,
                    3,
                    0,
                    3,
                    0,
                    3,
                    0,
                    3,
                    0,
                    0,
                    0,
                    0,
                };
        }
    }

    public const int CrustBridge = 6;
    /// <summary>True when the chunk may appear during the opening warm-up.</summary>
    public static bool IsCalm(int _0x9c4c14f3)
    {
        return _0x9c4c14f3 == OpenRun || _0x9c4c14f3 == EmberArc;
    }

    public const int Ember = 3;
    public const int Geode = 4;
    public const int GeyserPair = 1;
}