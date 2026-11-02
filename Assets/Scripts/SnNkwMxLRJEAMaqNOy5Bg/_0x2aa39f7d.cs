using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One hub section. The gate owns its root and its close button and nothing else,
/// so the hub can open and close a section without knowing what is inside it.
/// </summary>
public sealed class _0x2aa39f7d : MonoBehaviour
{
    public void Show()
    {
        if (this._root == null)
            return;
        this._root.SetActive(true);
        if (this._0x37ac052e || this._card == null)
            return;
        this._card.localScale = Vector3.one * 0.92f;
        this._card.DOScale(1f, 0.22f).SetEase(Ease.OutBack).SetLink(this._card.gameObject);
    }

    public void _0xcd308e0e()
    {
        if (this._root != null)
            this._root.SetActive(false);
    }

    private void OnDestroy()
    {
        if (this._card != null)
            DOTween.Kill(this._card, false);
    }

    [SerializeField]
    private GameObject _root;
    [SerializeField]
    private RectTransform _card;
    private bool _0x37ac052e;
    public _0x2aa39f7d _0x15104dcf(GameObject _0x5161bd65, Button _0x4dd91f49, RectTransform _0x79293911, bool _0x7ab72dc8)
    {
        this._root = _0x5161bd65;
        this._close = _0x4dd91f49;
        this._card = _0x79293911;
        this._0x37ac052e = _0x7ab72dc8;
        if (this._close != null)
            this._close.onClick.AddListener(() => this._0xcd308e0e());
        if (this._root != null)
            this._root.SetActive(false);
        return this;
    }

    [SerializeField]
    private Button _close;
}