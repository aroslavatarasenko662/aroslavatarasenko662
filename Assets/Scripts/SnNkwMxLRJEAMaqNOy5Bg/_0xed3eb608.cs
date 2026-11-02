using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds the ridge from seeded chunks and proves every chunk is walkable before it
/// is handed out (C.11). Nothing about the layout is written as constants except the
/// fallback chunk, which exists only for the case where twenty draws all fail.
/// </summary>
public sealed class _0xed3eb608 : MonoBehaviour
{
    private readonly bool[] _0x68423461 = new bool[Lanes];
    /// <summary>The warm-up only serves calm chunks, with the centre lane kept open.</summary>
    public void _0x56704358(bool _0x6b7b3b6f)
    {
        this._0x627b10fd = _0x6b7b3b6f;
    }

    /// <summary>Fills three lane codes and says whether the row is pale crust.</summary>
    public bool _0x7b788507(int[] _0x20fb257e, out bool _0x8fc40b92)
    {
        _0x8fc40b92 = false;
        if (_0x20fb257e == null || _0x20fb257e.Length < Lanes)
            return false;
        this._0xd2706cec();
        while (this._0x5820b2c0 * Lanes >= this._0x4e3700aa.Count)
            this._0x0a7de4fb();
        int _0x6dd2760e = this._0x5820b2c0 * Lanes;
        for (int _0x3e8852da = 0; _0x3e8852da < Lanes; _0x3e8852da++)
            _0x20fb257e[_0x3e8852da] = this._0x4e3700aa[_0x6dd2760e + _0x3e8852da];
        _0x8fc40b92 = this._0x07715d68[this._0x5820b2c0];
        this._0x5820b2c0++;
        return true;
    }

    public void _0xad931c9e(int _0x3f680b6a, int _0x20141c18, float _0x5f281d14)
    {
        int _0xb2ca357a = (_0x3f680b6a * 7919) ^ (_0x20141c18 * 104729);
        this._0x73113bf2 = new System.Random(_0xb2ca357a);
        this._0xfd7dfca2 = Mathf.Clamp(_0x5f281d14, 0.6f, 2f);
        this._0x627b10fd = true;
        this._0x5820b2c0 = 0;
        this._0x11a25115 = true;
        this._0x4e3700aa.Clear();
        this._0x07715d68.Clear();
        this._0x4138ef5c.Clear();
        this._0x4138ef5c.Add(1);
        for (int _0xdf36a21c = 0; _0xdf36a21c < Lanes; _0xdf36a21c++)
            this._0x68423461[_0xdf36a21c] = false;
        {
#if B_LOGS
            {
                Debug.Log($"[ridge] seed={_0xb2ca357a} ridge={_0x3f680b6a} attempt={_0x20141c18} density={this._0xfd7dfca2:0.00}");
            }
#endif
        }
    }

    private int _0x5820b2c0;
    public void _0xd2706cec()
    {
        if (this._0x11a25115)
            return;
        this._0xad931c9e(0, 0, 1f);
    }

    private System.Random _0x73113bf2;
    private bool _0x627b10fd = true;
    private int _0x5df38d9c()
    {
        if (this._0x627b10fd)
            return this._0x73113bf2.Next(0, 2) == 0 ? _0x63083ceb.OpenRun : _0x63083ceb.EmberArc;
        int _0x90dca4ac = 0;
        int[] _0x94eacfa8 = new int[_0x63083ceb.Count];
        for (int _0x77f08f6d = 0; _0x77f08f6d < _0x63083ceb.Count; _0x77f08f6d++)
        {
            int _0xdd884d3f = _0x63083ceb.IsCalm(_0x77f08f6d) ? 20 : Mathf.RoundToInt(22f * this._0xfd7dfca2);
            _0x94eacfa8[_0x77f08f6d] = Mathf.Max(1, _0xdd884d3f);
            _0x90dca4ac += _0x94eacfa8[_0x77f08f6d];
        }

        int _0x6dea787d = this._0x73113bf2.Next(0, _0x90dca4ac);
        for (int _0xa67ff530 = 0; _0xa67ff530 < _0x94eacfa8.Length; _0xa67ff530++)
        {
            _0x6dea787d -= _0x94eacfa8[_0xa67ff530];
            if (_0x6dea787d < 0)
                return _0xa67ff530;
        }

        return _0x63083ceb.OpenRun;
    }

