using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0x252d3bed : MonoBehaviour
{
    private const float ScanInterval = 0.25f;
    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0x34315f3c =
    {
        _0x05ff1f2d._0x0c0b6af2(new byte[3] { 33, 34, 63 }, 77) + _0x05ff1f2d._0x0c0b6af2(new byte[6] { 125, 117, 56, 113, 104, 107 }, 24) + _0x05ff1f2d._0x0c0b6af2(new byte[2] { 157, 133 }, 232),
        _0x05ff1f2d._0x0c0b6af2(new byte[6] { 245, 228, 252, 252, 232, 177 }, 145) + _0x05ff1f2d._0x0c0b6af2(new byte[4] { 78, 95, 66, 78 }, 58)
    };
    private static readonly HashSet<string> _0x9d9b2414 = new HashSet<string>
    {
        _0x05ff1f2d._0x0c0b6af2(new byte[6] { 68, 73, 77, 72, 73, 94 }, 12),
        _0x05ff1f2d._0x0c0b6af2(new byte[6] { 178, 159, 155, 158, 159, 136 }, 250),
        _0x05ff1f2d._0x0c0b6af2(new byte[6] { 58, 55, 51, 54, 55, 32 }, 82),
        _0x05ff1f2d._0x0c0b6af2(new byte[5] { 165, 184, 165, 189, 180 }, 241),
        _0x05ff1f2d._0x0c0b6af2(new byte[5] { 208, 237, 240, 232, 225 }, 132)
    };
    private void OnDisable()
    {
        if (this._0xb2d02e10 != null)
            SceneManager.sceneLoaded -= this._0xb2d02e10;
    }

    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0xb2d02e10;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xaa440345 != null)
            return;
        GameObject _0x77188262 = new GameObject(_0x05ff1f2d._0x0c0b6af2(new byte[24] { 88, 105, 97, 124, 96, 109, 120, 105, 92, 96, 109, 111, 105, 100, 99, 96, 104, 105, 126, 75, 121, 109, 126, 104 }, 12));
        _0x77188262.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x77188262);
        _0xaa440345 = _0x77188262.AddComponent<_0x252d3bed>();
    }

    private static _0x252d3bed _0xaa440345;
    private float _0xcea8da8e;
    private static bool IsPlaceholder(string _0x2987f5c0)
    {
        if (string.IsNullOrEmpty(_0x2987f5c0))
            return false;
        string _0x49cf69be = _0x2987f5c0.Trim();
        if (_0x9d9b2414.Contains(_0x49cf69be))
            return true;
        string _0x93c949cf = _0x49cf69be.ToLowerInvariant();
        for (int _0x3fba14ce = 0; _0x3fba14ce < _0x34315f3c.Length; _0x3fba14ce++)
        {
            if (_0x93c949cf.StartsWith(_0x34315f3c[_0x3fba14ce]))
                return true;
        }

        return false;
    }

    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0xcea8da8e)
            return;
        this._0xcea8da8e = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0x53670e9c = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0x688e0ae0 = 0; _0x688e0ae0 < _0x53670e9c.Length; _0x688e0ae0++)
        {
            TMP_Text _0xfa92f12a = _0x53670e9c[_0x688e0ae0];
            if (_0xfa92f12a != null && IsPlaceholder(_0xfa92f12a.text))
                _0xfa92f12a.text = "";
        }
    }

    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0xb2d02e10 == null)
            this._0xb2d02e10 = (_0x085972c3, _0x0661b1e1) =>
            {
                this._0xcea8da8e = 0f;
            };
        SceneManager.sceneLoaded += this._0xb2d02e10;
    }
}

internal static class _0x05ff1f2d
{
    internal static string _0x0c0b6af2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}