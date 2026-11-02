using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu hub: a bento grid of sections around the template's own Play button.
/// Everything is built into the panel the template already owns, through a
/// serialized reference, and the Play button itself is only re-dressed - its
/// template load-scene driver still does the work (C.1 / H).
/// No text here, and no sprite, carries the app name (hard rule 1).
/// </summary>
public sealed class _0x4bdc1b3c : MonoBehaviour
{
    [SerializeField]
    private RectTransform _content;
    [SerializeField]
    private Sprite _tileSprite;
    private void _0xcd42b98c()
    {
        _0xb6d1fc6b.Label(this._0xcc9f0df5, _0x5d1bcade._0x8ea8a153(new byte[12] { 73, 97, 110, 105, 126, 79, 109, 124, 120, 101, 99, 98 }, 12), this._font, _0x5d1bcade._0x8ea8a153(new byte[6] { 251, 243, 252, 251, 236, 237 }, 190), 36f, _0xa72ebf9b.Muted, TextAlignmentOptions.Left, new Vector2(0.5f, 1f), new Vector2(-430f, -246f), new Vector2(300f, 56f));
        RectTransform _0x1b9aa1d9 = _0xcdf88f8a.Node(this._0xcc9f0df5, _0x5d1bcade._0x8ea8a153(new byte[9] { 132, 172, 163, 164, 179, 130, 169, 168, 177 }, 193), new Vector2(0.5f, 1f), new Vector2(-120f, -246f), new Vector2(240f, 104f));
        if (this._coinsPrefab != null)
        {
            GameObject _0x5e1e97d1 = Instantiate(this._coinsPrefab, _0x1b9aa1d9);
            RectTransform _0x3b826de3 = _0x5e1e97d1.transform as RectTransform;
            if (_0x3b826de3 != null)
            {
                _0x3b826de3.anchorMin = Vector2.zero;
                _0x3b826de3.anchorMax = Vector2.one;
                _0x3b826de3.offsetMin = Vector2.zero;
                _0x3b826de3.offsetMax = Vector2.zero;
                _0x3b826de3.localScale = Vector3.one;
            }

            TMP_Text[] _0xfb837dfe = _0x5e1e97d1.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x5238c0c5 = 0; _0x5238c0c5 < _0xfb837dfe.Length; _0x5238c0c5++)
                _0xb6d1fc6b.Prepare(_0xfb837dfe[_0x5238c0c5], this._font);
        }

        Button _0x3d2415ff = _0xcdf88f8a.IconButton(this._0xcc9f0df5, _0x5d1bcade._0x8ea8a153(new byte[12] { 11, 61, 44, 44, 49, 54, 63, 43, 11, 52, 55, 44 }, 88), this._panelSprite, this._gearSprite, new Vector2(0.5f, 1f), new Vector2(490f, -246f), new Vector2(112f, 112f), 1.45f);
        _0x3d2415ff.onClick.AddListener(() => this._0xd1a6ab30());
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x5ca105a7(Button _0x8c23ac36, bool _0x2d41e8e4)
    {
        if (_0x8c23ac36 == null)
            return;
        Image _0xc58aa66d = _0x8c23ac36.targetGraphic as Image;
        if (_0xc58aa66d != null)
            _0xc58aa66d.color = _0x2d41e8e4 ? _0xa72ebf9b.Magma : _0xa72ebf9b.Fade(_0xa72ebf9b.Crust, 0.70f);
    }

    private void _0x04149de9()
    {
        RectTransform _0x1cc3a3a7;
        _0x2aa39f7d _0x74e86dd4 = this._0xe6c428bc(_0x5d1bcade._0x8ea8a153(new byte[14] { 170, 142, 148, 148, 142, 136, 137, 168, 145, 130, 149, 139, 134, 158 }, 231), _0x5d1bcade._0x8ea8a153(new byte[8] { 30, 26, 0, 0, 26, 28, 29, 0 }, 83), out _0x1cc3a3a7);
        _0xfdf0f7fe.Missions(_0x1cc3a3a7, this._font, this._panelSprite, this._badgeSprite, this._barTrackSprite, this._barFillSprite);
        _0x74e86dd4.Show();
    }

