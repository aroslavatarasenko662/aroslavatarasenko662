using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8d60e39f : MonoBehaviour
{
    public void Show()
    {
        this._0xa97653c5();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x559fb8c0.Instance._0x832e18d3(_0x559fb8c0.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0xa97653c5()
    {
        if (this.OuterBackground != null)
        {
            Image _0x2124ec07 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x2124ec07, true);
            _0x2124ec07.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public float ScaleDuration = 0.4f;
    public bool IsScaledDownOnAwake = true;
    private void _0x5adb4f10()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd5861792 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd5861792, true);
            _0xd5861792.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public Ease Ease = Ease.OutSine;
    public TMP_Text HeaderText;
    private void _0x6153899d()
    {
        if (this.OuterBackground != null)
        {
            Image _0xba85adca = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xba85adca, true);
            _0xba85adca.DOFade(0f, this.ScaleDuration);
        }
    }

    public void _0xeb64bd72()
    {
        this._0x6153899d();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x5adb4f10();
    }

    public GameObject Content;
    private void _0x1c7a5ee6()
    {
        if (this.OuterBackground != null)
        {
            Image _0x2397ecc7 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x2397ecc7, true);
            _0x2397ecc7.DOFade(1f, 0f);
        }
    }

    public void _0x58c81767()
    {
        this._0x1c7a5ee6();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x559fb8c0.Instance._0x832e18d3(_0x559fb8c0.Instance.CurrentPanelIndex);
    }

    private bool _0x856b78e5 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public GameObject OuterBackground;
    public TMP_Text MainText;
}