using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x67917582 : MonoBehaviour
{
    private const float TargetRatio = 7f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x1e19f478)
    {
        return 0.2126f * Linear(_0x1e19f478.r) + 0.7152f * Linear(_0x1e19f478.g) + 0.0722f * Linear(_0x1e19f478.b);
    }

    private readonly HashSet<TMP_Text> _0xf041cab0 = new HashSet<TMP_Text>();
    private void LateUpdate()
    {
        if (this._0xf041cab0.Count == 0)
            return;
        this._0x3a1e3503.Clear();
        this._0x3a1e3503.AddRange(this._0xf041cab0);
        this._0xf041cab0.Clear();
        for (int _0x2abbad21 = 0; _0x2abbad21 < this._0x3a1e3503.Count; _0x2abbad21++)
            Fix(this._0x3a1e3503[_0x2abbad21]);
    }

    private static _0x67917582 _0x4aa0f337;
    private const float MinOutlineWidth = 0.01f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xf57bea84(Object _0x0fe112ff)
    {
        TMP_Text _0xff3f8234 = _0x0fe112ff as TMP_Text;
        if (_0xff3f8234 != null)
            this._0xf041cab0.Add(_0xff3f8234);
    }

    private void OnEnable()
    {
        if (this._0x60febc46 == null)
            this._0x60febc46 = _0x5a1d9fc2 => this._0xf57bea84(_0x5a1d9fc2);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x60febc46);
    }

    private static void Fix(TMP_Text _0x41bb77f0)
    {
        if (_0x41bb77f0 == null || !_0x41bb77f0.isActiveAndEnabled)
            return;
        Material _0xb2f98cdc = _0x41bb77f0.fontSharedMaterial;
        if (_0xb2f98cdc == null || !_0xb2f98cdc.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xb2f98cdc.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xb2f98cdc.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x4b945736 = _0x41bb77f0.color;
        if (_0x4b945736.a <= 0f)
            return;
        Color _0xce3e873c = _0xb2f98cdc.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x4b945736, _0xce3e873c) >= MinRatio)
            return;
        Color _0x667a1d11 = Luminance(_0xce3e873c) < 0.5f ? Color.white : Color.black;
        Color _0x9cefe35f;
        if (Ratio(_0x667a1d11, _0xce3e873c) < TargetRatio)
        {
            _0x9cefe35f = _0x667a1d11;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x5819d857 = 0f;
            float _0x7d94dc2d = 1f;
            for (int _0x8eccfd50 = 0; _0x8eccfd50 < 20; _0x8eccfd50++)
            {
                float _0x41434d33 = (_0x5819d857 + _0x7d94dc2d) * 0.5f;
                if (Ratio(Color.Lerp(_0x4b945736, _0x667a1d11, _0x41434d33), _0xce3e873c) >= TargetRatio)
                    _0x7d94dc2d = _0x41434d33;
                else
                    _0x5819d857 = _0x41434d33;
            }

            _0x9cefe35f = Color.Lerp(_0x4b945736, _0x667a1d11, _0x7d94dc2d);
        }

        _0x9cefe35f.a = _0x4b945736.a;
        _0x41bb77f0.color = _0x9cefe35f;
    }

    private readonly List<TMP_Text> _0x3a1e3503 = new List<TMP_Text>();
    private static float Linear(float _0xa9ccd6e7)
    {
        _0xa9ccd6e7 = Mathf.Clamp01(_0xa9ccd6e7);
        return _0xa9ccd6e7 <= 0.03928f ? _0xa9ccd6e7 / 12.92f : Mathf.Pow((_0xa9ccd6e7 + 0.055f) / 1.055f, 2.4f);
    }

    private const float MinRatio = 4.5f;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x4aa0f337 != null)
            return;
        GameObject _0x1ac5fc46 = new GameObject(_0x97075ba4._0xa106a09f(new byte[16] { 190, 135, 154, 169, 133, 132, 158, 152, 139, 153, 158, 173, 159, 139, 152, 142 }, 234));
        _0x1ac5fc46.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x1ac5fc46);
        _0x4aa0f337 = _0x1ac5fc46.AddComponent<_0x67917582>();
    }

    private static float Ratio(Color _0x481a03a1, Color _0xebf7ece3)
    {
        float _0x50ea428d = Luminance(_0x481a03a1);
        float _0xfdbfb3b7 = Luminance(_0xebf7ece3);
        return (Mathf.Max(_0x50ea428d, _0xfdbfb3b7) + 0.05f) / (Mathf.Min(_0x50ea428d, _0xfdbfb3b7) + 0.05f);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x60febc46;
    private void OnDisable()
    {
        if (this._0x60febc46 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x60febc46);
    }
}

internal static class _0x97075ba4
{
    internal static string _0xa106a09f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}