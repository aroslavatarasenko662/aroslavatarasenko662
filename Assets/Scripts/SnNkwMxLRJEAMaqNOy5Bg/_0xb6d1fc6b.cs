using TMPro;
using UnityEngine;

/// <summary>
/// Every TMP label this game creates in code goes through here.
/// Word wrap OFF, breaks by hand, autosize ON with a 24 px floor (C.10 / C.12),
/// and a font assigned BEFORE the material instance is touched (C.65).
/// </summary>
public static class _0xb6d1fc6b
{
    /// <summary>Applies the wrapping/autosize contract to an existing label too.</summary>
    public static void Prepare(TMP_Text _0x868d16cc, TMP_FontAsset _0x22602321)
    {
        if (_0x868d16cc == null)
            return;
        if (_0x868d16cc.font == null)
            _0x868d16cc.font = _0x22602321 != null ? _0x22602321 : TMP_Settings.defaultFontAsset;
        if (_0x868d16cc.font != null && _0x868d16cc.fontSharedMaterial == null)
            _0x868d16cc.fontSharedMaterial = _0x868d16cc.font.material;
        _0x868d16cc.enableWordWrapping = false;
        _0x868d16cc.overflowMode = TextOverflowModes.Overflow;
        _0x868d16cc.enableAutoSizing = true;
        _0x868d16cc.fontSizeMin = MinSize;
        if (_0x868d16cc.fontSizeMax < MinSize)
            _0x868d16cc.fontSizeMax = MinSize;
    }

    /// <summary>
    /// Own material instance with an outline that contrasts with the face colour.
    /// Reading fontMaterial on a label with no font THROWS, hence the guard (C.65).
    /// </summary>
    public static void ApplyOutline(TMP_Text _0x4c97a8f5, Color _0x89355091)
    {
        if (_0x4c97a8f5 == null || _0x4c97a8f5.font == null)
            return;
        Material _0xfe9de49e = _0xe68563c7.InstanceOf(_0x4c97a8f5);
        if (_0xfe9de49e == null)
            return;
        float _0x31f1f009 = 0.299f * _0x89355091.r + 0.587f * _0x89355091.g + 0.114f * _0x89355091.b;
        _0xfe9de49e.SetColor(ShaderUtilities.ID_OutlineColor, _0x31f1f009 < 0.5f ? _0xa72ebf9b.Cream : _0xa72ebf9b.Outline);
        _0xfe9de49e.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
        _0xfe9de49e.SetFloat(ShaderUtilities.ID_FaceDilate, 0.16f);
    }

    public static TextMeshProUGUI Label(RectTransform _0x52317740, string _0x9535d3f3, TMP_FontAsset _0x62e93c89, string _0x78da4486, float _0x6beb0515, Color _0x55b5a091, TextAlignmentOptions _0x05468723, Vector2 _0x3338346f, Vector2 _0x768efeeb, Vector2 _0xa1d8ac81)
    {
        RectTransform _0x96489b79 = _0xcdf88f8a.Node(_0x52317740, _0x9535d3f3, _0x3338346f, _0x768efeeb, _0xa1d8ac81);
        TextMeshProUGUI _0x3426b3ca = _0x96489b79.gameObject.AddComponent<TextMeshProUGUI>();
        Prepare(_0x3426b3ca, _0x62e93c89);
        _0x3426b3ca.text = _0x78da4486;
        _0x3426b3ca.alignment = _0x05468723;
        _0x3426b3ca.color = _0x55b5a091;
        _0x3426b3ca.fontSizeMax = Mathf.Max(MinSize, _0x6beb0515);
        _0x3426b3ca.fontSize = Mathf.Max(MinSize, _0x6beb0515);
        _0x3426b3ca.raycastTarget = false;
        ApplyOutline(_0x3426b3ca, _0x55b5a091);
        return _0x3426b3ca;
    }

    public const float MinSize = 24f;
    public static string Thousands(int _0xc88af0ae)
    {
        if (_0xc88af0ae < 1000)
            return _0xc88af0ae.ToString();
        int _0xbe8afad8 = _0xc88af0ae / 1000;
        int _0x7c67b222 = _0xc88af0ae % 1000;
        return _0xbe8afad8.ToString() + _0x325fdbff._0x7f5f48f8(new byte[1] { 0 }, 44) + _0x7c67b222.ToString(_0x325fdbff._0x7f5f48f8(new byte[3] { 226, 226, 226 }, 210));
    }

    /// <summary>Re-dresses a label that already exists in a template prefab.</summary>
    public static void Dress(TMP_Text _0xbac93faa, TMP_FontAsset _0x0cf2c00c, string _0x3dbf4ee9, float _0xe6e22802, Color _0x2434ea7a)
    {
        if (_0xbac93faa == null)
            return;
        Prepare(_0xbac93faa, _0x0cf2c00c);
        _0xbac93faa.text = _0x3dbf4ee9;
        _0xbac93faa.color = _0x2434ea7a;
        _0xbac93faa.fontSizeMax = Mathf.Max(MinSize, _0xe6e22802);
        _0xbac93faa.fontSize = Mathf.Max(MinSize, _0xe6e22802);
        ApplyOutline(_0xbac93faa, _0x2434ea7a);
    }
}

internal static class _0x325fdbff
{
    internal static string _0x7f5f48f8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}