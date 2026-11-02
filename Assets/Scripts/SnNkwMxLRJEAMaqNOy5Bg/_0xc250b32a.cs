using DG.Tweening;
using UnityEngine;

/// <summary>
/// One ridge, start to finish. Every size comes from the scene camera (C.0), the run
/// is paused by the template's own run flag so the Pause pop keeps working, and the
/// result is handed to the template pops at 7 / 8 (C.3).
/// </summary>
public sealed class _0xc250b32a : MonoBehaviour
{
    private int _0xcb5edd78;
    private float _0x3d842448;
    private float _0x7be9fc60;
    [SerializeField]
    private _0x33214850 _pops;
    [SerializeField]
    private _0x5d346778 _hud;
    private int _0x7c6b759d = StateReady;
    private int _0xba84e151;
    private float _0x556d705a;
    private const int StateLost = 4;
    private float _0xf2e12c35;
    private void _0x70d2c90a(int _0x06ec7e56, int _0xde84b50f, int _0xcabc875f)
    {
        if (this._pops != null)
            this._pops._0xddc5454a(_0x06ec7e56, _0xde84b50f, _0xcabc875f);
    }

    private void Update()
    {
        float dt = Mathf.Min(Time.deltaTime, _0x2d32cceb.MaxFrameStep);
        bool _0xfce52fa4 = _0xc2255145.Instance != null && _0xc2255145.Instance._0x1a641ad7;
        if (this._0x7c6b759d == StateWon || this._0x7c6b759d == StateLost)
            return;
        if (!_0xfce52fa4)
        {
            if (this._0x7c6b759d == StateRunning)
                this._0x7c6b759d = StateHeld;
            return;
        }

        if (this._0x7c6b759d == StateHeld)
            this._0x7c6b759d = StateRunning;
        if (this._0x7c6b759d == StateReady)
        {
            this._0x7be9fc60 -= dt;
            if (this._hud != null)
                this._hud._0xc5b4e02f(this._0x7be9fc60 > _0x2d32cceb.CountInSeconds * 0.5f ? _0xdf95f816._0x9f80ecae(new byte[5] { 149, 130, 134, 131, 158 }, 199) : _0xdf95f816._0x9f80ecae(new byte[2] { 19, 27 }, 84), true);
            if (this._0x7be9fc60 > 0f)
                return;
            if (this._hud != null)
                this._hud._0xc5b4e02f(string.Empty, false);
            if (this._heat != null)
                this._heat._0xbf35b5bd();
            this._0x7c6b759d = StateRunning;
        }

        this._0x05ffc4a9(dt);
    }

    private void _0xe50235a8(int count)
    {
        float _0xafa4fac3 = this._0xba84e151 == 2 ? 1.0f : _0x2d32cceb.HeatPerEmber;
        int worth = this._0xba84e151 == 2 ? count * 2 : count;
        this._0xcb5edd78 += worth;
        if (this._heat != null)
            this._heat._0xaf3193b7(_0xafa4fac3 * count);
        if (this._hud != null)
            this._hud._0x52655957(_0xdf95f816._0x9f80ecae(new byte[1] { 156 }, 183) + worth.ToString() + _0xdf95f816._0x9f80ecae(new byte[6] { 62, 91, 83, 92, 91, 76 }, 30), _0xa72ebf9b.Ember, this._0x14dfc159);
    }

