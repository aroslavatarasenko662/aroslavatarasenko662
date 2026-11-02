using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The run HUD: heat, distance, embers, the two tap zones and the permanent control
/// hint (C.6). It is built from this game's own objects on its own canvas at sorting
/// order 5 - below the template pop canvases at 10/15 (C.9), above the scene UI at 0.
/// </summary>
public sealed class _0x5d346778 : MonoBehaviour
{
    private RectTransform _0x677d8097;
    private TextMeshProUGUI _0x3e2e7744;
    [SerializeField]
    private Sprite _pauseIcon;
    private Image _0xc89809c4;
    private void _0x865310bc()
    {
        if (this._director != null)
            this._director._0xd34df33c(-1);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _barFillSprite;
    private RectTransform _0xaf64b9bd;
    private const int HudOrder = 5;
    private RectTransform _0x428a4b15;
    private TextMeshProUGUI _0x2df9574a;
    [SerializeField]
    private Sprite _backIcon;
    private void _0xa8bc4c48()
    {
        if (this._director != null)
            this._director._0xd34df33c(1);
    }

    public void _0xc5b4e02f(string _0x1710b8a4, bool _0xd716c207)
    {
        this._0x23f475b6();
        if (this._0xaf64b9bd != null)
            this._0xaf64b9bd.gameObject.SetActive(_0xd716c207);
        if (this._0xfdcf1c78 != null && _0xd716c207)
            this._0xfdcf1c78.text = _0x1710b8a4;
    }

    private void OnDestroy()
    {
        if (this._0x677d8097 != null)
            DOTween.Kill(this._0x677d8097, false);
        if (this._0x92a4b66b != null)
            Destroy(this._0x92a4b66b.gameObject);
    }

    public void _0xd35e2d73(int _0xfd0c39fd, int _0x530a3d65)
    {
        this._0x23f475b6();
        if (this._0x2df9574a != null)
            this._0x2df9574a.text = _0xfd0c39fd.ToString() + _0x2fe12441._0xf7547a28(new byte[3] { 127, 112, 127 }, 95) + _0x530a3d65.ToString() + _0x2fe12441._0xf7547a28(new byte[2] { 19, 126 }, 51);
    }

    private bool _0xe8336cc4;
    private void _0x58c11e32()
    {
        if (this._director != null)
            this._director._0x04019c24();
    }

    private TextMeshProUGUI _0x8f3d7872;
    private TextMeshProUGUI _0xf7ea1dd3;
    public void _0x3681e537(int _0x08d02806, int _0xe413cab7)
    {
        this._0x23f475b6();
        if (this._0xf7ea1dd3 != null)
            this._0xf7ea1dd3.text = _0x2fe12441._0xf7547a28(new byte[7] { 97, 105, 102, 97, 118, 119, 4 }, 36) + _0x08d02806.ToString();
        if (this._0x3e2e7744 != null)
            this._0x3e2e7744.text = _0x2fe12441._0xf7547a28(new byte[6] { 193, 218, 215, 212, 214, 179 }, 147) + _0xe413cab7.ToString();
    }

    [SerializeField]
    private Sprite _panelSprite;
    public void _0x0badef86()
    {
        if (this._0x428a4b15 != null)
            this._0x428a4b15.gameObject.SetActive(false);
    }

    public void _0x52655957(string _0xe3786e22, Color _0x5acb5877, bool _0x2e22d407)
    {
        this._0x23f475b6();
        TextMeshProUGUI _0xd774dfcf = _0xb6d1fc6b.Label(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[6] { 239, 208, 207, 207, 218, 205 }, 191), this._font, _0xe3786e22, 44f, _0x5acb5877, TextAlignmentOptions.Center, new Vector2(0.5f, 0.34f), Vector2.zero, new Vector2(620f, 70f));
        RectTransform _0xfc1050e3 = _0xd774dfcf.rectTransform;
        if (_0x2e22d407)
        {
            Destroy(_0xd774dfcf.gameObject, 0.6f);
            return;
        }

        _0xfc1050e3.DOAnchorPosY(110f, 0.6f).SetEase(Ease.OutCubic).SetLink(_0xd774dfcf.gameObject);
        _0xd774dfcf.DOFade(0f, 0.6f).SetEase(Ease.InQuad).SetLink(_0xd774dfcf.gameObject);
        Destroy(_0xd774dfcf.gameObject, 0.7f);
    }

    public void _0xfb94a3fa(bool _0x7945ff04)
    {
        if (_0x7945ff04 || this._0x677d8097 == null)
            return;
        this._0x677d8097.DOPunchScale(new Vector3(0f, 0.25f, 0f), 0.22f, 6, 0.6f).SetLink(this._0x677d8097.gameObject);
    }

