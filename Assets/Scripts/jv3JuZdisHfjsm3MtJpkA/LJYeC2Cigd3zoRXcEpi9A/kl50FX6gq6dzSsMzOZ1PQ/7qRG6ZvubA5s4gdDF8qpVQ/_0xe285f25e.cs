using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xe285f25e : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe285f25e>();
    }

    private Sequence _0xac332a14;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xd931f97e._0x427a7181.SCENE_0 && !_0x6c4d6bad)
        {
            this._0x0dff31b2();
        }
        else
        {
            this._0x48784745();
        }
    }

    private static bool _0x6c4d6bad = false;
    public GameObject Error;
    public float SecondPassSliderValue = 0.5f;
    public GameObject Content;
    public float FirstAnimationTime = 10.0f;
    public void _0x19cf9d09()
    {
        this._0xac332a14?.Kill();
        this.AnimationSlider.value = _0x6c4d6bad ? this.SecondPassSliderValue : 0.05f;
    }

    public float DefaultAnimationTime = 0.4f;
    public void _0xf9b39a70()
    {
        this._0xac332a14?.Play();
    }

    public static _0xe285f25e Instance;
    public Slider AnimationSlider;
    private void _0x0dff31b2()
    {
        this.AnimationSlider.value = 0.05f;
        _0x6c4d6bad = !_0x6c4d6bad;
        this._0xac332a14 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x93588b2c => this.AnimationSlider.value = _0x93588b2c, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xb1aeb5b6._0x28358be3?._0x380f41c0();
        });
    }

    public void _0x48784745()
    {
        this._0x19cf9d09();
        bool _0x220f0037 = _0x6c4d6bad;
        this._0xac332a14 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x93588b2c => this.AnimationSlider.value = _0x93588b2c, _0x220f0037 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x6c4d6bad = !_0x6c4d6bad;
    }

    public void _0xdb45ec0a()
    {
        this._0xac332a14?.Pause();
    }

    public void _0x7ec6b07b()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xac332a14?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x6c4d6bad = false;
    }

    public GameObject Background;
}