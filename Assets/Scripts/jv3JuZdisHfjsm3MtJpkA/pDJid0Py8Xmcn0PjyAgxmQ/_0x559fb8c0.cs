using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xd931f97e;

public class _0x559fb8c0 : MonoBehaviour
{
    private void _0xad84591b(int _0x895df54b)
    {
        this.LastPanelIndexes.Add(_0x895df54b);
        this.CurrentPanelIndex = _0x895df54b;
        for (int _0x0be54ce5 = 0; _0x0be54ce5 < this.Panels.Count; _0x0be54ce5++)
            if (_0x0be54ce5 != _0x895df54b && this.Panels[_0x0be54ce5] != null)
                this.Panels[_0x0be54ce5]._0xeb64bd72();
    }

    public void _0x6fddb199(int _0x6fc554bc)
    {
        this._0xad84591b(_0x6fc554bc);
        this._0xe5d5a0d3(_0x6fc554bc);
        this.CurrentPanelIndex = _0x6fc554bc;
        this.Panels[_0x6fc554bc].Show();
    }

    private void SwitchSplash()
    {
        if (_0x75fcf5ad.Instance.IsTutorialEnabled && !_0xc2255145._0xe6c2f64d._0x23af6f78)
            this._0x6fddb199(_0xfa1e82e0.TUTORIAL0);
        else
            this._0x6fddb199(_0xfa1e82e0.DEFAULT);
    }

    private _0x8d60e39f _0x815bb0df(int _0xdd326515)
    {
        return this.Panels[_0xdd326515];
    }

    public List<_0x8d60e39f> Panels;
    private void _0x8ecd1207(int _0x2af351b8)
    {
        this._0xad84591b(_0x2af351b8);
        this._0xe5d5a0d3(_0x2af351b8);
        this.CurrentPanelIndex = _0x2af351b8;
        this.Panels[_0x2af351b8]._0x58c81767();
    }

    public bool IsShowSplashOnStart = true;
    public void _0xbc804e90()
    {
        this.LastPanelIndexes.RemoveAll(_0x951938f5 => _0x951938f5 == this.CurrentPanelIndex);
        int _0x9b60a9dd = this.LastPanelIndexes.Last();
        this._0xe5d5a0d3(_0x9b60a9dd);
        this._0x79bea4f7(_0x9b60a9dd);
        this.CurrentPanelIndex = _0x9b60a9dd;
        this.Panels[_0x9b60a9dd].Show();
    }

    public int CurrentPanelIndex;
    public float StaticBlurMaterialInitialValue;
    public float ScaleDuration = 0.4f;
    private void _0xe5d5a0d3(int _0x4433448c)
    {
        if (_0x4433448c == _0xfa1e82e0.SPLASH)
            _0xe285f25e.Instance._0x19cf9d09();
        if (_0xc2255145.Instance._0xadc97912 == _0x427a7181.SCENE_0)
        {
        }
    }

    private void _0x82c70ce5()
    {
        this._0x8ecd1207(_0xfa1e82e0.SPLASH);
        if (_0xc2255145.Instance._0xadc97912 == _0x427a7181.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xe285f25e.Instance.DefaultAnimationTime);
        }
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x559fb8c0>();
    }

    public static _0x559fb8c0 Instance;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0x832e18d3(int _0x1b5df68d)
    {
        if (_0x1b5df68d == _0xfa1e82e0.SPLASH && _0xc2255145.Instance._0xadc97912 != _0x427a7181.SCENE_0)
            _0xe285f25e.Instance._0x48784745();
        if (_0xc2255145.Instance._0xadc97912 != _0x427a7181.SCENE_0)
        {
            if (_0x1b5df68d == _0xfa1e82e0.SPLASH || _0x1b5df68d == _0xfa1e82e0.TUTORIAL0)
                _0xc2255145.Instance._0xae3b7fed(false);
            else if (_0x1b5df68d == _0xfa1e82e0.DEFAULT)
                _0xc2255145.Instance._0xae3b7fed(true);
        }
    }

    private void _0x79bea4f7(int _0xb0daec66)
    {
        this.LastPanelIndexes.Add(_0xb0daec66);
        this.CurrentPanelIndex = _0xb0daec66;
        for (int _0x3cb558c5 = 0; _0x3cb558c5 < this.Panels.Count; _0x3cb558c5++)
            if (_0x3cb558c5 != _0xb0daec66 && this.Panels[_0x3cb558c5] != null)
                this.Panels[_0x3cb558c5]._0xeb64bd72();
    }

    private void Start()
    {
        this._0x82c70ce5();
    }
}