    private int _0x278b9ac1;
    private int _0xc8379f72 = _0x2d32cceb.RidgeBaseTarget;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject, false);
    }

    public void _0x75af6e0f()
    {
        if (this._0x7c6b759d != StateRunning)
            return;
        if (_0xc2255145.Instance != null)
            _0xc2255145.Instance._0xae3b7fed(false);
        this._0x7c6b759d = StateHeld;
        if (this._pops != null)
            this._pops._0x5c294d91(Mathf.RoundToInt((this._heat != null ? this._heat._0x797b4bf8 : 0f) * 100f), Mathf.FloorToInt(this._0x556d705a));
    }

    private void _0x049e9d5b(int _0x9b404c62, int _0xfa15bb28, int _0xb708f403)
    {
        if (this._pops != null)
            this._pops._0xdc61bdb3(_0x9b404c62, _0xfa15bb28, _0xb708f403);
    }

    private const int StateWon = 3;
    private int _0xb9dfa704;
    private void _0xf3679bf9()
    {
        if (this._heroPrefab == null || this._0xaf67506b == null)
            return;
        GameObject _0x2b683c23 = Instantiate(this._heroPrefab, this._0xaf67506b);
        _0x2b683c23.transform.localPosition = new Vector3(0f, -this._0xf0fb850e + _0x2d32cceb.HeroScreenFraction * 2f * this._0xf0fb850e, 0f);
        if (this._spawner != null)
            this._spawner._0x30e97d20(_0x2b683c23);
        this._0xfe282164 = _0x2b683c23.GetComponent<_0xdd85a77b>();
        if (this._0xfe282164 != null)
            this._0xfe282164._0xa1246c56(this._0x24b1e6d5, this._0x14dfc159);
    }

    private float _0x24b1e6d5 = AuthoredLaneWidth;
    private Transform _0xaf67506b;
    private const int StateRunning = 1;
    private void _0xc8e86169(bool _0x421679d6)
    {
        this._0x7c6b759d = _0x421679d6 ? StateWon : StateLost;
        int _0x15cd9b8b = Mathf.FloorToInt(this._0x556d705a);
        int _0xef74cbc0 = this._0xcb5edd78 + _0x15cd9b8b / 12;
        if (this._heat != null)
            this._heat._0xa9cef622();
        if (this._0xfe282164 != null && !_0x421679d6)
            this._0xfe282164._0xae6825d7();
        _0xe4e07605.BankRun(_0xef74cbc0, _0x15cd9b8b, _0x421679d6, this._0xb9dfa704);
        _0xd931f97e._0x0633db75._0x684309b9 = _0xd931f97e._0x0633db75._0x684309b9 + _0xef74cbc0;
        if (_0xc2255145.Instance != null)
            _0xc2255145.Instance._0xae3b7fed(false);
        int _0xdc7cd23f = this._0x278b9ac1 + 1;
        int _0x8b5d5311 = this._0xc8379f72;
        if (_0x421679d6)
            DOVirtual.DelayedCall(0.45f, () => this._0x049e9d5b(_0x15cd9b8b, _0xef74cbc0, _0xdc7cd23f)).SetLink(this.gameObject);
        else
            DOVirtual.DelayedCall(0.55f, () => this._0x70d2c90a(_0x15cd9b8b, _0x8b5d5311, _0xef74cbc0)).SetLink(this.gameObject);
    }

    private const float AuthoredLaneWidth = 1.3231f;
    private void Start()
    {
        this._0x14dfc159 = _0xe4e07605._0x51670660;
        this._0x278b9ac1 = _0xe4e07605._0x3db09e6c;
        this._0xc8379f72 = _0x2d32cceb.RidgeTarget(this._0x278b9ac1);
        this._0xba84e151 = _0x1934ccb4._0xeba2a78a;
        Camera _0xead5892a = Camera.main;
        this._0xf0fb850e = _0xead5892a != null && _0xead5892a.orthographic ? _0xead5892a.orthographicSize : 5f;
        float _0xbf81d7e2 = _0xead5892a != null && _0xead5892a.aspect > 0.01f ? _0xead5892a.aspect : 9f / 19.5f;
        float _0xefbc9343 = this._0xf0fb850e * _0xbf81d7e2;
        this._0x24b1e6d5 = 2f * _0xefbc9343 * _0x2d32cceb.BandFraction / _0x2d32cceb.LaneCount;
        this._0xaf67506b = new GameObject(_0xdf95f816._0x9f80ecae(new byte[10] { 156, 186, 169, 161, 164, 142, 161, 173, 164, 172 }, 200)).transform;
        this._0xaf67506b.position = Vector3.zero;
        if (this._generator != null)
            this._generator._0xad931c9e(this._0x278b9ac1, _0xe4e07605._0xba42b763, _0x2d32cceb.RidgeDensity(this._0x278b9ac1) * _0x1934ccb4.Density(this._0xba84e151));
        if (this._heat != null)
            this._heat._0x1b441c70(_0x1934ccb4.PassiveHeat(this._0xba84e151));
        if (this._scanner != null)
            this._scanner._0xa1a030a5();
        if (this._spawner != null)
        {
            this._spawner._0x41fd8fb8(this._0xaf67506b, this._0x24b1e6d5, this._0xf0fb850e);
            this._spawner._0x72a40b16(this._0x24b1e6d5 / AuthoredLaneWidth);
            this._spawner._0xf5ea1ba9();
        }

        this._0xf3679bf9();
        if (this._hud != null)
        {
            this._hud._0x23f475b6();
            this._hud._0xda729ec8(0f);
            this._hud._0xd35e2d73(0, this._0xc8379f72);
            this._hud._0x3681e537(0, this._0x278b9ac1 + 1);
            this._hud._0xc5b4e02f(_0xdf95f816._0x9f80ecae(new byte[5] { 133, 146, 150, 147, 142 }, 215), true);
        }

        this._0x7be9fc60 = _0x2d32cceb.CountInSeconds;
        this._0x7c6b759d = StateReady;
        {
#if B_LOGS
            {
                Debug.Log($"[run] ridge={this._0x278b9ac1} target={this._0xc8379f72} lane={this._0x24b1e6d5:0.000} halfH={this._0xf0fb850e:0.00}");
            }
#endif
        }
    }

    [SerializeField]
    private _0xa00fe4fd _scanner;
    private float _0x5043508f = _0x2d32cceb.BaseSpeed;
    private const int StateHeld = 2;
    [SerializeField]
    private _0xb7cdcffa _heat;
    [SerializeField]
    private _0x5b2e7d00 _spawner;
    [SerializeField]
    private _0xed3eb608 _generator;
    private _0xdd85a77b _0xfe282164;
    private void _0x2e4a449f(int count)
    {
        this._0xb9dfa704 += count;
        if (this._heat != null)
            this._heat._0xaf3193b7(_0x2d32cceb.HeatPerGeode * count);
        if (this._0xfe282164 != null)
            this._0xfe282164._0x4a27f52c();
        if (this._hud != null)
            this._hud._0x52655957(_0xdf95f816._0x9f80ecae(new byte[17] { 96, 98, 104, 99, 98, 7, 10, 7, 111, 98, 102, 115, 7, 99, 104, 112, 105 }, 39), _0xa72ebf9b.Cream, this._0x14dfc159);
    }

    private bool _0x14dfc159;
    private const int StateReady = 0;
    private void _0x05ffc4a9(float dt)
    {
        this._0x3d842448 += dt;
        if (!this._0x27879e8d && this._0x3d842448 >= _0x2d32cceb.WarmupSeconds - 6f)
        {
            this._0x27879e8d = true;
            if (this._generator != null)
                this._generator._0x56704358(false);
        }

        float _0x610853da = this._0xba84e151 == 4 ? 8f : _0x2d32cceb.SpeedCap;
        this._0x5043508f = Mathf.Min(_0x610853da, _0x2d32cceb.BaseSpeed + _0x2d32cceb.SpeedGain * this._0x3d842448);
        if (this._0xf2e12c35 > 0f)
        {
            this._0xf2e12c35 -= dt;
            this._0x5043508f *= _0x2d32cceb.HitSlowFactor;
        }

        float _0x5127830c = this._0x5043508f / _0x2d32cceb.MetresPerUnit * dt;
        this._0x556d705a += this._0x5043508f * dt;
        if (this._spawner != null)
            this._spawner._0x6f69d4e8(_0x5127830c);
        if (this._0xfe282164 != null)
            this._0xfe282164._0xe96a61c9(dt);
        if (this._heat != null)
            this._heat._0x2eb7b59f(dt);
        if (this._scanner != null && this._spawner != null && this._0xfe282164 != null)
        {
            int _0xac287e0b = this._scanner._0xe1a1c676;
            int _0xb7a005fa = this._scanner._0x64938a11;
            bool _0xce9a9c86 = this._scanner._0xe3ceceed(this._0xfe282164, this._spawner._0x6c855a8b, this._spawner._0xb89d3b60, _0x5127830c);
            if (_0xce9a9c86)
                this._0xc2444fe8();
            int _0x1f35bcb0 = this._scanner._0xe1a1c676 - _0xac287e0b;
            if (_0x1f35bcb0 > 0)
                this._0xe50235a8(_0x1f35bcb0);
            int _0x26c76bc3 = this._scanner._0x64938a11 - _0xb7a005fa;
            if (_0x26c76bc3 > 0)
                this._0x2e4a449f(_0x26c76bc3);
        }

        if (this._hud != null)
        {
            this._hud._0xda729ec8(this._heat != null ? this._heat._0x797b4bf8 : 0f);
            this._hud._0xd35e2d73(Mathf.FloorToInt(this._0x556d705a), this._0xc8379f72);
            this._hud._0x3681e537(this._0xcb5edd78, this._0x278b9ac1 + 1);
        }

        if (this._heat != null && this._heat._0x14660750)
        {
            this._0xc8e86169(false);
            return;
        }

        // The geode modifier is a SHORTCUT, never a second condition that could make
        // the ridge unreachable: the distance target always clears it as well (C.5).
        bool _0xad67384a = this._0x556d705a >= this._0xc8379f72 || (this._0xba84e151 == 5 && this._0xb9dfa704 >= 4);
        if (_0xad67384a)
            this._0xc8e86169(true);
    }

    private bool _0x27879e8d;
    public void _0xd34df33c(int _0x376ab10f)
    {
        if (this._0x7c6b759d != StateRunning || this._0xfe282164 == null)
            return;
        this._0xfe282164._0xa325a5f6(_0x376ab10f);
    }

    [SerializeField]
    private GameObject _heroPrefab;
    private float _0xf0fb850e = 5f;
    private void _0xc2444fe8()
    {
        if (this._heat != null)
            this._heat.Add(_0x2d32cceb.HeatPerHit);
        this._0xf2e12c35 = _0x2d32cceb.HitSlowSeconds;
        if (this._0xfe282164 != null)
            this._0xfe282164._0xdfd0e581();
        if (this._hud != null)
        {
            this._hud._0xfb94a3fa(this._0x14dfc159);
            this._hud._0x52655957(_0xdf95f816._0x9f80ecae(new byte[7] { 240, 224, 226, 239, 231, 230, 231 }, 163), _0xa72ebf9b.Danger, this._0x14dfc159);
        }
    }

    public void _0x04019c24()
    {
        if (_0xc2255145.Instance == null)
            return;
        _0xc2255145.Instance._0xae3b7fed(true);
        _0xc2255145.Instance._0x7e0b520e(_0xd931f97e._0x427a7181.SCENE_0);
    }
}

internal static class _0xdf95f816
{
    internal static string _0x9f80ecae(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}