    private void _0xf13f8b7b(int[] _0x069e5ba7)
    {
        List<int> _0xe1c61e4f = new List<int>(this._0x4138ef5c);
        int _0x2a5c29e8 = _0x069e5ba7.Length / Lanes;
        for (int _0xc4cc8588 = 0; _0xc4cc8588 < _0x2a5c29e8; _0xc4cc8588++)
        {
            List<int> _0x43702f7c = new List<int>();
            for (int _0x1b740b1b = 0; _0x1b740b1b < Lanes; _0x1b740b1b++)
            {
                int _0x7e680421 = _0x069e5ba7[_0xc4cc8588 * Lanes + _0x1b740b1b];
                if (_0x7e680421 == _0x63083ceb.Geyser || _0x7e680421 == _0x63083ceb.Cinder)
                    continue;
                for (int _0x2aba9881 = 0; _0x2aba9881 < _0xe1c61e4f.Count; _0x2aba9881++)
                {
                    if (Mathf.Abs(_0xe1c61e4f[_0x2aba9881] - _0x1b740b1b) <= 1)
                    {
                        _0x43702f7c.Add(_0x1b740b1b);
                        break;
                    }
                }
            }

            if (_0x43702f7c.Count > 0)
                _0xe1c61e4f = _0x43702f7c;
        }

        this._0x4138ef5c.Clear();
        for (int _0x3db80e7c = 0; _0x3db80e7c < _0xe1c61e4f.Count; _0x3db80e7c++)
            this._0x4138ef5c.Add(_0xe1c61e4f[_0x3db80e7c]);
    }

    /// <summary>
    /// Applies the run's density to a drawn chunk: thin the hazards out on an easy
    /// ridge, add one on a dense one, and never let a row block all three lanes.
    /// </summary>
    private int[] _0xd15a82e4(int[] _0x3a855c14)
    {
        int _0xb7e7b9a9 = _0x3a855c14.Length / Lanes;
        for (int _0xab0c1192 = 0; _0xab0c1192 < _0xb7e7b9a9; _0xab0c1192++)
        {
            int _0x523e330e = 0;
            for (int _0xa3079c28 = 0; _0xa3079c28 < Lanes; _0xa3079c28++)
            {
                int _0xdcd125dd = _0xab0c1192 * Lanes + _0xa3079c28;
                int _0x1597cbcc = _0x3a855c14[_0xdcd125dd];
                bool _0xafae2db1 = _0x1597cbcc == _0x63083ceb.Geyser || _0x1597cbcc == _0x63083ceb.Cinder;
                if (_0xafae2db1 && this._0xfd7dfca2 < 1f && this._0x73113bf2.NextDouble() > this._0xfd7dfca2)
                {
                    _0x3a855c14[_0xdcd125dd] = _0x63083ceb.Empty;
                    _0x1597cbcc = _0x63083ceb.Empty;
                    _0xafae2db1 = false;
                }

                if (_0xafae2db1)
                    _0x523e330e++;
            }

            // Extra pressure on a dense ridge goes into a SIDE lane: the middle of the
            // trail is the line a player holds while reading the rows ahead.
            if (this._0xfd7dfca2 > 1f && _0x523e330e == 0 && this._0x73113bf2.NextDouble() < (this._0xfd7dfca2 - 1f) * 1.6f)
            {
                int _0x19722ca7 = this._0x73113bf2.Next(0, 2) == 0 ? 0 : 2;
                _0x3a855c14[_0xab0c1192 * Lanes + _0x19722ca7] = this._0x73113bf2.Next(0, 2) == 0 ? _0x63083ceb.Geyser : _0x63083ceb.Cinder;
                _0x523e330e++;
            }

            if (_0x523e330e >= Lanes)
                _0x3a855c14[_0xab0c1192 * Lanes + this._0x73113bf2.Next(0, Lanes)] = _0x63083ceb.Empty;
            if (this._0x627b10fd)
            {
                int _0x217fe1a9 = _0xab0c1192 * Lanes + 1;
                if (_0x3a855c14[_0x217fe1a9] == _0x63083ceb.Geyser || _0x3a855c14[_0x217fe1a9] == _0x63083ceb.Cinder)
                    _0x3a855c14[_0x217fe1a9] = _0x63083ceb.Empty;
            }

            // NO LANE IS BLOCKED IN TWO ROWS RUNNING. This is what bounds the worst case
            // of a run with no taps at all to one scald every other row, which is what
            // keeps the baseline past 60 s (C.5) - and it reads as fair play, not mercy.
            for (int _0xed5733a8 = 0; _0xed5733a8 < Lanes; _0xed5733a8++)
            {
                int _0x0d73cd0a = _0xab0c1192 * Lanes + _0xed5733a8;
                bool _0xb6a2866f = _0x3a855c14[_0x0d73cd0a] == _0x63083ceb.Geyser || _0x3a855c14[_0x0d73cd0a] == _0x63083ceb.Cinder;
                if (_0xb6a2866f && this._0x68423461[_0xed5733a8])
                {
                    _0x3a855c14[_0x0d73cd0a] = _0x63083ceb.Empty;
                    _0xb6a2866f = false;
                }

                this._0x68423461[_0xed5733a8] = _0xb6a2866f;
            }
        }

        return _0x3a855c14;
    }

