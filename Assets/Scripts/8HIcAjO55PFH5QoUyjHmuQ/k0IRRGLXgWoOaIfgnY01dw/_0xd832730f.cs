using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xd832730f : MonoBehaviour
{
    private float _0x225491b8 = 4;
    private float _0x5ba22694;
    private AspectRatioFitter _0x1391a4db;
    private TMP_Text _0x3ea879dc;
    private float _0xb1568e3f = 0.6f;
    private void Update()
    {
        int _0x7f7bd6ac = 1;
        if (this._0xa8c5527c.Count > 0)
        {
            string _0x608c55df = this._0x3ea879dc.text;
            foreach (string _0x653c6219 in this._0xa8c5527c)
                while (_0x608c55df.Contains(_0x653c6219))
                    _0x608c55df = _0x608c55df.Replace(_0x653c6219, "");
            _0x7f7bd6ac = _0x608c55df.Length;
        }
        else
        {
            _0x7f7bd6ac = this._0x3ea879dc.text.Length;
        }

        float _0xea508e69 = Mathf.Clamp(this._0x5ba22694 + this._0xb1568e3f * _0x7f7bd6ac, this._0x6fac899a, this._0x225491b8);
        if (!Mathf.Approximately(this._0x1391a4db.aspectRatio, _0xea508e69))
            this._0x1391a4db.aspectRatio = _0xea508e69;
    }

    private List<string> _0xa8c5527c = new();
    private float _0x6fac899a = 1.5f;
}