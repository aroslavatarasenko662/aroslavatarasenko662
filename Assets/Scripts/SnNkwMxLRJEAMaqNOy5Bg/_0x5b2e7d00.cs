using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Puts rows of the generated trail into the world and recycles them once they have
/// scrolled past the bottom edge. Every object comes from a serialized prefab
/// reference; nothing is looked up by name and nothing is simulated.
/// </summary>
public sealed class _0x5b2e7d00 : MonoBehaviour
{
    private void _0xb04fe80c(float distance)
    {
        for (int _0xbb6592e4 = this._0xfe54a153.Count - 1; _0xbb6592e4 >= 0; _0xbb6592e4--)
        {
            _0xe13f674f _0x84d06ecf = this._0xfe54a153[_0xbb6592e4];
            if (_0x84d06ecf == null)
            {
                this._0xfe54a153.RemoveAt(_0xbb6592e4);
                continue;
            }

            Vector3 _0xc32d726d = _0x84d06ecf.transform.localPosition;
            _0xc32d726d.y -= distance;
            _0x84d06ecf.transform.localPosition = _0xc32d726d;
            if (_0xc32d726d.y < this._0xd061ae17)
            {
                this._0xfe54a153.RemoveAt(_0xbb6592e4);
                Destroy(_0x84d06ecf.gameObject);
            }
        }
    }

    public void _0x6f69d4e8(float distance)
    {
        if (!this._0x6244c907)
            return;
        this._0xe218bbb6(this._0xaa9a670f, distance);
        this._0x29b9546f(distance);
        this._0xb04fe80c(distance);
        this._0xd7773ae4 -= distance;
        this._0x29de4046();
    }

    private float _0xe88e672d;
    [SerializeField]
    private GameObject _geyserPrefab;
    private readonly List<Transform> _0xaa9a670f = new List<Transform>();
    [SerializeField]
    private GameObject _emberPrefab;
    private float _0xd7773ae4;
    private float _0xd061ae17;
    private readonly List<_0xe13f674f> _0xfe54a153 = new List<_0xe13f674f>();
    public void _0x41fd8fb8(Transform _0xc33c552c, float _0xa80b7dc3, float _0xb716418a)
    {
        if (this._0x6244c907)
            return;
        this._0xb43e1553 = _0xc33c552c;
        this._0xe88e672d = _0xa80b7dc3;
        this._0x2e151de3 = _0xb716418a + 1.3f;
        this._0xd061ae17 = -_0xb716418a - 1.6f;
        this._0xd7773ae4 = this._0xd061ae17 + 0.7f;
        this._0x6244c907 = true;
    }

    private readonly List<_0x75caf696> _0x19581ed5 = new List<_0x75caf696>();
    private Transform _0xb43e1553;
    public void _0x94f48175()
    {
        for (int _0x7d35d0d5 = 0; _0x7d35d0d5 < this._0xaa9a670f.Count; _0x7d35d0d5++)
            if (this._0xaa9a670f[_0x7d35d0d5] != null)
                Destroy(this._0xaa9a670f[_0x7d35d0d5].gameObject);
        for (int _0x4d2ee8b0 = 0; _0x4d2ee8b0 < this._0x19581ed5.Count; _0x4d2ee8b0++)
            if (this._0x19581ed5[_0x4d2ee8b0] != null)
                Destroy(this._0x19581ed5[_0x4d2ee8b0].gameObject);
        for (int _0x0561ab05 = 0; _0x0561ab05 < this._0xfe54a153.Count; _0x0561ab05++)
            if (this._0xfe54a153[_0x0561ab05] != null)
                Destroy(this._0xfe54a153[_0x0561ab05].gameObject);
        this._0xaa9a670f.Clear();
        this._0x19581ed5.Clear();
        this._0xfe54a153.Clear();
        this._0xd7773ae4 = this._0xd061ae17 + 0.7f;
    }

    public IList<_0x75caf696> _0x6c855a8b
    {
        get
        {
            return this._0x19581ed5;
        }
    }

    [SerializeField]
    private GameObject _tilePrefab;
    /// <summary>
    /// The prefabs are authored for the reference lane width; this is the ratio
    /// between that and the lane width the real camera gives us, so every sliced
    /// size stays camera-derived on any device (C.0).
    /// </summary>
    public void _0x72a40b16(float _0x9c9de339)
    {
        this._0x2c1b3270 = Mathf.Clamp(_0x9c9de339, 0.5f, 2f);
    }

