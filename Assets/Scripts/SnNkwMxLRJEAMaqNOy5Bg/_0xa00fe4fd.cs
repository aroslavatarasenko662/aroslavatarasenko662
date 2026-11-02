using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Arithmetical axis-aligned overlap between the wanderer and the markers on the
/// trail, swept over the travel of one frame so a fast ridge can never skip a
/// hazard between frames. The frame step is clamped, as a long frame would
/// otherwise sweep half the screen at once.
/// </summary>
public sealed class _0xa00fe4fd : MonoBehaviour
{
    public int _0x64938a11 { get; private set; }
    public int _0x7b55d845 { get; private set; }

    private static bool Swept(float _0x68d88c6f, float _0x1b6ab942, float _0x5dc29577, float _0x1282b5fd, float _0xa1bff4d1, float _0x12e07612, float _0x3dc29f7a, float _0xa11feed6, float _0x62a38deb)
    {
        if (Mathf.Abs(_0x68d88c6f - _0xa1bff4d1) > _0x5dc29577 + _0x3dc29f7a)
            return false;
        float _0xa4a11194 = Mathf.Max(0f, _0x62a38deb);
        float _0xbf8626f5 = _0x12e07612 - _0xa11feed6;
        float _0x4ad7e9ee = _0x12e07612 + _0xa11feed6 + _0xa4a11194;
        return _0xbf8626f5 <= _0x1b6ab942 + _0x1282b5fd && _0x4ad7e9ee >= _0x1b6ab942 - _0x1282b5fd;
    }

    public void _0xa1a030a5()
    {
        this._0x7b55d845 = 0;
        this._0xe1a1c676 = 0;
        this._0x64938a11 = 0;
    }

    /// <summary>
    /// travel = how far the trail moved down this frame. Returns true when a hazard
    /// touched an unshielded wanderer.
    /// </summary>
    public bool _0xe3ceceed(_0xdd85a77b _0x2b940f15, IList<_0x75caf696> _0xd3b5839b, IList<_0xe13f674f> _0xafac5878, float _0x1e0a8006)
    {
        if (_0x2b940f15 == null)
            return false;
        float _0xec7b5575 = _0x2b940f15.transform.localPosition.x;
        float _0xadb9dd73 = _0x2b940f15.transform.localPosition.y;
        bool _0x4bc6ea23 = false;
        if (_0xd3b5839b != null && !_0x2b940f15._0x06d4bbfd)
        {
            for (int _0xeaee8167 = 0; _0xeaee8167 < _0xd3b5839b.Count; _0xeaee8167++)
            {
                _0x75caf696 _0xcf1567fd = _0xd3b5839b[_0xeaee8167];
                if (_0xcf1567fd == null)
                    continue;
                Vector3 _0x1dc0683c = _0xcf1567fd.transform.localPosition;
                if (!Swept(_0xec7b5575, _0xadb9dd73, _0x2b940f15._0xbc92a57b, _0x2b940f15._0x66948d06, _0x1dc0683c.x, _0x1dc0683c.y, _0xcf1567fd._0xe98bc2b2, _0xcf1567fd._0xb94646fa, _0x1e0a8006))
                    continue;
                _0x4bc6ea23 = true;
                this._0x7b55d845++;
                break;
            }
        }

        if (_0xafac5878 != null)
        {
            for (int _0x07f7e43e = 0; _0x07f7e43e < _0xafac5878.Count; _0x07f7e43e++)
            {
                _0xe13f674f _0x3d741473 = _0xafac5878[_0x07f7e43e];
                if (_0x3d741473 == null || _0x3d741473._0x8180b507)
                    continue;
                Vector3 _0x2e687b77 = _0x3d741473.transform.localPosition;
                if (!Swept(_0xec7b5575, _0xadb9dd73, _0x2b940f15._0xbc92a57b, _0x2b940f15._0x66948d06, _0x2e687b77.x, _0x2e687b77.y, _0x3d741473._0x38808bf9, _0x3d741473._0x64499c78, _0x1e0a8006))
                    continue;
                _0x3d741473._0x05f14d85();
                if (_0x3d741473._0xcd11d843 == 1)
                    this._0x64938a11++;
                else
                    this._0xe1a1c676++;
            }
        }

        return _0x4bc6ea23;
    }

    public int _0xe1a1c676 { get; private set; }
}