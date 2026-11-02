using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x8a8040a5 : MonoBehaviour
{
    private Canvas _0x0fb004a0;
    private static ScreenOrientation _0x9ef1cbb1 = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x8cce2e4f;
    private void _0xd3109ec1()
    {
        if (this._0x8cce2e4f == null)
            return;
        Rect _0x835f738e = Screen.safeArea;
        Vector2 _0x9916d0bf = _0x835f738e.position;
        Vector2 _0xf6fd3e15 = _0x835f738e.position + _0x835f738e.size;
        _0x9916d0bf.x /= this._0x0fb004a0.pixelRect.width;
        _0x9916d0bf.y /= this._0x0fb004a0.pixelRect.height;
        _0xf6fd3e15.x /= this._0x0fb004a0.pixelRect.width;
        _0xf6fd3e15.y /= this._0x0fb004a0.pixelRect.height;
        this._0x8cce2e4f.anchorMin = _0x9916d0bf;
        this._0x8cce2e4f.anchorMax = _0xf6fd3e15;
    }

    private static readonly List<_0x8a8040a5> _0x76c9d574 = new();
    private void OnDestroy()
    {
        if (_0x76c9d574 != null && _0x76c9d574.Contains(this))
            _0x76c9d574.Remove(this);
    }

    private static UnityEvent _0xa948db38 = new();
    private static Rect _0xd88319e9 = Rect.zero;
    private RectTransform _0x1c9a0019;
    private static Vector2 _0x6b2fd4be = Vector2.zero;
    private static bool _0x9bac40fa;
    private static void SafeAreaChanged()
    {
        _0xd88319e9 = Screen.safeArea;
        for (int _0x2b023e62 = 0; _0x2b023e62 < _0x76c9d574.Count; _0x2b023e62++)
            _0x76c9d574[_0x2b023e62]._0xd3109ec1();
    }

    private void Awake()
    {
        if (!_0x76c9d574.Contains(this))
            _0x76c9d574.Add(this);
        this._0x0fb004a0 = this.GetComponent<Canvas>();
        this._0x1c9a0019 = this.GetComponent<RectTransform>();
        this._0x8cce2e4f = this.transform.Find(_0x846b7539._0x515e0f3d(new byte[8] { 64, 114, 117, 118, 82, 97, 118, 114 }, 19)) as RectTransform;
        if (!_0x9bac40fa)
        {
            _0x9ef1cbb1 = Screen.orientation;
            _0x6b2fd4be.x = Screen.width;
            _0x6b2fd4be.y = Screen.height;
            _0xd88319e9 = Screen.safeArea;
            _0x9bac40fa = true;
        }

        this._0xd3109ec1();
    }

    private static void OrientationChanged()
    {
        _0x9ef1cbb1 = Screen.orientation;
        _0x6b2fd4be.x = Screen.width;
        _0x6b2fd4be.y = Screen.height;
        _0xa948db38.Invoke();
    }

    private void Update()
    {
        if (_0x76c9d574[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x9ef1cbb1)
            OrientationChanged();
        if (Screen.safeArea != _0xd88319e9)
            SafeAreaChanged();
        if (Screen.width != _0x6b2fd4be.x || Screen.height != _0x6b2fd4be.y)
            ResolutionChanged();
    }

    private static void ResolutionChanged()
    {
        _0x6b2fd4be.x = Screen.width;
        _0x6b2fd4be.y = Screen.height;
        _0xa948db38.Invoke();
    }
}

internal static class _0x846b7539
{
    internal static string _0x515e0f3d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}