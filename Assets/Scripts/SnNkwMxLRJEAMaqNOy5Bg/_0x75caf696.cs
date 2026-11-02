using UnityEngine;

/// <summary>
/// What a spawned hazard is and how big it is. The run uses an arithmetical
/// overlap test against these half-extents; nothing here is simulated.
/// </summary>
public sealed class _0x75caf696 : MonoBehaviour
{
    public int _0x7545d786
    {
        get
        {
            return this._kind;
        }
    }

    [SerializeField]
    private int _kind;
    [SerializeField]
    private float _halfHeight = 0.52f;
    [SerializeField]
    private float _halfWidth = 0.40f;
    public float _0xe98bc2b2
    {
        get
        {
            return this._halfWidth;
        }
    }

    public float _0xb94646fa
    {
        get
        {
            return this._halfHeight;
        }
    }

    public _0x75caf696 _0xe16b8c64(float _0x1ffda1b5, float _0x77d296f0, int _0x1eba3cd0)
    {
        this._halfWidth = _0x1ffda1b5;
        this._halfHeight = _0x77d296f0;
        this._kind = _0x1eba3cd0;
        return this;
    }
}