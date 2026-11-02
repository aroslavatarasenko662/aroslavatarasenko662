using UnityEngine;

/// <summary>
/// The obsidian/magma palette. Every entry is an independent literal so that no
/// field initializer depends on another one (CLAUDE-unity.md C.52).
/// Text colours are light on purpose: the shared font outline is dark (C.14).
/// </summary>
public static class _0xa72ebf9b
{
    public static readonly Color Magma = new Color(1f, 0.420f, 0.102f, 1f);
    public static readonly Color Surface = new Color(0.071f, 0.071f, 0.122f, 1f);
    public static readonly Color TrackDark = new Color(0.086f, 0.129f, 0.243f, 0.92f);
    public static readonly Color Cream = new Color(1f, 0.945f, 0.875f, 1f);
    public static readonly Color Scrim = new Color(0.039f, 0.039f, 0.059f, 0.82f);
    public static readonly Color Ember = new Color(1f, 0.757f, 0.302f, 1f);
    /// <summary>Heat 0..1 reads gold -> magma -> danger.</summary>
    public static Color Heat(float _0xd1844b32)
    {
        if (_0xd1844b32 <= 0.5f)
            return Color.Lerp(Ember, Magma, Mathf.Clamp01(_0xd1844b32 * 2f));
        return Color.Lerp(Magma, Danger, Mathf.Clamp01((_0xd1844b32 - 0.5f) * 2f));
    }

    public static Color Fade(Color _0x78cccf9c, float _0x5f3b45f0)
    {
        return new Color(_0x78cccf9c.r, _0x78cccf9c.g, _0x78cccf9c.b, _0x5f3b45f0);
    }

    public static readonly Color Outline = new Color(0.078f, 0.039f, 0.031f, 1f);
    public static readonly Color Crust = new Color(0.086f, 0.129f, 0.243f, 1f);
    public static readonly Color Muted = new Color(0.784f, 0.737f, 0.686f, 1f);
    public static readonly Color Danger = new Color(1f, 0.180f, 0f, 1f);
    public static readonly Color GlassFill = new Color(0.071f, 0.071f, 0.122f, 0.78f);
    public static readonly Color Raised = new Color(0.102f, 0.102f, 0.180f, 1f);
    public static readonly Color GlassRim = new Color(1f, 0.420f, 0.102f, 0.38f);
    public static readonly Color Ink = new Color(0.039f, 0.039f, 0.059f, 1f);
}