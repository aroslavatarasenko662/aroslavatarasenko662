using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Thin UGUI construction helpers. Draw order is sibling order, so every builder in
/// this game creates backdrop -> frame -> content -> label, in that order (C.13 / C.63).
/// </summary>
public static class _0xcdf88f8a
{
    public static Canvas Overlay(string _0x2edd0499, int _0xf239dbe3)
    {
        GameObject _0x77920242 = new GameObject(_0x2edd0499, typeof(RectTransform), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
        Canvas _0xa1fada56 = _0x77920242.GetComponent<Canvas>();
        _0xa1fada56.renderMode = RenderMode.ScreenSpaceOverlay;
        _0xa1fada56.sortingOrder = _0xf239dbe3;
        CanvasScaler _0x051646bb = _0x77920242.GetComponent<CanvasScaler>();
        _0x051646bb.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        _0x051646bb.referenceResolution = Reference;
        _0x051646bb.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        _0x051646bb.matchWidthOrHeight = 0f;
        return _0xa1fada56;
    }

    public static readonly Vector2 Reference = new Vector2(1242f, 2688f);
    public static Image PlateSpan(RectTransform _0xa4500f0a, string _0x4c059bdf, Sprite _0xa6aeee63, Color _0x77042c9c, Vector2 _0xfb3b22b8, Vector2 _0x8cf181fa, float _0xeec70ca6)
    {
        RectTransform _0x8b338521 = Span(_0xa4500f0a, _0x4c059bdf, _0xfb3b22b8, _0x8cf181fa);
        Image _0xedf72c71 = _0x8b338521.gameObject.AddComponent<Image>();
        _0xedf72c71.sprite = _0xa6aeee63;
        _0xedf72c71.type = _0xa6aeee63 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0xedf72c71.pixelsPerUnitMultiplier = _0xeec70ca6;
        _0xedf72c71.color = _0x77042c9c;
        _0xedf72c71.raycastTarget = false;
        return _0xedf72c71;
    }

    /// <summary>Plate first, icon on top of it, caption last - never the other way round.</summary>
    public static Button IconButton(RectTransform _0xa48e9abf, string _0xbecc763f, Sprite _0x9f00d612, Sprite _0x6d3f680a, Vector2 _0x79e5754d, Vector2 _0x9e54cc01, Vector2 _0xf8ecff4d, float _0xcf05053e)
    {
        RectTransform _0x7cd8272e = Node(_0xa48e9abf, _0xbecc763f, _0x79e5754d, _0x9e54cc01, _0xf8ecff4d);
        Image _0x4b1ba6f4 = _0x7cd8272e.gameObject.AddComponent<Image>();
        _0x4b1ba6f4.sprite = _0x9f00d612;
        _0x4b1ba6f4.type = _0x9f00d612 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x4b1ba6f4.pixelsPerUnitMultiplier = _0xcf05053e;
        _0x4b1ba6f4.color = _0xa72ebf9b.GlassFill;
        _0x4b1ba6f4.raycastTarget = true;
        Icon(_0x7cd8272e, _0xbecc763f + _0x15286657._0x1dbd9fb0(new byte[5] { 114, 89, 76, 69, 93 }, 53), _0x6d3f680a, _0xa72ebf9b.Ember, new Vector2(0.5f, 0.5f), Vector2.zero, _0xf8ecff4d * 0.56f);
        Button _0x8ba85e52 = _0x7cd8272e.gameObject.AddComponent<Button>();
        _0x8ba85e52.transition = Selectable.Transition.None;
        _0x8ba85e52.targetGraphic = _0x4b1ba6f4;
        return _0x8ba85e52;
    }

    /// <summary>A 9-slice plate: stretching is its purpose, so no preserveAspect (F.2a).</summary>
    public static Image Plate(RectTransform _0xfe4a7890, string _0xbb7090f4, Sprite _0x463ec748, Color _0x5eb51373, Vector2 _0xc95a1f5b, Vector2 _0x49de21e1, Vector2 _0x9ac2cbf2, float _0x35f36d92)
    {
        RectTransform _0xede94fef = Node(_0xfe4a7890, _0xbb7090f4, _0xc95a1f5b, _0x49de21e1, _0x9ac2cbf2);
        Image _0xb23c300e = _0xede94fef.gameObject.AddComponent<Image>();
        _0xb23c300e.sprite = _0x463ec748;
        _0xb23c300e.type = _0x463ec748 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0xb23c300e.pixelsPerUnitMultiplier = _0x35f36d92;
        _0xb23c300e.color = _0x5eb51373;
        _0xb23c300e.raycastTarget = false;
        return _0xb23c300e;
    }

    public static RectTransform Node(RectTransform _0x9f6b9f9a, string _0xa6ba0f49, Vector2 _0x26e8d95d, Vector2 _0x7622319a, Vector2 _0x573a6324)
    {
        GameObject _0x2d92840b = new GameObject(_0xa6ba0f49, typeof(RectTransform));
        RectTransform _0xb2e73e79 = _0x2d92840b.GetComponent<RectTransform>();
        _0xb2e73e79.SetParent(_0x9f6b9f9a, false);
        _0xb2e73e79.anchorMin = _0x26e8d95d;
        _0xb2e73e79.anchorMax = _0x26e8d95d;
        _0xb2e73e79.pivot = new Vector2(0.5f, 0.5f);
        _0xb2e73e79.anchoredPosition = _0x7622319a;
        _0xb2e73e79.sizeDelta = _0x573a6324;
        _0xb2e73e79.localScale = Vector3.one;
        return _0xb2e73e79;
    }

    public static RectTransform Span(RectTransform _0x41de7013, string _0x6bf363c9, Vector2 _0xe2f9ae0e, Vector2 _0xf11beb02)
    {
        GameObject _0x930fff7c = new GameObject(_0x6bf363c9, typeof(RectTransform));
        RectTransform _0x7f57f6d1 = _0x930fff7c.GetComponent<RectTransform>();
        _0x7f57f6d1.SetParent(_0x41de7013, false);
        _0x7f57f6d1.anchorMin = _0xe2f9ae0e;
        _0x7f57f6d1.anchorMax = _0xf11beb02;
        _0x7f57f6d1.pivot = new Vector2(0.5f, 0.5f);
        _0x7f57f6d1.offsetMin = Vector2.zero;
        _0x7f57f6d1.offsetMax = Vector2.zero;
        _0x7f57f6d1.localScale = Vector3.one;
        return _0x7f57f6d1;
    }

    /// <summary>A content image: the artwork's own proportions are kept (F.2a).</summary>
    public static Image Icon(RectTransform _0x5cfb8d50, string _0x100fac6e, Sprite _0xb6e0919c, Color _0x37d4b11a, Vector2 _0x04be7883, Vector2 _0x0cc1de1b, Vector2 _0x1c65902e)
    {
        RectTransform _0xcc1aaada = Node(_0x5cfb8d50, _0x100fac6e, _0x04be7883, _0x0cc1de1b, _0x1c65902e);
        Image _0x9080a30e = _0xcc1aaada.gameObject.AddComponent<Image>();
        _0x9080a30e.sprite = _0xb6e0919c;
        _0x9080a30e.type = Image.Type.Simple;
        _0x9080a30e.preserveAspect = true;
        _0x9080a30e.color = _0x37d4b11a;
        _0x9080a30e.raycastTarget = false;
        return _0x9080a30e;
    }

    /// <summary>An invisible but tappable rectangle.</summary>
    public static Button Zone(RectTransform _0x74a6d280, string _0x0cc955b9, Vector2 _0xb8a4183f, Vector2 _0x8b28dab8)
    {
        RectTransform _0x638d0584 = Span(_0x74a6d280, _0x0cc955b9, _0xb8a4183f, _0x8b28dab8);
        Image _0xdb378ffe = _0x638d0584.gameObject.AddComponent<Image>();
        _0xdb378ffe.color = new Color(1f, 1f, 1f, 0f);
        _0xdb378ffe.raycastTarget = true;
        Button _0xd9dc2559 = _0x638d0584.gameObject.AddComponent<Button>();
        _0xd9dc2559.transition = Selectable.Transition.None;
        _0xd9dc2559.targetGraphic = _0xdb378ffe;
        return _0xd9dc2559;
    }
}

internal static class _0x15286657
{
    internal static string _0x1dbd9fb0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}