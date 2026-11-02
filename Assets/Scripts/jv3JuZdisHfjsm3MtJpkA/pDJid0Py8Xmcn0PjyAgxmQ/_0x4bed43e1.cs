using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xd931f97e;

public class _0x4bed43e1 : MonoBehaviour
{
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    public void _0x9f14b05a()
    {
        this.LastPopIndexes.RemoveAll(_0x951938f5 => _0x951938f5 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x004cceed();
        else
            this._0x8878fd5d(this.LastPopIndexes.Last());
    }

    private void _0x7b969aca()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x4bed43e1>();
    }

    public List<_0xb0a1d978> Pops;
    public void _0x8878fd5d(int _0x73525be6)
    {
        this.CurrentPopIndex = _0x73525be6;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x6d93032f(true);
        this._0x7b969aca();
        this.Pops[_0x73525be6].Show();
        foreach (GameObject _0x8f6be773 in this.GameObjectsToHide)
            _0x8f6be773.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
    public static _0x4bed43e1 Instance;
    private void _0x6d93032f(bool _0x0b9f1767 = false)
    {
        for (int _0x1b88c5c0 = 0; _0x1b88c5c0 < this.Pops.Count; ++_0x1b88c5c0)
            if (this.Pops[_0x1b88c5c0] != null && !(_0x1b88c5c0 == this.CurrentPopIndex && _0x0b9f1767))
                this.Pops[_0x1b88c5c0]._0x6db595b8();
    }

    public void _0x004cceed()
    {
        this.LastPopIndexes.Clear();
        this._0x6d93032f();
        foreach (GameObject _0x15e959d7 in this.GameObjectsToHide)
            if (_0x15e959d7 != null)
                _0x15e959d7.SetActive(true);
        this._0xbe996bc0();
    }

    public GameObject BlurBackground;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xb0a1d978 _0xeb116444 in this.Pops)
            if (_0xeb116444 != null)
                _0xeb116444.gameObject.SetActive(true);
    }

    private void _0xbe996bc0()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public float ScaleDuration = 0.4f;
    public _0xb0a1d978 _0xc251639b(int _0xf528cdcf)
    {
        return this.Pops[_0xf528cdcf];
    }

    public int CurrentPopIndex;
}