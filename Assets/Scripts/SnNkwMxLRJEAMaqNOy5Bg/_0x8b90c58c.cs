using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Themes the splash: the brand mark (an abstract emblem, never the app name) and
/// the loading bar's colours. It deliberately touches NO rect of the bar - the fill
/// area's geometry belongs to the template and to stage 5d2c (C.68) - and it never
/// edits SplashPanel.cs, which is the template owner's file (C.64).
/// </summary>
public sealed class _0x8b90c58c : MonoBehaviour
{
    private void _0x18188133(_0xe285f25e _0x90316c09)
    {
        if (_0x90316c09.Background == null)
            return;
        Image[] _0x1c3223bc = _0x90316c09.Background.GetComponentsInChildren<Image>(true);
        for (int _0x8f163d4f = 0; _0x8f163d4f < _0x1c3223bc.Length; _0x8f163d4f++)
            if (_0x1c3223bc[_0x8f163d4f] != null)
                _0x1c3223bc[_0x8f163d4f].color = _0xa72ebf9b.Scrim;
    }

    /// <summary>
    /// Fill = magma accent at full alpha, track = deep crust at a real alpha, so the
    /// progress reads against its own groove (rule G).
    /// </summary>
    private void _0x74004dff(_0xe285f25e _0x6a12b08a)
    {
        Slider _0xf6ae88ee = _0x6a12b08a.AnimationSlider;
        if (_0xf6ae88ee == null)
            return;
        RectTransform _0x82b2cf16 = _0xf6ae88ee.fillRect;
        if (_0x82b2cf16 != null)
        {
            Image _0x43fa5dd4 = _0x82b2cf16.GetComponent<Image>();
            if (_0x43fa5dd4 != null)
                _0x43fa5dd4.color = _0xa72ebf9b.Magma;
        }

        Image _0x643ce0bc = _0xf6ae88ee.GetComponent<Image>();
        if (_0x643ce0bc != null)
            _0x643ce0bc.color = _0xa72ebf9b.TrackDark;
        Image[] _0xae09ea39 = _0xf6ae88ee.GetComponentsInChildren<Image>(true);
        for (int _0x0e1be6e1 = 0; _0x0e1be6e1 < _0xae09ea39.Length; _0x0e1be6e1++)
        {
            Image _0x2481a7fb = _0xae09ea39[_0x0e1be6e1];
            if (_0x2481a7fb == null)
                continue;
            bool _0x201ddb92 = _0x82b2cf16 != null && _0x2481a7fb.transform == _0x82b2cf16;
            _0x2481a7fb.color = _0x201ddb92 ? _0xa72ebf9b.Magma : _0xa72ebf9b.TrackDark;
        }
    }

    [SerializeField]
    private TMP_FontAsset _font;
    /// <summary>
    /// An abstract emblem and one functional line. No title, no tagline, no name.
    /// </summary>
    private void _0xd94dfd2b(_0xe285f25e _0xbd24d7df)
    {
        if (_0xbd24d7df.Content == null)
            return;
        RectTransform _0x927c10a8 = _0xbd24d7df.Content.transform as RectTransform;
        if (_0x927c10a8 == null)
            return;
        Image _0x6f92a6a5 = _0xcdf88f8a.Icon(_0x927c10a8, _0x7ff2bb16._0x7b175962(new byte[9] { 249, 201, 218, 213, 223, 246, 218, 201, 208 }, 187), this._markSprite, _0xa72ebf9b.Ember, new Vector2(0.5f, 0.5f), new Vector2(0f, 150f), new Vector2(320f, 320f));
        _0xb6d1fc6b.Label(_0x927c10a8, _0x7ff2bb16._0x7b175962(new byte[10] { 71, 100, 120, 117, 103, 124, 88, 125, 122, 113 }, 20), this._font, _0x7ff2bb16._0x7b175962(new byte[19] { 154, 152, 143, 154, 139, 152, 131, 132, 141, 234, 158, 130, 143, 234, 152, 131, 142, 141, 143 }, 202), 38f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, -150f), new Vector2(860f, 60f));
        if (_0xe4e07605._0x51670660 || _0x6f92a6a5 == null)
            return;
        _0x6f92a6a5.transform.localScale = Vector3.one * 0.88f;
        _0x6f92a6a5.transform.DOScale(1f, 0.52f).SetEase(Ease.OutBack).SetLink(_0x6f92a6a5.gameObject);
    }

    [SerializeField]
    private bool _addMark = true;
    private void Start()
    {
        _0xe285f25e _0x28d65dd2 = _0xe285f25e.Instance;
        if (_0x28d65dd2 == null)
            return;
        this._0x18188133(_0x28d65dd2);
        this._0x74004dff(_0x28d65dd2);
        if (this._addMark)
            this._0xd94dfd2b(_0x28d65dd2);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject, false);
    }

    [SerializeField]
    private Sprite _markSprite;
}

internal static class _0x7ff2bb16
{
    internal static string _0x7b175962(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}