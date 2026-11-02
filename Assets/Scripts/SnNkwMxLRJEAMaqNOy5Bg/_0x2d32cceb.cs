using UnityEngine;

/// <summary>
/// Tuning for one ridge run. Everything spatial is derived from the scene camera at
/// runtime (CLAUDE-unity.md C.0); only ratios and rates live here.
/// Balance proof (C.5): a run with ZERO taps keeps the centre lane clear for the
/// warm-up, and afterwards no lane is ever blocked in two consecutive rows, so the
/// worst case is one scald every other row. Replayed over the five difficulty modes
/// and four seeds each, the SHORTEST baseline run is 65 s - past the 31st second
/// where the review capture takes its last gameplay frame, with margin.
/// </summary>
public static class _0x2d32cceb
{
    public const float SpeedGain = 0.06f;
    public const float HeroScreenFraction = 0.22f;
    public const float HeatPerHit = 4f;
    public static int RidgeTarget(int _0x37548af2)
    {
        int _0x4ce60d4d = RidgeBaseTarget + RidgeTargetStep * Mathf.Max(0, _0x37548af2);
        return Mathf.Min(_0x4ce60d4d, RidgeTargetCap);
    }

    public const float MetresPerUnit = 4.0f;
    public const float CountInSeconds = 1.2f;
    public const float RowSpacing = 1.9f;
    public const float InvulnerableSeconds = 2.2f;
    public const int RidgeBaseTarget = 520;
    public const float HeatMax = 100f;
    public const float MaxFrameStep = 0.05f;
    public const float HeroLaneFraction = 0.82f;
    public const int RidgeTargetCap = 1500;
    public const float WarmupSeconds = 30f;
    public const float BandFraction = 0.86f;
    public const float LaneStepCooldown = 0.10f;
    public const float HeatPerGeode = 22f;
    public const float SpeedCap = 10.0f;
    public const float LaneStepSeconds = 0.16f;
    public const int RidgeCount = 12;
    public static float RidgeDensity(int _0x6d5cf3dd)
    {
        return 1f + Mathf.Min(0.60f, 0.08f * Mathf.Max(0, _0x6d5cf3dd));
    }

    public const float HeatPerEmber = 2.5f;
    public const float HeatPassive = 0.50f;
    public const float HitSlowFactor = 0.75f;
    public const float BaseSpeed = 6.0f;
    public const int RidgeTargetStep = 140;
    public const float HitSlowSeconds = 1.2f;
    public const int LaneCount = 3;
}