    [SerializeField]
    private GameObject _tileCrustPrefab;
    private void _0x8e63c3d5(GameObject _0x47d907d4, float _0xec187da1, float _0x6c3f4bbd, float _0x3dc5faae, float _0x2804254f, int _0xa051d493)
    {
        if (_0x47d907d4 == null)
            return;
        GameObject _0xcf6998a2 = Instantiate(_0x47d907d4, this._0xb43e1553);
        _0xcf6998a2.transform.localPosition = new Vector3(_0xec187da1, _0x6c3f4bbd, 0f);
        this._0x30e97d20(_0xcf6998a2);
        _0xe13f674f _0x59fb42fe = _0xcf6998a2.GetComponent<_0xe13f674f>();
        if (_0x59fb42fe == null)
            _0x59fb42fe = _0xcf6998a2.AddComponent<_0xe13f674f>();
        _0x59fb42fe._0xab2ddf33(_0x3dc5faae * this._0xe88e672d / 1.32f, _0x2804254f, _0xa051d493);
        this._0xfe54a153.Add(_0x59fb42fe);
    }

    /// <summary>Applies the camera ratio to a spawned object, uniformly (F.2a).</summary>
    public void _0x30e97d20(GameObject _0xd5ea8dd4)
    {
        if (_0xd5ea8dd4 == null || Mathf.Abs(this._0x2c1b3270 - 1f) < 0.001f)
            return;
        SpriteRenderer[] _0x42de5758 = _0xd5ea8dd4.GetComponentsInChildren<SpriteRenderer>(true);
        for (int _0x03b4d8f2 = 0; _0x03b4d8f2 < _0x42de5758.Length; _0x03b4d8f2++)
        {
            SpriteRenderer _0xd1eed9e2 = _0x42de5758[_0x03b4d8f2];
            if (_0xd1eed9e2 == null || _0xd1eed9e2.drawMode == SpriteDrawMode.Simple)
                continue;
            _0xd1eed9e2.size = _0xd1eed9e2.size * this._0x2c1b3270;
        }
    }

    [SerializeField]
    private GameObject _laneMarkerPrefab;
    private bool _0x6244c907;
    private void _0x29de4046()
    {
        int _0x87f2cee3 = 0;
        while (this._0xd7773ae4 + _0x2d32cceb.RowSpacing <= this._0x2e151de3 && _0x87f2cee3 < 64)
        {
            this._0x42dc813e();
            _0x87f2cee3++;
        }
    }

    private void _0x4b5a5cc6(GameObject _0x3b376bae, float _0xee6aa0d8, float _0x154fb28e, float _0x670d40f3, float _0xd1d545a6, int _0xbcbb9b3e)
    {
        if (_0x3b376bae == null)
            return;
        GameObject _0x663a264b = Instantiate(_0x3b376bae, this._0xb43e1553);
        _0x663a264b.transform.localPosition = new Vector3(_0xee6aa0d8, _0x154fb28e, 0f);
        this._0x30e97d20(_0x663a264b);
        _0x75caf696 _0xcfb94626 = _0x663a264b.GetComponent<_0x75caf696>();
        if (_0xcfb94626 == null)
            _0xcfb94626 = _0x663a264b.AddComponent<_0x75caf696>();
        _0xcfb94626._0xe16b8c64(_0x670d40f3 * this._0xe88e672d / 1.32f, _0xd1d545a6, _0xbcbb9b3e);
        this._0x19581ed5.Add(_0xcfb94626);
    }

    [SerializeField]
    private _0xed3eb608 _generator;
    private readonly int[] _0xed6e8348 = new int[_0x2d32cceb.LaneCount];
    /// <summary>Fills the screen before the first frame the player sees.</summary>
    public void _0xf5ea1ba9()
    {
        this._0x29de4046();
    }

    public IList<_0xe13f674f> _0xb89d3b60
    {
        get
        {
            return this._0xfe54a153;
        }
    }

