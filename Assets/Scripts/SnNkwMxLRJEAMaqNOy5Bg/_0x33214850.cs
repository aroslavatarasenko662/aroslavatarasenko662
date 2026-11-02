using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the template pops at SETTINGS.POPS indices 6 / 7 / 8 in this game's own
/// words (C.3). Pops are fetched by index, never by name. Their buttons are told
/// apart by the TEMPLATE DRIVER each one carries - a load-current-scene driver is
/// the retry action, a load-scene-0 driver is the menu action, a run-toggle driver
/// is resume, a lone show-pop driver is the close cross - so neither traversal order
/// nor object names decide anything (C.17). Template rows this game does not fill
/// are switched off at runtime so no placeholder wording ships (C.15).
/// </summary>
public sealed class _0x33214850 : MonoBehaviour
{
    /// <summary>
    /// activeInHierarchy is useless here: a pop keeps its content switched off until
    /// it is shown. Walk the chain up to the pop, reading each link's own flag and
    /// passing through the two nodes the template itself toggles.
    /// </summary>
    private static bool IsLive(_0xb0a1d978 _0x1591d567, Transform _0x4fb2568f)
    {
        Transform _0xe7b866e3 = _0x1591d567.transform;
        Transform _0xca4f691e = _0x1591d567.Content != null ? _0x1591d567.Content.transform : null;
        Transform _0xee6c9608 = _0x4fb2568f;
        while (_0xee6c9608 != null)
        {
            if (_0xee6c9608 == _0xe7b866e3)
                return true;
            if (_0xee6c9608 != _0xca4f691e && !_0xee6c9608.gameObject.activeSelf)
                return false;
            _0xee6c9608 = _0xee6c9608.parent;
        }

        return true;
    }

    private void _0x17873fb4(_0xb0a1d978 _0x4a3cde8f, int _0x72ac06d6, string _0x5edd5508, string _0xf99c4b23, string _0xdefc0d92, string _0x2e03e914, string _0x3ccfa789)
    {
        if (_0x4a3cde8f == null)
            return;
        _0xb6d1fc6b.Dress(_0x4a3cde8f.ContentHeaderText, this._font, _0x5edd5508, 60f, _0xa72ebf9b.Ember);
        if (_0x4a3cde8f.ContentHeaderText != null)
            _0x4a3cde8f.ContentHeaderText.gameObject.SetActive(true);
        _0xb6d1fc6b.Dress(_0x4a3cde8f.ContentMainText, this._font, _0xf99c4b23, 40f, _0xa72ebf9b.Cream);
        if (_0x4a3cde8f.ContentMainText != null)
            _0x4a3cde8f.ContentMainText.gameObject.SetActive(true);
        // The chrome below is dressed ONCE: the pause pop is opened again and again,
        // and a second pass would stack a second cross glyph on the close button.
        if (this._0x031fd119.Contains(_0x72ac06d6))
            return;
        this._0x031fd119.Add(_0x72ac06d6);
        this._0x9af89a8c(_0x4a3cde8f);
        Button[] _0x457fe545 = _0x4a3cde8f.GetComponentsInChildren<Button>(true);
        for (int _0x907e0bf0 = 0; _0x907e0bf0 < _0x457fe545.Length; _0x907e0bf0++)
        {
            Button _0xd662d64f = _0x457fe545[_0x907e0bf0];
            if (_0xd662d64f == null || !IsLive(_0x4a3cde8f, _0xd662d64f.transform))
                continue;
            _0xf40249dd _0x1d329e21 = _0xd662d64f.GetComponent<_0xf40249dd>();
            _0x2ca1899c _0xd02513d6 = _0xd662d64f.GetComponent<_0x2ca1899c>();
            _0x6d64dc98 _0x2447bed1 = _0xd662d64f.GetComponent<_0x6d64dc98>();
            if (_0x1d329e21 != null && _0x1d329e21.IsLoadCurrentScene)
                this._0x75bdaf57(_0xd662d64f, _0xdefc0d92);
            else if (_0x1d329e21 != null)
                this._0x75bdaf57(_0xd662d64f, _0x2e03e914);
            else if (_0xd02513d6 != null)
                this._0x75bdaf57(_0xd662d64f, _0x3ccfa789);
            else if (_0x2447bed1 != null)
                this._0xab4dbd09(_0xd662d64f);
        }
    }

