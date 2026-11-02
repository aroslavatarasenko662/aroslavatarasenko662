using UnityEngine;

/// <summary>
/// The only thing that ends a run. It climbs on its own and is pushed back down by
/// embers and geodes, so the goal stays reachable (C.5).
/// </summary>
public sealed class _0xb7cdcffa : MonoBehaviour
{
    public void _0xa9cef622()
    {
        this._0x3c032ee8 = true;
    }

    public float _0x797b4bf8
    {
        get
        {
            return Mathf.Clamp01(this._0x12b83319 / _0x2d32cceb.HeatMax);
        }
    }

    public bool _0x14660750
    {
        get
        {
            return this._0x12b83319 >= _0x2d32cceb.HeatMax;
        }
    }

    public void _0xaf3193b7(float _0x749e09f0)
    {
        this._0x12b83319 = Mathf.Clamp(this._0x12b83319 - Mathf.Abs(_0x749e09f0), 0f, _0x2d32cceb.HeatMax);
    }

    public void Add(float _0xa5c65495)
    {
        this._0x12b83319 = Mathf.Clamp(this._0x12b83319 + _0xa5c65495, 0f, _0x2d32cceb.HeatMax);
    }

    private float _0x12b83319;
    public void _0x2eb7b59f(float dt)
    {
        if (this._0x3c032ee8)
            return;
        this._0x12b83319 = Mathf.Clamp(this._0x12b83319 + this._0x583cea79 * dt, 0f, _0x2d32cceb.HeatMax);
    }

    public void _0xbf35b5bd()
    {
        this._0x3c032ee8 = false;
    }

    public float _0xc31049c7
    {
        get
        {
            return this._0x12b83319;
        }
    }

    private float _0x583cea79 = _0x2d32cceb.HeatPassive;
    private bool _0x3c032ee8 = true;
    public _0xb7cdcffa _0x1b441c70(float _0x40c11160)
    {
        this._0x12b83319 = 0f;
        this._0x583cea79 = Mathf.Max(0.05f, _0x40c11160);
        this._0x3c032ee8 = true;
        return this;
    }
}