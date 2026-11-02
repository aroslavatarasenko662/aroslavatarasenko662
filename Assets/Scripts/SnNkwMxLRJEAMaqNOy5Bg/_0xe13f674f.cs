using UnityEngine;

/// <summary>Ember (kind 0) or frost geode (kind 1), with its own pickup box.</summary>
public sealed class _0xe13f674f : MonoBehaviour
{
    public bool _0x8180b507 { get; private set; }

    [SerializeField]
    private int _kind;
    public void _0x5350da0d()
    {
        this._0x8180b507 = false;
    }

    public void _0x05f14d85()
    {
        this._0x8180b507 = true;
    }

    public float _0x38808bf9
    {
        get
        {
            return this._halfWidth;
        }
    }

    [SerializeField]
    private float _halfHeight = 0.32f;
    public int _0xcd11d843
    {
        get
        {
            return this._kind;
        }
    }

    public float _0x64499c78
    {
        get
        {
            return this._halfHeight;
        }
    }

    [SerializeField]
    private float _halfWidth = 0.32f;
    public _0xe13f674f _0xab2ddf33(float _0x26d8f1e9, float _0xcf989f7a, int _0x17da738e)
    {
        this._halfWidth = _0x26d8f1e9;
        this._halfHeight = _0xcf989f7a;
        this._kind = _0x17da738e;
        this._0x8180b507 = false;
        return this;
    }
}