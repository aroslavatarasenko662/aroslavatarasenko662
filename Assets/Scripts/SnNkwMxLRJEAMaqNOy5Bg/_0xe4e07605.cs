using System;
using UnityEngine;

/// <summary>
/// Local progression. Every key is a literal and independent of any C# symbol, so
/// obfuscation cannot move a player's save (C.1).
/// </summary>
public static class _0xe4e07605
{
    public static int _0x1ffedb2a
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[9] { 204, 213, 254, 196, 204, 195, 196, 211, 210 }, 161), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[9] { 231, 254, 213, 239, 231, 232, 239, 248, 249 }, 138), Mathf.Max(0, value));
        }
    }

    public static int _0x3743fecb
    {
        get
        {
            return Mathf.Clamp(1 + _0x1ffedb2a / 250, 1, 50);
        }
    }

    public static int _0xe3de1b20
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[12] { 222, 199, 236, 193, 214, 196, 210, 193, 215, 215, 210, 202 }, 179), 0), 0, 6);
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[12] { 232, 241, 218, 247, 224, 242, 228, 247, 225, 225, 228, 252 }, 133), Mathf.Clamp(value, 0, 6));
        }
    }

    public static int _0x4d3ad7d2
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[9] { 242, 235, 192, 236, 235, 237, 250, 254, 244 }, 159), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[9] { 42, 51, 24, 52, 51, 53, 34, 38, 44 }, 71), Mathf.Max(0, value));
        }
    }

    public static int _0xdd10c97b
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[10] { 86, 79, 100, 88, 87, 94, 90, 73, 94, 95 }, 59), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[10] { 95, 70, 109, 81, 94, 87, 83, 64, 87, 86 }, 50), Mathf.Max(0, value));
        }
    }

    public static void BankRun(int _0x926c02f9, int _0xcab7dac7, bool _0x8023bcaf, int _0x9b1cdc48)
    {
        _0x1ffedb2a = _0x1ffedb2a + Mathf.Max(0, _0x926c02f9);
        _0x7b133ae4 = _0xcab7dac7;
        _0xe705a088 = _0xe705a088 + Mathf.Max(0, _0x9b1cdc48);
        _0xba42b763 = _0xba42b763 + 1;
        if (_0x8023bcaf)
        {
            _0xdd10c97b = _0xdd10c97b + 1;
            _0x3db09e6c = _0x3db09e6c + 1;
            int _0xb4136410 = _0xfea57d33;
            _0x4d3ad7d2 = PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[12] { 145, 136, 163, 143, 136, 142, 153, 157, 151, 152, 157, 133 }, 252), -1) == _0xb4136410 - 1 ? _0x4d3ad7d2 + 1 : 1;
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[12] { 155, 130, 169, 133, 130, 132, 147, 151, 157, 146, 151, 143 }, 246), _0xb4136410);
        }

        SetMissionProgress(0, MissionProgress(0) + Mathf.Max(0, _0x926c02f9));
        SetMissionProgress(1, Mathf.Max(MissionProgress(1), _0xcab7dac7));
        SetMissionProgress(2, MissionProgress(2) + (_0x8023bcaf ? 1 : 0));
        PlayerPrefs.Save();
    }

    public static bool _0x51670660
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[15] { 24, 1, 42, 7, 16, 17, 0, 22, 16, 24, 26, 1, 28, 26, 27 }, 117), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[15] { 105, 112, 91, 118, 97, 96, 113, 103, 97, 105, 107, 112, 109, 107, 106 }, 4), value ? 1 : 0);
        }
    }

    public static int _0x7b133ae4
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[7] { 6, 31, 52, 9, 14, 24, 31 }, 107), 0);
        }

        set
        {
            if (value > _0x7b133ae4)
                PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[7] { 127, 102, 77, 112, 119, 97, 102 }, 18), value);
        }
    }

    public static int _0x3db09e6c
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[8] { 17, 8, 35, 14, 21, 24, 27, 25 }, 124), 0), 0, _0x2d32cceb.RidgeCount - 1);
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[8] { 47, 54, 29, 48, 43, 38, 37, 39 }, 66), Mathf.Clamp(value, 0, _0x2d32cceb.RidgeCount - 1));
        }
    }

    public static int _0xe705a088
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[9] { 18, 11, 32, 24, 26, 16, 27, 26, 12 }, 127), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[9] { 13, 20, 63, 7, 5, 15, 4, 5, 19 }, 96), Mathf.Max(0, value));
        }
    }

    public static void SetMissionProgress(int _0x8be5574b, int _0x851da0fc)
    {
        PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[10] { 93, 68, 111, 93, 89, 67, 67, 89, 95, 94 }, 48) + _0x8be5574b.ToString(), Mathf.Max(0, _0x851da0fc));
    }

    public static int MissionProgress(int _0xd160b368)
    {
        return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[10] { 201, 208, 251, 201, 205, 215, 215, 205, 203, 202 }, 164) + _0xd160b368.ToString(), 0);
    }

    public static bool _0xc3bd49fc
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[10] { 98, 123, 80, 103, 110, 127, 123, 102, 108, 124 }, 15), 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[10] { 47, 54, 29, 42, 35, 50, 54, 43, 33, 49 }, 66), value ? 1 : 0);
        }
    }

    public static int _0xfea57d33
    {
        get
        {
            return DateTime.UtcNow.DayOfYear + DateTime.UtcNow.Year * 400;
        }
    }

    public static int _0xba42b763
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[10] { 53, 44, 7, 57, 44, 44, 61, 53, 40, 44 }, 88), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[10] { 253, 228, 207, 241, 228, 228, 245, 253, 224, 228 }, 144), Mathf.Max(0, value));
        }
    }

    public static int _0xb1b5509c
    {
        get
        {
            return PlayerPrefs.GetInt(_0x63012b48._0x1f9ceec9(new byte[11] { 157, 132, 175, 147, 156, 145, 153, 157, 148, 145, 137 }, 240), -1);
        }

        set
        {
            PlayerPrefs.SetInt(_0x63012b48._0x1f9ceec9(new byte[11] { 179, 170, 129, 189, 178, 191, 183, 179, 186, 191, 167 }, 222), value);
        }
    }

    public static void WipeAll()
    {
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[8] { 47, 54, 29, 48, 43, 38, 37, 39 }, 66));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[10] { 208, 201, 226, 220, 201, 201, 216, 208, 205, 201 }, 189));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[7] { 202, 211, 248, 197, 194, 212, 211 }, 167));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[10] { 237, 244, 223, 227, 236, 229, 225, 242, 229, 228 }, 128));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[9] { 67, 90, 113, 73, 75, 65, 74, 75, 93 }, 46));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[9] { 13, 20, 63, 5, 13, 2, 5, 18, 19 }, 96));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[9] { 122, 99, 72, 100, 99, 101, 114, 118, 124 }, 23));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[12] { 144, 137, 162, 142, 137, 143, 152, 156, 150, 153, 156, 132 }, 253));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[11] { 16, 9, 34, 30, 17, 28, 20, 16, 25, 28, 4 }, 125));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[12] { 197, 220, 247, 218, 205, 223, 201, 218, 204, 204, 201, 209 }, 168));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[11] { 157, 132, 175, 157, 153, 131, 131, 153, 159, 158, 192 }, 240));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[11] { 10, 19, 56, 10, 14, 20, 20, 14, 8, 9, 86 }, 103));
        PlayerPrefs.DeleteKey(_0x63012b48._0x1f9ceec9(new byte[11] { 182, 175, 132, 182, 178, 168, 168, 178, 180, 181, 233 }, 219));
        _0xd931f97e._0x0633db75._0x684309b9 = 0;
        PlayerPrefs.Save();
    }
}

internal static class _0x63012b48
{
    internal static string _0x1f9ceec9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}