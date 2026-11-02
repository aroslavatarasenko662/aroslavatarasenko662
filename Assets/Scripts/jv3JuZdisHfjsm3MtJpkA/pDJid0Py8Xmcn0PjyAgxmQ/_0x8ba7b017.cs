using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x8ba7b017 : MonoBehaviour
{
    private bool _0xc7c5415f(Touch? _0xe9a87cfa, Bounds _0x34468728, TouchPhase _0xf9c07960)
    {
        if (!_0xc2255145.Instance._0x1a641ad7)
        {
            _0xe9a87cfa = null;
            return false;
        }

        if (_0xe9a87cfa != null)
            if (_0xe9a87cfa.Value.phase == _0xf9c07960)
            {
                Vector3 _0x016ba7f2 = Camera.main.ScreenToWorldPoint(_0xe9a87cfa.Value.screenPosition);
                Vector3 _0x3c1706de = new(_0x016ba7f2.x, _0x016ba7f2.y, _0x34468728.center.z);
                if (_0x34468728.Contains(_0x3c1706de) && this._0x59d3b759(_0xe9a87cfa.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0xeae98407(Bounds _0x09ede938, TouchPhase _0xe609a8fc)
    {
        if (!_0xc2255145.Instance._0x1a641ad7)
            return null;
        foreach (Touch _0xb90b4d05 in Touch.activeTouches)
            if (_0xb90b4d05.phase == _0xe609a8fc)
            {
                Vector3 _0x260d69f5 = Camera.main.ScreenToWorldPoint(_0xb90b4d05.screenPosition);
                Vector3 _0x52c3b227 = new(_0x260d69f5.x, _0x260d69f5.y, _0x09ede938.center.z);
                if (_0x09ede938.Contains(_0x52c3b227) && this._0x59d3b759(_0xb90b4d05))
                    return _0xb90b4d05;
            }

        return null;
    }

    private static _0x8ba7b017 _0xa7cf6b96;
    private Touch? _0x085d00dd()
    {
        if (!_0xc2255145.Instance._0x1a641ad7)
            return null;
        foreach (Touch _0x4714fa8e in Touch.activeTouches)
            if (!_0x4714fa8e.ended)
                if (this._0x59d3b759(_0x4714fa8e))
                    return _0x4714fa8e;
        return null;
    }

    private Touch? _0x0b032d65()
    {
        if (!_0xc2255145.Instance._0x1a641ad7)
            return null;
        foreach (Touch _0x7d6979d4 in Touch.activeTouches)
            if (_0x7d6979d4.ended)
                if (this._0x59d3b759(_0x7d6979d4))
                    return _0x7d6979d4;
        return null;
    }

    private Touch? _0xcb45b020(Bounds _0xfab36bf0)
    {
        if (!_0xc2255145.Instance._0x1a641ad7)
            return null;
        foreach (Touch _0x62299c29 in Touch.activeTouches)
            if (!_0x62299c29.ended)
            {
                Vector3 _0xaf14704b = Camera.main.ScreenToWorldPoint(_0x62299c29.screenPosition);
                Vector3 _0x00d04fcb = new(_0xaf14704b.x, _0xaf14704b.y, _0xfab36bf0.center.z);
                if (_0xfab36bf0.Contains(_0x00d04fcb) && this._0x59d3b759(_0x62299c29))
                    return _0x62299c29;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private void _0xbd7940ed(Touch? _0xfef4df2d)
    {
        if (!_0xc2255145.Instance._0x1a641ad7)
        {
            _0xfef4df2d = null;
            return;
        }

        int _0xe320fe95 = _0xfef4df2d.Value.touchId;
        _0xfef4df2d = Touch.activeTouches.FirstOrDefault(_0xfcc5f413 => _0xfcc5f413.touchId == _0xe320fe95);
        if (!this._0x59d3b759(_0xfef4df2d.Value))
            _0xfef4df2d = null;
    }

    private Touch? _0x576a3d4d(Bounds _0x4b79edec)
    {
        if (!_0xc2255145.Instance._0x1a641ad7)
            return null;
        foreach (Touch _0x22502dbe in Touch.activeTouches)
            if (_0x22502dbe.ended)
            {
                Vector3 _0x14d165a2 = Camera.main.ScreenToWorldPoint(_0x22502dbe.screenPosition);
                Vector3 _0x130610bd = new(_0x14d165a2.x, _0x14d165a2.y, _0x4b79edec.center.z);
                if (_0x4b79edec.Contains(_0x130610bd) && this._0x59d3b759(_0x22502dbe))
                    return _0x22502dbe;
            }

        return null;
    }

    private bool _0x59d3b759(Touch? _0xd26614de)
    {
        if (!_0xd26614de.HasValue)
            return false;
        Vector3 _0x4c47e778 = Camera.main.ScreenToWorldPoint(_0xd26614de.Value.screenPosition);
        Vector3 _0xdb42e184 = _0x4c47e778;
        _0xdb42e184.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xdb42e184))
            return true;
        _0xd26614de = null;
        return false;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xa7cf6b96 = this.gameObject.GetComponent<_0x8ba7b017>();
    }
}