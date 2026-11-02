using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x7dde803f : MonoBehaviour
{
    private static readonly List<_0x7dde803f> _0x55046d75 = new();
    private CanvasScaler _0x8af4bee9;
    private static void ResolutionChanged()
    {
        _0x084f6a0c.x = Screen.width;
        _0x084f6a0c.y = Screen.height;
        _0xac8c4a77 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x38aaf3ae.Invoke();
    }

    private Canvas _0xbbcff149;
    private static Vector2 _0x084f6a0c = Vector2.zero;
    private Vector2 _0x81d57a7e;
    private static void OrientationChanged()
    {
        _0x9686262a = Screen.orientation;
        _0x084f6a0c.x = Screen.width;
        _0x084f6a0c.y = Screen.height;
        _0xac8c4a77 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x38aaf3ae.Invoke();
    }

    private RectTransform _0xfc259716;
    private static UnityEvent _0x38aaf3ae = new();
    private RectTransform _0x97bee0d6;
    private static bool _0x90a794bb;
    private void Awake()
    {
        if (!_0x55046d75.Contains(this))
            _0x55046d75.Add(this);
        this._0xbbcff149 = this.GetComponent<Canvas>();
        this._0x8af4bee9 = this.GetComponent<CanvasScaler>();
        if (this._0x8af4bee9 != null)
            this._0x81d57a7e = this._0x8af4bee9.referenceResolution;
        this._0x97bee0d6 = this.GetComponent<RectTransform>();
        this._0xfc259716 = this.transform.Find(_0xa03d7774._0x7bd599a5(new byte[8] { 52, 6, 1, 2, 38, 21, 2, 6 }, 103)) as RectTransform;
        if (!_0x90a794bb)
        {
            _0x9686262a = Screen.orientation;
            _0x084f6a0c.x = Screen.width;
            _0x084f6a0c.y = Screen.height;
            _0xac8c4a77 = Screen.safeArea;
            _0x90a794bb = true;
        }

        this._0xc4159e17();
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (_0x55046d75.Count == 0 || _0x55046d75[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x9686262a)
            OrientationChanged();
        if (Screen.safeArea != _0xac8c4a77)
            SafeAreaChanged();
        if (Screen.width != _0x084f6a0c.x || Screen.height != _0x084f6a0c.y)
            ResolutionChanged();
    }

    private static void SafeAreaChanged()
    {
        _0xac8c4a77 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private void _0xc4159e17()
    {
        if (this._0xfc259716 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xc889c819 = Screen.safeArea;
        Vector2 _0xeac8666d = _0xc889c819.position;
        Vector2 _0x42a2e439 = _0xc889c819.position + _0xc889c819.size;
        _0xeac8666d.x /= screenWidth;
        _0xeac8666d.y /= screenHeight;
        _0x42a2e439.x /= screenWidth;
        _0x42a2e439.y /= screenHeight;
        this._0xfc259716.anchorMin = _0xeac8666d;
        this._0xfc259716.anchorMax = _0x42a2e439;
        this._0xfc259716.offsetMin = Vector2.zero;
        this._0xfc259716.offsetMax = Vector2.zero;
        if (this._0x8af4bee9 == null)
            return;
        Vector2 _0x03b737c6 = _0x42a2e439 - _0xeac8666d;
        float _0xb52ad153 = 2f - _0x03b737c6.x;
        float _0x3b885a7f = 2f - _0x03b737c6.y;
        this._0x8af4bee9.referenceResolution = this._0x81d57a7e * new Vector2(_0xb52ad153, _0x3b885a7f);
    }

    private void OnDestroy()
    {
        if (_0x55046d75 != null && _0x55046d75.Contains(this))
            _0x55046d75.Remove(this);
    }

    private static Rect _0xac8c4a77 = Rect.zero;
    private static void ApplySafeAreaToAll()
    {
        for (int _0xe1b4db22 = 0; _0xe1b4db22 < _0x55046d75.Count; _0xe1b4db22++)
            _0x55046d75[_0xe1b4db22]._0xc4159e17();
    }

    private static ScreenOrientation _0x9686262a = ScreenOrientation.LandscapeLeft;
}

internal static class _0xa03d7774
{
    internal static string _0x7bd599a5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}