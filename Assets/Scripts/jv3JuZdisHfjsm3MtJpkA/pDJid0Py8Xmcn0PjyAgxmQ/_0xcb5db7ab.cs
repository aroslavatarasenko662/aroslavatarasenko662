using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xcb5db7ab : MonoBehaviour
{
    [HideInInspector]
    public int TimeLeft;
    public void _0xe51dd859(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xf2ad8ea1();
            this._0x0d9dddda();
        }
    }

    private void _0xf2ad8ea1()
    {
        if (_0x75fcf5ad.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x762c0ef8 => _0x762c0ef8.text = $"{this.ScoreCurrent}/{this._0x4b017bb2}");
        else
            this.ScoreText.ForEach(_0x762c0ef8 => _0x762c0ef8.text = $"{this.ScoreCurrent}");
    }

    public int CustomTargetScore = 10;
    public List<TMP_Text> LevelNumberText = new();
    private void Awake()
    {
        _0x1a889451 = this.gameObject.GetComponent<_0xcb5db7ab>();
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x00c5b76f()
    {
        if (!this.IsGameEnd)
        {
            this._0x336c53bf();
            _0xc2255145.IsAfterLevelComplete = true;
            _0xc2255145.IsAfterLevelFailed = false;
            _0xb0a1d978 _0xb5847396 = _0x4bed43e1.Instance._0xc251639b(_0xd931f97e._0xa66d5513.WIN).GetComponent<_0xb0a1d978>();
            if (_0x75fcf5ad.Instance.IsCheckScoreEnabled)
                _0xb5847396.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x4b017bb2}";
            else
                _0xb5847396.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x75fcf5ad.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xd931f97e._0x0633db75._0x684309b9)
                    _0xd931f97e._0x0633db75._0x684309b9 = this.ScoreCurrent;
                _0xb5847396.ContentAdditionalText.text = $"{_0xd931f97e._0x0633db75._0x684309b9}";
            }
            else
            {
                _0xb5847396.ContentAdditionalText.text = $"{this._0xfed23d36}";
                _0xd931f97e._0x0633db75._0x684309b9 += this._0xfed23d36;
            }

            if (_0x75fcf5ad.Instance.IsLevelIncrementOnWin)
                ++_0xc2255145._0xe6c2f64d._0x32109224;
            _0x4bed43e1.Instance._0x8878fd5d(_0xd931f97e._0xa66d5513.WIN);
        }
    }

    public List<TMP_Text> TimerText = new();
    private int _0x4b017bb2 => this.CustomTargetScore + _0xc2255145._0xe6c2f64d._0x32109224 * 10;

    private static _0xcb5db7ab _0x1a889451;
    private void _0xe4e7b538()
    {
        if (this.ScoreCurrent >= this._0x4b017bb2)
            this._0x00c5b76f();
        else
            this._0xb0e30e45();
    }

    public List<Button> HomeButtons = new();
    private IEnumerator _0x94aa7c70()
    {
        this._0xe6035758();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xc2255145.Instance._0xadc97912 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xc2255145.Instance._0x1a641ad7)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xe6035758();
            }
        }

        if (!this.IsGameEnd)
            this._0xb0e30e45();
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x42f5037e;
        this.CurrentGameIndex = _0xc2255145.Instance._0xadc97912;
        foreach (Button _0xc6a0cd43 in this.HomeButtons)
            _0xc6a0cd43.onClick.AddListener(() =>
            {
                this._0xb367eaa5();
            });
        foreach (Button _0x6e4eb489 in this.PauseButtons)
            _0x6e4eb489.onClick.AddListener(() =>
            {
                _0xc2255145.Instance._0xae3b7fed(false);
                _0x4bed43e1.Instance._0x8878fd5d(_0xd931f97e._0xa66d5513.PAUSE);
            });
        this._0xf2ad8ea1();
        this.LevelNumberText.ForEach(_0x762c0ef8 => _0x762c0ef8.text = $"LVL {_0xc2255145._0xe6c2f64d._0x32109224 + 1}");
        if (_0x75fcf5ad.Instance.IsTimerEnabled)
        {
            this._0xe6035758();
            this.StartCoroutine(this._0x94aa7c70());
        }
    }

    public void _0xb0e30e45()
    {
        if (_0x75fcf5ad.Instance.IsOnlyWinGameEndEnabled)
            this._0x00c5b76f();
        if (!this.IsGameEnd)
        {
            this._0x336c53bf();
            _0xc2255145.IsAfterLevelComplete = false;
            _0xc2255145.IsAfterLevelFailed = true;
            _0xb0a1d978 _0x7f83e5c8 = _0x4bed43e1.Instance._0xc251639b(_0xd931f97e._0xa66d5513.LOSE).GetComponent<_0xb0a1d978>();
            if (_0x75fcf5ad.Instance.IsCheckScoreEnabled)
                _0x7f83e5c8.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x4b017bb2}";
            else
                _0x7f83e5c8.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x7f83e5c8.ContentAdditionalText.text = $"{0}";
            _0xd931f97e._0x0633db75._0x684309b9 += 0;
            _0x4bed43e1.Instance._0x8878fd5d(_0xd931f97e._0xa66d5513.LOSE);
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    private int _0xfed23d36 => this.ScoreCurrent;

    [HideInInspector]
    public int ScoreCurrent;
    private void _0xe6035758()
    {
        this.TimerText.ForEach(_0x762c0ef8 => _0x762c0ef8.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xce8f18c3._0x5ab9186f(new byte[6] { 37, 37, 20, 114, 59, 59 }, 72)));
    }

    public List<Button> PauseButtons = new();
    public void _0xb367eaa5()
    {
        _0xc2255145.Instance._0xae3b7fed(true);
        _0xc2255145.Instance._0x7e0b520e(_0xd931f97e._0x427a7181.SCENE_0);
    }

    public List<TMP_Text> ScoreText = new();
    public List<TMP_Text> SubtitleText = new();
    private void _0x0d9dddda()
    {
        if (this.ScoreCurrent > _0xc2255145._0xe6c2f64d._0xeb471462)
            _0xc2255145._0xe6c2f64d._0xeb471462 = this.ScoreCurrent;
        if (_0x75fcf5ad.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x4b017bb2)
                this._0x00c5b76f();
    }

    private int _0x42f5037e => this.CustomTimeInitial + _0xc2255145._0xe6c2f64d._0x32109224 * 10;

    private void _0x336c53bf()
    {
        this.IsGameEnd = true;
        _0xc2255145.IsAfterLevelComplete = true;
    }

    public int CustomTimeInitial = 30;
}

internal static class _0xce8f18c3
{
    internal static string _0x5ab9186f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}