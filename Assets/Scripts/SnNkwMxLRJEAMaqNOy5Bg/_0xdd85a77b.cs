using DG.Tweening;
using UnityEngine;

/// <summary>
/// The wanderer. Lane position is script kinematics plus one tween per step; there
/// is no simulated body anywhere in this game, so nothing else moves this transform.
/// </summary>
public sealed class _0xdd85a77b : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
        if (this._body != null)
            DOTween.Kill(this._body, false);
        if (this._glow != null)
            DOTween.Kill(this._glow, false);
    }

    private float _0x407e4d01;
    private int _0xa3382e5d = 1;
    private float _0x91337839 = 0.44f;
    private bool _0xc6298f3e;
    [SerializeField]
    private SpriteRenderer _body;
    public void _0xe96a61c9(float dt)
    {
        if (this._0x407e4d01 > 0f)
            this._0x407e4d01 -= dt;
        if (this._0x1aeb499a > 0f)
        {
            this._0x1aeb499a -= dt;
            if (this._0x1aeb499a <= 0f && this._body != null)
                this._body.color = Color.white;
        }
    }

    private float _0xfff9248f = 0.50f;
    public float _0xbc92a57b
    {
        get
        {
            return this._0x91337839;
        }
    }

    public float _0x66948d06
    {
        get
        {
            return this._0xfff9248f;
        }
    }

    [SerializeField]
    private SpriteRenderer _glow;
    private float _0x20a25f80 = 1.32f;
    private float _0x1aeb499a;
    public int _0x594dec50
    {
        get
        {
            return this._0xa3382e5d;
        }
    }

    public void _0xdfd0e581()
    {
        this._0x1aeb499a = _0x2d32cceb.InvulnerableSeconds;
        if (this._body == null)
            return;
        this._body.color = _0xa72ebf9b.Danger;
        if (this._0xc6298f3e)
            return;
        this._body.DOColor(Color.white, 0.22f).SetLoops(2, LoopType.Yoyo).SetLink(this._body.gameObject);
    }

    public bool _0x06d4bbfd
    {
        get
        {
            return this._0x1aeb499a > 0f;
        }
    }

    public void _0x4a27f52c()
    {
        if (this._glow == null)
            return;
        this._glow.color = _0xa72ebf9b.Ember;
        if (this._0xc6298f3e)
            return;
        this._glow.DOColor(_0xa72ebf9b.Magma, 0.32f).SetLink(this._glow.gameObject);
    }

    public _0xdd85a77b _0xa1246c56(float _0x9d3ae8ef, bool _0xcf6c6da4)
    {
        this._0x20a25f80 = _0x9d3ae8ef;
        this._0xc6298f3e = _0xcf6c6da4;
        this._0x91337839 = _0x9d3ae8ef * 0.33f;
        this._0xfff9248f = _0x9d3ae8ef * 0.38f;
        this._0xa3382e5d = 1;
        this._0x407e4d01 = 0f;
        this._0x1aeb499a = 0f;
        Vector3 _0x3d5fa609 = this.transform.localPosition;
        _0x3d5fa609.x = 0f;
        this.transform.localPosition = _0x3d5fa609;
        return this;
    }

    public bool _0xa325a5f6(int _0x18b1106e)
    {
        if (this._0x407e4d01 > 0f)
            return false;
        int _0x747dbe35 = Mathf.Clamp(this._0xa3382e5d + (_0x18b1106e > 0 ? 1 : -1), 0, _0x2d32cceb.LaneCount - 1);
        if (_0x747dbe35 == this._0xa3382e5d)
            return false;
        this._0xa3382e5d = _0x747dbe35;
        this._0x407e4d01 = _0x2d32cceb.LaneStepSeconds + _0x2d32cceb.LaneStepCooldown;
        float _0xc73970ac = (this._0xa3382e5d - 1) * this._0x20a25f80;
        DOTween.Kill(this.transform, false);
        this.transform.DOLocalMoveX(_0xc73970ac, _0x2d32cceb.LaneStepSeconds).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        return true;
    }

    public void _0xae6825d7()
    {
        if (this._body != null)
            this._body.DOColor(_0xa72ebf9b.Danger, 0.35f).SetLink(this._body.gameObject);
        if (this._glow != null)
            this._glow.DOColor(_0xa72ebf9b.Danger, 0.35f).SetLink(this._glow.gameObject);
    }
}