    [SerializeField]
    private _0xc250b32a _director;
    private void _0xc949f8d0()
    {
        if (this._director != null)
            this._director._0x75af6e0f();
    }

    [SerializeField]
    private Sprite _barTrackSprite;
    public void _0x23f475b6()
    {
        if (this._0xe8336cc4)
            return;
        this._0xe8336cc4 = true;
        this._0x92a4b66b = _0xcdf88f8a.Overlay(_0x2fe12441._0xf7547a28(new byte[6] { 87, 112, 107, 77, 112, 97 }, 5), HudOrder);
        this._0x428a4b15 = this._0x92a4b66b.GetComponent<RectTransform>();
        Button _0x21cfac4a = _0xcdf88f8a.IconButton(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[8] { 63, 28, 30, 22, 46, 17, 18, 9 }, 125), this._panelSprite, this._backIcon, new Vector2(0.0926f, 0.9450f), Vector2.zero, new Vector2(112f, 112f), 1.45f);
        _0x21cfac4a.onClick.AddListener(() => this._0x58c11e32());
        Button _0x0e5323bd = _0xcdf88f8a.IconButton(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[9] { 218, 235, 255, 249, 239, 217, 230, 229, 254 }, 138), this._panelSprite, this._pauseIcon, new Vector2(0.9074f, 0.9450f), Vector2.zero, new Vector2(112f, 112f), 1.45f);
        _0x0e5323bd.onClick.AddListener(() => this._0xc949f8d0());
        this._0x8f3d7872 = _0xb6d1fc6b.Label(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[11] { 53, 24, 28, 9, 62, 28, 13, 9, 20, 18, 19 }, 125), this._font, _0x2fe12441._0xf7547a28(new byte[7] { 128, 141, 137, 156, 232, 248, 237 }, 200), 30f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.9570f), Vector2.zero, new Vector2(660f, 46f));
        RectTransform _0x8c873f3c = _0xcdf88f8a.Node(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[7] { 93, 112, 116, 97, 87, 116, 103 }, 21), new Vector2(0.5f, 0.9290f), Vector2.zero, new Vector2(640f, 38f));
        Image _0xe34469bf = _0x8c873f3c.gameObject.AddComponent<Image>();
        _0xe34469bf.sprite = this._barTrackSprite;
        _0xe34469bf.type = this._barTrackSprite != null ? Image.Type.Sliced : Image.Type.Simple;
        _0xe34469bf.pixelsPerUnitMultiplier = 1.45f;
        _0xe34469bf.color = _0xa72ebf9b.TrackDark;
        _0xe34469bf.raycastTarget = false;
        RectTransform _0x34af1cf3 = _0xcdf88f8a.Span(_0x8c873f3c, _0x2fe12441._0xf7547a28(new byte[9] { 163, 142, 138, 159, 162, 133, 133, 142, 153 }, 235), new Vector2(0f, 0.2f), new Vector2(1f, 0.8f));
        this._0x677d8097 = _0xcdf88f8a.Span(_0x34af1cf3, _0x2fe12441._0xf7547a28(new byte[8] { 36, 9, 13, 24, 42, 5, 0, 0 }, 108), new Vector2(0f, 0f), new Vector2(0.001f, 1f));
        this._0xc89809c4 = this._0x677d8097.gameObject.AddComponent<Image>();
        this._0xc89809c4.sprite = this._barFillSprite;
        this._0xc89809c4.type = this._barFillSprite != null ? Image.Type.Sliced : Image.Type.Simple;
        this._0xc89809c4.pixelsPerUnitMultiplier = 1.45f;
        this._0xc89809c4.color = _0xa72ebf9b.Ember;
        this._0xc89809c4.raycastTarget = false;
        this._0x2df9574a = _0xb6d1fc6b.Label(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[8] { 215, 250, 224, 231, 242, 253, 240, 246 }, 147), this._font, _0x2fe12441._0xf7547a28(new byte[3] { 227, 243, 158 }, 211), 56f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.8930f), Vector2.zero, new Vector2(720f, 80f));
        this._0xf7ea1dd3 = _0xb6d1fc6b.Label(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[6] { 21, 61, 50, 53, 34, 35 }, 80), this._font, _0x2fe12441._0xf7547a28(new byte[8] { 92, 84, 91, 92, 75, 74, 57, 41 }, 25), 34f, _0xa72ebf9b.Ember, TextAlignmentOptions.Left, new Vector2(0.5f, 0.8600f), new Vector2(-230f, 0f), new Vector2(440f, 50f));
        this._0x3e2e7744 = _0xb6d1fc6b.Label(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[5] { 209, 234, 231, 228, 230 }, 131), this._font, _0x2fe12441._0xf7547a28(new byte[7] { 255, 228, 233, 234, 232, 141, 156 }, 173), 34f, _0xa72ebf9b.Ember, TextAlignmentOptions.Right, new Vector2(0.5f, 0.8600f), new Vector2(230f, 0f), new Vector2(440f, 50f));
        Button _0x32d3be08 = _0xcdf88f8a.Zone(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[12] { 26, 61, 44, 57, 5, 44, 47, 61, 19, 38, 39, 44 }, 73), new Vector2(0f, 0.17f), new Vector2(0.5f, 0.80f));
        _0x32d3be08.onClick.AddListener(() => this._0x865310bc());
        Button _0x2b647eee = _0xcdf88f8a.Zone(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[13] { 131, 164, 181, 160, 130, 185, 183, 184, 164, 138, 191, 190, 181 }, 208), new Vector2(0.5f, 0.17f), new Vector2(1f, 0.80f));
        _0x2b647eee.onClick.AddListener(() => this._0xa8bc4c48());
        RectTransform _0x7ab129e1 = _0xcdf88f8a.Node(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[8] { 140, 173, 170, 176, 148, 173, 168, 168 }, 196), new Vector2(0.5f, 0.1100f), Vector2.zero, new Vector2(980f, 104f));
        Image _0xbfa72575 = _0x7ab129e1.gameObject.AddComponent<Image>();
        _0xbfa72575.sprite = this._panelSprite;
        _0xbfa72575.type = this._panelSprite != null ? Image.Type.Sliced : Image.Type.Simple;
        _0xbfa72575.pixelsPerUnitMultiplier = 1.45f;
        _0xbfa72575.color = _0xa72ebf9b.GlassFill;
        _0xbfa72575.raycastTarget = false;
        _0xb6d1fc6b.Label(_0x7ab129e1, _0x2fe12441._0xf7547a28(new byte[8] { 128, 161, 166, 188, 156, 173, 176, 188 }, 200), this._font, _0x2fe12441._0xf7547a28(new byte[39] { 191, 170, 187, 203, 167, 174, 173, 191, 203, 164, 185, 203, 185, 162, 172, 163, 191, 203, 184, 162, 175, 174, 225, 191, 164, 203, 184, 191, 174, 187, 203, 164, 165, 174, 203, 167, 170, 165, 174 }, 235), 40f, _0xa72ebf9b.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(930f, 96f));
        this._0xaf64b9bd = _0xcdf88f8a.Node(this._0x428a4b15, _0x2fe12441._0xf7547a28(new byte[7] { 10, 38, 60, 39, 61, 0, 39 }, 73), new Vector2(0.5f, 0.62f), Vector2.zero, new Vector2(760f, 150f));
        Image _0x7feaa9aa = this._0xaf64b9bd.gameObject.AddComponent<Image>();
        _0x7feaa9aa.sprite = this._panelSprite;
        _0x7feaa9aa.type = this._panelSprite != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x7feaa9aa.pixelsPerUnitMultiplier = 1.45f;
        _0x7feaa9aa.color = _0xa72ebf9b.GlassFill;
        _0x7feaa9aa.raycastTarget = false;
        this._0xfdcf1c78 = _0xb6d1fc6b.Label(this._0xaf64b9bd, _0x2fe12441._0xf7547a28(new byte[11] { 35, 15, 21, 14, 20, 41, 14, 52, 5, 24, 20 }, 96), this._font, _0x2fe12441._0xf7547a28(new byte[5] { 176, 167, 163, 166, 187 }, 226), 64f, _0xa72ebf9b.Ember, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(700f, 130f));
    }

    private Canvas _0x92a4b66b;
    private TextMeshProUGUI _0xfdcf1c78;
    public void _0xda729ec8(float _0xaad673e4)
    {
        this._0x23f475b6();
        float _0x75f4e038 = Mathf.Clamp01(_0xaad673e4);
        if (this._0x677d8097 != null)
            this._0x677d8097.anchorMax = new Vector2(Mathf.Max(0.001f, _0x75f4e038), 1f);
        if (this._0xc89809c4 != null)
            this._0xc89809c4.color = _0xa72ebf9b.Heat(_0x75f4e038);
        if (this._0x8f3d7872 != null)
            this._0x8f3d7872.text = _0x2fe12441._0xf7547a28(new byte[5] { 161, 172, 168, 189, 201 }, 233) + Mathf.RoundToInt(_0x75f4e038 * 100f).ToString() + _0x2fe12441._0xf7547a28(new byte[1] { 209 }, 244);
    }
}

internal static class _0x2fe12441
{
    internal static string _0xf7547a28(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}