using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Fills the five hub sections. Every list that can come up empty says so in words
/// instead of leaving a blank card (rule G), and the mission rows keep the badge
/// gutter and the text column in two bands that never overlap (C.25).
/// </summary>
public static class _0xfdf0f7fe
{
    public static void Missions(RectTransform _0xa356a8de, TMP_FontAsset _0xfe056d86, Sprite _0x1325724a, Sprite _0x8cc0cf62, Sprite _0x2d938269, Sprite _0xd20f242a)
    {
        string[] _0xb2067771 = new string[]
        {
            _0xc62401c4._0xbc96853a(new byte[17] { 29, 17, 18, 18, 27, 29, 10, 126, 106, 110, 126, 27, 19, 28, 27, 12, 13 }, 94),
            _0xc62401c4._0xbc96853a(new byte[22] { 31, 8, 12, 14, 5, 109, 126, 120, 125, 109, 0, 109, 4, 3, 109, 2, 3, 8, 109, 31, 24, 3 }, 77),
            _0xc62401c4._0xbc96853a(new byte[13] { 255, 240, 249, 253, 238, 156, 253, 156, 238, 245, 248, 251, 249 }, 188)
        };
        int[] _0x947857aa = new int[]
        {
            40,
            350,
            1
        };
        int _0x08e2df79 = 0;
        for (int _0x621fbd2e = 0; _0x621fbd2e < _0xb2067771.Length; _0x621fbd2e++)
        {
            int _0x3cf49a54 = Mathf.Min(_0xe4e07605.MissionProgress(_0x621fbd2e), _0x947857aa[_0x621fbd2e]);
            if (_0x3cf49a54 >= _0x947857aa[_0x621fbd2e])
                _0x08e2df79++;
            float _0x023e48d1 = -70f - _0x621fbd2e * 180f;
            Strip(_0xa356a8de, _0x1325724a, _0x023e48d1 - 78f, 156f);
            _0xcdf88f8a.Icon(_0xa356a8de, _0xc62401c4._0xbc96853a(new byte[5] { 194, 225, 228, 231, 229 }, 128) + _0x621fbd2e.ToString(), _0x8cc0cf62, _0x3cf49a54 >= _0x947857aa[_0x621fbd2e] ? _0xa72ebf9b.Ember : _0xa72ebf9b.Fade(_0xa72ebf9b.Muted, 0.5f), new Vector2(0f, 1f), new Vector2(GutterCentre, _0x023e48d1 - 50f), new Vector2(GutterWidth, GutterWidth));
            _0xb6d1fc6b.Label(_0xa356a8de, _0xc62401c4._0xbc96853a(new byte[12] { 176, 148, 142, 142, 148, 146, 147, 169, 148, 137, 145, 152 }, 253) + _0x621fbd2e.ToString(), _0xfe056d86, _0xb2067771[_0x621fbd2e], 34f, _0xa72ebf9b.Cream, TextAlignmentOptions.Left, new Vector2(0f, 1f), new Vector2(TextLeft + TextWidth * 0.5f, _0x023e48d1 - 30f), new Vector2(TextWidth, 46f));
            _0xcdf88f8a.Plate(_0xa356a8de, _0xc62401c4._0xbc96853a(new byte[12] { 249, 221, 199, 199, 221, 219, 218, 224, 198, 213, 215, 223 }, 180) + _0x621fbd2e.ToString(), _0x2d938269, _0xa72ebf9b.TrackDark, new Vector2(0f, 1f), new Vector2(TextLeft + TextWidth * 0.5f, _0x023e48d1 - 82f), new Vector2(TextWidth, 18f), 1.4f);
            float _0x10841a56 = _0x947857aa[_0x621fbd2e] > 0 ? Mathf.Clamp01((float)_0x3cf49a54 / _0x947857aa[_0x621fbd2e]) : 0f;
            _0xcdf88f8a.Plate(_0xa356a8de, _0xc62401c4._0xbc96853a(new byte[11] { 15, 43, 49, 49, 43, 45, 44, 4, 43, 46, 46 }, 66) + _0x621fbd2e.ToString(), _0xd20f242a, _0xa72ebf9b.Magma, new Vector2(0f, 1f), new Vector2(TextLeft + TextWidth * _0x10841a56 * 0.5f, _0x023e48d1 - 82f), new Vector2(Mathf.Max(6f, TextWidth * _0x10841a56), 18f), 1.4f);
            _0xb6d1fc6b.Label(_0xa356a8de, _0xc62401c4._0xbc96853a(new byte[12] { 52, 16, 10, 10, 16, 22, 23, 58, 22, 12, 23, 13 }, 121) + _0x621fbd2e.ToString(), _0xfe056d86, _0x3cf49a54.ToString() + _0xc62401c4._0xbc96853a(new byte[3] { 31, 16, 31 }, 63) + _0x947857aa[_0x621fbd2e].ToString(), 30f, _0xa72ebf9b.Ember, TextAlignmentOptions.Right, new Vector2(0f, 1f), new Vector2(TextLeft + TextWidth * 0.5f, _0x023e48d1 - 120f), new Vector2(TextWidth, 40f));
        }

        _0xb6d1fc6b.Label(_0xa356a8de, _0xc62401c4._0xbc96853a(new byte[14] { 227, 199, 221, 221, 199, 193, 192, 253, 219, 195, 195, 207, 220, 215 }, 174), _0xfe056d86, _0x08e2df79.ToString() + _0xc62401c4._0xbc96853a(new byte[15] { 104, 103, 104, 123, 104, 12, 7, 6, 13, 104, 28, 7, 12, 9, 17 }, 72), 34f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -620f), new Vector2(860f, 50f));
    }

    private const float TextLeft = 129f;
    private const float GutterCentre = 62f;
    private const float GutterWidth = 42f;
    public static Button Rewards(RectTransform _0x409d01f5, TMP_FontAsset _0xc3f320a0, Sprite _0xc2b563f8, Sprite _0xd975f762, Sprite _0x1292a0d9)
    {
        int[] _0xe8ba248b = new int[]
        {
            15,
            25,
            40,
            60,
            90,
            130,
            200
        };
        int _0x022999aa = _0xe4e07605._0xe3de1b20;
        bool _0xbba044fd = _0xe4e07605._0xb1b5509c == _0xe4e07605._0xfea57d33;
        for (int _0x77c902f5 = 0; _0x77c902f5 < _0xe8ba248b.Length; _0x77c902f5++)
        {
            float _0xec272df3 = -70f - _0x77c902f5 * 92f;
            bool _0xb6f6f731 = _0x77c902f5 < _0x022999aa;
            Color _0x291808d2 = _0xb6f6f731 ? _0xa72ebf9b.Fade(_0xa72ebf9b.Muted, 0.4f) : (_0x77c902f5 == _0x022999aa && !_0xbba044fd ? _0xa72ebf9b.Ember : _0xa72ebf9b.Cream);
            Strip(_0x409d01f5, _0xc2b563f8, _0xec272df3 - 40f, 80f);
            _0xcdf88f8a.Icon(_0x409d01f5, _0xc62401c4._0xbc96853a(new byte[10] { 43, 28, 14, 24, 11, 29, 48, 26, 22, 23 }, 121) + _0x77c902f5.ToString(), _0xd975f762, _0x291808d2, new Vector2(0f, 1f), new Vector2(GutterCentre, _0xec272df3 - 34f), new Vector2(GutterWidth, GutterWidth));
            _0xb6d1fc6b.Label(_0x409d01f5, _0xc62401c4._0xbc96853a(new byte[9] { 51, 4, 22, 0, 19, 5, 37, 0, 24 }, 97) + _0x77c902f5.ToString(), _0xc3f320a0, _0xc62401c4._0xbc96853a(new byte[4] { 210, 215, 207, 182 }, 150) + (_0x77c902f5 + 1).ToString(), 32f, _0x291808d2, TextAlignmentOptions.Left, new Vector2(0f, 1f), new Vector2(TextLeft + 220f, _0xec272df3 - 34f), new Vector2(440f, 44f));
            _0xb6d1fc6b.Label(_0x409d01f5, _0xc62401c4._0xbc96853a(new byte[11] { 76, 123, 105, 127, 108, 122, 72, 127, 114, 107, 123 }, 30) + _0x77c902f5.ToString(), _0xc3f320a0, _0xe8ba248b[_0x77c902f5].ToString() + _0xc62401c4._0xbc96853a(new byte[7] { 233, 140, 132, 139, 140, 155, 154 }, 201), 32f, _0x291808d2, TextAlignmentOptions.Right, new Vector2(0f, 1f), new Vector2(TextLeft + TextWidth * 0.5f, _0xec272df3 - 34f), new Vector2(TextWidth, 44f));
        }

        if (_0xbba044fd)
        {
            _0xb6d1fc6b.Label(_0x409d01f5, _0xc62401c4._0xbc96853a(new byte[10] { 145, 166, 180, 162, 177, 167, 135, 172, 173, 166 }, 195), _0xc3f320a0, _0xc62401c4._0xbc96853a(new byte[32] { 220, 211, 222, 214, 210, 218, 219, 191, 203, 208, 219, 222, 198, 149, 220, 208, 210, 218, 191, 221, 222, 220, 212, 191, 203, 208, 210, 208, 205, 205, 208, 200 }, 159), 34f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -760f), new Vector2(860f, 96f));
            return null;
        }

        RectTransform _0x36c52958 = _0xcdf88f8a.Node(_0x409d01f5, _0xc62401c4._0xbc96853a(new byte[9] { 63, 16, 29, 21, 17, 47, 16, 19, 8 }, 124), new Vector2(0.5f, 1f), new Vector2(0f, -770f), new Vector2(620f, 128f));
        Image _0xe6561c26 = _0x36c52958.gameObject.AddComponent<Image>();
        _0xe6561c26.sprite = _0x1292a0d9;
        _0xe6561c26.type = _0x1292a0d9 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0xe6561c26.pixelsPerUnitMultiplier = 1.45f;
        _0xe6561c26.color = _0xa72ebf9b.Magma;
        _0xe6561c26.raycastTarget = true;
        _0xb6d1fc6b.Label(_0x36c52958, _0xc62401c4._0xbc96853a(new byte[10] { 234, 197, 200, 192, 196, 229, 200, 203, 204, 197 }, 169), _0xc3f320a0, _0xc62401c4._0xbc96853a(new byte[6] { 148, 155, 150, 158, 154, 247 }, 215) + _0xe8ba248b[_0x022999aa].ToString() + _0xc62401c4._0xbc96853a(new byte[7] { 120, 29, 21, 26, 29, 10, 11 }, 88), 40f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(560f, 76f));
        Button _0x51f8f29a = _0x36c52958.gameObject.AddComponent<Button>();
        _0x51f8f29a.transition = Selectable.Transition.None;
        _0x51f8f29a.targetGraphic = _0xe6561c26;
        return _0x51f8f29a;
    }

    /// <summary>A plain plate strip behind a row. Created before its content (C.13).</summary>
    private static void Strip(RectTransform _0x36a67225, Sprite _0x9b2d3fbf, float _0xdbe1d03b, float height)
    {
        _0xcdf88f8a.Plate(_0x36a67225, _0xc62401c4._0xbc96853a(new byte[8] { 49, 12, 20, 51, 15, 2, 23, 6 }, 99), _0x9b2d3fbf, _0xa72ebf9b.GlassFill, new Vector2(0.5f, 1f), new Vector2(0f, _0xdbe1d03b), new Vector2(BodyWidth, height), 1.45f);
    }

    public static void Profile(RectTransform _0xe400a0ff, TMP_FontAsset _0x7ad5c4ab, Sprite _0xa132c690)
    {
        string[] _0x14e920ea = new string[]
        {
            _0xc62401c4._0xbc96853a(new byte[4] { 253, 238, 225, 228 }, 175),
            _0xc62401c4._0xbc96853a(new byte[12] { 94, 69, 94, 75, 70, 42, 79, 71, 72, 79, 88, 89 }, 10),
            _0xc62401c4._0xbc96853a(new byte[14] { 30, 5, 8, 11, 9, 31, 108, 15, 0, 9, 13, 30, 9, 8 }, 76),
            _0xc62401c4._0xbc96853a(new byte[13] { 90, 93, 75, 76, 56, 92, 81, 75, 76, 89, 86, 91, 93 }, 24),
            _0xc62401c4._0xbc96853a(new byte[11] { 116, 115, 101, 98, 22, 101, 98, 100, 115, 119, 125 }, 54),
            _0xc62401c4._0xbc96853a(new byte[12] { 254, 252, 246, 253, 252, 234, 153, 255, 246, 236, 247, 253 }, 185)
        };
        string[] _0x6c172d76 = new string[]
        {
            _0xe4e07605._0x3743fecb.ToString(),
            _0xb6d1fc6b.Thousands(_0xe4e07605._0x1ffedb2a),
            _0xe4e07605._0xdd10c97b.ToString(),
            _0xe4e07605._0x7b133ae4.ToString() + _0xc62401c4._0xbc96853a(new byte[2] { 93, 48 }, 125),
            _0xe4e07605._0x4d3ad7d2.ToString(),
            _0xe4e07605._0xe705a088.ToString(),
        };
        for (int _0x1f91764b = 0; _0x1f91764b < _0x14e920ea.Length; _0x1f91764b++)
        {
            int _0x0e779180 = _0x1f91764b % 2;
            int _0x4a90ef70 = _0x1f91764b / 2;
            Vector2 _0x6e99cc36 = new Vector2(-230f + _0x0e779180 * 460f, -170f - _0x4a90ef70 * 250f);
            _0xcdf88f8a.Plate(_0xe400a0ff, _0xc62401c4._0xbc96853a(new byte[8] { 4, 35, 54, 35, 20, 54, 37, 51 }, 87) + _0x1f91764b.ToString(), _0xa132c690, _0xa72ebf9b.GlassFill, new Vector2(0.5f, 1f), _0x6e99cc36, new Vector2(430f, 210f), 1.45f);
            _0xb6d1fc6b.Label(_0xe400a0ff, _0xc62401c4._0xbc96853a(new byte[9] { 12, 43, 62, 43, 9, 62, 51, 42, 58 }, 95) + _0x1f91764b.ToString(), _0x7ad5c4ab, _0x6c172d76[_0x1f91764b], 54f, _0x1f91764b == 0 ? _0xa72ebf9b.Magma : _0xa72ebf9b.Ember, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), _0x6e99cc36 + new Vector2(0f, 34f), new Vector2(390f, 72f));
            _0xb6d1fc6b.Label(_0xe400a0ff, _0xc62401c4._0xbc96853a(new byte[11] { 116, 83, 70, 83, 100, 70, 87, 83, 78, 72, 73 }, 39) + _0x1f91764b.ToString(), _0x7ad5c4ab, _0x14e920ea[_0x1f91764b], 28f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), _0x6e99cc36 + new Vector2(0f, -46f), new Vector2(390f, 44f));
        }

        if (_0xe4e07605._0x1ffedb2a == 0 && _0xe4e07605._0x7b133ae4 == 0)
            _0xb6d1fc6b.Label(_0xe400a0ff, _0xc62401c4._0xbc96853a(new byte[12] { 51, 17, 12, 5, 10, 15, 6, 38, 14, 19, 23, 26 }, 99), _0x7ad5c4ab, _0xc62401c4._0xbc96853a(new byte[42] { 154, 155, 128, 156, 157, 154, 147, 244, 131, 149, 152, 159, 145, 144, 244, 141, 145, 128, 222, 141, 155, 129, 134, 244, 146, 157, 134, 135, 128, 244, 134, 157, 144, 147, 145, 244, 149, 131, 149, 157, 128, 135 }, 212), 32f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -930f), new Vector2(860f, 96f));
    }

    public const float BodyWidth = 954f;
    private const float TextWidth = 700f;
    public static void Challenge(RectTransform _0xa2c34668, TMP_FontAsset _0xdf65b2f6, Sprite _0x42ff75db, Sprite _0xf601d3fc)
    {
        int _0xaf1111eb = _0x1934ccb4._0xeba2a78a;
        Strip(_0xa2c34668, _0x42ff75db, -220f, 400f);
        _0xb6d1fc6b.Label(_0xa2c34668, _0xc62401c4._0xbc96853a(new byte[13] { 3, 40, 33, 44, 44, 37, 46, 39, 37, 14, 33, 45, 37 }, 64), _0xdf65b2f6, _0x1934ccb4.Title(_0xaf1111eb), 52f, _0xa72ebf9b.Ember, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -86f), new Vector2(860f, 66f));
        _0xb6d1fc6b.Label(_0xa2c34668, _0xc62401c4._0xbc96853a(new byte[13] { 12, 39, 46, 35, 35, 42, 33, 40, 42, 29, 58, 35, 42 }, 79), _0xdf65b2f6, _0x1934ccb4.Rule(_0xaf1111eb), 34f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -200f), new Vector2(860f, 120f));
        _0xb6d1fc6b.Label(_0xa2c34668, _0xc62401c4._0xbc96853a(new byte[15] { 57, 18, 27, 22, 22, 31, 20, 29, 31, 46, 27, 8, 29, 31, 14 }, 122), _0xdf65b2f6, _0xc62401c4._0xbc96853a(new byte[7] { 67, 86, 69, 80, 82, 67, 55 }, 23) + _0x2d32cceb.RidgeTarget(_0xe4e07605._0x3db09e6c).ToString() + _0xc62401c4._0xbc96853a(new byte[2] { 84, 57 }, 116), 34f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -320f), new Vector2(860f, 56f));
        _0xb6d1fc6b.Label(_0xa2c34668, _0xc62401c4._0xbc96853a(new byte[13] { 210, 245, 243, 228, 224, 234, 194, 224, 241, 245, 232, 238, 239 }, 129), _0xdf65b2f6, _0xc62401c4._0xbc96853a(new byte[6] { 89, 94, 88, 79, 75, 65 }, 10), 32f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -470f), new Vector2(860f, 50f));
        int _0x8b8ac3d7 = _0xe4e07605._0x4d3ad7d2;
        for (int _0x8356290f = 0; _0x8356290f < 7; _0x8356290f++)
        {
            Color _0xdad7ff34 = _0x8356290f < _0x8b8ac3d7 ? _0xa72ebf9b.Magma : _0xa72ebf9b.Fade(_0xa72ebf9b.Muted, 0.35f);
            _0xcdf88f8a.Icon(_0xa2c34668, _0xc62401c4._0xbc96853a(new byte[10] { 53, 18, 20, 3, 7, 13, 40, 9, 2, 3 }, 102) + _0x8356290f.ToString(), _0xf601d3fc, _0xdad7ff34, new Vector2(0.5f, 1f), new Vector2((_0x8356290f - 3) * 110f, -560f), new Vector2(74f, 92f));
        }

        if (_0x8b8ac3d7 == 0)
            _0xb6d1fc6b.Label(_0xa2c34668, _0xc62401c4._0xbc96853a(new byte[11] { 226, 197, 195, 212, 208, 218, 244, 220, 193, 197, 200 }, 177), _0xdf65b2f6, _0xc62401c4._0xbc96853a(new byte[33] { 103, 102, 9, 122, 125, 123, 108, 104, 98, 9, 112, 108, 125, 35, 106, 101, 108, 104, 123, 9, 104, 9, 123, 96, 109, 110, 108, 9, 125, 102, 109, 104, 112 }, 41), 30f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -660f), new Vector2(860f, 90f));
    }
}

internal static class _0xc62401c4
{
    internal static string _0xbc96853a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}