    private void _0x0a7de4fb()
    {
        // A rejected draw must not leave its "which lane was blocked last row" trail
        // behind, so the carry is restored before every attempt.
        bool[] _0xe4ce8b95 = new bool[Lanes];
        for (int _0xcfb417a5 = 0; _0xcfb417a5 < Lanes; _0xcfb417a5++)
            _0xe4ce8b95[_0xcfb417a5] = this._0x68423461[_0xcfb417a5];
        int[] _0xab1d691f = null;
        int _0xbcd0d5dc = _0x63083ceb.OpenRun;
        for (int _0x8efc3cd2 = 0; _0x8efc3cd2 < MaxDraws; _0x8efc3cd2++)
        {
            for (int _0xdc601322 = 0; _0xdc601322 < Lanes; _0xdc601322++)
                this._0x68423461[_0xdc601322] = _0xe4ce8b95[_0xdc601322];
            int _0x9bdbcade = this._0x5df38d9c();
            int[] _0xe7c66211 = this._0xd15a82e4(_0x63083ceb.Rows(_0x9bdbcade));
            if (this._0x5cd5d792(_0xe7c66211))
            {
                _0xab1d691f = _0xe7c66211;
                _0xbcd0d5dc = _0x9bdbcade;
                break;
            }
        }

        if (_0xab1d691f == null)
        {
            _0xbcd0d5dc = _0x63083ceb.OpenRun;
            _0xab1d691f = _0x63083ceb.Rows(_0xbcd0d5dc);
            for (int _0xa85d27c7 = 0; _0xa85d27c7 < Lanes; _0xa85d27c7++)
                this._0x68423461[_0xa85d27c7] = false;
        }

        bool _0x79a3ea71 = _0x63083ceb.IsCrust(_0xbcd0d5dc);
        this._0xf13f8b7b(_0xab1d691f);
        for (int _0x360c1ca7 = 0; _0x360c1ca7 < _0xab1d691f.Length / Lanes; _0x360c1ca7++)
            this._0x07715d68.Add(_0x79a3ea71);
        for (int _0x8b96a255 = 0; _0x8b96a255 < _0xab1d691f.Length; _0x8b96a255++)
            this._0x4e3700aa.Add(_0xab1d691f[_0x8b96a255]);
    }

    private readonly List<int> _0x4138ef5c = new List<int>();
    private readonly List<int> _0x4e3700aa = new List<int>();
    private const int Lanes = _0x2d32cceb.LaneCount;
    private const int MaxDraws = 20;
    private float _0xfd7dfca2 = 1f;
    private readonly List<bool> _0x07715d68 = new List<bool>();
    private bool _0x11a25115;
    /// <summary>A greedy lane walker must get through with zero forced hits.</summary>
    private bool _0x5cd5d792(int[] _0xfa9e3d88)
    {
        List<int> _0x88bdf04e = new List<int>(this._0x4138ef5c);
        int _0xb6e012b1 = _0xfa9e3d88.Length / Lanes;
        for (int _0x20b0df43 = 0; _0x20b0df43 < _0xb6e012b1; _0x20b0df43++)
        {
            List<int> _0xfddbfc16 = new List<int>();
            for (int _0x7c39419f = 0; _0x7c39419f < Lanes; _0x7c39419f++)
            {
                int _0x1a3232b7 = _0xfa9e3d88[_0x20b0df43 * Lanes + _0x7c39419f];
                if (_0x1a3232b7 == _0x63083ceb.Geyser || _0x1a3232b7 == _0x63083ceb.Cinder)
                    continue;
                bool _0x924ec133 = false;
                for (int _0xd18ab288 = 0; _0xd18ab288 < _0x88bdf04e.Count; _0xd18ab288++)
                {
                    if (Mathf.Abs(_0x88bdf04e[_0xd18ab288] - _0x7c39419f) <= 1)
                    {
                        _0x924ec133 = true;
                        break;
                    }
                }

                if (_0x924ec133)
                    _0xfddbfc16.Add(_0x7c39419f);
            }

            if (_0xfddbfc16.Count == 0)
                return false;
            _0x88bdf04e = _0xfddbfc16;
        }

        return true;
    }
}