    [SerializeField]
    private GameObject _cinderPrefab;
    private float _0x2e151de3;
    private void _0x42dc813e()
    {
        if (this._generator == null || this._0xb43e1553 == null)
            return;
        bool _0x77e2a243;
        if (!this._generator._0x7b788507(this._0xed6e8348, out _0x77e2a243))
            return;
        float _0xc9133af7 = this._0xd7773ae4 + _0x2d32cceb.RowSpacing;
        for (int _0x7f3fa1e2 = 0; _0x7f3fa1e2 < _0x2d32cceb.LaneCount; _0x7f3fa1e2++)
        {
            float _0xd1a0db60 = (_0x7f3fa1e2 - 1) * this._0xe88e672d;
            GameObject _0xab2993f4 = _0x77e2a243 && this._tileCrustPrefab != null ? this._tileCrustPrefab : this._tilePrefab;
            this._0xc0d37ec0(_0xab2993f4, _0xd1a0db60, _0xc9133af7, this._0xaa9a670f);
            int _0x89c7be54 = this._0xed6e8348[_0x7f3fa1e2];
            switch (_0x89c7be54)
            {
                case _0x63083ceb.Geyser:
                    this._0x4b5a5cc6(this._geyserPrefab, _0xd1a0db60, _0xc9133af7, 0.44f, 0.72f, 0);
                    break;
                case _0x63083ceb.Cinder:
                    this._0x4b5a5cc6(this._cinderPrefab, _0xd1a0db60, _0xc9133af7, 0.32f, 0.32f, 1);
                    break;
                case _0x63083ceb.Ember:
                    this._0x8e63c3d5(this._emberPrefab, _0xd1a0db60, _0xc9133af7, 0.30f, 0.30f, 0);
                    break;
                case _0x63083ceb.Geode:
                    this._0x8e63c3d5(this._geodePrefab, _0xd1a0db60, _0xc9133af7, 0.36f, 0.36f, 1);
                    break;
                default:
                    this._0xc0d37ec0(this._laneMarkerPrefab, _0xd1a0db60, _0xc9133af7, this._0xaa9a670f);
                    break;
            }
        }

        this._0xd7773ae4 = _0xc9133af7;
    }

    private void _0x29b9546f(float distance)
    {
        for (int _0xcfe4418a = this._0x19581ed5.Count - 1; _0xcfe4418a >= 0; _0xcfe4418a--)
        {
            _0x75caf696 _0xea5dc2e2 = this._0x19581ed5[_0xcfe4418a];
            if (_0xea5dc2e2 == null)
            {
                this._0x19581ed5.RemoveAt(_0xcfe4418a);
                continue;
            }

            Vector3 _0x648d36e4 = _0xea5dc2e2.transform.localPosition;
            _0x648d36e4.y -= distance;
            _0xea5dc2e2.transform.localPosition = _0x648d36e4;
            if (_0x648d36e4.y < this._0xd061ae17)
            {
                this._0x19581ed5.RemoveAt(_0xcfe4418a);
                Destroy(_0xea5dc2e2.gameObject);
            }
        }
    }

    [SerializeField]
    private GameObject _geodePrefab;
    private void _0xc0d37ec0(GameObject _0x34d21ddb, float _0xca22107e, float _0x991bf01a, List<Transform> _0x60e76e37)
    {
        if (_0x34d21ddb == null)
            return;
        GameObject _0x8cfff6c4 = Instantiate(_0x34d21ddb, this._0xb43e1553);
        _0x8cfff6c4.transform.localPosition = new Vector3(_0xca22107e, _0x991bf01a, 0f);
        this._0x30e97d20(_0x8cfff6c4);
        _0x60e76e37.Add(_0x8cfff6c4.transform);
    }

    private float _0x2c1b3270 = 1f;
    private void _0xe218bbb6(List<Transform> _0x18d231f0, float distance)
    {
        for (int _0x4ab0d569 = _0x18d231f0.Count - 1; _0x4ab0d569 >= 0; _0x4ab0d569--)
        {
            Transform _0xd8671091 = _0x18d231f0[_0x4ab0d569];
            if (_0xd8671091 == null)
            {
                _0x18d231f0.RemoveAt(_0x4ab0d569);
                continue;
            }

            Vector3 _0x7256bce1 = _0xd8671091.localPosition;
            _0x7256bce1.y -= distance;
            _0xd8671091.localPosition = _0x7256bce1;
            if (_0x7256bce1.y < this._0xd061ae17)
            {
                _0x18d231f0.RemoveAt(_0x4ab0d569);
                Destroy(_0xd8671091.gameObject);
            }
        }
    }
}