    private void _0xffc85887()
    {
        int _0x50e21513 = _0xe4e07605._0x7b133ae4;
        int _0x7bd80600 = _0xe4e07605._0x3db09e6c + 1;
        int _0x80cf74c0 = _0xe4e07605._0x4d3ad7d2;
        string _0x07c325ae = _0x50e21513 > 0 ? _0x5d1bcade._0x8ea8a153(new byte[5] { 190, 185, 175, 168, 220 }, 252) + _0x50e21513.ToString() + _0x5d1bcade._0x8ea8a153(new byte[13] { 224, 141, 224, 224, 237, 224, 224, 146, 137, 132, 135, 133, 224 }, 192) + _0x7bd80600.ToString() + _0x5d1bcade._0x8ea8a153(new byte[12] { 252, 252, 241, 252, 252, 143, 136, 142, 153, 157, 151, 252 }, 220) + _0x80cf74c0.ToString() : _0x5d1bcade._0x8ea8a153(new byte[23] { 35, 53, 47, 40, 90, 60, 51, 40, 41, 46, 90, 40, 51, 62, 61, 63, 90, 59, 45, 59, 51, 46, 41 }, 122);
        _0xb6d1fc6b.Label(this._0xcc9f0df5, _0x5d1bcade._0x8ea8a153(new byte[9] { 26, 61, 40, 61, 26, 61, 59, 32, 57 }, 73), this._font, _0x07c325ae, 34f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -1780f), new Vector2(1100f, 56f));
        RectTransform _0x6391964c = _0xcdf88f8a.Node(this._0xcc9f0df5, _0x5d1bcade._0x8ea8a153(new byte[9] { 193, 230, 254, 221, 230, 218, 229, 230, 253 }, 137), new Vector2(0.5f, 1f), new Vector2(0f, -2200f), new Vector2(480f, 100f));
        Image _0x8881f543 = _0x6391964c.gameObject.AddComponent<Image>();
        _0x8881f543.sprite = this._secondarySprite;
        _0x8881f543.type = this._secondarySprite != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x8881f543.pixelsPerUnitMultiplier = 1.45f;
        _0x8881f543.color = _0xa72ebf9b.GlassFill;
        _0x8881f543.raycastTarget = true;
        _0xb6d1fc6b.Label(_0x6391964c, _0x5d1bcade._0x8ea8a153(new byte[10] { 65, 102, 126, 93, 102, 69, 104, 107, 108, 101 }, 9), this._font, _0x5d1bcade._0x8ea8a153(new byte[11] { 96, 103, 127, 8, 124, 103, 8, 120, 100, 105, 113 }, 40), 36f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(430f, 60f));
        Button _0x869d62aa = _0x6391964c.gameObject.AddComponent<Button>();
        _0x869d62aa.transition = Selectable.Transition.None;
        _0x869d62aa.targetGraphic = _0x8881f543;
        _0x869d62aa.onClick.AddListener(() => this._0xe79c13db());
    }

    private _0x2aa39f7d _0xe6c428bc(string _0xaac6690b, string _0x691965b4, out RectTransform _0xc345561e)
    {
        RectTransform _0x38dc4949 = _0xcdf88f8a.Span(this._0xcb4c004a, _0xaac6690b, Vector2.zero, Vector2.one);
        Image _0x761d3769 = _0x38dc4949.gameObject.AddComponent<Image>();
        _0x761d3769.color = _0xa72ebf9b.Scrim;
        _0x761d3769.raycastTarget = true;
        RectTransform _0x0816bbd1 = _0xcdf88f8a.Node(_0x38dc4949, _0x5d1bcade._0x8ea8a153(new byte[4] { 142, 172, 191, 169 }, 205), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1050f, 1700f));
        Image _0x5119df0d = _0x0816bbd1.gameObject.AddComponent<Image>();
        _0x5119df0d.sprite = this._panelSprite;
        _0x5119df0d.type = this._panelSprite != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x5119df0d.pixelsPerUnitMultiplier = 1.45f;
        _0x5119df0d.color = _0xa72ebf9b.GlassFill;
        _0x5119df0d.raycastTarget = true;
        _0xb6d1fc6b.Label(_0x0816bbd1, _0x5d1bcade._0x8ea8a153(new byte[9] { 178, 144, 131, 149, 165, 152, 133, 157, 148 }, 241), this._font, _0x691965b4, 56f, _0xa72ebf9b.Ember, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -78f), new Vector2(820f, 72f));
        _0xc345561e = _0xcdf88f8a.Node(_0x0816bbd1, _0x5d1bcade._0x8ea8a153(new byte[8] { 243, 209, 194, 212, 242, 223, 212, 201 }, 176), new Vector2(0.5f, 1f), new Vector2(0f, -900f), new Vector2(_0xfdf0f7fe.BodyWidth, 1520f));
        Button _0x28c85e16 = _0xcdf88f8a.IconButton(_0x0816bbd1, _0x5d1bcade._0x8ea8a153(new byte[9] { 196, 230, 245, 227, 196, 235, 232, 244, 226 }, 135), this._panelSprite, this._closeSprite, new Vector2(1f, 1f), new Vector2(-74f, -74f), new Vector2(96f, 96f), 1.45f);
        _0x2aa39f7d _0xf1c9d6af = _0x38dc4949.gameObject.AddComponent<_0x2aa39f7d>();
        _0xf1c9d6af._0x15104dcf(_0x38dc4949.gameObject, _0x28c85e16, _0x0816bbd1, this._0x391795cf);
        return _0xf1c9d6af;
    }

    private bool _0x391795cf;
    [SerializeField]
    private Sprite _secondarySprite;
    private void _0xf9d11ff0(Button _0x246666a3, TextMeshProUGUI _0x921436d6)
    {
        _0xe4e07605._0xc3bd49fc = !_0xe4e07605._0xc3bd49fc;
        if (_0x921436d6 != null)
            _0x921436d6.text = _0xe4e07605._0xc3bd49fc ? _0x5d1bcade._0x8ea8a153(new byte[2] { 24, 25 }, 87) : _0x5d1bcade._0x8ea8a153(new byte[3] { 67, 74, 74 }, 12);
        this._0x5ca105a7(_0x246666a3, _0xe4e07605._0xc3bd49fc);
        if (_0xe4e07605._0xc3bd49fc)
            Handheld.Vibrate();
    }

    private void _0x90f57a7c(Button _0x0eeb8cfc, TextMeshProUGUI _0x9d83b18f)
    {
        _0xe4e07605._0x51670660 = !_0xe4e07605._0x51670660;
        this._0x391795cf = _0xe4e07605._0x51670660;
        if (_0x9d83b18f != null)
            _0x9d83b18f.text = _0xe4e07605._0x51670660 ? _0x5d1bcade._0x8ea8a153(new byte[2] { 215, 214 }, 152) : _0x5d1bcade._0x8ea8a153(new byte[3] { 105, 96, 96 }, 38);
        this._0x5ca105a7(_0x0eeb8cfc, _0xe4e07605._0x51670660);
    }

    private void _0xd1a6ab30()
    {
        RectTransform _0x5fa6c549;
        _0x2aa39f7d _0x99a9dc84 = this._0xe6c428bc(_0x5d1bcade._0x8ea8a153(new byte[15] { 221, 235, 250, 250, 231, 224, 233, 253, 193, 248, 235, 252, 226, 239, 247 }, 142), _0x5d1bcade._0x8ea8a153(new byte[8] { 34, 52, 37, 37, 56, 63, 54, 34 }, 113), out _0x5fa6c549);
        this._0x625ba70d = false;
        TextMeshProUGUI _0xe749c724 = null;
        Button _0xde8922b5 = this._0x7df106ff(_0x5fa6c549, _0x5d1bcade._0x8ea8a153(new byte[10] { 69, 108, 125, 121, 100, 110, 126, 95, 98, 122 }, 13), _0x5d1bcade._0x8ea8a153(new byte[7] { 105, 96, 113, 117, 104, 98, 114 }, 33), -90f, _0xe4e07605._0xc3bd49fc, out _0xe749c724);
        _0xde8922b5.onClick.AddListener(() => this._0xf9d11ff0(_0xde8922b5, _0xe749c724));
        TextMeshProUGUI _0x466bf7f8 = null;
        Button _0x97da231c = this._0x7df106ff(_0x5fa6c549, _0x5d1bcade._0x8ea8a153(new byte[9] { 112, 82, 73, 84, 82, 83, 111, 82, 74 }, 61), _0x5d1bcade._0x8ea8a153(new byte[13] { 126, 105, 104, 121, 111, 105, 12, 97, 99, 120, 101, 99, 98 }, 44), -270f, _0xe4e07605._0x51670660, out _0x466bf7f8);
        _0x97da231c.onClick.AddListener(() => this._0x90f57a7c(_0x97da231c, _0x466bf7f8));
        TextMeshProUGUI _0x3f2c04d7 = null;
        Button _0x7f287401 = this._0x5376d816(_0x5fa6c549, _0x5d1bcade._0x8ea8a153(new byte[8] { 157, 170, 188, 170, 187, 157, 160, 184 }, 207), _0x5d1bcade._0x8ea8a153(new byte[14] { 4, 19, 5, 19, 2, 118, 6, 4, 25, 17, 4, 19, 5, 5 }, 86), -450f, _0x5d1bcade._0x8ea8a153(new byte[5] { 1, 14, 7, 3, 16 }, 66), out _0x3f2c04d7);
        this._0xfe603b21 = _0x3f2c04d7;
        _0x7f287401.onClick.AddListener(() => this._0x4db1db52());
        _0xb6d1fc6b.Label(_0x5fa6c549, _0x5d1bcade._0x8ea8a153(new byte[12] { 86, 96, 113, 113, 108, 107, 98, 118, 75, 106, 113, 96 }, 5), this._font, _0x5d1bcade._0x8ea8a153(new byte[38] { 52, 54, 43, 35, 54, 33, 55, 55, 68, 45, 55, 68, 55, 48, 43, 54, 33, 32, 68, 43, 42, 68, 48, 44, 45, 55, 68, 32, 33, 50, 45, 39, 33, 68, 43, 42, 40, 61 }, 100), 30f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -640f), new Vector2(880f, 60f));
        _0x99a9dc84.Show();
    }

    [SerializeField]
    private Sprite _badgeSprite;
    private void Start()
    {
        this._0x391795cf = _0xe4e07605._0x51670660;
        this._0xc35b9c1c();
        this._0x2d0b7270();
    }

    [SerializeField]
    private Sprite _closeSprite;
    [SerializeField]
    private Sprite _emberSprite;
    private void _0x4db1db52()
    {
        if (!this._0x625ba70d)
        {
            this._0x625ba70d = true;
            if (this._0xfe603b21 != null)
                this._0xfe603b21.text = _0x5d1bcade._0x8ea8a153(new byte[5] { 133, 131, 132, 147, 233 }, 214);
            return;
        }

        this._0x625ba70d = false;
        _0xe4e07605.WipeAll();
        if (this._0xfe603b21 != null)
            this._0xfe603b21.text = _0x5d1bcade._0x8ea8a153(new byte[7] { 54, 57, 48, 52, 39, 48, 49 }, 117);
        this._0x2d0b7270();
    }

    [SerializeField]
    private Sprite _barFillSprite;
    [SerializeField]
    private RectTransform _playButton;
    private bool _0x625ba70d;
    [SerializeField]
    private Sprite _panelSprite;
    /// <summary>
    /// The template button arrives invisible and stretched; the scene gives it a
    /// real rect and this gives it a real face. Its own driver still loads the game
    /// scene, so nothing here subscribes to the click (G.3).
    /// </summary>
    private void _0xc35b9c1c()
    {
        if (this._playButton == null)
            return;
        Image _0xe8dd888d = _0xcdf88f8a.PlateSpan(this._playButton, _0x5d1bcade._0x8ea8a153(new byte[9] { 26, 38, 43, 51, 26, 38, 43, 62, 47 }, 74), this._primarySprite, _0xa72ebf9b.Magma, Vector2.zero, Vector2.one, 1.45f);
        _0xe8dd888d.raycastTarget = false;
        _0xb6d1fc6b.Label(this._playButton, _0x5d1bcade._0x8ea8a153(new byte[9] { 244, 200, 197, 221, 232, 197, 198, 193, 200 }, 164), this._font, _0x5d1bcade._0x8ea8a153(new byte[4] { 9, 21, 24, 0 }, 89), 68f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(700f, 120f));
    }

    private void _0x421aa421()
    {
        int[] _0x74f33946 = new int[]
        {
            15,
            25,
            40,
            60,
            90,
            130,
            200
        };
        int _0xed4f7542 = _0xe4e07605._0xe3de1b20;
        _0xe4e07605._0xb1b5509c = _0xe4e07605._0xfea57d33;
        _0xe4e07605._0xe3de1b20 = _0xed4f7542 + 1 > 6 ? 0 : _0xed4f7542 + 1;
        _0xe4e07605._0x1ffedb2a = _0xe4e07605._0x1ffedb2a + _0x74f33946[_0xed4f7542];
        _0xd931f97e._0x0633db75._0x684309b9 = _0xd931f97e._0x0633db75._0x684309b9 + _0x74f33946[_0xed4f7542];
        this._0x2d0b7270();
    }

    private void _0x069d4b8b()
    {
        RectTransform _0x2db7e130;
        _0x2aa39f7d _0xa8fd39b3 = this._0xe6c428bc(_0x5d1bcade._0x8ea8a153(new byte[14] { 16, 50, 47, 38, 41, 44, 37, 15, 54, 37, 50, 44, 33, 57 }, 64), _0x5d1bcade._0x8ea8a153(new byte[7] { 48, 50, 47, 38, 41, 44, 37 }, 96), out _0x2db7e130);
        _0xfdf0f7fe.Profile(_0x2db7e130, this._font, this._panelSprite);
        _0xa8fd39b3.Show();
    }

    private Button _0x5376d816(RectTransform _0xa2e6d6f2, string _0x4763faad, string _0xddd99df4, float _0xe37bc2ce, string _0xdfa6a63c, out TextMeshProUGUI _0x81733f55)
    {
        _0xcdf88f8a.Plate(_0xa2e6d6f2, _0x4763faad + _0x5d1bcade._0x8ea8a153(new byte[5] { 19, 47, 34, 55, 38 }, 67), this._panelSprite, _0xa72ebf9b.GlassFill, new Vector2(0.5f, 1f), new Vector2(0f, _0xe37bc2ce), new Vector2(_0xfdf0f7fe.BodyWidth, 140f), 1.45f);
        _0xb6d1fc6b.Label(_0xa2e6d6f2, _0x4763faad + _0x5d1bcade._0x8ea8a153(new byte[7] { 254, 220, 205, 201, 212, 210, 211 }, 189), this._font, _0xddd99df4, 36f, _0xa72ebf9b.Cream, TextAlignmentOptions.Left, new Vector2(0.5f, 1f), new Vector2(-180f, _0xe37bc2ce), new Vector2(520f, 56f));
        RectTransform _0x23194275 = _0xcdf88f8a.Node(_0xa2e6d6f2, _0x4763faad + _0x5d1bcade._0x8ea8a153(new byte[4] { 96, 95, 92, 71 }, 51), new Vector2(0.5f, 1f), new Vector2(330f, _0xe37bc2ce), new Vector2(250f, 96f));
        Image _0xc3248dfb = _0x23194275.gameObject.AddComponent<Image>();
        _0xc3248dfb.sprite = this._secondarySprite;
        _0xc3248dfb.type = this._secondarySprite != null ? Image.Type.Sliced : Image.Type.Simple;
        _0xc3248dfb.pixelsPerUnitMultiplier = 1.45f;
        _0xc3248dfb.color = _0xa72ebf9b.Fade(_0xa72ebf9b.Magma, 0.55f);
        _0xc3248dfb.raycastTarget = true;
        _0x81733f55 = _0xb6d1fc6b.Label(_0x23194275, _0x4763faad + _0x5d1bcade._0x8ea8a153(new byte[5] { 249, 206, 195, 218, 202 }, 175), this._font, _0xdfa6a63c, 36f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(210f, 60f));
        Button _0x52f99de2 = _0x23194275.gameObject.AddComponent<Button>();
        _0x52f99de2.transition = Selectable.Transition.None;
        _0x52f99de2.targetGraphic = _0xc3248dfb;
        return _0x52f99de2;
    }

    [SerializeField]
    private Sprite _gearSprite;
    [SerializeField]
    private Sprite _flameSprite;
    [SerializeField]
    private Sprite _barTrackSprite;
    private void _0x9e8aaf0e()
    {
        _0xcdf88f8a.Icon(this._0xcc9f0df5, _0x5d1bcade._0x8ea8a153(new byte[9] { 128, 176, 163, 172, 166, 143, 163, 176, 169 }, 194), this._markSprite, _0xa72ebf9b.Ember, new Vector2(0.5f, 1f), new Vector2(0f, -470f), new Vector2(300f, 300f));
        _0xb6d1fc6b.Label(this._0xcc9f0df5, _0x5d1bcade._0x8ea8a153(new byte[9] { 143, 162, 170, 165, 163, 180, 169, 182, 165 }, 192), this._font, _0x5d1bcade._0x8ea8a153(new byte[34] { 117, 100, 121, 101, 101, 22, 98, 126, 115, 22, 100, 127, 114, 113, 115, 60, 125, 115, 115, 102, 22, 98, 126, 115, 22, 126, 115, 119, 98, 22, 114, 121, 97, 120 }, 54), 40f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -720f), new Vector2(1060f, 110f));
    }

    [SerializeField]
    private Sprite _primarySprite;
    /// <summary>
    /// A two-state row. The slot carries the state in BOTH its caption and its fill
    /// colour, so a tap is visible on a screenshot and not only in the word (C.7).
    /// </summary>
    private Button _0x7df106ff(RectTransform _0x169d21c5, string _0x66fe99fa, string _0x18d9f1bf, float _0x16eed957, bool _0xae4349d0, out TextMeshProUGUI _0xc6cbde28)
    {
        Button _0x8da11f9a = this._0x5376d816(_0x169d21c5, _0x66fe99fa, _0x18d9f1bf, _0x16eed957, _0xae4349d0 ? _0x5d1bcade._0x8ea8a153(new byte[2] { 142, 143 }, 193) : _0x5d1bcade._0x8ea8a153(new byte[3] { 38, 47, 47 }, 105), out _0xc6cbde28);
        this._0x5ca105a7(_0x8da11f9a, _0xae4349d0);
        return _0x8da11f9a;
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject, false);
    }

    private void _0xe79c13db()
    {
        RectTransform _0x7ec11f41;
        _0x2aa39f7d _0x336da325 = this._0xe6c428bc(_0x5d1bcade._0x8ea8a153(new byte[12] { 91, 124, 100, 71, 124, 92, 101, 118, 97, 127, 114, 106 }, 19), _0x5d1bcade._0x8ea8a153(new byte[11] { 113, 118, 110, 25, 109, 118, 25, 105, 117, 120, 96 }, 57), out _0x7ec11f41);
        _0xcdf88f8a.Plate(_0x7ec11f41, _0x5d1bcade._0x8ea8a153(new byte[10] { 205, 234, 242, 209, 234, 213, 233, 228, 241, 224 }, 133), this._panelSprite, _0xa72ebf9b.GlassFill, new Vector2(0.5f, 1f), new Vector2(0f, -280f), new Vector2(_0xfdf0f7fe.BodyWidth, 520f), 1.45f);
        _0xb6d1fc6b.Label(_0x7ec11f41, _0x5d1bcade._0x8ea8a153(new byte[9] { 87, 112, 104, 75, 112, 93, 112, 123, 102 }, 31), this._font, _0x5d1bcade._0x8ea8a153(new byte[66] { 243, 230, 247, 135, 243, 239, 226, 135, 235, 226, 225, 243, 135, 232, 245, 135, 245, 238, 224, 239, 243, 135, 244, 238, 227, 226, 173, 232, 225, 135, 243, 239, 226, 135, 244, 228, 245, 226, 226, 233, 135, 243, 232, 135, 244, 243, 226, 247, 173, 232, 233, 226, 135, 235, 230, 233, 226, 135, 244, 238, 227, 226, 240, 230, 254, 244 }, 167), 38f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -180f), new Vector2(880f, 180f));
        _0xb6d1fc6b.Label(_0x7ec11f41, _0x5d1bcade._0x8ea8a153(new byte[9] { 76, 107, 115, 80, 107, 76, 97, 101, 112 }, 4), this._font, _0x5d1bcade._0x8ea8a153(new byte[88] { 162, 160, 188, 182, 160, 183, 182, 197, 164, 171, 161, 197, 166, 172, 171, 161, 160, 183, 182, 197, 183, 164, 172, 182, 160, 197, 173, 160, 164, 177, 239, 160, 168, 167, 160, 183, 182, 197, 164, 171, 161, 197, 162, 160, 170, 161, 160, 182, 197, 166, 170, 170, 169, 197, 172, 177, 197, 161, 170, 178, 171, 239, 164, 177, 197, 212, 213, 213, 197, 173, 160, 164, 177, 197, 177, 173, 160, 197, 183, 172, 161, 162, 160, 197, 160, 171, 161, 182 }, 229), 34f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -390f), new Vector2(880f, 180f));
        _0xcdf88f8a.Icon(_0x7ec11f41, _0x5d1bcade._0x8ea8a153(new byte[9] { 120, 95, 71, 100, 95, 120, 85, 66, 95 }, 48), this._heroSprite, Color.white, new Vector2(0.5f, 1f), new Vector2(0f, -720f), new Vector2(300f, 300f));
        _0x336da325.Show();
    }

    [SerializeField]
    private GameObject _coinsPrefab;
    [SerializeField]
    private Sprite _heroSprite;
    private RectTransform _0xcc9f0df5;
    private void _0x2d0b7270()
    {
        if (this._content == null)
            return;
        if (this._0xcc9f0df5 != null)
            Destroy(this._0xcc9f0df5.gameObject);
        if (this._0xcb4c004a != null)
            Destroy(this._0xcb4c004a.gameObject);
        this._0xcc9f0df5 = _0xcdf88f8a.Span(this._content, _0x5d1bcade._0x8ea8a153(new byte[8] { 24, 37, 50, 3, 36, 49, 55, 53 }, 80), Vector2.zero, Vector2.one);
        this._0xcc9f0df5.SetAsFirstSibling();
        this._0xcb4c004a = _0xcdf88f8a.Span(this._content, _0x5d1bcade._0x8ea8a153(new byte[11] { 3, 62, 41, 4, 61, 46, 57, 39, 42, 50, 56 }, 75), Vector2.zero, Vector2.one);
        this._0xcb4c004a.SetAsLastSibling();
        this._0xcd42b98c();
        this._0x9e8aaf0e();
        this._0x7f4825c0();
        this._0xffc85887();
    }

    private RectTransform _0xcb4c004a;
    private TextMeshProUGUI _0xfe603b21;
    private Button _0x99f37908(string _0x0b65cfae, Sprite _0x8636be74, string _0xccbe3fe0, string _0xd070381d, Vector2 _0x3e295d05)
    {
        RectTransform _0xaa728436 = _0xcdf88f8a.Node(this._0xcc9f0df5, _0x0b65cfae, new Vector2(0.5f, 1f), _0x3e295d05, new Vector2(450f, 300f));
        Image _0xb4147efb = _0xaa728436.gameObject.AddComponent<Image>();
        _0xb4147efb.sprite = this._tileSprite;
        _0xb4147efb.type = this._tileSprite != null ? Image.Type.Sliced : Image.Type.Simple;
        _0xb4147efb.pixelsPerUnitMultiplier = 1.45f;
        _0xb4147efb.color = _0xa72ebf9b.GlassFill;
        _0xb4147efb.raycastTarget = true;
        _0xcdf88f8a.Icon(_0xaa728436, _0x0b65cfae + _0x5d1bcade._0x8ea8a153(new byte[5] { 128, 171, 190, 183, 175 }, 199), _0x8636be74, _0xa72ebf9b.Ember, new Vector2(0.5f, 1f), new Vector2(0f, -76f), new Vector2(96f, 96f));
        _0xb6d1fc6b.Label(_0xaa728436, _0x0b65cfae + _0x5d1bcade._0x8ea8a153(new byte[5] { 66, 127, 98, 122, 115 }, 22), this._font, _0xccbe3fe0, 40f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -170f), new Vector2(400f, 52f));
        _0xb6d1fc6b.Label(_0xaa728436, _0x0b65cfae + _0x5d1bcade._0x8ea8a153(new byte[3] { 130, 164, 179 }, 209), this._font, _0xd070381d, 28f, _0xa72ebf9b.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -234f), new Vector2(400f, 46f));
        Button _0x7016234a = _0xaa728436.gameObject.AddComponent<Button>();
        _0x7016234a.transition = Selectable.Transition.None;
        _0x7016234a.targetGraphic = _0xb4147efb;
        if (this._0x391795cf)
            return _0x7016234a;
        _0xaa728436.localScale = Vector3.one * 0.94f;
        _0xaa728436.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(_0xaa728436.gameObject);
        return _0x7016234a;
    }

    [SerializeField]
    private Sprite _markSprite;
    private void _0x543baf48()
    {
        RectTransform _0x1c03d03f;
        _0x2aa39f7d _0x315f2c06 = this._0xe6c428bc(_0x5d1bcade._0x8ea8a153(new byte[13] { 162, 149, 135, 145, 130, 148, 191, 134, 149, 130, 156, 145, 137 }, 240), _0x5d1bcade._0x8ea8a153(new byte[7] { 212, 195, 209, 199, 212, 194, 213 }, 134), out _0x1c03d03f);
        Button _0xc88a4ffc = _0xfdf0f7fe.Rewards(_0x1c03d03f, this._font, this._panelSprite, this._emberSprite, this._primarySprite);
        if (_0xc88a4ffc != null)
            _0xc88a4ffc.onClick.AddListener(() => this._0x421aa421());
        _0x315f2c06.Show();
    }

    private void _0x65f7d5b2()
    {
        RectTransform _0x461c2451;
        _0x2aa39f7d _0xfc5548ec = this._0xe6c428bc(_0x5d1bcade._0x8ea8a153(new byte[16] { 122, 81, 88, 85, 85, 92, 87, 94, 92, 118, 79, 92, 75, 85, 88, 64 }, 57), _0x5d1bcade._0x8ea8a153(new byte[15] { 1, 4, 12, 9, 28, 101, 6, 13, 4, 9, 9, 0, 11, 2, 0 }, 69), out _0x461c2451);
        _0xfdf0f7fe.Challenge(_0x461c2451, this._font, this._panelSprite, this._flameSprite);
        _0xfc5548ec.Show();
    }

    private void _0x7f4825c0()
    {
        int _0x8d11e0fe = 0;
        for (int _0x8e8153c4 = 0; _0x8e8153c4 < 3; _0x8e8153c4++)
        {
            int[] _0x63440dc0 = new int[]
            {
                40,
                350,
                1
            };
            if (_0xe4e07605.MissionProgress(_0x8e8153c4) >= _0x63440dc0[_0x8e8153c4])
                _0x8d11e0fe++;
        }

        bool _0xc0b76ee8 = _0xe4e07605._0xb1b5509c != _0xe4e07605._0xfea57d33;
        Button _0xcc6ed8c2 = this._0x99f37908(_0x5d1bcade._0x8ea8a153(new byte[9] { 97, 68, 76, 73, 92, 113, 76, 73, 64 }, 37), this._flameSprite, _0x5d1bcade._0x8ea8a153(new byte[5] { 118, 115, 123, 126, 107 }, 50), _0x1934ccb4.Title(_0x1934ccb4._0xeba2a78a), new Vector2(-243f, -980f));
        _0xcc6ed8c2.onClick.AddListener(() => this._0x65f7d5b2());
        Button _0x85b7081d = this._0x99f37908(_0x5d1bcade._0x8ea8a153(new byte[11] { 255, 219, 193, 193, 219, 221, 220, 230, 219, 222, 215 }, 178), this._badgeSprite, _0x5d1bcade._0x8ea8a153(new byte[8] { 206, 202, 208, 208, 202, 204, 205, 208 }, 131), _0x8d11e0fe.ToString() + _0x5d1bcade._0x8ea8a153(new byte[9] { 110, 97, 110, 125, 110, 10, 1, 0, 11 }, 78), new Vector2(243f, -980f));
        _0x85b7081d.onClick.AddListener(() => this._0x04149de9());
        Button _0xe9c9a2a3 = this._0x99f37908(_0x5d1bcade._0x8ea8a153(new byte[10] { 10, 61, 47, 57, 42, 60, 12, 49, 52, 61 }, 88), this._emberSprite, _0x5d1bcade._0x8ea8a153(new byte[7] { 21, 2, 16, 6, 21, 3, 20 }, 71), _0xc0b76ee8 ? _0x5d1bcade._0x8ea8a153(new byte[4] { 178, 183, 175, 214 }, 246) + (_0xe4e07605._0xe3de1b20 + 1).ToString() + _0x5d1bcade._0x8ea8a153(new byte[6] { 232, 154, 141, 137, 140, 145 }, 200) : _0x5d1bcade._0x8ea8a153(new byte[7] { 153, 150, 155, 147, 151, 159, 158 }, 218), new Vector2(-243f, -1316f));
        _0xe9c9a2a3.onClick.AddListener(() => this._0x543baf48());
        Button _0xbad6f115 = this._0x99f37908(_0x5d1bcade._0x8ea8a153(new byte[11] { 162, 128, 157, 148, 155, 158, 151, 166, 155, 158, 151 }, 242), this._heroSprite, _0x5d1bcade._0x8ea8a153(new byte[7] { 142, 140, 145, 152, 151, 146, 155 }, 222), _0x5d1bcade._0x8ea8a153(new byte[5] { 252, 239, 224, 229, 142 }, 174) + _0xe4e07605._0x3743fecb.ToString(), new Vector2(243f, -1316f));
        _0xbad6f115.onClick.AddListener(() => this._0x069d4b8b());
    }
}

internal static class _0x5d1bcade
{
    internal static string _0x8ea8a153(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}