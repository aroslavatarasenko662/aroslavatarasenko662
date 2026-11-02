using System;

/// <summary>
/// One modifier per UTC day, picked arithmetically so every device agrees without
/// a network call.
/// </summary>
public static class _0x1934ccb4
{
    public const int Count = 6;
    public static string Title(int _0x0db5748d)
    {
        switch (((_0x0db5748d % Count) + Count) % Count)
        {
            case 0:
                return _0x702c7dd8._0x8407795f(new byte[12] { 6, 9, 26, 26, 7, 31, 104, 28, 26, 9, 1, 4 }, 72);
            case 1:
                return _0x702c7dd8._0x8407795f(new byte[10] { 137, 132, 128, 149, 225, 146, 148, 147, 134, 132 }, 193);
            case 2:
                return _0x702c7dd8._0x8407795f(new byte[10] { 42, 34, 45, 42, 61, 79, 61, 58, 60, 39 }, 111);
            case 3:
                return _0x702c7dd8._0x8407795f(new byte[9] { 244, 229, 226, 228, 227, 151, 229, 226, 249 }, 183);
            case 4:
                return _0x702c7dd8._0x8407795f(new byte[12] { 252, 251, 234, 238, 235, 246, 143, 236, 227, 230, 226, 237 }, 175);
            default:
                return _0x702c7dd8._0x8407795f(new byte[10] { 159, 157, 151, 156, 157, 248, 144, 141, 150, 140 }, 216);
        }
    }

    public static int _0xeba2a78a
    {
        get
        {
            return DateTime.UtcNow.DayOfYear % Count;
        }
    }

    public static float Density(int _0x9a4fc16f)
    {
        int _0xd0791024 = ((_0x9a4fc16f % Count) + Count) % Count;
        if (_0xd0791024 == 0)
            return 0.80f;
        if (_0xd0791024 == 3)
            return 1.25f;
        return 1f;
    }

    public static float PassiveHeat(int _0x84a72710)
    {
        return ((_0x84a72710 % Count) + Count) % Count == 1 ? 0.70f : _0x2d32cceb.HeatPassive;
    }

    public static string Rule(int _0x591bfb41)
    {
        switch (((_0x591bfb41 % Count) + Count) % Count)
        {
            case 0:
                return _0x702c7dd8._0x8407795f(new byte[29] { 73, 72, 74, 95, 38, 73, 72, 67, 38, 74, 71, 72, 67, 12, 79, 85, 38, 67, 80, 67, 84, 38, 68, 74, 73, 69, 77, 67, 66 }, 6);
            case 1:
                return _0x702c7dd8._0x8407795f(new byte[45] { 102, 107, 111, 122, 14, 109, 98, 103, 99, 108, 125, 14, 104, 111, 125, 122, 107, 124, 36, 105, 107, 97, 106, 107, 125, 14, 111, 124, 107, 14, 122, 121, 103, 109, 107, 14, 111, 125, 14, 109, 97, 99, 99, 97, 96 }, 46);
            case 2:
                return _0x702c7dd8._0x8407795f(new byte[37] { 81, 89, 86, 81, 70, 71, 52, 87, 91, 65, 90, 64, 52, 80, 91, 65, 86, 88, 81, 30, 86, 65, 64, 52, 87, 91, 91, 88, 52, 77, 91, 65, 52, 88, 81, 71, 71 }, 20);
            case 3:
                return _0x702c7dd8._0x8407795f(new byte[39] { 162, 179, 190, 183, 210, 177, 160, 167, 161, 166, 210, 166, 160, 179, 187, 190, 248, 179, 210, 163, 167, 179, 160, 166, 183, 160, 210, 191, 189, 160, 183, 210, 186, 179, 168, 179, 160, 182, 161 }, 242);
            case 4:
                return _0x702c7dd8._0x8407795f(new byte[29] { 197, 218, 217, 193, 211, 196, 182, 194, 217, 198, 182, 197, 198, 211, 211, 210, 156, 218, 217, 216, 209, 211, 196, 182, 196, 223, 210, 209, 211 }, 150);
            default:
                return _0x702c7dd8._0x8407795f(new byte[39] { 36, 45, 55, 48, 66, 36, 48, 45, 49, 54, 66, 37, 39, 45, 38, 39, 49, 104, 33, 46, 39, 35, 48, 66, 54, 42, 39, 66, 48, 43, 38, 37, 39, 66, 39, 35, 48, 46, 59 }, 98);
        }
    }
}

internal static class _0x702c7dd8
{
    internal static string _0x8407795f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}