    /// <summary>
    /// Everything the pop shows that this game never fills is removed: the template
    /// score and reward rows, their counters and their static captions.
    /// </summary>
    private void _0x9af89a8c(_0xb0a1d978 _0x035d82a6)
    {
        _0x4d75d231[] _0xd1242023 = _0x035d82a6.GetComponentsInChildren<_0x4d75d231>(true);
        for (int _0x915c0280 = 0; _0x915c0280 < _0xd1242023.Length; _0x915c0280++)
            if (_0xd1242023[_0x915c0280] != null)
                _0xd1242023[_0x915c0280].gameObject.SetActive(false);
        TMP_Text[] _0xef6d88d5 = _0x035d82a6.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x3336f0f5 = 0; _0x3336f0f5 < _0xef6d88d5.Length; _0x3336f0f5++)
        {
            TMP_Text _0x2b6999b2 = _0xef6d88d5[_0x3336f0f5];
            if (_0x2b6999b2 == null)
                continue;
            if (_0x2b6999b2 == _0x035d82a6.ContentHeaderText || _0x2b6999b2 == _0x035d82a6.ContentMainText || _0x2b6999b2 == _0x035d82a6.ContentAdditionalText)
                continue;
            if (_0x2b6999b2.GetComponentInParent<Button>(true) != null)
                continue;
            _0x2b6999b2.text = string.Empty;
            _0x2b6999b2.gameObject.SetActive(false);
        }

