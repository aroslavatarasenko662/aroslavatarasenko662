using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xd931f97e;

public class _0xc2255145 : MonoBehaviour
{
    private static _0xee129f61 GAME_INDEX_SETTINGS(int _0x7dcc26af)
    {
        return _0xee129f61.ALL_SCENES_SETTING_SINGLETONS[_0x7dcc26af];
    }

    public void _0xae3b7fed(bool _0xc6a4b514)
    {
        this._0x1a641ad7 = _0xc6a4b514;
        this._0x66380f5d(!this._0x1a641ad7);
        Physics2D.simulationMode = this._0x1a641ad7 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x9fccc689(this.EnvironmentWithTweensToToggle);
    }

    public bool _0x1a641ad7 { get; private set; }

    public Canvas MainCanvas;
    private static _0xee129f61 _0xbe52ddf1 => _0xee129f61.ALL_SCENES_SETTING_SINGLETONS[0];

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc2255145>();
        this.RootGameObject = GameObject.FindWithTag(_0x892a1465._0xb4247c40(new byte[4] { 179, 142, 142, 149 }, 225));
        if (this._0xadc97912 == _0x427a7181.SCENE_0)
            this._0xae3b7fed(true);
        else
            this._0xae3b7fed(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x4d75d231>(true).ToList();
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public static _0xee129f61 _0xe6c2f64d => _0xee129f61.ALL_SCENES_SETTING_SINGLETONS[Instance._0xadc97912];

    public static bool IsAfterLevelComplete;
    public void _0x46114ae9()
    {
        foreach (_0x4d75d231 _0x655e9618 in this.MoneyCountContainers)
            _0x655e9618._0xb3962664();
    }

    private IEnumerator _0xbdaf1b7a(int _0xeb885818)
    {
        _0x559fb8c0.Instance._0x6fddb199(_0xfa1e82e0.SPLASH);
        AsyncOperation _0xd9a01858 = SceneManager.LoadSceneAsync(_0xeb885818);
        while (!_0xd9a01858.isDone)
            yield return null;
    }

    public Button DeleteProgressDataButton;
    public Transform EnvironmentWithTweensToToggle;
    public static _0xc2255145 Instance;
    private void _0x66380f5d(bool _0xd49a0b39)
    {
        Rigidbody2D[] _0xdf92c59f = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x5d78e92c in _0xdf92c59f)
            if (_0xd49a0b39)
                _0x5d78e92c.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x5d78e92c.constraints = RigidbodyConstraints2D.None;
    }

    public Transform Environment;
    private void _0x49f82196()
    {
        IsAfterLevelComplete = true;
        Instance._0x7e0b520e(_0x427a7181.SCENE_0);
    }

    public void _0xc8f733ef()
    {
        this._0x7e0b520e(SceneManager.GetActiveScene().buildIndex);
    }

    private static void MakeGrid(List<RectTransform> _0xcff0f53c, AspectRatioFitter _0x3c426815, float _0xbce819ee, int _0x5a46c198, int _0x106cb209)
    {
        _0x3c426815.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x3c426815.aspectRatio = _0xbce819ee;
        foreach (RectTransform _0xed82f5e7 in _0xcff0f53c)
        {
            int _0xe9b6231c = _0xed82f5e7.transform.GetSiblingIndex();
            _0xed82f5e7.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xe9b6231c % _0x5a46c198) * (1f / _0x5a46c198), (_0x106cb209 - (Mathf.FloorToInt((float)_0xe9b6231c / _0x5a46c198) % _0x106cb209 + 1f)) * (1f / _0x106cb209));
            _0xed82f5e7.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xe9b6231c % _0x5a46c198 + 1f) * (1f / _0x5a46c198), (_0x106cb209 - Mathf.FloorToInt((float)_0xe9b6231c / _0x5a46c198) % _0x106cb209) * (1f / _0x106cb209));
            _0xed82f5e7.offsetMin = Vector2.zero;
            _0xed82f5e7.offsetMax = Vector2.zero;
        }
    }

    public int _0xadc97912 => SceneManager.GetActiveScene().buildIndex;

    public void _0x7e0b520e(int _0x434cac7a)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xbdaf1b7a(_0x434cac7a));
    }

    public Button ShowResetTutorialButton;
    private void _0x9fccc689(Transform _0xc78b4e14)
    {
        Transform[] _0x52255437 = _0xc78b4e14.GetComponentsInChildren<Transform>();
        foreach (Transform _0xfd28194a in _0x52255437)
            if (_0xfd28194a != null && DOTween.IsTweening(_0xfd28194a))
            {
                if (this._0x1a641ad7)
                    DOTween.Play(_0xfd28194a);
                else
                    DOTween.Pause(_0xfd28194a);
            }
    }

    public void _0x5e13e328()
    {
        _0xe6c2f64d._0x23af6f78 = true;
    }

    private IEnumerator _0xc77265f5(string _0xb358d84e)
    {
        _0x559fb8c0.Instance._0x6fddb199(_0xfa1e82e0.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x73d3f0ca = SceneManager.LoadSceneAsync(_0xb358d84e);
        while (!_0x73d3f0ca.isDone)
            yield return null;
    }

    public static bool IsAfterLevelFailed = false;
    private void Start()
    {
        if (this._0xadc97912 != _0x427a7181.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x7e0b520e(_0x427a7181.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xe6c2f64d._0x23af6f78 = false;
            _0x4bed43e1.Instance._0x004cceed();
            _0x559fb8c0.Instance._0x6fddb199(_0xfa1e82e0.TUTORIAL0);
        });
    }

    [HideInInspector]
    public List<_0x4d75d231> MoneyCountContainers = new();
}

internal static class _0x892a1465
{
    internal static string _0xb4247c40(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}