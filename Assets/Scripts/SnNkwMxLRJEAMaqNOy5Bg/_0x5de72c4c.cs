using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Switches off the template chrome this game does not use, at runtime, through
/// serialized references only (C.2: a modification written into the scene for an
/// object an inner prefab instance owns is silently dropped, so the reference is
/// the one thing that works). It also blanks the placeholder wording of the
/// tutorial panels the game never shows, so no "Lorem Ipsum" can reach the screen
/// (C.15). Nothing of this game's own content hangs on any of these objects.
/// </summary>
public sealed class _0x5de72c4c : MonoBehaviour
{
    [SerializeField]
    private RectTransform[] _unused;
    [SerializeField]
    private bool _blankTutorials = true;
    /// <summary>
    /// The tutorial is disabled for this game (its controls are explained by the
    /// permanent hint in the run and by the hub's HOW TO PLAY card), so the panels
    /// keep the template's filler text. Blank it rather than deactivate the panels:
    /// the controllers address panels by index and a missing one breaks navigation.
    /// </summary>
    private void _0xd6893177()
    {
        if (_0xc2255145.Instance == null || _0xc2255145.Instance.RootGameObject == null)
            return;
        _0xf433c92f[] _0x8519976f = _0xc2255145.Instance.RootGameObject.GetComponentsInChildren<_0xf433c92f>(true);
        for (int _0x081999de = 0; _0x081999de < _0x8519976f.Length; _0x081999de++)
        {
            _0xf433c92f _0x1f854474 = _0x8519976f[_0x081999de];
            if (_0x1f854474 == null)
                continue;
            TMP_Text[] _0x2b8d2813 = _0x1f854474.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xe9c5a88b = 0; _0xe9c5a88b < _0x2b8d2813.Length; _0xe9c5a88b++)
            {
                TMP_Text _0x9c201a0f = _0x2b8d2813[_0xe9c5a88b];
                if (_0x9c201a0f == null || _0x9c201a0f.GetComponentInParent<Button>(true) != null)
                    continue;
                _0x9c201a0f.text = string.Empty;
            }
        }
    }

    private void Start()
    {
        int _0x420eb18b = 0;
        if (this._unused != null)
        {
            for (int _0xab7a1278 = 0; _0xab7a1278 < this._unused.Length; _0xab7a1278++)
            {
                RectTransform _0x8619d9af = this._unused[_0xab7a1278];
                if (_0x8619d9af == null || !_0x8619d9af.gameObject.activeSelf)
                    continue;
                _0x8619d9af.gameObject.SetActive(false);
                _0x420eb18b++;
            }
        }

        if (this._blankTutorials)
            this._0xd6893177();
        {
#if B_LOGS
            {
                Debug.Log($"[chrome] template elements switched off: {_0x420eb18b}");
            }
#endif
        }
    }
}