        if (_0x035d82a6.ContentAdditionalText != null)
        {
            _0x035d82a6.ContentAdditionalText.text = string.Empty;
            _0x035d82a6.ContentAdditionalText.gameObject.SetActive(false);
        }
    }

    public void _0xdc61bdb3(int _0x655693cd, int _0xec79e5a2, int _0xc0e9d96b)
    {
        _0xb0a1d978 _0xdda94dea = _0x4bed43e1.Instance._0xc251639b(_0xd931f97e._0xa66d5513.WIN);
        this._0x17873fb4(_0xdda94dea, _0xd931f97e._0xa66d5513.WIN, _0xae178157._0x2385aa04(new byte[13] { 98, 121, 116, 119, 117, 16, 115, 124, 117, 113, 98, 117, 116 }, 48), _0xae178157._0x2385aa04(new byte[10] { 3, 5, 29, 29, 25, 4, 112, 17, 4, 112 }, 80) + _0x655693cd.ToString() + _0xae178157._0x2385aa04(new byte[11] { 241, 156, 219, 148, 156, 147, 148, 131, 130, 241, 250 }, 209) + _0xec79e5a2.ToString(), _0xae178157._0x2385aa04(new byte[10] { 46, 37, 56, 52, 64, 50, 41, 36, 39, 37 }, 96), _0xae178157._0x2385aa04(new byte[4] { 56, 48, 59, 32 }, 117), _0xae178157._0x2385aa04(new byte[6] { 143, 152, 142, 136, 144, 152 }, 221));
        {
#if B_LOGS
            {
                Debug.Log($"[pop] win ridge={_0xc0e9d96b} metres={_0x655693cd} embers={_0xec79e5a2}");
            }
#endif
        }

        _0x4bed43e1.Instance._0x8878fd5d(_0xd931f97e._0xa66d5513.WIN);
    }

    private void _0x75bdaf57(Button _0xa179cc66, string _0x7f9a3394)
    {
        TMP_Text _0x2a93c7dd = _0xa179cc66.GetComponentInChildren<TMP_Text>(true);
        if (_0x2a93c7dd == null)
            return;
        _0x2a93c7dd.gameObject.SetActive(true);
        _0xb6d1fc6b.Dress(_0x2a93c7dd, this._font, _0x7f9a3394, 44f, _0xa72ebf9b.Cream);
    }

    public void _0x5c294d91(int _0xb070939c, int _0x907ae91d)
    {
        _0xb0a1d978 _0x502dbeb8 = _0x4bed43e1.Instance._0xc251639b(_0xd931f97e._0xa66d5513.PAUSE);
        this._0x17873fb4(_0x502dbeb8, _0xd931f97e._0xa66d5513.PAUSE, _0xae178157._0x2385aa04(new byte[17] { 159, 146, 155, 147, 247, 152, 153, 247, 131, 159, 146, 247, 133, 158, 147, 144, 146 }, 215), _0xae178157._0x2385aa04(new byte[5] { 131, 142, 138, 159, 235 }, 203) + _0xb070939c.ToString() + _0xae178157._0x2385aa04(new byte[2] { 168, 135 }, 141) + _0x907ae91d.ToString() + _0xae178157._0x2385aa04(new byte[9] { 128, 237, 128, 247, 225, 236, 235, 229, 228 }, 160), _0xae178157._0x2385aa04(new byte[5] { 13, 26, 11, 13, 6 }, 95), _0xae178157._0x2385aa04(new byte[4] { 78, 70, 77, 86 }, 3), _0xae178157._0x2385aa04(new byte[6] { 56, 47, 57, 63, 39, 47 }, 106));
        _0x4bed43e1.Instance._0x8878fd5d(_0xd931f97e._0xa66d5513.PAUSE);
    }

    public void _0xddc5454a(int _0x1dd1b6c3, int _0xcdd4acf6, int _0x84243c38)
    {
        _0xb0a1d978 _0x87492d71 = _0x4bed43e1.Instance._0xc251639b(_0xd931f97e._0xa66d5513.LOSE);
        this._0x17873fb4(_0x87492d71, _0xd931f97e._0xa66d5513.LOSE, _0xae178157._0x2385aa04(new byte[17] { 15, 19, 30, 123, 19, 30, 26, 15, 123, 15, 20, 20, 16, 123, 2, 20, 14 }, 91), _0x1dd1b6c3.ToString() + _0xae178157._0x2385aa04(new byte[4] { 48, 95, 86, 48 }, 16) + _0xcdd4acf6.ToString() + _0xae178157._0x2385aa04(new byte[11] { 253, 144, 215, 152, 144, 159, 152, 143, 142, 253, 246 }, 221) + _0x84243c38.ToString(), _0xae178157._0x2385aa04(new byte[5] { 228, 243, 226, 228, 239 }, 182), _0xae178157._0x2385aa04(new byte[4] { 167, 175, 164, 191 }, 234), _0xae178157._0x2385aa04(new byte[6] { 179, 164, 178, 180, 172, 164 }, 225));
        {
#if B_LOGS
            {
                Debug.Log($"[pop] lose metres={_0x1dd1b6c3} target={_0xcdd4acf6} embers={_0x84243c38}");
            }
#endif
        }

        _0x4bed43e1.Instance._0x8878fd5d(_0xd931f97e._0xa66d5513.LOSE);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private readonly HashSet<int> _0x031fd119 = new HashSet<int>();
    /// <summary>
    /// The template leaves the close button's image unassigned, which Unity draws as
    /// a WHITE RECTANGLE (B.1). Give it the game's own cross, added last so it sits
    /// on top of the plate, and strip the caption the cross must not carry (C.17).
    /// </summary>
    private void _0xab4dbd09(Button _0x54496f30)
    {
        TMP_Text _0x8795de7e = _0x54496f30.GetComponentInChildren<TMP_Text>(true);
        if (_0x8795de7e != null)
        {
            _0x8795de7e.text = string.Empty;
            _0x8795de7e.gameObject.SetActive(false);
        }

        RectTransform _0x516a0b4e = _0x54496f30.transform as RectTransform;
        if (_0x516a0b4e == null || this._closeIcon == null)
            return;
        Image _0xe38a1243 = _0xcdf88f8a.Icon(_0x516a0b4e, _0xae178157._0x2385aa04(new byte[10] { 229, 202, 201, 213, 195, 225, 202, 223, 214, 206 }, 166), this._closeIcon, _0xa72ebf9b.Ember, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(64f, 64f));
        _0xe38a1243.rectTransform.anchorMin = new Vector2(0.24f, 0.24f);
        _0xe38a1243.rectTransform.anchorMax = new Vector2(0.76f, 0.76f);
        _0xe38a1243.rectTransform.offsetMin = Vector2.zero;
        _0xe38a1243.rectTransform.offsetMax = Vector2.zero;
    }

    [SerializeField]
    private Sprite _closeIcon;
}

internal static class _0xae178157
{
    internal static string _0x2385aa04(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}