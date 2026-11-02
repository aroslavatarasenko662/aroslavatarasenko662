using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xd931f97e
{
    public static class _0x0633db75
    {
        public static int _0x684309b9
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xf9554372._0x8329b7eb(new byte[5] { 32, 12, 10, 13, 16 }, 99)))
                    PlayerPrefs.SetInt(_0xf9554372._0x8329b7eb(new byte[5] { 231, 203, 205, 202, 215 }, 164), 0);
                return PlayerPrefs.GetInt(_0xf9554372._0x8329b7eb(new byte[5] { 72, 100, 98, 101, 120 }, 11));
            }

            set
            {
                PlayerPrefs.SetInt(_0xf9554372._0x8329b7eb(new byte[5] { 22, 58, 60, 59, 38 }, 85), value);
                _0xc2255145.Instance._0x46114ae9();
            }
        }
    }

    public static class _0x427a7181
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0xfa1e82e0
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0xee129f61
    {
        private static readonly _0xee129f61 _0x0a9b9e39 = new();
        public static readonly _0xee129f61[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x0a9b9e39,
            _0x0a9b9e39,
            _0x0a9b9e39,
        };
        private int _0x0a8194f1 => 0;
        private int _0x7ebe8b43 => 10;
        private string _0x9310e81d => _0xf9554372._0x8329b7eb(new byte[4] { 118, 94, 85, 78 }, 59);
        private string _0x038939c7 => _0xf9554372._0x8329b7eb(new byte[8] { 146, 155, 136, 155, 146, 165, 238, 163 }, 222);

        private int _0xb9d5b0b1
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xf9554372._0x8329b7eb(new byte[25] { 70, 112, 119, 119, 96, 107, 113, 66, 105, 106, 103, 100, 105, 70, 109, 100, 117, 113, 96, 119, 76, 107, 97, 96, 125 }, 5)))
                    PlayerPrefs.SetInt(_0xf9554372._0x8329b7eb(new byte[25] { 171, 157, 154, 154, 141, 134, 156, 175, 132, 135, 138, 137, 132, 171, 128, 137, 152, 156, 141, 154, 161, 134, 140, 141, 144 }, 232), 0);
                return PlayerPrefs.GetInt(_0xf9554372._0x8329b7eb(new byte[25] { 30, 40, 47, 47, 56, 51, 41, 26, 49, 50, 63, 60, 49, 30, 53, 60, 45, 41, 56, 47, 20, 51, 57, 56, 37 }, 93));
            }

            set => PlayerPrefs.SetInt(_0xf9554372._0x8329b7eb(new byte[25] { 24, 46, 41, 41, 62, 53, 47, 28, 55, 52, 57, 58, 55, 24, 51, 58, 43, 47, 62, 41, 18, 53, 63, 62, 35 }, 91), value);
        }

        public int _0x32109224
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x9310e81d}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x9310e81d}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x9310e81d}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x9310e81d}CurrentLevelIndex", value);
        }

        public int _0xeb471462
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x9310e81d}BestScore"))
                    this._0xeb471462 = 0;
                return PlayerPrefs.GetInt($"{this._0x9310e81d}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x9310e81d}BestScore", value);
        }

        public bool _0x23af6f78
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x9310e81d}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x9310e81d}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x9310e81d}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x9310e81d}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xa66d5513
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }
}

internal static class _0xf9554372
{
    internal static string _0x8329b7eb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}