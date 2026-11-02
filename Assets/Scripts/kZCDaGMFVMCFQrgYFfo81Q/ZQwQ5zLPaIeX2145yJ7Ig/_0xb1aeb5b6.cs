using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xb1aeb5b6 : MonoBehaviour
{
    private void _0x2f91a9f8(string _0xcbf37984)
    {
        if (string.IsNullOrEmpty(_0xcbf37984))
            return;
        if (TryOpenExternalLikeChrome(_0xcbf37984))
            return;
        OpenUrlExternally(_0xcbf37984);
    }

    private async Task<bool> _0x57467fda()
    {
        _0xe285f25e.Instance?._0xdb45ec0a();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x6b85e5ec) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[32] { 200, 199, 246, 224, 231, 206, 179, 198, 253, 250, 231, 234, 179, 195, 230, 224, 251, 179, 221, 252, 231, 250, 245, 250, 240, 242, 231, 250, 252, 253, 169, 179 }, 147) + string.Join(_0xe441340d._0xeed5ad3c(new byte[1] { 128 }, 137), _0x6b85e5ec));
                }
#endif
            }
        };
        try
        {
            _0xca8453ae = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[31] { 8, 7, 54, 32, 39, 14, 115, 21, 50, 58, 63, 54, 55, 115, 39, 60, 115, 52, 54, 39, 115, 35, 38, 32, 59, 115, 39, 60, 56, 54, 61 }, 83));
                }
#endif
            }

            _0xca8453ae = "";
        }

        _0x2ff1ee96 = !string.IsNullOrEmpty(_0xca8453ae);
        _0x90321c91 = _0xdc7d1bec();
        {
#if B_LOGS
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[25] { 210, 221, 236, 250, 253, 212, 169, 220, 231, 224, 253, 240, 169, 217, 252, 250, 225, 169, 221, 230, 226, 236, 231, 179, 169 }, 137) + _0xca8453ae);
#endif
        }

        _0xe285f25e.Instance?._0xf9b39a70();
        return false;
    }

    internal bool IsAboutBlank(string _0x494f1c17)
    {
        if (string.IsNullOrEmpty(_0x494f1c17))
            return false;
        return _0x494f1c17.StartsWith(_0xe441340d._0xeed5ad3c(new byte[11] { 21, 22, 27, 1, 0, 78, 22, 24, 21, 26, 31 }, 116), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x90321c91 = "";
    private string _0xca8453ae = "";
    // NATIVE WEB VIEW METHODS
    private UniWebView _0xea5f3a36 = null;
    // WS_SOURCE MONO
    public static _0xb1aeb5b6 _0x28358be3 { get; private set; }

    private readonly string[] _0x356cd576 = new string[]
    {
        _0xe441340d._0xeed5ad3c(new byte[60] { 171, 196, 213, 235, 123, 15, 51, 62, 123, 41, 62, 62, 55, 40, 123, 58, 41, 62, 123, 51, 52, 47, 123, 41, 50, 60, 51, 47, 123, 53, 52, 44, 123, 185, 219, 200, 123, 63, 52, 53, 185, 219, 194, 47, 123, 54, 50, 40, 40, 123, 34, 52, 46, 41, 123, 40, 43, 50, 53, 122 }, 91),
        _0xe441340d._0xeed5ad3c(new byte[52] { 121, 22, 4, 9, 169, 192, 253, 169, 234, 230, 252, 229, 237, 169, 235, 236, 169, 240, 230, 252, 251, 169, 229, 252, 234, 226, 240, 169, 228, 230, 228, 236, 231, 253, 169, 107, 9, 26, 169, 254, 225, 240, 169, 250, 253, 230, 249, 169, 231, 230, 254, 182 }, 137),
        _0xe441340d._0xeed5ad3c(new byte[66] { 241, 137, 178, 252, 171, 156, 51, 81, 122, 116, 51, 100, 122, 125, 96, 51, 114, 97, 118, 51, 123, 122, 103, 103, 122, 125, 116, 51, 126, 124, 97, 118, 51, 124, 117, 103, 118, 125, 51, 103, 124, 119, 114, 106, 51, 241, 147, 128, 51, 96, 103, 114, 106, 51, 122, 125, 51, 103, 123, 118, 51, 116, 114, 126, 118, 61 }, 19),
        _0xe441340d._0xeed5ad3c(new byte[54] { 96, 15, 5, 2, 176, 196, 248, 249, 227, 176, 249, 227, 176, 224, 226, 249, 253, 245, 176, 228, 249, 253, 245, 176, 114, 16, 3, 176, 228, 248, 245, 176, 242, 245, 227, 228, 176, 224, 252, 241, 233, 245, 226, 227, 176, 224, 252, 241, 233, 176, 254, 255, 231, 190 }, 144),
        _0xe441340d._0xeed5ad3c(new byte[48] { 85, 58, 49, 0, 133, 252, 202, 208, 215, 133, 210, 204, 203, 203, 204, 203, 194, 133, 214, 209, 215, 192, 196, 206, 133, 198, 202, 208, 201, 193, 133, 199, 192, 133, 202, 203, 192, 133, 214, 213, 204, 203, 133, 196, 210, 196, 220, 139 }, 165),
        _0xe441340d._0xeed5ad3c(new byte[65] { 139, 228, 225, 251, 91, 49, 26, 24, 16, 11, 20, 15, 8, 91, 26, 9, 30, 91, 22, 20, 9, 30, 91, 26, 24, 15, 18, 13, 30, 91, 15, 20, 21, 18, 28, 19, 15, 91, 153, 251, 232, 91, 8, 15, 26, 2, 91, 26, 21, 31, 91, 15, 9, 2, 91, 2, 20, 14, 9, 91, 23, 14, 24, 16, 85 }, 123),
        _0xe441340d._0xeed5ad3c(new byte[55] { 55, 88, 73, 117, 231, 130, 177, 162, 181, 190, 231, 180, 183, 174, 169, 231, 164, 168, 178, 169, 179, 180, 231, 37, 71, 84, 231, 179, 175, 162, 231, 169, 162, 191, 179, 231, 168, 169, 162, 231, 164, 168, 178, 171, 163, 231, 165, 162, 231, 190, 168, 178, 181, 180, 233 }, 199),
        _0xe441340d._0xeed5ad3c(new byte[63] { 190, 241, 204, 179, 228, 211, 124, 12, 48, 61, 37, 57, 46, 47, 124, 46, 53, 59, 52, 40, 124, 50, 51, 43, 124, 61, 46, 57, 124, 43, 53, 50, 50, 53, 50, 59, 124, 190, 220, 207, 124, 56, 51, 50, 190, 220, 197, 40, 124, 43, 61, 48, 55, 124, 61, 43, 61, 37, 124, 37, 57, 40, 114 }, 92),
        _0xe441340d._0xeed5ad3c(new byte[51] { 189, 210, 194, 203, 109, 2, 35, 33, 52, 109, 57, 37, 34, 62, 40, 109, 58, 37, 34, 109, 62, 57, 44, 52, 109, 36, 35, 109, 57, 37, 40, 109, 42, 44, 32, 40, 109, 58, 36, 35, 109, 57, 37, 40, 109, 61, 63, 36, 55, 40, 99 }, 77),
        _0xe441340d._0xeed5ad3c(new byte[64] { 223, 167, 156, 210, 133, 178, 29, 112, 82, 80, 88, 83, 73, 72, 80, 29, 84, 78, 29, 88, 75, 88, 79, 68, 73, 85, 84, 83, 90, 29, 223, 189, 174, 29, 86, 88, 88, 77, 29, 78, 77, 84, 83, 83, 84, 83, 90, 29, 91, 82, 79, 29, 68, 82, 72, 79, 29, 94, 85, 92, 83, 94, 88, 19 }, 61)
    };
    private string _0x02251dd4 = "";
    private string _0x52e72cc7 = "";
    private string _0x6d266de2 = "";
    private bool _0x67f25899 = false;
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x29c7d39a();
    }

    private void StopCurrentFailedLoad(UniWebView _0xcd57639e)
    {
        _0xa3c9ca3f(false);
        if (_0xcd57639e == null)
            return;
        _0xcd57639e.Stop();
        if (_0xcd57639e.CanGoBack)
            _0xcd57639e.GoBack();
    }

    private IEnumerator _0x5c8f18e3()
    {
        yield return _0xb97f2d3e(Permission.Camera);
    }

    private bool _0x3432cd8b(int _0x8acd4b03, string _0x382b3e96, string _0x6491028d)
    {
        if (string.IsNullOrEmpty(_0x6491028d))
            return false;
        if (!IsHttpUrl(_0x6491028d))
            return true;
        if (string.IsNullOrEmpty(_0x382b3e96))
            return false;
        return _0x382b3e96.IndexOf(_0xe441340d._0xeed5ad3c(new byte[20] { 115, 100, 100, 105, 117, 121, 120, 120, 115, 117, 98, 127, 121, 120, 105, 100, 115, 101, 115, 98 }, 54), StringComparison.OrdinalIgnoreCase) >= 0 || _0x382b3e96.IndexOf(_0xe441340d._0xeed5ad3c(new byte[22] { 179, 164, 164, 169, 181, 185, 184, 184, 179, 181, 162, 191, 185, 184, 169, 164, 179, 176, 163, 165, 179, 178 }, 246), StringComparison.OrdinalIgnoreCase) >= 0 || _0x382b3e96.IndexOf(_0xe441340d._0xeed5ad3c(new byte[21] { 49, 38, 38, 43, 55, 59, 58, 58, 49, 55, 32, 61, 59, 58, 43, 55, 56, 59, 39, 49, 48 }, 116), StringComparison.OrdinalIgnoreCase) >= 0 || _0x382b3e96.IndexOf(_0xe441340d._0xeed5ad3c(new byte[22] { 188, 171, 171, 166, 172, 183, 178, 183, 182, 174, 183, 166, 172, 171, 181, 166, 170, 186, 177, 188, 180, 188 }, 249), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal bool isApplicationFocus = false;
    private bool _0x3a8e6280 = false;
    private UniWebViewPopup _0x7636b619()
    {
        for (int _0x2de2e8da = _0xd356e5f8.Count - 1; _0x2de2e8da >= 0; _0x2de2e8da--)
        {
            var _0x64068d16 = _0xd356e5f8[_0x2de2e8da];
            if (_0x64068d16 != null && _0x64068d16.IsAlive)
                return _0x64068d16;
            _0xd356e5f8.RemoveAt(_0x2de2e8da);
        }

        return null;
    }

    internal Vector2 lastSize = Vector2.zero;
    internal bool isApplicationPause = false;
    private async Task _0xb7c2a532(string _0x6b5ca3c4)
    {
        if (_0x3a8e6280 || string.IsNullOrEmpty(_0x5e8b9ef9) || string.IsNullOrEmpty(_0x6b5ca3c4) || _0xb9a7af3d)
            return;
        _0x3a8e6280 = true;
        try
        {
            JObject _0x7edea7e0 = _0x977901f7(_0x6b5ca3c4, _0x5e8b9ef9, _0xdc7d1bec());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x6b5ca3c4} payload: {_0x7edea7e0}");
                }
#endif
            }

            var _0xaf68bc85 = _0x35249414(_0x7edea7e0.ToString(), _0x5e8b9ef9);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xe441340d._0xeed5ad3c(new byte[4] { 234, 233, 231, 226 }, 134) + _0x5e8b9ef9, _0xaf68bc85 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[24] { 14, 1, 16, 6, 1, 8, 117, 25, 58, 52, 49, 117, 37, 52, 38, 38, 117, 48, 39, 39, 58, 39, 111, 117 }, 85) + e.Message);
#endif
            }
        }
    }

    private string _0x4126e031 = "";
    private string _0xd28d1f8f()
    {
        string _0xa88ac4d9 = _0xe441340d._0xeed5ad3c(new byte[62] { 226, 225, 224, 231, 230, 229, 228, 235, 234, 233, 232, 239, 238, 237, 236, 243, 242, 241, 240, 247, 246, 245, 244, 251, 250, 249, 194, 193, 192, 199, 198, 197, 196, 203, 202, 201, 200, 207, 206, 205, 204, 211, 210, 209, 208, 215, 214, 213, 212, 219, 218, 217, 179, 178, 177, 176, 183, 182, 181, 180, 187, 186 }, 131);
        System.Random _0x4c8c5218 = new System.Random();
        int _0x1d31ee46 = _0x4c8c5218.Next(8, 16);
        return new string (Enumerable.Repeat(_0xa88ac4d9, _0x1d31ee46).Select(_0xfd398e3b => _0xfd398e3b[_0x4c8c5218.Next(_0xfd398e3b.Length)]).ToArray());
    }

    public void _0x380f41c0()
    {
        if (_0x03c76a4f)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[33] { 223, 208, 225, 247, 240, 217, 164, 208, 237, 233, 225, 246, 164, 235, 241, 240, 164, 169, 186, 164, 233, 235, 242, 225, 164, 240, 235, 164, 247, 231, 225, 234, 225 }, 132));
            }
#endif
        }

        _0x29c7d39a();
    }

    private string _0x36846b67()
    {
        try
        {
            using (var _0x8c7e6087 = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[30] { 22, 26, 24, 91, 0, 27, 28, 1, 12, 70, 17, 91, 5, 25, 20, 12, 16, 7, 91, 32, 27, 28, 1, 12, 37, 25, 20, 12, 16, 7 }, 117)))
            {
                var _0xf28eaf57 = _0x8c7e6087.GetStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[15] { 16, 6, 1, 1, 22, 29, 7, 50, 16, 7, 26, 5, 26, 7, 10 }, 115));
                var _0x2028f60c = _0xf28eaf57.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[21] { 171, 169, 184, 141, 188, 188, 160, 165, 175, 173, 184, 165, 163, 162, 143, 163, 162, 184, 169, 180, 184 }, 204));
                using (var _0x06cfa2b1 = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[26] { 208, 223, 213, 195, 222, 216, 213, 159, 198, 212, 211, 218, 216, 197, 159, 230, 212, 211, 226, 212, 197, 197, 216, 223, 214, 194 }, 177)))
                {
                    return _0x06cfa2b1.CallStatic<string>(_0xe441340d._0xeed5ad3c(new byte[19] { 107, 105, 120, 72, 105, 106, 109, 121, 96, 120, 89, 127, 105, 126, 77, 107, 105, 98, 120 }, 12), _0x2028f60c);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private void OnApplicationPause(bool _0xbc0060e5)
    {
        isApplicationPause = _0xbc0060e5;
    }

    private string _0xd56e9c66 = "";
    internal bool IsHttpUrl(string _0x06fafe08)
    {
        if (string.IsNullOrEmpty(_0x06fafe08))
            return false;
        return _0x06fafe08.StartsWith(_0xe441340d._0xeed5ad3c(new byte[7] { 162, 190, 190, 186, 240, 229, 229 }, 202), StringComparison.OrdinalIgnoreCase) || _0x06fafe08.StartsWith(_0xe441340d._0xeed5ad3c(new byte[8] { 168, 180, 180, 176, 179, 250, 239, 239 }, 192), StringComparison.OrdinalIgnoreCase);
    }

    private IEnumerator _0xc50d75b9(string _0xdfcdc300)
    {
        if (_0xea5f3a36 != null && _0x03c76a4f)
            yield break;
        _0xea5f3a36 = gameObject.AddComponent<UniWebView>();
        _0x5d2a3eab(_0xea5f3a36);
        _0x0ad780b0(_0xea5f3a36);
        _0xea5f3a36.BackgroundColor = Color.clear;
        var _0x65d3f56a = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xe8d81587();
        yield return new WaitForEndOfFrame();
        _0x03c76a4f = true;
        _0xb2f5f18c();
        _0xa3c9ca3f(true);
        _0x6bdb1312 = false;
        _0x1cb3a648 = false;
        _0xd356e5f8.Clear();
        _0x65678db8 = -1;
        firstLoadShown = false;
        _0xf00826ad = false;
        _0x67f25899 = false;
        _0xea5f3a36.SetUserAgent("");
        _0xc849958d = Time.realtimeSinceStartup;
        _0xea5f3a36.Stop();
        _0xea5f3a36.Load(_0xdfcdc300);
        _0xea5f3a36.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0xe441340d._0xeed5ad3c(new byte[25] { 75, 103, 111, 104, 38, 81, 99, 100, 80, 111, 99, 113, 38, 79, 104, 111, 114, 111, 103, 106, 38, 85, 110, 105, 113 }, 6));
    }

    private IEnumerator _0xdaf7c2d3(float _0x8a9f61ac)
    {
        yield return new WaitForSeconds(_0x8a9f61ac);
        if (!_0xe3ef2380)
        {
            _0xe3ef2380 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xfacee621}");
                }
#endif
            }
        }
    }

    private async Task<string> _0x0fcec291(int _0x3e969650 = 5, int _0xd9e2d46c = 500)
    {
        try
        {
            List<EntityData> _0x0a953e61 = new List<EntityData>();
            int _0xae2a41e3 = 0;
            do
            {
                _0x0a953e61 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xe441340d._0xeed5ad3c(new byte[8] { 4, 24, 21, 13, 17, 6, 61, 16 }, 116), _0x5e8b9ef9, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x5e8b9ef9 }), new QueryOptions())).ToList();
                await Task.Delay(_0xd9e2d46c);
            }
            while (_0x0a953e61.Count == 0 && _0xae2a41e3++ < _0x3e969650);
            {
#if B_LOGS
                {
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[33] { 171, 164, 149, 131, 132, 173, 208, 163, 145, 134, 149, 148, 208, 188, 153, 158, 155, 208, 161, 133, 149, 130, 137, 208, 130, 149, 131, 133, 156, 132, 131, 202, 208 }, 240) + JsonConvert.SerializeObject(_0x0a953e61, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[39] { 15, 0, 49, 39, 32, 9, 116, 7, 53, 34, 49, 48, 116, 24, 61, 58, 63, 116, 5, 33, 49, 38, 45, 116, 38, 49, 39, 33, 56, 32, 39, 116, 55, 59, 33, 58, 32, 110, 116 }, 84) + _0x0a953e61.Count);
                }
#endif
            }

            var _0xfa648156 = _0x0a953e61.SelectMany(_0xd63ff156 => _0xd63ff156.Data).FirstOrDefault(_0x2a7c2d7f => _0x2a7c2d7f.Key == _0x5e8b9ef9)?.Value.GetAs<string>() ?? string.Empty;
            _0xfa648156 = Decrypt(_0xfa648156, _0x5e8b9ef9);
            {
#if B_LOGS
                {
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[24] { 20, 27, 42, 60, 59, 18, 111, 3, 32, 46, 43, 111, 60, 46, 57, 42, 43, 111, 35, 38, 33, 36, 117, 111 }, 79) + _0xfa648156);
                }
#endif
            }

            return _0xfa648156;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[39] { 62, 49, 0, 22, 17, 56, 69, 34, 0, 17, 69, 10, 23, 69, 21, 4, 23, 22, 0, 69, 22, 4, 19, 0, 1, 69, 9, 12, 11, 14, 69, 3, 4, 12, 9, 0, 1, 95, 69 }, 101) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private GameObject _0x53a52f4c;
    private ApplicationInstallMode _0x2079da86 = ApplicationInstallMode.Unknown;
    private Task _0x83d511b8(IEnumerator _0x814f783c)
    {
        var _0x3dfd5f5e = new TaskCompletionSource<bool>();
        StartCoroutine(_0x5b5375e5(_0x814f783c, _0x3dfd5f5e));
        return _0x3dfd5f5e.Task;
    }

    internal bool IsGoogleAuthFlowUrl(string _0x9d0179d9)
    {
        if (string.IsNullOrEmpty(_0x9d0179d9))
            return false;
        return _0x9d0179d9.IndexOf(_0xe441340d._0xeed5ad3c(new byte[19] { 174, 172, 172, 160, 186, 161, 187, 188, 225, 168, 160, 160, 168, 163, 170, 225, 172, 160, 162 }, 207), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9d0179d9.IndexOf(_0xe441340d._0xeed5ad3c(new byte[16] { 86, 84, 84, 88, 66, 89, 67, 68, 25, 80, 88, 88, 80, 91, 82, 25 }, 55), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9d0179d9.IndexOf(_0xe441340d._0xeed5ad3c(new byte[21] { 39, 47, 47, 39, 44, 37, 53, 51, 37, 50, 35, 47, 46, 52, 37, 46, 52, 110, 35, 47, 45 }, 64), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9d0179d9.IndexOf(_0xe441340d._0xeed5ad3c(new byte[11] { 132, 144, 151, 130, 151, 138, 128, 205, 128, 140, 142 }, 227), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x0874acbf()
    {
        return _0xe441340d._0xeed5ad3c(new byte[12] { 50, 124, 111, 116, 121, 110, 115, 117, 116, 50, 51, 97 }, 26) + _0xe441340d._0xeed5ad3c(new byte[8] { 236, 251, 232, 186, 239, 251, 167, 189 }, 154) + WindowsDesktopUserAgent + _0xe441340d._0xeed5ad3c(new byte[2] { 203, 215 }, 236) + _0xe441340d._0xeed5ad3c(new byte[30] { 133, 146, 129, 211, 131, 129, 156, 135, 156, 206, 189, 146, 133, 154, 148, 146, 135, 156, 129, 221, 131, 129, 156, 135, 156, 135, 138, 131, 150, 200 }, 243) + _0xe441340d._0xeed5ad3c(new byte[121] { 73, 90, 65, 76, 91, 70, 64, 65, 15, 75, 74, 73, 7, 64, 77, 69, 3, 68, 74, 86, 3, 89, 78, 67, 6, 84, 91, 93, 86, 84, 96, 77, 69, 74, 76, 91, 1, 75, 74, 73, 70, 65, 74, 127, 93, 64, 95, 74, 93, 91, 86, 7, 64, 77, 69, 3, 68, 74, 86, 3, 84, 72, 74, 91, 21, 73, 90, 65, 76, 91, 70, 64, 65, 7, 6, 84, 93, 74, 91, 90, 93, 65, 15, 89, 78, 67, 20, 82, 3, 76, 64, 65, 73, 70, 72, 90, 93, 78, 77, 67, 74, 21, 91, 93, 90, 74, 82, 6, 20, 82, 76, 78, 91, 76, 71, 7, 74, 6, 84, 82, 82 }, 47) + _0xe441340d._0xeed5ad3c(new byte[26] { 194, 195, 192, 142, 214, 212, 201, 210, 201, 138, 129, 211, 213, 195, 212, 231, 193, 195, 200, 210, 129, 138, 211, 199, 143, 157 }, 166) + _0xe441340d._0xeed5ad3c(new byte[130] { 130, 131, 128, 206, 150, 148, 137, 146, 137, 202, 193, 135, 150, 150, 176, 131, 148, 149, 143, 137, 136, 193, 202, 193, 211, 200, 214, 198, 206, 177, 143, 136, 130, 137, 145, 149, 198, 168, 178, 198, 215, 214, 200, 214, 221, 198, 177, 143, 136, 208, 210, 221, 198, 158, 208, 210, 207, 198, 167, 150, 150, 138, 131, 177, 131, 132, 173, 143, 146, 201, 211, 213, 209, 200, 213, 208, 198, 206, 173, 174, 178, 171, 170, 202, 198, 138, 143, 141, 131, 198, 161, 131, 133, 141, 137, 207, 198, 165, 142, 148, 137, 139, 131, 201, 215, 212, 214, 200, 214, 200, 214, 200, 214, 198, 181, 135, 128, 135, 148, 143, 201, 211, 213, 209, 200, 213, 208, 193, 207, 221 }, 230) + _0xe441340d._0xeed5ad3c(new byte[30] { 137, 136, 139, 197, 157, 159, 130, 153, 130, 193, 202, 157, 129, 140, 153, 139, 130, 159, 128, 202, 193, 202, 186, 132, 131, 222, 223, 202, 196, 214 }, 237) + _0xe441340d._0xeed5ad3c(new byte[34] { 101, 100, 103, 41, 113, 115, 110, 117, 110, 45, 38, 119, 100, 111, 101, 110, 115, 38, 45, 38, 70, 110, 110, 102, 109, 100, 33, 72, 111, 98, 47, 38, 40, 58 }, 1) + _0xe441340d._0xeed5ad3c(new byte[30] { 112, 113, 114, 60, 100, 102, 123, 96, 123, 56, 51, 121, 117, 108, 64, 123, 97, 119, 124, 68, 123, 125, 122, 96, 103, 51, 56, 36, 61, 47 }, 20) + _0xe441340d._0xeed5ad3c(new byte[449] { 204, 202, 193, 195, 206, 217, 202, 152, 205, 217, 220, 133, 195, 218, 202, 217, 214, 220, 203, 130, 227, 195, 218, 202, 217, 214, 220, 130, 159, 251, 208, 202, 215, 213, 209, 205, 213, 159, 148, 206, 221, 202, 203, 209, 215, 214, 130, 159, 137, 138, 136, 159, 197, 148, 195, 218, 202, 217, 214, 220, 130, 159, 255, 215, 215, 223, 212, 221, 152, 251, 208, 202, 215, 213, 221, 159, 148, 206, 221, 202, 203, 209, 215, 214, 130, 159, 137, 138, 136, 159, 197, 148, 195, 218, 202, 217, 214, 220, 130, 159, 246, 215, 204, 133, 249, 135, 250, 202, 217, 214, 220, 159, 148, 206, 221, 202, 203, 209, 215, 214, 130, 159, 138, 140, 159, 197, 229, 148, 213, 215, 218, 209, 212, 221, 130, 222, 217, 212, 203, 221, 148, 200, 212, 217, 204, 222, 215, 202, 213, 130, 159, 239, 209, 214, 220, 215, 207, 203, 159, 148, 223, 221, 204, 240, 209, 223, 208, 253, 214, 204, 202, 215, 200, 193, 238, 217, 212, 205, 221, 203, 130, 222, 205, 214, 219, 204, 209, 215, 214, 144, 145, 195, 202, 221, 204, 205, 202, 214, 152, 232, 202, 215, 213, 209, 203, 221, 150, 202, 221, 203, 215, 212, 206, 221, 144, 195, 217, 202, 219, 208, 209, 204, 221, 219, 204, 205, 202, 221, 130, 159, 192, 128, 142, 159, 148, 218, 209, 204, 214, 221, 203, 203, 130, 159, 142, 140, 159, 148, 213, 215, 218, 209, 212, 221, 130, 222, 217, 212, 203, 221, 148, 213, 215, 220, 221, 212, 130, 159, 159, 148, 200, 212, 217, 204, 222, 215, 202, 213, 130, 159, 239, 209, 214, 220, 215, 207, 203, 159, 148, 200, 212, 217, 204, 222, 215, 202, 213, 238, 221, 202, 203, 209, 215, 214, 130, 159, 137, 141, 150, 136, 150, 136, 159, 148, 205, 217, 254, 205, 212, 212, 238, 221, 202, 203, 209, 215, 214, 130, 159, 137, 138, 136, 150, 136, 150, 136, 150, 136, 159, 197, 145, 131, 197, 197, 131, 247, 218, 210, 221, 219, 204, 150, 220, 221, 222, 209, 214, 221, 232, 202, 215, 200, 221, 202, 204, 193, 144, 200, 202, 215, 204, 215, 148, 159, 205, 203, 221, 202, 249, 223, 221, 214, 204, 252, 217, 204, 217, 159, 148, 195, 223, 221, 204, 130, 222, 205, 214, 219, 204, 209, 215, 214, 144, 145, 195, 202, 221, 204, 205, 202, 214, 152, 205, 217, 220, 131, 197, 148, 219, 215, 214, 222, 209, 223, 205, 202, 217, 218, 212, 221, 130, 204, 202, 205, 221, 197, 145, 131, 197, 219, 217, 204, 219, 208, 144, 221, 145, 195, 197 }, 184) + _0xe441340d._0xeed5ad3c(new byte[112] { 245, 244, 247, 185, 226, 242, 227, 244, 244, 255, 189, 182, 230, 248, 245, 229, 249, 182, 189, 160, 168, 163, 161, 184, 170, 245, 244, 247, 185, 226, 242, 227, 244, 244, 255, 189, 182, 249, 244, 248, 246, 249, 229, 182, 189, 160, 161, 169, 161, 184, 170, 245, 244, 247, 185, 226, 242, 227, 244, 244, 255, 189, 182, 240, 231, 240, 248, 253, 198, 248, 245, 229, 249, 182, 189, 160, 168, 163, 161, 184, 170, 245, 244, 247, 185, 226, 242, 227, 244, 244, 255, 189, 182, 240, 231, 240, 248, 253, 217, 244, 248, 246, 249, 229, 182, 189, 160, 161, 165, 161, 184, 170 }, 145) + _0xe441340d._0xeed5ad3c(new byte[45] { 63, 57, 50, 48, 60, 34, 37, 47, 36, 60, 101, 36, 37, 63, 36, 62, 40, 35, 56, 63, 42, 57, 63, 118, 62, 37, 47, 46, 45, 34, 37, 46, 47, 112, 54, 40, 42, 63, 40, 35, 99, 46, 98, 48, 54 }, 75) + _0xe441340d._0xeed5ad3c(new byte[721] { 102, 96, 107, 105, 100, 115, 96, 50, 125, 96, 123, 117, 47, 101, 123, 124, 118, 125, 101, 60, 127, 115, 102, 113, 122, 95, 119, 118, 123, 115, 60, 112, 123, 124, 118, 58, 101, 123, 124, 118, 125, 101, 59, 41, 101, 123, 124, 118, 125, 101, 60, 127, 115, 102, 113, 122, 95, 119, 118, 123, 115, 47, 116, 103, 124, 113, 102, 123, 125, 124, 58, 99, 59, 105, 100, 115, 96, 50, 97, 47, 65, 102, 96, 123, 124, 117, 58, 99, 59, 60, 102, 125, 94, 125, 101, 119, 96, 81, 115, 97, 119, 58, 59, 41, 123, 116, 58, 97, 60, 123, 124, 118, 119, 106, 93, 116, 58, 53, 98, 125, 123, 124, 102, 119, 96, 40, 50, 113, 125, 115, 96, 97, 119, 53, 59, 44, 47, 34, 110, 110, 97, 60, 123, 124, 118, 119, 106, 93, 116, 58, 53, 122, 125, 100, 119, 96, 40, 50, 124, 125, 124, 119, 53, 59, 44, 47, 34, 110, 110, 97, 60, 123, 124, 118, 119, 106, 93, 116, 58, 53, 127, 115, 106, 63, 101, 123, 118, 102, 122, 53, 59, 44, 47, 34, 110, 110, 97, 60, 123, 124, 118, 119, 106, 93, 116, 58, 53, 127, 115, 106, 63, 118, 119, 100, 123, 113, 119, 63, 101, 123, 118, 102, 122, 53, 59, 44, 47, 34, 59, 96, 119, 102, 103, 96, 124, 50, 105, 127, 115, 102, 113, 122, 119, 97, 40, 116, 115, 126, 97, 119, 62, 127, 119, 118, 123, 115, 40, 99, 62, 125, 124, 113, 122, 115, 124, 117, 119, 40, 124, 103, 126, 126, 62, 115, 118, 118, 94, 123, 97, 102, 119, 124, 119, 96, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 111, 62, 96, 119, 127, 125, 100, 119, 94, 123, 97, 102, 119, 124, 119, 96, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 111, 62, 115, 118, 118, 87, 100, 119, 124, 102, 94, 123, 97, 102, 119, 124, 119, 96, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 111, 62, 96, 119, 127, 125, 100, 119, 87, 100, 119, 124, 102, 94, 123, 97, 102, 119, 124, 119, 96, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 111, 62, 118, 123, 97, 98, 115, 102, 113, 122, 87, 100, 119, 124, 102, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 96, 119, 102, 103, 96, 124, 50, 116, 115, 126, 97, 119, 41, 111, 111, 41, 123, 116, 58, 97, 60, 123, 124, 118, 119, 106, 93, 116, 58, 53, 98, 125, 123, 124, 102, 119, 96, 40, 50, 116, 123, 124, 119, 53, 59, 44, 47, 34, 110, 110, 97, 60, 123, 124, 118, 119, 106, 93, 116, 58, 53, 122, 125, 100, 119, 96, 40, 50, 122, 125, 100, 119, 96, 53, 59, 44, 47, 34, 59, 96, 119, 102, 103, 96, 124, 50, 105, 127, 115, 102, 113, 122, 119, 97, 40, 102, 96, 103, 119, 62, 127, 119, 118, 123, 115, 40, 99, 62, 125, 124, 113, 122, 115, 124, 117, 119, 40, 124, 103, 126, 126, 62, 115, 118, 118, 94, 123, 97, 102, 119, 124, 119, 96, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 111, 62, 96, 119, 127, 125, 100, 119, 94, 123, 97, 102, 119, 124, 119, 96, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 111, 62, 115, 118, 118, 87, 100, 119, 124, 102, 94, 123, 97, 102, 119, 124, 119, 96, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 111, 62, 96, 119, 127, 125, 100, 119, 87, 100, 119, 124, 102, 94, 123, 97, 102, 119, 124, 119, 96, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 111, 62, 118, 123, 97, 98, 115, 102, 113, 122, 87, 100, 119, 124, 102, 40, 116, 103, 124, 113, 102, 123, 125, 124, 58, 59, 105, 96, 119, 102, 103, 96, 124, 50, 116, 115, 126, 97, 119, 41, 111, 111, 41, 96, 119, 102, 103, 96, 124, 50, 125, 96, 123, 117, 58, 99, 59, 41, 111, 41, 111, 113, 115, 102, 113, 122, 58, 119, 59, 105, 111 }, 18) + _0xe441340d._0xeed5ad3c(new byte[5] { 169, 253, 252, 253, 239 }, 212);
    }

    private void _0xa3c9ca3f(bool _0x2327fb40)
    {
        _0xb2f5f18c();
        _0x53a52f4c.SetActive(_0x2327fb40);
        _0x847e39e2 = _0x2327fb40;
        if (_0x2327fb40)
        {
            _0x53a52f4c.transform.SetAsLastSibling();
            if (_0x92bbc448 != null)
                _0x92bbc448.localRotation = Quaternion.identity;
        }
    }

    private void _0xd04993cb()
    {
        using (var _0xfd321619 = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[30] { 115, 127, 125, 62, 101, 126, 121, 100, 105, 35, 116, 62, 96, 124, 113, 105, 117, 98, 62, 69, 126, 121, 100, 105, 64, 124, 113, 105, 117, 98 }, 16)))
        using (var _0x673074c9 = _0xfd321619.GetStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[15] { 102, 112, 119, 119, 96, 107, 113, 68, 102, 113, 108, 115, 108, 113, 124 }, 5)))
        using (var _0x597afda3 = _0x673074c9.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[9] { 187, 185, 168, 149, 178, 168, 185, 178, 168 }, 220)))
        {
            if (_0x597afda3 == null)
                return;
            using (var _0xec95ac79 = _0x597afda3.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[9] { 112, 114, 99, 82, 111, 99, 101, 118, 100 }, 23)))
            {
                if (_0xec95ac79 == null)
                    return;
                using (var _0x6d908487 = new AndroidJavaObject(_0xe441340d._0xeed5ad3c(new byte[19] { 200, 213, 192, 137, 205, 212, 200, 201, 137, 237, 244, 232, 233, 232, 197, 205, 194, 196, 211 }, 167)))
                using (var _0x609e77a3 = _0xec95ac79.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[6] { 195, 205, 209, 251, 205, 220 }, 168)))
                using (var _0xe5d96c5a = _0x609e77a3.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[8] { 20, 9, 24, 15, 28, 9, 18, 15 }, 125)))
                {
                    while (_0xe5d96c5a.Call<bool>(_0xe441340d._0xeed5ad3c(new byte[7] { 47, 38, 52, 9, 34, 63, 51 }, 71)))
                    {
                        string _0xeaff7694 = _0xe5d96c5a.Call<string>(_0xe441340d._0xeed5ad3c(new byte[4] { 161, 170, 183, 187 }, 207));
                        using (var _0xa34246bb = _0xec95ac79.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[3] { 248, 250, 235 }, 159), _0xeaff7694))
                        {
                            _0x6d908487.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[3] { 119, 114, 115 }, 7), _0xeaff7694, _0xa34246bb);
                        }
                    }

                    string _0xa9e9f750 = _0x6d908487.Call<string>(_0xe441340d._0xeed5ad3c(new byte[8] { 162, 185, 133, 162, 164, 191, 184, 177 }, 214));
                    if (!string.IsNullOrEmpty(_0xa9e9f750))
                    {
                        _0x6e9248fb(_0xa9e9f750);
                        _0x0de089ab(_0xa9e9f750);
                    }
                }
            }
        }
    }

    private void MarkMainFrameCommitted(string _0x86e1d010)
    {
        _0xcf67103a = true;
        string _0x83b342b4 = GetUrlHost(_0x86e1d010);
        if (!string.IsNullOrEmpty(_0x83b342b4))
            _0xa61bf2c5 = _0x83b342b4;
    }

    private void _0x75f9cd9a(string _0xea10289c)
    {
        bool _0x25407e2e = !string.IsNullOrEmpty(_0xea10289c);
        if (_0x25407e2e)
        {
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[13] { 82, 93, 108, 122, 125, 84, 41, 90, 97, 102, 126, 51, 41 }, 9) + _0xea10289c);
#endif
            }

            _0x0e24a26b(_0xea10289c);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[39] { 166, 169, 152, 142, 137, 160, 221, 187, 156, 145, 145, 159, 156, 158, 150, 221, 31, 123, 111, 221, 186, 156, 144, 152, 221, 213, 147, 146, 221, 155, 148, 147, 156, 145, 221, 168, 175, 177, 212 }, 253));
#endif
            }

            _0x29c7d39a();
            return;
        }
    }

    private IEnumerator _0xd91c845f()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[26] { 141, 130, 179, 165, 162, 139, 246, 159, 184, 191, 162, 191, 183, 186, 191, 172, 179, 132, 179, 176, 176, 179, 164, 179, 164, 246 }, 214));
            }
#endif
        }

        bool _0x410f0be2 = false;
        InstallReferrer.GetReferrer((_0x5bd7ff2f) =>
        {
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[24] { 61, 50, 3, 21, 18, 70, 52, 3, 0, 3, 20, 20, 3, 20, 59, 70, 1, 3, 18, 70, 132, 224, 244, 70 }, 102) + _0xfacee621);
            if (_0x5bd7ff2f.IsSuccess)
            {
                _0xfacee621 = _0x5bd7ff2f.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[28] { 155, 148, 165, 179, 180, 224, 146, 165, 166, 165, 178, 178, 165, 178, 157, 224, 147, 181, 163, 163, 165, 179, 179, 224, 34, 70, 82, 224 }, 192) + _0xfacee621);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[27] { 111, 96, 81, 71, 64, 20, 102, 81, 82, 81, 70, 70, 81, 70, 105, 20, 114, 85, 93, 88, 81, 80, 20, 214, 178, 166, 20 }, 52) + _0x5bd7ff2f);
#endif
                }

                _0xfacee621 = "";
            }

            _0xe3ef2380 = true;
        });
        StartCoroutine(_0xdaf7c2d3(2f));
        yield return new WaitUntil(() => _0xe3ef2380);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xfacee621}");
#endif
        }

        bool _0x00a0deb0 = _0xfacee621.Contains(_0xe441340d._0xeed5ad3c(new byte[6] { 113, 117, 122, 127, 114, 43 }, 22));
        _0x410f0be2 = _0x00a0deb0 || _0xfacee621.Contains(_0xe441340d._0xeed5ad3c(new byte[18] { 13, 28, 28, 31, 66, 5, 2, 31, 24, 13, 11, 30, 13, 1, 66, 15, 3, 1 }, 108)) || _0xfacee621.Contains(_0xe441340d._0xeed5ad3c(new byte[17] { 219, 202, 202, 201, 148, 220, 219, 217, 223, 216, 213, 213, 209, 148, 217, 213, 215 }, 186));
        _0x6785142e = _0x00a0deb0 ? "" : (_0x410f0be2 ? "" : _0x6785142e);
        _0x6785142e = _0x6785142e ?? "";
        _0x3aebf144 = _0x3aebf144 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x6785142e}");
#endif
        }
    }

    private bool TryOpenExternalLikeChrome(string _0xfa981dc7)
    {
        if (string.IsNullOrEmpty(_0xfa981dc7))
            return false;
        if (_0xfa981dc7.StartsWith(_0xe441340d._0xeed5ad3c(new byte[9] { 255, 248, 226, 243, 248, 226, 172, 185, 185 }, 150), StringComparison.OrdinalIgnoreCase))
            return _0x4fd25bd0(_0xfa981dc7);
        if (_0x71141ee5(_0xfa981dc7))
            return _0xfa56f636(_0xfa981dc7, null);
        if (!_0xfa981dc7.StartsWith(_0xe441340d._0xeed5ad3c(new byte[7] { 231, 251, 251, 255, 181, 160, 160 }, 143), StringComparison.OrdinalIgnoreCase) && !_0xfa981dc7.StartsWith(_0xe441340d._0xeed5ad3c(new byte[8] { 47, 51, 51, 55, 52, 125, 104, 104 }, 71), StringComparison.OrdinalIgnoreCase) && !_0xfa981dc7.StartsWith(_0xe441340d._0xeed5ad3c(new byte[11] { 170, 169, 164, 190, 191, 241, 169, 167, 170, 165, 160 }, 203), StringComparison.OrdinalIgnoreCase))
        {
            return _0x7506bbaa(_0xfa981dc7);
        }

        return false;
    }

    private void _0xf7b55842()
    {
        WLog(_0xe441340d._0xeed5ad3c(new byte[21] { 172, 133, 150, 128, 147, 133, 150, 129, 196, 134, 133, 135, 143, 196, 148, 150, 129, 151, 151, 129, 128 }, 228));
        if (Time.frameCount == _0x65678db8)
            return;
        _0x65678db8 = Time.frameCount;
        if (_0xd6ddb456())
            return;
        _0x482a2a46();
    }

    private string _0xc3ac42dd = "";
    private string _0x6785142e { get; set; }

    private int _0xe81a1b0d = 5, _0xb7a800ff = 5, _0x764f3410 = 5, _0x33891908 = 5;
    private string _0x65f9d80e;
    internal bool ContainsIgnoreCase(string _0x67efda4c, string _0xe9b30586)
    {
        if (string.IsNullOrEmpty(_0x67efda4c) || string.IsNullOrEmpty(_0xe9b30586))
            return false;
        return _0x67efda4c.IndexOf(_0xe9b30586, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xdfe64dcf()
    {
        if (string.IsNullOrEmpty(_0xd56e9c66) && _0xea5f3a36 != null)
            _0xd56e9c66 = _0xea5f3a36.GetUserAgent();
        if (string.IsNullOrEmpty(_0xd56e9c66))
            return string.Empty;
        string _0x92969a10 = Regex.Replace(_0xd56e9c66, _0xe441340d._0xeed5ad3c(new byte[11] { 159, 176, 233, 248, 159, 176, 233, 180, 181, 159, 161 }, 195), string.Empty);
        _0x92969a10 = Regex.Replace(_0x92969a10, _0xe441340d._0xeed5ad3c(new byte[15] { 80, 127, 39, 78, 121, 101, 96, 104, 35, 87, 82, 55, 37, 81, 39 }, 12), string.Empty);
        _0x92969a10 = Regex.Replace(_0x92969a10, _0xe441340d._0xeed5ad3c(new byte[15] { 225, 210, 197, 196, 222, 216, 217, 152, 131, 235, 153, 135, 235, 196, 157 }, 183), string.Empty);
        return Regex.Replace(_0x92969a10, _0xe441340d._0xeed5ad3c(new byte[6] { 84, 123, 115, 58, 36, 117 }, 8), _0xe441340d._0xeed5ad3c(new byte[1] { 83 }, 115)).Trim();
    }

    internal void _0xe8d81587()
    {
        Rect _0x5646ce01 = Screen.safeArea;
        Vector2 _0xca9b6675 = new Vector2(Screen.width, Screen.height);
        if (_0x5646ce01 == lastSafe && _0xca9b6675 == lastSize)
            return;
        // Apply manual padding
        _0x5646ce01.xMin += _0x764f3410;
        _0x5646ce01.xMax -= _0x33891908;
        _0x5646ce01.yMin += _0xb7a800ff;
        _0x5646ce01.yMax -= _0xe81a1b0d;
        // Convert Unity safe area -> native WebView frame
        Rect _0x51e4bbc4 = new Rect(_0x5646ce01.x, _0xca9b6675.y - _0x5646ce01.y - _0x5646ce01.height, // Y flip for native coordinate system
 _0x5646ce01.width, _0x5646ce01.height);
        _0xea5f3a36.Frame = _0x51e4bbc4;
        lastSafe = Screen.safeArea;
        lastSize = _0xca9b6675;
    }

    private bool _0x1647e54d()
    {
        _0xd356e5f8.RemoveAll(_0x9e0df9d2 => _0x9e0df9d2 == null || !_0x9e0df9d2.IsAlive);
        return _0xd356e5f8.Count > 0;
    }

    private async Task _0x95eb94b5()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x07129c91 = _0xe441340d._0xeed5ad3c(new byte[5] { 76, 75, 70, 89, 79 }, 42);
        _0x6d266de2 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x181a4109 = DateTime.UtcNow.Ticks.ToString();
        _0x43c9e51b = "";
        JObject _0x4bf13142 = _0x977901f7(_0x33a7014e, _0x48aba5b6, _0x52e72cc7, _0xca8453ae, _0xfacee621, _0x6785142e, _0x3aebf144, _0xd56e9c66, _0xf450acbd, _0x02251dd4, _0x07129c91, _0x43c9e51b, _0xfc6dc768, _0xf50ed0e0, _0x2079da86.ToString(), _0x26d5f321, _0x181a4109, _0x6d266de2, _0x5e8b9ef9, _0x0b3f9733, _0xc3ac42dd, _0x90321c91, _0xdc7d1bec());
        var _0x7dd06d7a = _0x35249414(_0x4bf13142.ToString(), _0x5e8b9ef9);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x4bf13142}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xe441340d._0xeed5ad3c(new byte[7] { 174, 191, 167, 178, 177, 191, 186 }, 222) + _0x5e8b9ef9, _0x7dd06d7a } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[22] { 37, 42, 59, 45, 42, 35, 94, 57, 27, 16, 27, 12, 31, 18, 94, 27, 12, 12, 17, 12, 68, 94 }, 126) + e.Message);
#endif
            }
        }

        await Task.Delay(500);
        string _0x663d1eaa = "";
        for (int _0x54024c02 = 0; _0x54024c02 < 30; _0x54024c02++)
        {
            if (await _0xf6fb5e63(1, 1))
            {
                await _0xb7c2a532(_0xe441340d._0xeed5ad3c(new byte[7] { 93, 83, 80, 92, 84, 90, 91 }, 63));
                _0x29c7d39a();
                return;
            }

            _0x663d1eaa = await _0x0fcec291(1, 500);
            if (!string.IsNullOrEmpty(_0x663d1eaa))
                break;
        }

        _0x75f9cd9a(_0x663d1eaa);
    }

    private void _0x8f0b6f11()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private static bool IsPrivacyItemTrue(Item _0xee2630ec)
    {
        if (_0xee2630ec.Key != _0xe441340d._0xeed5ad3c(new byte[9] { 8, 18, 49, 19, 8, 23, 0, 2, 24 }, 97))
            return false;
        try
        {
            var _0x91431d98 = _0xee2630ec.Value.GetAs<object>();
            return _0x91431d98 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    internal string _0x724a6850(string _0xcc60c718)
    {
        int _0xa8294603 = _0xcc60c718.IndexOf(_0xe441340d._0xeed5ad3c(new byte[3] { 155, 150, 207 }, 242), StringComparison.OrdinalIgnoreCase);
        if (_0xa8294603 < 0)
            return null;
        string _0x428a42ce = _0xcc60c718.Substring(_0xa8294603 + 3);
        int _0x4d68a899 = _0x428a42ce.IndexOf('&');
        return _0x4d68a899 >= 0 ? _0x428a42ce.Substring(0, _0x4d68a899) : _0x428a42ce;
    }

    private float _0xc849958d = 0f;
    private string _0xfacee621 = "";
    private bool _0x9499e5a7(string _0x82805297)
    {
        if (string.IsNullOrEmpty(_0x82805297))
            return false;
        try
        {
            using (var _0xb8eee9dc = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[30] { 66, 78, 76, 15, 84, 79, 72, 85, 88, 18, 69, 15, 81, 77, 64, 88, 68, 83, 15, 116, 79, 72, 85, 88, 113, 77, 64, 88, 68, 83 }, 33)))
            using (var _0xc7a51c40 = _0xb8eee9dc.GetStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[15] { 251, 237, 234, 234, 253, 246, 236, 217, 251, 236, 241, 238, 241, 236, 225 }, 152)))
            using (var _0x844e2846 = _0xc7a51c40.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[17] { 92, 94, 79, 107, 90, 88, 80, 90, 92, 94, 118, 90, 85, 90, 92, 94, 73 }, 59)))
            using (var _0xb55aa3e3 = _0x844e2846.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[25] { 252, 254, 239, 215, 250, 238, 245, 248, 243, 210, 245, 239, 254, 245, 239, 221, 244, 233, 203, 250, 248, 240, 250, 252, 254 }, 155), _0x82805297))
            {
                if (_0xb55aa3e3 == null)
                    return false;
                WLog(_0xe441340d._0xeed5ad3c(new byte[37] { 23, 60, 38, 59, 57, 49, 24, 61, 63, 49, 116, 56, 53, 33, 58, 55, 60, 116, 61, 58, 39, 32, 53, 56, 56, 49, 48, 116, 36, 53, 55, 63, 53, 51, 49, 110, 116 }, 84) + _0x82805297);
                _0xb55aa3e3.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[8] { 124, 121, 121, 91, 113, 124, 122, 110 }, 29), 0x10000000);
                _0xc7a51c40.Call(_0xe441340d._0xeed5ad3c(new byte[13] { 38, 33, 52, 39, 33, 20, 54, 33, 60, 35, 60, 33, 44 }, 85), _0xb55aa3e3);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool _0x6bdb1312 = false;
    private void _0x0de089ab(string _0x55166e75)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[34] { 115, 124, 77, 91, 92, 117, 8, 110, 77, 92, 75, 64, 8, 109, 80, 92, 90, 73, 8, 120, 93, 91, 64, 8, 108, 73, 92, 73, 8, 122, 73, 95, 18, 8 }, 40) + _0x55166e75);
#endif
            }
        }

        var _0x224b1555 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x55166e75);
        StartCoroutine(_0xe629ae5d(_0x224b1555));
    }

    // MAIN FLOW
    private bool _0xe3ef2380 { get; set; }

    internal Button _0x757cf2e6(string _0x2911ac85, Transform _0xb846f8a7)
    {
        var _0x5ed767b7 = new GameObject(_0x2911ac85 + _0xe441340d._0xeed5ad3c(new byte[3] { 141, 187, 161 }, 207), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x4aeb2dc2 = _0x5ed767b7.GetComponent<RectTransform>();
        _0x4aeb2dc2.SetParent(_0xb846f8a7, false);
        var _0xf01e3cdf = _0x5ed767b7.GetComponent<Image>();
        _0xf01e3cdf.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x575018a8 = _0x5ed767b7.GetComponent<Button>();
        var _0x5a0cd095 = _0x575018a8.colors;
        _0x5a0cd095.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x5a0cd095.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x575018a8.colors = _0x5a0cd095;
        var _0x736a86e6 = new GameObject(_0xe441340d._0xeed5ad3c(new byte[4] { 138, 187, 166, 170 }, 222), typeof(RectTransform), typeof(Text));
        var _0x6b0817e3 = _0x736a86e6.GetComponent<RectTransform>();
        _0x6b0817e3.SetParent(_0x5ed767b7.transform, false);
        _0x6b0817e3.anchorMin = Vector2.zero;
        _0x6b0817e3.anchorMax = Vector2.one;
        _0x6b0817e3.offsetMin = _0x6b0817e3.offsetMax = Vector2.zero;
        var _0x88b9b406 = _0x736a86e6.GetComponent<Text>();
        _0x88b9b406.text = _0x2911ac85;
        _0x88b9b406.alignment = TextAnchor.MiddleCenter;
        _0x88b9b406.color = Color.black;
        _0x88b9b406.font = Resources.GetBuiltinResource<Font>(_0xe441340d._0xeed5ad3c(new byte[9] { 174, 157, 134, 142, 131, 193, 155, 155, 137 }, 239));
        _0x88b9b406.fontSize = 28;
        WLog(_0xe441340d._0xeed5ad3c(new byte[14] { 106, 91, 76, 72, 93, 76, 107, 92, 93, 93, 70, 71, 9, 14 }, 41) + _0x2911ac85 + _0xe441340d._0xeed5ad3c(new byte[1] { 138 }, 173));
        return _0x575018a8;
    }

    private void _0x0ad780b0(UniWebView _0x5b6873f8)
    {
        if (_0x1b08c16b)
            return;
        _0x1b08c16b = true;
        _0x5b6873f8.AddUrlScheme(_0xe441340d._0xeed5ad3c(new byte[2] { 131, 144 }, 247));
        _0x5b6873f8.AddUrlScheme(_0xe441340d._0xeed5ad3c(new byte[6] { 55, 48, 42, 59, 48, 42 }, 94));
        _0x5b6873f8.AddUrlScheme(_0xe441340d._0xeed5ad3c(new byte[6] { 88, 84, 71, 94, 80, 65 }, 53));
        _0x5b6873f8.OnMessageReceived += (_0xa308d507, _0x2062da7e) =>
        {
            if (TryOpenExternalLikeChrome(_0x2062da7e.RawMessage))
            {
                _0xa3c9ca3f(false);
                return;
            }
        };
        _0x5b6873f8.RegisterShouldHandleRequest(_0x082d9915 =>
        {
            string _0x5d936057 = _0x082d9915 != null ? _0x082d9915.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x5d936057))
                return true;
            WLog(_0xe441340d._0xeed5ad3c(new byte[21] { 246, 205, 202, 208, 201, 193, 237, 196, 203, 193, 201, 192, 247, 192, 212, 208, 192, 214, 209, 159, 133 }, 165) + _0x5d936057);
            if (TryOpenExternalLikeChrome(_0x5d936057))
            {
                _0xa3c9ca3f(false);
                return false;
            }

            if (_0x082d9915 != null && _0x082d9915.IsMainFrame && IsGoogleAuthFlowUrl(_0x5d936057) && !_0x1cb3a648)
            {
                WLog(_0xe441340d._0xeed5ad3c(new byte[62] { 87, 123, 115, 116, 58, 77, 127, 120, 76, 115, 127, 109, 58, 126, 127, 110, 127, 121, 110, 127, 126, 58, 93, 117, 117, 125, 118, 127, 58, 123, 111, 110, 114, 58, 79, 72, 86, 58, 55, 36, 58, 104, 127, 118, 117, 123, 126, 58, 109, 115, 110, 114, 58, 93, 117, 117, 125, 118, 127, 58, 79, 91 }, 26));
                _0x1cb3a648 = true;
                _0xa3c9ca3f(true);
                _0xea5f3a36.SetUserAgent(_0xdfe64dcf());
                _0xea5f3a36.Load(_0x5d936057);
                return false;
            }

            return true;
        });
        _0x5b6873f8.OnLoadingErrorReceived += (_0xa308d507, _0x39416eb5, _0x2062da7e, _0x30f143c5) =>
        {
            WLog(_0xe441340d._0xeed5ad3c(new byte[25] { 52, 24, 16, 23, 89, 46, 28, 27, 47, 16, 28, 14, 89, 60, 11, 11, 22, 11, 67, 89, 26, 22, 29, 28, 68 }, 121) + _0x39416eb5 + _0xe441340d._0xeed5ad3c(new byte[9] { 85, 24, 16, 6, 6, 20, 18, 16, 72 }, 117) + _0x2062da7e);
            string _0xe319ab8a = GetFailingUrl(_0x30f143c5);
            if (string.IsNullOrEmpty(_0xe319ab8a) || IsAboutBlank(_0xe319ab8a))
                return;
            if (IsSslError(_0x39416eb5, _0x2062da7e) && _0xdd19cf10(_0xe319ab8a))
            {
                WLog(_0xe441340d._0xeed5ad3c(new byte[52] { 220, 242, 251, 250, 231, 240, 181, 198, 198, 217, 181, 240, 231, 231, 250, 231, 181, 250, 224, 225, 230, 252, 241, 240, 181, 225, 253, 240, 181, 248, 244, 252, 251, 181, 241, 250, 246, 224, 248, 240, 251, 225, 175, 181, 243, 244, 252, 249, 252, 251, 242, 168 }, 149) + _0xe319ab8a + _0xe441340d._0xeed5ad3c(new byte[6] { 106, 39, 43, 35, 36, 119 }, 74) + _0xa61bf2c5 + _0xe441340d._0xeed5ad3c(new byte[11] { 226, 161, 173, 175, 175, 171, 182, 182, 167, 166, 255 }, 194) + _0xcf67103a);
                return;
            }

            _ = _0xb7c2a532(_0xe441340d._0xeed5ad3c(new byte[8] { 147, 146, 187, 129, 150, 150, 139, 150 }, 228));
            WLog(_0xe441340d._0xeed5ad3c(new byte[45] { 63, 19, 27, 28, 82, 37, 23, 16, 36, 27, 23, 5, 82, 20, 19, 27, 30, 27, 28, 21, 82, 39, 32, 62, 82, 95, 76, 82, 29, 2, 23, 28, 82, 23, 10, 6, 23, 0, 28, 19, 30, 30, 11, 72, 82 }, 114) + _0xe319ab8a);
            StopCurrentFailedLoad(_0xa308d507);
            _0x2f91a9f8(_0xe319ab8a);
        };
        _0x5b6873f8.OnPageStarted += (_0xa308d507, _0xb4ea66bb) =>
        {
            _0x4f260de2 = 0;
            if (_0x6bdb1312 && IsAboutBlank(_0xb4ea66bb))
            {
                WLog(_0xe441340d._0xeed5ad3c(new byte[27] { 222, 252, 235, 249, 239, 252, 227, 174, 239, 236, 225, 251, 250, 180, 236, 226, 239, 224, 229, 174, 253, 250, 239, 252, 250, 235, 234 }, 142));
                return;
            }

            _0xcf67103a = false;
            string _0x598ff01e = GetUrlHost(_0xb4ea66bb);
            if (!string.IsNullOrEmpty(_0x598ff01e))
                _0xa61bf2c5 = _0x598ff01e;
            WLog(_0xe441340d._0xeed5ad3c(new byte[29] { 138, 166, 174, 169, 231, 144, 162, 165, 145, 174, 162, 176, 231, 136, 169, 151, 166, 160, 162, 148, 179, 166, 181, 179, 162, 163, 253, 231, 236 }, 199) + (Time.realtimeSinceStartup - _0xc849958d).ToString(_0xe441340d._0xeed5ad3c(new byte[5] { 28, 2, 28, 28, 28 }, 44)) + _0xe441340d._0xeed5ad3c(new byte[2] { 168, 251 }, 219) + _0xb4ea66bb);
            if (TryOpenExternalLikeChrome(_0xb4ea66bb))
            {
                StopCurrentFailedLoad(_0xa308d507);
                return;
            }

            if (ContainsIgnoreCase(_0xb4ea66bb, _0xe441340d._0xeed5ad3c(new byte[8] { 146, 159, 159, 151, 216, 151, 134, 134 }, 246)) || ContainsIgnoreCase(_0xb4ea66bb, _0xe441340d._0xeed5ad3c(new byte[15] { 249, 232, 240, 167, 254, 224, 237, 238, 236, 253, 167, 235, 229, 230, 238 }, 137)) || _0xb4ea66bb.StartsWith(_0xe441340d._0xeed5ad3c(new byte[25] { 215, 203, 203, 207, 204, 133, 144, 144, 221, 207, 216, 211, 208, 221, 222, 211, 217, 222, 201, 145, 211, 214, 201, 218, 144 }, 191), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xa308d507);
                OpenUrlExternally(_0xb4ea66bb);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xb4ea66bb))
            {
                _0xa3c9ca3f(true);
                WLog(_0xe441340d._0xeed5ad3c(new byte[41] { 49, 25, 25, 17, 26, 19, 86, 23, 3, 2, 30, 86, 16, 26, 25, 1, 86, 18, 19, 2, 19, 21, 2, 19, 18, 86, 91, 72, 86, 29, 19, 19, 6, 86, 0, 31, 5, 31, 20, 26, 19 }, 118));
                return;
            }

            _0xf00826ad = true;
            _0xa3c9ca3f(true);
            WLog(_0xe441340d._0xeed5ad3c(new byte[43] { 37, 23, 16, 36, 27, 23, 5, 82, 30, 29, 19, 22, 27, 28, 21, 93, 0, 23, 22, 27, 0, 23, 17, 6, 27, 28, 21, 82, 95, 76, 82, 25, 23, 23, 2, 82, 4, 27, 1, 27, 16, 30, 23 }, 114));
        };
        _0x5b6873f8.OnPageCommitted += (_0xa308d507, _0xb4ea66bb) =>
        {
            if (_0x6bdb1312 && IsAboutBlank(_0xb4ea66bb))
                return;
            MarkMainFrameCommitted(_0xb4ea66bb);
            WLog(_0xe441340d._0xeed5ad3c(new byte[31] { 210, 254, 246, 241, 191, 200, 250, 253, 201, 246, 250, 232, 191, 208, 241, 207, 254, 248, 250, 220, 240, 242, 242, 246, 235, 235, 250, 251, 165, 191, 180 }, 159) + (Time.realtimeSinceStartup - _0xc849958d).ToString(_0xe441340d._0xeed5ad3c(new byte[5] { 170, 180, 170, 170, 170 }, 154)) + _0xe441340d._0xeed5ad3c(new byte[2] { 170, 249 }, 217) + _0xb4ea66bb);
            if (!firstLoadShown && IsHttpUrl(_0xb4ea66bb))
            {
                firstLoadShown = true;
                _0xf00826ad = false;
                _0xa3c9ca3f(false);
                _0x8f0b6f11();
                _0xe8d81587();
                _0xa308d507.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xb7c2a532(_0xe441340d._0xeed5ad3c(new byte[9] { 184, 185, 144, 160, 191, 170, 161, 170, 171 }, 207));
                WLog(_0xe441340d._0xeed5ad3c(new byte[39] { 42, 6, 14, 9, 71, 48, 2, 5, 49, 14, 2, 16, 71, 20, 15, 8, 16, 9, 71, 8, 9, 71, 4, 8, 10, 10, 14, 19, 19, 2, 3, 71, 4, 8, 9, 19, 2, 9, 19 }, 103));
            }
        };
        _0x5b6873f8.OnPageProgressChanged += (_0xa308d507, _0x77424abc) =>
        {
            if (_0x6bdb1312)
                return;
            if (!firstLoadShown && _0x77424abc >= 0.65f)
            {
                firstLoadShown = true;
                _0xf00826ad = false;
                _0xa3c9ca3f(false);
                _0x8f0b6f11();
                _0xe8d81587();
                _0xa308d507.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xb7c2a532(_0xe441340d._0xeed5ad3c(new byte[9] { 14, 15, 38, 22, 9, 28, 23, 28, 29 }, 121));
                WLog(_0xe441340d._0xeed5ad3c(new byte[32] { 118, 90, 82, 85, 27, 108, 94, 89, 109, 82, 94, 76, 27, 72, 83, 84, 76, 85, 27, 89, 66, 27, 75, 73, 84, 92, 73, 94, 72, 72, 1, 27 }, 59) + _0x77424abc);
            }
        };
        _0x5b6873f8.OnPageFinished += (_0xa308d507, _0x39416eb5, _0xb4ea66bb) =>
        {
            if (_0x6bdb1312 && IsAboutBlank(_0xb4ea66bb))
            {
                _0x6bdb1312 = false;
                WLog(_0xe441340d._0xeed5ad3c(new byte[28] { 79, 109, 122, 104, 126, 109, 114, 63, 126, 125, 112, 106, 107, 37, 125, 115, 126, 113, 116, 63, 121, 118, 113, 118, 108, 119, 122, 123 }, 31));
                return;
            }

            WLog(_0xe441340d._0xeed5ad3c(new byte[24] { 182, 154, 146, 149, 219, 172, 158, 153, 173, 146, 158, 140, 219, 189, 146, 149, 146, 136, 147, 158, 159, 193, 219, 208 }, 251) + (Time.realtimeSinceStartup - _0xc849958d).ToString(_0xe441340d._0xeed5ad3c(new byte[5] { 54, 40, 54, 54, 54 }, 6)) + _0xe441340d._0xeed5ad3c(new byte[7] { 160, 243, 176, 188, 183, 182, 238 }, 211) + _0x39416eb5 + _0xe441340d._0xeed5ad3c(new byte[5] { 193, 148, 147, 141, 220 }, 225) + _0xb4ea66bb);
            if (_0x39416eb5 >= 200 && _0x39416eb5 < 400)
                MarkMainFrameCommitted(_0xb4ea66bb);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xf00826ad = false;
                _0xa3c9ca3f(false);
                _0x8f0b6f11();
                _0xe8d81587();
                _0xa308d507.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xb7c2a532(_0xe441340d._0xeed5ad3c(new byte[9] { 125, 124, 85, 101, 122, 111, 100, 111, 110 }, 10));
                WLog(_0xe441340d._0xeed5ad3c(new byte[33] { 93, 113, 121, 126, 48, 71, 117, 114, 70, 121, 117, 103, 48, 118, 121, 98, 99, 100, 48, 124, 127, 113, 116, 48, 115, 127, 125, 96, 124, 117, 100, 117, 116 }, 16));
            }
            else if (_0xf00826ad)
            {
                _0xf00826ad = false;
                _0xa3c9ca3f(false);
                _0xa308d507.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xe441340d._0xeed5ad3c(new byte[40] { 91, 119, 127, 120, 54, 65, 115, 116, 64, 127, 115, 97, 54, 69, 126, 121, 97, 54, 119, 112, 98, 115, 100, 54, 122, 121, 119, 114, 127, 120, 113, 54, 112, 127, 120, 127, 101, 126, 115, 114 }, 22));
            }
            else
            {
                _0xa3c9ca3f(false);
            }

            if (_0x1cb3a648 && !IsGoogleAuthFlowUrl(_0xb4ea66bb) && !IsGoogleAuthFlowUrl(_0xb4ea66bb))
            {
                WLog(_0xe441340d._0xeed5ad3c(new byte[48] { 180, 156, 156, 148, 159, 150, 211, 146, 134, 135, 155, 211, 128, 150, 150, 158, 128, 211, 149, 154, 157, 154, 128, 155, 150, 151, 211, 222, 205, 211, 129, 150, 128, 135, 156, 129, 150, 211, 151, 150, 149, 146, 134, 159, 135, 211, 166, 178 }, 243));
                _0x1cb3a648 = false;
                _0xea5f3a36.SetUserAgent("");
            }
        };
        _0x5b6873f8.OnShouldClose += _0xa308d507 =>
        {
            WLog(_0xe441340d._0xeed5ad3c(new byte[41] { 97, 110, 95, 73, 78, 103, 26, 119, 91, 83, 84, 26, 109, 95, 88, 108, 83, 95, 77, 26, 117, 84, 105, 82, 85, 79, 86, 94, 121, 86, 85, 73, 95, 26, 83, 84, 76, 85, 81, 95, 94 }, 58));
            _0xf7b55842();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x5b6873f8.SetPopupPageEventEnabled(true);
        bool _0xce0c8661 = false;
        bool _0xa4fbaa87 = false;
        _0x5b6873f8.OnMultipleWindowOpened += (_0xa308d507, _0xfe6546f7) =>
        {
            _0xa308d507.ScrollTo(0, 0, false);
            WLog(_0xe441340d._0xeed5ad3c(new byte[43] { 63, 48, 1, 23, 16, 57, 68, 41, 5, 13, 10, 68, 51, 1, 6, 50, 13, 1, 19, 68, 41, 17, 8, 16, 13, 20, 8, 1, 51, 13, 10, 0, 11, 19, 68, 43, 20, 1, 10, 1, 0, 94, 68 }, 100) + _0xfe6546f7);
            var _0xbdbe0ffb = _0x5b6873f8.GetPopupWindow(_0xfe6546f7);
            if (_0xbdbe0ffb == null)
                return;
            _0xd356e5f8.Add(_0xbdbe0ffb);
            Debug.Log($"[Test] Popup ID: {_0xbdbe0ffb.Id}");
            _0xbdbe0ffb.OnPageStarted += (_0x3b82f8e9, _0xb4ea66bb) =>
            {
                WLog(_0xe441340d._0xeed5ad3c(new byte[36] { 159, 144, 161, 183, 176, 153, 228, 148, 171, 180, 177, 180, 228, 147, 161, 166, 146, 173, 161, 179, 228, 139, 170, 148, 165, 163, 161, 151, 176, 165, 182, 176, 161, 160, 254, 228 }, 196) + _0xb4ea66bb);
                _0x4f260de2 = 0;
                if (string.IsNullOrEmpty(_0xb4ea66bb) || IsAboutBlank(_0xb4ea66bb))
                    return;
                if (IsGoogleAuthFlowUrl(_0xb4ea66bb))
                {
                    WLog(_0xe441340d._0xeed5ad3c(new byte[57] { 176, 191, 142, 152, 159, 182, 203, 187, 132, 155, 158, 155, 203, 172, 132, 132, 140, 135, 142, 203, 138, 158, 159, 131, 203, 141, 135, 132, 156, 203, 198, 213, 203, 152, 155, 132, 132, 141, 203, 172, 132, 132, 140, 135, 142, 203, 168, 131, 153, 132, 134, 142, 203, 190, 170, 209, 203 }, 235) + _0xb4ea66bb);
                    _0xce0c8661 = false;
                    _0xcae6af78();
                    if (_0x3b82f8e9 != null && _0x3b82f8e9.IsAlive)
                        _0x3b82f8e9.EvaluateJavaScript(_0x319c1b24());
                    return;
                }

                if (_0xea5f3a36 == null)
                    return;
                if (!_0xce0c8661)
                {
                    _0xce0c8661 = true;
                    _0xea5f3a36.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0xe441340d._0xeed5ad3c(new byte[39] { 6, 9, 56, 46, 41, 0, 125, 13, 50, 45, 40, 45, 125, 60, 45, 45, 49, 36, 125, 10, 52, 51, 57, 50, 42, 46, 125, 57, 56, 46, 54, 41, 50, 45, 125, 8, 28, 103, 125 }, 93) + _0xb4ea66bb);
                }

                if (_0x3b82f8e9 != null && _0x3b82f8e9.IsAlive)
                    _0x3b82f8e9.EvaluateJavaScript(_0x0874acbf());
                if (!_0xa4fbaa87 && _0x3b82f8e9 != null && _0x3b82f8e9.IsAlive && IsHttpUrl(_0xb4ea66bb))
                {
                    _0xa4fbaa87 = true;
                }
            };
            _0xbdbe0ffb.OnPageFinished += (_0x3b82f8e9, _0x30f143c5) =>
            {
                string _0xc1f5b0e6 = _0x30f143c5 != null ? _0x30f143c5.data : string.Empty;
                WLog(_0xe441340d._0xeed5ad3c(new byte[35] { 142, 129, 176, 166, 161, 136, 245, 133, 186, 165, 160, 165, 245, 130, 176, 183, 131, 188, 176, 162, 245, 147, 188, 187, 188, 166, 189, 176, 177, 239, 245, 160, 167, 185, 232 }, 213) + _0xc1f5b0e6);
                if (_0x3b82f8e9 == null || !_0x3b82f8e9.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xc1f5b0e6))
                {
                    _0xcae6af78();
                    _0x3b82f8e9.EvaluateJavaScript(_0x319c1b24());
                    return;
                }

                if (!_0xce0c8661)
                    return;
                _0x3b82f8e9.EvaluateJavaScript(_0x0874acbf());
            };
        };
        _0x5b6873f8.OnMultipleWindowClosed += (_0xa308d507, _0xfe6546f7) =>
        {
            _0xd356e5f8.RemoveAll(_0x9e0df9d2 => _0x9e0df9d2 == null || _0x9e0df9d2.Id == _0xfe6546f7 || !_0x9e0df9d2.IsAlive);
            _0xa3c9ca3f(false);
            if (_0xd356e5f8.Count == 0 && _0xea5f3a36 != null)
            {
                _0xce0c8661 = false;
                _0xa4fbaa87 = false;
                _0x2cbea96f();
            }

            WLog(_0xe441340d._0xeed5ad3c(new byte[43] { 143, 128, 177, 167, 160, 137, 244, 153, 181, 189, 186, 244, 131, 177, 182, 130, 189, 177, 163, 244, 153, 161, 184, 160, 189, 164, 184, 177, 131, 189, 186, 176, 187, 163, 244, 151, 184, 187, 167, 177, 176, 238, 244 }, 212) + _0xfe6546f7);
        };
        _0x5b6873f8.RegisterOnRequestMediaCapturePermission(_0x082d9915 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private readonly List<UniWebViewPopup> _0xd356e5f8 = new List<UniWebViewPopup>();
    private static readonly string WindowsDesktopUserAgent = _0xe441340d._0xeed5ad3c(new byte[111] { 27, 57, 44, 63, 58, 58, 55, 121, 99, 120, 102, 118, 126, 1, 63, 56, 50, 57, 33, 37, 118, 24, 2, 118, 103, 102, 120, 102, 109, 118, 1, 63, 56, 96, 98, 109, 118, 46, 96, 98, 127, 118, 23, 38, 38, 58, 51, 1, 51, 52, 29, 63, 34, 121, 99, 101, 97, 120, 101, 96, 118, 126, 29, 30, 2, 27, 26, 122, 118, 58, 63, 61, 51, 118, 17, 51, 53, 61, 57, 127, 118, 21, 62, 36, 57, 59, 51, 121, 103, 100, 102, 120, 102, 120, 102, 120, 102, 118, 5, 55, 48, 55, 36, 63, 121, 99, 101, 97, 120, 101, 96 }, 86);
    private bool _0xcf67103a;
    internal Rect lastSafe = Rect.zero;
    private string _0x3aebf144 { get; set; }

    private bool _0x2ff1ee96 = false;
    private IEnumerator _0xe629ae5d(Dictionary<string, object> _0x36299df2)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[30] { 113, 126, 79, 89, 94, 119, 10, 108, 79, 94, 73, 66, 10, 111, 82, 94, 88, 75, 10, 122, 95, 89, 66, 10, 110, 75, 94, 75, 16, 10 }, 42) + string.Join(_0xe441340d._0xeed5ad3c(new byte[1] { 205 }, 196), _0x36299df2));
#endif
            }
        }

        string _0xa7a059b7 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x36299df2 != null && _0x36299df2.TryGetValue(_0xe441340d._0xeed5ad3c(new byte[16] { 58, 59, 32, 61, 50, 61, 55, 53, 32, 61, 59, 58, 16, 53, 32, 53 }, 84), out var raw))
        {
            try
            {
                var _0xa8833864 = raw?.ToString();
                var _0x22cc0aa2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xa8833864);
                if (_0x22cc0aa2 != null && _0x22cc0aa2.TryGetValue(_0xe441340d._0xeed5ad3c(new byte[6] { 90, 76, 71, 77, 64, 77 }, 41), out var val))
                {
                    _0xa7a059b7 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xe441340d._0xeed5ad3c(new byte[30] { 23, 24, 41, 63, 56, 108, 28, 57, 63, 36, 17, 108, 6, 31, 3, 2, 108, 60, 45, 62, 63, 41, 108, 41, 62, 62, 35, 62, 118, 108 }, 76) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xa7a059b7) && _0x36299df2 != null && _0x36299df2.TryGetValue(_0xe441340d._0xeed5ad3c(new byte[6] { 164, 178, 185, 179, 190, 179 }, 215), out var lab))
        {
            _0xa7a059b7 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[38] { 14, 1, 48, 38, 33, 117, 5, 32, 38, 61, 8, 117, 19, 48, 33, 54, 61, 48, 49, 117, 38, 48, 59, 49, 60, 49, 117, 51, 39, 58, 56, 117, 63, 38, 58, 59, 111, 117 }, 85) + _0xa7a059b7);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xa7a059b7))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[38] { 107, 100, 85, 67, 68, 16, 96, 69, 67, 88, 109, 16, 103, 81, 89, 68, 16, 68, 95, 16, 95, 64, 85, 94, 16, 71, 89, 68, 88, 16, 67, 85, 94, 84, 89, 84, 10, 16 }, 48) + _0xa7a059b7);
            }
#endif
        }

        _0x65f9d80e = _0xa7a059b7;
        yield return new WaitUntil(() => _0x03c76a4f);
        var _0xaeea586e = _0x0fcec291(2, 100);
        yield return new WaitUntil(() => _0xaeea586e.IsCompleted);
        string _0xeba45d9d = _0xaeea586e.Result;
        if (!string.IsNullOrEmpty(_0xeba45d9d))
        {
            string _0x558bfc44 = _0x15144aaa(_0xeba45d9d, _0xa7a059b7);
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[33] { 233, 230, 215, 193, 198, 146, 226, 199, 193, 218, 239, 146, 224, 215, 222, 221, 211, 214, 146, 229, 215, 208, 228, 219, 215, 197, 146, 197, 219, 198, 218, 136, 146 }, 178) + _0x558bfc44);
#endif
            }

            _0xea5f3a36.Load(_0x558bfc44);
        }
    }

    private JObject _0x977901f7(params string[] _0x9aaff0b9)
    {
        JObject _0x2abcd5b8 = new JObject();
        foreach (var _0x1fbde2bf in _0x9aaff0b9)
        {
            string _0xd27d1bab = _0xd28d1f8f();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xd27d1bab} val={_0x1fbde2bf}");
#endif
            }

            _0x2abcd5b8.Add(_0xd27d1bab, _0x1fbde2bf == null ? "" : _0x1fbde2bf);
        }

        return _0x2abcd5b8;
    }

    private string Decrypt(string _0x60ddebc4, string _0xe4cc7b58)
    {
        try
        {
            var _0xc0024036 = Convert.FromBase64String(_0x60ddebc4);
            using var _0x5bedfe03 = Aes.Create();
            _0x5bedfe03.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe4cc7b58));
            var _0xe340a6f1 = new byte[16];
            Buffer.BlockCopy(_0xc0024036, 0, _0xe340a6f1, 0, 16);
            _0x5bedfe03.IV = _0xe340a6f1;
            using var _0x43d8161a = new MemoryStream(_0xc0024036, 16, _0xc0024036.Length - 16);
            using var _0x0e17cfbf = new CryptoStream(_0x43d8161a, _0x5bedfe03.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x623c78da = new StreamReader(_0x0e17cfbf, Encoding.UTF8);
            return _0x623c78da.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0xfc6dc768 = "";
    private string _0x26d5f321 = "";
    private bool _0x1cb3a648 = false;
    private Canvas _0x944b4d67;
    private IEnumerator _0xb97f2d3e(string _0xabb0381b)
    {
        if (Permission.HasUserAuthorizedPermission(_0xabb0381b))
            yield break;
        bool _0x5569e376 = false;
        var _0x00270f04 = new PermissionCallbacks();
        _0x00270f04.PermissionGranted += _0xc8609a4c => _0x5569e376 = true;
        _0x00270f04.PermissionDenied += _0xc8609a4c => _0x5569e376 = true;
        Permission.RequestUserPermission(_0xabb0381b, _0x00270f04);
        yield return new WaitUntil(() => _0x5569e376);
    }

    private async Task _0x4d06a1d8()
    {
        if (await _0x597f7b4a())
            return;
        if (await _0x57467fda())
            return;
        if (await _0x0266d456())
            return;
        _0xbf1f87e4();
        await _0x83d511b8(_0xd91c845f());
        _0xf450acbd = await _0x9357b37c();
        await _0x95eb94b5();
    }

    private Canvas _0x2fd8b3f0()
    {
        if (_0x944b4d67 != null)
            return _0x944b4d67;
        var _0xb2ea2e53 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xb2ea2e53 == null)
        {
            var _0x49411bce = new GameObject(_0xe441340d._0xeed5ad3c(new byte[6] { 127, 93, 82, 74, 93, 79 }, 60), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xb2ea2e53 = _0x49411bce.GetComponent<Canvas>();
            _0xb2ea2e53.transform.SetParent(transform, false);
            _0xb2ea2e53.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x944b4d67 = _0xb2ea2e53;
        return _0x944b4d67;
    }

    private AndroidJavaObject _0x559ba2e1 { get; set; }

    private string _0x7d02e7f8;
    private bool _0xfccc8020()
    {
        var _0xcebbeec8 = Keyboard.current;
        return _0xcebbeec8 != null && _0xcebbeec8.escapeKey.wasPressedThisFrame;
    }

    private int _0x4f260de2 = 0;
    private bool _0x5c33c9ee()
    {
        var _0x8ad36fa2 = _0x7636b619();
        if (_0x8ad36fa2 == null)
            return false;
        WLog(_0xe441340d._0xeed5ad3c(new byte[31] { 17, 56, 43, 61, 46, 56, 43, 60, 121, 59, 56, 58, 50, 121, 116, 103, 121, 41, 54, 41, 44, 41, 121, 30, 54, 27, 56, 58, 50, 99, 121 }, 89) + _0x8ad36fa2.Id);
        _0x8ad36fa2.GoBack();
        return true;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x9357b37c()
    {
        var _0x82d4ebc6 = _0xe441340d._0xeed5ad3c(new byte[40] { 170, 182, 182, 178, 177, 248, 237, 237, 181, 181, 181, 236, 161, 174, 173, 183, 166, 164, 174, 163, 176, 167, 236, 161, 173, 175, 237, 161, 166, 172, 239, 161, 165, 171, 237, 182, 176, 163, 161, 167 }, 194);
        using (UnityWebRequest _0x9ddd2b5d = UnityWebRequest.Get(_0x82d4ebc6))
        {
            await _0x9ddd2b5d.SendWebRequest();
            string[] _0xc569259a = _0x9ddd2b5d.downloadHandler.text.Split('\n');
            foreach (string _0xd9f7b52c in _0xc569259a)
            {
                if (_0xd9f7b52c.StartsWith(_0xe441340d._0xeed5ad3c(new byte[3] { 51, 42, 103 }, 90)))
                {
                    string _0x28e9b17a = _0xd9f7b52c.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x28e9b17a} from {_0x82d4ebc6}");
                        }
#endif
                    }

                    return _0x28e9b17a;
                }
            }
        }

        return "";
    }

    private void _0x5d2a3eab(UniWebView _0x9dc67d32)
    {
        _0x9dc67d32.BackgroundColor = Color.clear;
        _0x9dc67d32.SetSupportMultipleWindows(true, true);
        _0x9dc67d32.SetBackButtonEnabled(false);
        _0xea5f3a36.SetUserAgent(_0xdfe64dcf());
    }

    private string _0x319c1b24()
    {
        string _0xc792490b = _0xdfe64dcf();
        if (string.IsNullOrEmpty(_0xc792490b))
            return _0xe441340d._0xeed5ad3c(new byte[7] { 162, 187, 189, 176, 244, 228, 239 }, 212);
        string _0x079e0c57 = _0xc792490b.Replace(_0xe441340d._0xeed5ad3c(new byte[1] { 238 }, 178), _0xe441340d._0xeed5ad3c(new byte[2] { 93, 93 }, 1)).Replace(_0xe441340d._0xeed5ad3c(new byte[1] { 29 }, 58), _0xe441340d._0xeed5ad3c(new byte[2] { 43, 80 }, 119));
        var _0x02e9dd70 = Regex.Match(_0xc792490b, _0xe441340d._0xeed5ad3c(new byte[12] { 13, 38, 60, 33, 35, 43, 97, 102, 18, 42, 101, 103 }, 78));
        string _0xc65442f2 = _0x02e9dd70.Success ? _0x02e9dd70.Groups[1].Value : _0xe441340d._0xeed5ad3c(new byte[3] { 140, 143, 141 }, 189);
        return _0xe441340d._0xeed5ad3c(new byte[12] { 57, 119, 100, 127, 114, 101, 120, 126, 127, 57, 56, 106 }, 17) + _0xe441340d._0xeed5ad3c(new byte[8] { 249, 238, 253, 175, 250, 238, 178, 168 }, 143) + _0x079e0c57 + _0xe441340d._0xeed5ad3c(new byte[2] { 162, 190 }, 133) + _0xe441340d._0xeed5ad3c(new byte[30] { 206, 217, 202, 152, 200, 202, 215, 204, 215, 133, 246, 217, 206, 209, 223, 217, 204, 215, 202, 150, 200, 202, 215, 204, 215, 204, 193, 200, 221, 131 }, 184) + _0xe441340d._0xeed5ad3c(new byte[121] { 113, 98, 121, 116, 99, 126, 120, 121, 55, 115, 114, 113, 63, 120, 117, 125, 59, 124, 114, 110, 59, 97, 118, 123, 62, 108, 99, 101, 110, 108, 88, 117, 125, 114, 116, 99, 57, 115, 114, 113, 126, 121, 114, 71, 101, 120, 103, 114, 101, 99, 110, 63, 120, 117, 125, 59, 124, 114, 110, 59, 108, 112, 114, 99, 45, 113, 98, 121, 116, 99, 126, 120, 121, 63, 62, 108, 101, 114, 99, 98, 101, 121, 55, 97, 118, 123, 44, 106, 59, 116, 120, 121, 113, 126, 112, 98, 101, 118, 117, 123, 114, 45, 99, 101, 98, 114, 106, 62, 44, 106, 116, 118, 99, 116, 127, 63, 114, 62, 108, 106, 106 }, 23) + _0xe441340d._0xeed5ad3c(new byte[26] { 130, 131, 128, 206, 150, 148, 137, 146, 137, 202, 193, 147, 149, 131, 148, 167, 129, 131, 136, 146, 193, 202, 147, 135, 207, 221 }, 230) + _0xe441340d._0xeed5ad3c(new byte[52] { 217, 216, 219, 149, 205, 207, 210, 201, 210, 145, 154, 220, 205, 205, 235, 216, 207, 206, 212, 210, 211, 154, 145, 200, 220, 147, 207, 216, 205, 209, 220, 222, 216, 149, 146, 227, 240, 210, 199, 212, 209, 209, 220, 225, 146, 146, 145, 154, 154, 148, 148, 134 }, 189) + _0xe441340d._0xeed5ad3c(new byte[37] { 65, 64, 67, 13, 85, 87, 74, 81, 74, 9, 2, 85, 73, 68, 81, 67, 74, 87, 72, 2, 9, 2, 105, 76, 75, 80, 93, 5, 68, 87, 72, 83, 29, 73, 2, 12, 30 }, 37) + _0xe441340d._0xeed5ad3c(new byte[34] { 157, 156, 159, 209, 137, 139, 150, 141, 150, 213, 222, 143, 156, 151, 157, 150, 139, 222, 213, 222, 190, 150, 150, 158, 149, 156, 217, 176, 151, 154, 215, 222, 208, 194 }, 249) + _0xe441340d._0xeed5ad3c(new byte[30] { 238, 239, 236, 162, 250, 248, 229, 254, 229, 166, 173, 231, 235, 242, 222, 229, 255, 233, 226, 218, 229, 227, 228, 254, 249, 173, 166, 191, 163, 177 }, 138) + _0xe441340d._0xeed5ad3c(new byte[48] { 97, 103, 108, 110, 99, 116, 103, 53, 96, 116, 113, 40, 110, 119, 103, 116, 123, 113, 102, 47, 78, 110, 119, 103, 116, 123, 113, 47, 50, 86, 125, 103, 122, 120, 124, 96, 120, 50, 57, 99, 112, 103, 102, 124, 122, 123, 47, 50 }, 21) + _0xc65442f2 + _0xe441340d._0xeed5ad3c(new byte[35] { 239, 181, 228, 179, 170, 186, 169, 166, 172, 242, 239, 143, 167, 167, 175, 164, 173, 232, 139, 160, 186, 167, 165, 173, 239, 228, 190, 173, 186, 187, 161, 167, 166, 242, 239 }, 200) + _0xc65442f2 + _0xe441340d._0xeed5ad3c(new byte[238] { 226, 184, 233, 190, 167, 183, 164, 171, 161, 255, 226, 139, 170, 177, 248, 132, 250, 135, 183, 164, 171, 161, 226, 233, 179, 160, 183, 182, 172, 170, 171, 255, 226, 247, 241, 226, 184, 152, 233, 168, 170, 167, 172, 169, 160, 255, 177, 183, 176, 160, 233, 181, 169, 164, 177, 163, 170, 183, 168, 255, 226, 132, 171, 161, 183, 170, 172, 161, 226, 233, 162, 160, 177, 141, 172, 162, 173, 128, 171, 177, 183, 170, 181, 188, 147, 164, 169, 176, 160, 182, 255, 163, 176, 171, 166, 177, 172, 170, 171, 237, 236, 190, 183, 160, 177, 176, 183, 171, 229, 149, 183, 170, 168, 172, 182, 160, 235, 183, 160, 182, 170, 169, 179, 160, 237, 190, 164, 183, 166, 173, 172, 177, 160, 166, 177, 176, 183, 160, 255, 226, 164, 183, 168, 226, 233, 167, 172, 177, 171, 160, 182, 182, 255, 226, 243, 241, 226, 233, 168, 170, 167, 172, 169, 160, 255, 177, 183, 176, 160, 233, 168, 170, 161, 160, 169, 255, 226, 226, 233, 181, 169, 164, 177, 163, 170, 183, 168, 255, 226, 132, 171, 161, 183, 170, 172, 161, 226, 233, 181, 169, 164, 177, 163, 170, 183, 168, 147, 160, 183, 182, 172, 170, 171, 255, 226, 244, 241, 235, 245, 235, 245, 226, 233, 176, 164, 131, 176, 169, 169, 147, 160, 183, 182, 172, 170, 171, 255, 226 }, 197) + _0xc65442f2 + _0xe441340d._0xeed5ad3c(new byte[117] { 170, 180, 170, 180, 170, 180, 163, 249, 173, 191, 249, 249, 191, 203, 230, 238, 225, 231, 240, 170, 224, 225, 226, 237, 234, 225, 212, 246, 235, 244, 225, 246, 240, 253, 172, 244, 246, 235, 240, 235, 168, 163, 241, 247, 225, 246, 197, 227, 225, 234, 240, 192, 229, 240, 229, 163, 168, 255, 227, 225, 240, 190, 226, 241, 234, 231, 240, 237, 235, 234, 172, 173, 255, 246, 225, 240, 241, 246, 234, 164, 241, 229, 224, 191, 249, 168, 231, 235, 234, 226, 237, 227, 241, 246, 229, 230, 232, 225, 190, 240, 246, 241, 225, 249, 173, 191, 249, 231, 229, 240, 231, 236, 172, 225, 173, 255, 249 }, 132) + _0xe441340d._0xeed5ad3c(new byte[5] { 219, 143, 142, 143, 157 }, 166);
    }

    private string _0x5e8b9ef9 = "";
    private bool _0x4fd25bd0(string _0x5751f150)
    {
        try
        {
            using (var _0xc8b3ead5 = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[30] { 193, 205, 207, 140, 215, 204, 203, 214, 219, 145, 198, 140, 210, 206, 195, 219, 199, 208, 140, 247, 204, 203, 214, 219, 242, 206, 195, 219, 199, 208 }, 162)))
            using (var _0xb48f1c9c = _0xc8b3ead5.GetStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[15] { 70, 80, 87, 87, 64, 75, 81, 100, 70, 81, 76, 83, 76, 81, 92 }, 37)))
            using (var _0x557aef2b = _0xb48f1c9c.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[17] { 116, 118, 103, 67, 114, 112, 120, 114, 116, 118, 94, 114, 125, 114, 116, 118, 97 }, 19)))
            using (var _0x7141cd35 = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[22] { 179, 188, 182, 160, 189, 187, 182, 252, 177, 189, 188, 166, 183, 188, 166, 252, 155, 188, 166, 183, 188, 166 }, 210)))
            using (var _0x2d4820a3 = _0x7141cd35.CallStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[8] { 84, 69, 86, 87, 65, 113, 86, 77 }, 36), _0x5751f150, 1))
            {
                string _0xb31be982 = _0x2d4820a3.Call<string>(_0xe441340d._0xeed5ad3c(new byte[14] { 200, 202, 219, 252, 219, 221, 198, 193, 200, 234, 215, 219, 221, 206 }, 175), _0xe441340d._0xeed5ad3c(new byte[20] { 193, 209, 204, 212, 208, 198, 209, 252, 197, 194, 207, 207, 193, 194, 192, 200, 252, 214, 209, 207 }, 163));
                string _0x826344c7 = _0x2d4820a3.Call<string>(_0xe441340d._0xeed5ad3c(new byte[10] { 87, 85, 68, 96, 81, 83, 91, 81, 87, 85 }, 48));
                _0x2d4820a3.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[11] { 172, 169, 169, 142, 172, 185, 168, 170, 162, 191, 180 }, 205), _0xe441340d._0xeed5ad3c(new byte[33] { 215, 216, 210, 196, 217, 223, 210, 152, 223, 216, 194, 211, 216, 194, 152, 213, 215, 194, 211, 209, 217, 196, 207, 152, 244, 228, 249, 225, 229, 247, 244, 250, 243 }, 182));
                _0x2d4820a3.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[11] { 32, 55, 63, 61, 36, 55, 23, 42, 38, 32, 51 }, 82), _0xe441340d._0xeed5ad3c(new byte[20] { 248, 232, 245, 237, 233, 255, 232, 197, 252, 251, 246, 246, 248, 251, 249, 241, 197, 239, 232, 246 }, 154));
                if (_0x2d4820a3.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[15] { 22, 1, 23, 11, 8, 18, 1, 37, 7, 16, 13, 18, 13, 16, 29 }, 100), _0x557aef2b) != null)
                {
                    WLog(_0xe441340d._0xeed5ad3c(new byte[24] { 242, 217, 195, 222, 220, 212, 253, 216, 218, 212, 145, 222, 193, 212, 223, 145, 216, 223, 197, 212, 223, 197, 139, 145 }, 177) + _0x5751f150);
                    _0x2d4820a3.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[8] { 162, 167, 167, 133, 175, 162, 164, 176 }, 195), 0x10000000);
                    _0xb48f1c9c.Call(_0xe441340d._0xeed5ad3c(new byte[13] { 194, 197, 208, 195, 197, 240, 210, 197, 216, 199, 216, 197, 200 }, 177), _0x2d4820a3);
                    return true;
                }

                if (_0x9499e5a7(_0x826344c7))
                    return true;
                if (!string.IsNullOrEmpty(_0xb31be982))
                {
                    WLog(_0xe441340d._0xeed5ad3c(new byte[28] { 166, 141, 151, 138, 136, 128, 169, 140, 142, 128, 197, 140, 139, 145, 128, 139, 145, 197, 131, 132, 137, 137, 135, 132, 134, 142, 223, 197 }, 229) + _0xb31be982);
                    if (_0x71141ee5(_0xb31be982))
                        return _0xfa56f636(_0xb31be982, _0x826344c7);
                    return _0x7506bbaa(_0xb31be982);
                }

                WLog(_0xe441340d._0xeed5ad3c(new byte[30] { 203, 224, 250, 231, 229, 237, 196, 225, 227, 237, 168, 225, 230, 252, 237, 230, 252, 168, 230, 231, 168, 224, 233, 230, 236, 228, 237, 250, 178, 168 }, 136) + _0x5751f150);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xe441340d._0xeed5ad3c(new byte[26] { 91, 112, 106, 119, 117, 125, 84, 113, 115, 125, 56, 113, 118, 108, 125, 118, 108, 56, 126, 121, 113, 116, 125, 124, 34, 56 }, 24) + e.Message);
            return true;
        }
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x2975c967)
    {
        if (_0x2975c967 == null || _0x2975c967.Extra == null)
            return null;
        object _0x55dd1f0f;
        if (!_0x2975c967.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x55dd1f0f))
            return null;
        return _0x55dd1f0f as string;
    }

    private string _0xf450acbd = "";
    public void _0x29c7d39a()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[18] { 30, 17, 32, 54, 49, 24, 101, 9, 36, 48, 43, 38, 45, 101, 2, 36, 40, 32 }, 69));
#endif
        }

        _0xe285f25e.Instance?._0x7ec6b07b();
        _0x559fb8c0.Instance._0x6fddb199(_0xd931f97e._0xfa1e82e0.DEFAULT);
    }

    private bool _0x7506bbaa(string _0xf77f5f05)
    {
        try
        {
            using (var _0x712a85fe = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[30] { 250, 246, 244, 183, 236, 247, 240, 237, 224, 170, 253, 183, 233, 245, 248, 224, 252, 235, 183, 204, 247, 240, 237, 224, 201, 245, 248, 224, 252, 235 }, 153)))
            using (var _0xe0b2ddb2 = _0x712a85fe.GetStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[15] { 92, 74, 77, 77, 90, 81, 75, 126, 92, 75, 86, 73, 86, 75, 70 }, 63)))
            using (var _0x317567f6 = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[15] { 251, 244, 254, 232, 245, 243, 254, 180, 244, 255, 238, 180, 207, 232, 243 }, 154)))
            using (var _0x3474bdb6 = _0x317567f6.CallStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[5] { 99, 114, 97, 96, 118 }, 19), _0xf77f5f05))
            using (var _0xfac2be5b = new AndroidJavaObject(_0xe441340d._0xeed5ad3c(new byte[22] { 5, 10, 0, 22, 11, 13, 0, 74, 7, 11, 10, 16, 1, 10, 16, 74, 45, 10, 16, 1, 10, 16 }, 100), _0xe441340d._0xeed5ad3c(new byte[26] { 122, 117, 127, 105, 116, 114, 127, 53, 114, 117, 111, 126, 117, 111, 53, 122, 120, 111, 114, 116, 117, 53, 77, 82, 94, 76 }, 27), _0x3474bdb6))
            {
                WLog(_0xe441340d._0xeed5ad3c(new byte[26] { 114, 89, 67, 94, 92, 84, 125, 88, 90, 84, 17, 94, 65, 84, 95, 17, 84, 73, 69, 84, 67, 95, 80, 93, 11, 17 }, 49) + _0xf77f5f05);
                _0xfac2be5b.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[11] { 84, 81, 81, 118, 84, 65, 80, 82, 90, 71, 76 }, 53), _0xe441340d._0xeed5ad3c(new byte[33] { 73, 70, 76, 90, 71, 65, 76, 6, 65, 70, 92, 77, 70, 92, 6, 75, 73, 92, 77, 79, 71, 90, 81, 6, 106, 122, 103, 127, 123, 105, 106, 100, 109 }, 40));
                _0xfac2be5b.Call<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[8] { 70, 67, 67, 97, 75, 70, 64, 84 }, 39), 0x10000000);
                _0xe0b2ddb2.Call(_0xe441340d._0xeed5ad3c(new byte[13] { 252, 251, 238, 253, 251, 206, 236, 251, 230, 249, 230, 251, 246 }, 143), _0xfac2be5b);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xe441340d._0xeed5ad3c(new byte[28] { 191, 148, 142, 147, 145, 153, 176, 149, 151, 153, 220, 153, 132, 136, 153, 142, 146, 157, 144, 220, 154, 157, 149, 144, 153, 152, 198, 220 }, 252) + e.Message);
            Application.OpenURL(_0xf77f5f05);
            return true;
        }
    }

    private bool _0x1b08c16b = false;
    private string _0xf50ed0e0 = "";
    private int _0x65678db8 = -1;
    private bool _0xdd19cf10(string _0xa62e0365)
    {
        string _0xbff3b86e = GetUrlHost(_0xa62e0365);
        if (!string.IsNullOrEmpty(_0xbff3b86e) && !string.IsNullOrEmpty(_0xa61bf2c5) && !string.Equals(_0xbff3b86e, _0xa61bf2c5, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0xcf67103a;
    }

    private void _0x482a2a46()
    {
        if (_0x67f25899)
        {
            WLog(_0xe441340d._0xeed5ad3c(new byte[18] { 144, 173, 188, 161, 245, 180, 185, 167, 176, 180, 177, 172, 245, 166, 189, 186, 162, 187 }, 213));
            return;
        }

        _0xa3c9ca3f(false);
        WLog(_0xe441340d._0xeed5ad3c(new byte[46] { 98, 78, 70, 65, 15, 120, 74, 77, 121, 70, 74, 88, 15, 127, 90, 92, 71, 15, 97, 64, 91, 70, 73, 70, 76, 78, 91, 70, 64, 65, 15, 7, 71, 78, 93, 75, 88, 78, 93, 74, 15, 77, 78, 76, 68, 6 }, 47));
        ++_0x4f260de2;
        _0x5a2f0724();
        if (_0x4f260de2 <= 1)
            return;
        if (_0x1647e54d())
        {
            WLog(_0xe441340d._0xeed5ad3c(new byte[37] { 84, 105, 120, 101, 49, 98, 122, 120, 97, 97, 116, 117, 49, 60, 47, 49, 97, 126, 97, 100, 97, 98, 49, 98, 101, 120, 125, 125, 49, 126, 97, 116, 127, 116, 117, 43, 49 }, 17) + _0xd356e5f8.Count);
            return;
        }

        Application.Quit();
    }

    private bool _0xfa56f636(string _0xbe6c2a4d, string _0x5e948187)
    {
        string _0x2c3329a8 = _0x724a6850(_0xbe6c2a4d);
        if (string.IsNullOrEmpty(_0x2c3329a8))
            _0x2c3329a8 = _0x5e948187;
        if (_0x9499e5a7(_0x2c3329a8))
            return true;
        string _0xc6314ddd = string.IsNullOrEmpty(_0x2c3329a8) ? _0xe441340d._0xeed5ad3c(new byte[29] { 178, 174, 174, 170, 169, 224, 245, 245, 170, 182, 187, 163, 244, 189, 181, 181, 189, 182, 191, 244, 185, 181, 183, 245, 169, 174, 181, 168, 191 }, 218) : _0xe441340d._0xeed5ad3c(new byte[46] { 64, 92, 92, 88, 91, 18, 7, 7, 88, 68, 73, 81, 6, 79, 71, 71, 79, 68, 77, 6, 75, 71, 69, 7, 91, 92, 71, 90, 77, 7, 73, 88, 88, 91, 7, 76, 77, 92, 73, 65, 68, 91, 23, 65, 76, 21 }, 40) + _0x2c3329a8;
        WLog(_0xe441340d._0xeed5ad3c(new byte[35] { 231, 204, 214, 203, 201, 193, 232, 205, 207, 193, 132, 201, 197, 214, 207, 193, 208, 132, 194, 197, 200, 200, 198, 197, 199, 207, 132, 197, 215, 132, 211, 193, 198, 158, 132 }, 164) + _0xc6314ddd);
        return _0x7506bbaa(_0xc6314ddd);
    }

    private Text _0x438e5a04;
    private async Task<bool> _0x597f7b4a()
    {
        {
#if B_LOGS
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[37] { 112, 127, 78, 88, 95, 118, 11, 120, 66, 76, 69, 98, 69, 126, 69, 66, 95, 82, 120, 78, 89, 93, 66, 72, 78, 88, 106, 69, 68, 69, 82, 70, 68, 94, 88, 71, 82 }, 43));
#endif
        }

        try
        {
            var _0x0cd3eac5 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x0cd3eac5);
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[32] { 85, 90, 107, 125, 122, 83, 46, 91, 96, 103, 122, 119, 93, 107, 124, 120, 103, 109, 107, 125, 46, 71, 96, 103, 122, 103, 111, 98, 103, 116, 107, 106 }, 14));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[20] { 56, 41, 63, 56, 76, 57, 2, 5, 24, 21, 63, 9, 30, 26, 5, 15, 9, 31, 86, 76 }, 108) + ex.Message);
#endif
            }

            _0x28358be3?._0x29c7d39a();
            return true;
        }

        bool _0x3cb077e0 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x3cb077e0 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0xe441340d._0xeed5ad3c(new byte[37] { 59, 52, 5, 19, 20, 61, 64, 51, 9, 7, 14, 77, 9, 14, 64, 33, 14, 15, 14, 25, 13, 15, 21, 19, 78, 64, 48, 12, 1, 25, 5, 18, 64, 41, 36, 90, 64 }, 96) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x5e8b9ef9 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[25] { 226, 243, 229, 226, 150, 229, 223, 209, 216, 155, 223, 216, 150, 247, 195, 194, 222, 150, 243, 228, 228, 249, 228, 140, 150 }, 182) + ex.Message);
#endif
                }

                _0x28358be3?._0x29c7d39a();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[28] { 87, 70, 80, 87, 35, 80, 106, 100, 109, 46, 106, 109, 35, 81, 102, 114, 118, 102, 112, 119, 35, 70, 81, 81, 76, 81, 57, 35 }, 3) + ex.Message);
#endif
                }

                _0x28358be3?._0x29c7d39a();
                return true;
            }
        }
        while (!_0x3cb077e0);
        return false;
    }

    private void _0xcae6af78()
    {
        _0x1cb3a648 = true;
        if (_0xea5f3a36 != null)
            _0xea5f3a36.SetUserAgent(_0xdfe64dcf());
    }

    private void _0x0e24a26b(string _0x6f6d1589)
    {
        _0xd04993cb();
        StartCoroutine(_0xc50d75b9(_0x6f6d1589));
    }

    // PART 3
    private string _0x9700beba()
    {
        try
        {
            var _0x62026acc = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[30] { 160, 172, 174, 237, 182, 173, 170, 183, 186, 240, 167, 237, 179, 175, 162, 186, 166, 177, 237, 150, 173, 170, 183, 186, 147, 175, 162, 186, 166, 177 }, 195));
            var _0xc4f28c9d = _0x62026acc.GetStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[15] { 46, 56, 63, 63, 40, 35, 57, 12, 46, 57, 36, 59, 36, 57, 52 }, 77));
            var _0x3815b9c8 = new AndroidJavaClass(_0xe441340d._0xeed5ad3c(new byte[57] { 58, 54, 52, 119, 62, 54, 54, 62, 53, 60, 119, 56, 55, 61, 43, 54, 48, 61, 119, 62, 52, 42, 119, 56, 61, 42, 119, 48, 61, 60, 55, 45, 48, 63, 48, 60, 43, 119, 24, 61, 47, 60, 43, 45, 48, 42, 48, 55, 62, 16, 61, 26, 53, 48, 60, 55, 45 }, 89));
            var _0x32a71fc9 = _0x3815b9c8.CallStatic<AndroidJavaObject>(_0xe441340d._0xeed5ad3c(new byte[20] { 20, 22, 7, 50, 23, 5, 22, 1, 7, 26, 0, 26, 29, 20, 58, 23, 58, 29, 21, 28 }, 115), _0xc4f28c9d);
            var _0x9a7c8024 = _0x32a71fc9.Call<string>(_0xe441340d._0xeed5ad3c(new byte[5] { 80, 82, 67, 126, 83 }, 55));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x9a7c8024}");
#endif
            }

            return string.IsNullOrEmpty(_0x9a7c8024) ? "" : _0x9a7c8024;
        }
        catch
        {
            return "";
        }
    }

    private Action _0x46b32b6b;
    private IEnumerator _0x5b5375e5(IEnumerator _0x85a91d37, TaskCompletionSource<bool> _0x7093aef4)
    {
        yield return _0x85a91d37;
        _0x7093aef4.SetResult(true);
    }

    private void _0x2cbea96f()
    {
        if (_0xea5f3a36 == null)
            return;
        if (_0x1cb3a648)
            _0xea5f3a36.SetUserAgent(_0xdfe64dcf());
        else
            _0xea5f3a36.SetUserAgent("");
    }

    private string _0x33a7014e = "";
    private bool _0xb9a7af3d = false;
    private static string ReadPushField(Dictionary<string, object> _0x89438457, string _0x13b9ec5e)
    {
        if (_0x89438457 == null || string.IsNullOrEmpty(_0x13b9ec5e))
            return string.Empty;
        if (_0x89438457.TryGetValue(_0xe441340d._0xeed5ad3c(new byte[16] { 185, 184, 163, 190, 177, 190, 180, 182, 163, 190, 184, 185, 147, 182, 163, 182 }, 215), out var raw))
        {
            try
            {
                var _0x1a96ce58 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x1a96ce58 != null && _0x1a96ce58.TryGetValue(_0x13b9ec5e, out var nestedVal))
                {
                    var _0xb841be9d = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xb841be9d))
                        return _0xb841be9d;
                }
            }
            catch
            {
            }
        }

        if (_0x89438457.TryGetValue(_0x13b9ec5e, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private bool _0x847e39e2 = false;
    private async Task<bool> _0xf6fb5e63(int _0xdac4b9e7 = 5, int _0x7134ce68 = 500)
    {
        List<EntityData> _0x0b514fb1 = new List<EntityData>();
        int _0x0a935b72 = 0;
        do
        {
            try
            {
                _0x0b514fb1 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xe441340d._0xeed5ad3c(new byte[8] { 95, 67, 78, 86, 74, 93, 102, 75 }, 47), _0x5e8b9ef9, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xe441340d._0xeed5ad3c(new byte[9] { 40, 50, 17, 51, 40, 55, 32, 34, 56 }, 65) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xe441340d._0xeed5ad3c(new byte[32] { 246, 249, 200, 222, 217, 240, 141, 220, 216, 200, 223, 212, 236, 222, 212, 195, 206, 255, 200, 222, 216, 193, 217, 222, 141, 200, 223, 223, 194, 223, 151, 141 }, 173) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x7134ce68);
        }
        while (_0x0b514fb1.Count == 0 && _0x0a935b72++ < _0xdac4b9e7);
        {
#if B_LOGS
            {
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[32] { 100, 107, 90, 76, 75, 98, 31, 118, 76, 111, 77, 86, 73, 94, 92, 70, 31, 110, 74, 90, 77, 70, 31, 77, 90, 76, 74, 83, 75, 76, 5, 31 }, 63) + JsonConvert.SerializeObject(_0x0b514fb1, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[38] { 86, 89, 104, 126, 121, 80, 45, 68, 126, 93, 127, 100, 123, 108, 110, 116, 45, 92, 120, 104, 127, 116, 45, 127, 104, 126, 120, 97, 121, 126, 45, 110, 98, 120, 99, 121, 55, 45 }, 13) + _0x0b514fb1.Count);
            }
#endif
        }

        bool _0xf53fe8d0 = true;
        if (_0x0b514fb1.Count == 0)
        {
            _0xf53fe8d0 = false;
        }
        else
        {
            _0xf53fe8d0 = _0x0b514fb1.Any(_0xd63ff156 => _0xd63ff156.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe441340d._0xeed5ad3c(new byte[25] { 56, 55, 6, 16, 23, 62, 67, 42, 16, 51, 17, 10, 21, 2, 0, 26, 67, 17, 6, 16, 22, 15, 23, 89, 67 }, 99) + _0xf53fe8d0);
            }
#endif
        }

        return _0xf53fe8d0;
    }

    // WEB VIEW LOGIC
    public bool _0x03c76a4f { get; set; }

    private async Task<bool> _0x0266d456()
    {
        {
#if B_LOGS
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[29] { 210, 221, 236, 250, 253, 212, 169, 192, 250, 217, 251, 224, 255, 232, 234, 240, 200, 231, 237, 218, 232, 255, 236, 237, 202, 225, 236, 234, 226 }, 137));
#endif
        }

        string _0x64ed7bd8 = "";
        for (int _0xfe0640b3 = 0; _0xfe0640b3 < 2; _0xfe0640b3++)
        {
            if (await _0xf6fb5e63(1, 100))
            {
                await _0xb7c2a532(_0xe441340d._0xeed5ad3c(new byte[7] { 156, 146, 145, 157, 149, 155, 154 }, 254));
                _0x29c7d39a();
                return true;
            }

            _0x64ed7bd8 = await _0x0fcec291(1, 100);
            if (!string.IsNullOrEmpty(_0x64ed7bd8))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x64ed7bd8))
            {
                if (!string.IsNullOrEmpty(_0x65f9d80e))
                {
                    _0x64ed7bd8 = _0x15144aaa(_0x64ed7bd8, _0x65f9d80e);
                    {
#if B_LOGS
                        Debug.Log(_0xe441340d._0xeed5ad3c(new byte[53] { 53, 58, 11, 29, 26, 51, 78, 45, 15, 13, 6, 11, 10, 78, 8, 7, 0, 15, 2, 59, 28, 2, 78, 25, 7, 26, 6, 78, 29, 11, 0, 10, 7, 10, 78, 140, 232, 252, 78, 29, 6, 1, 25, 78, 57, 11, 12, 56, 7, 11, 25, 84, 78 }, 110) + _0x64ed7bd8);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xe441340d._0xeed5ad3c(new byte[39] { 81, 94, 111, 121, 126, 87, 42, 73, 107, 105, 98, 111, 110, 42, 108, 99, 100, 107, 102, 95, 120, 102, 42, 232, 140, 152, 42, 121, 98, 101, 125, 42, 93, 111, 104, 92, 99, 111, 125 }, 10));
#endif
                    }
                }

                _0xb9a7af3d = true;
                _0x0e24a26b(_0x64ed7bd8);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe441340d._0xeed5ad3c(new byte[44] { 36, 43, 26, 12, 11, 34, 95, 58, 7, 28, 26, 15, 11, 22, 16, 17, 95, 8, 23, 22, 19, 26, 95, 28, 23, 26, 28, 20, 22, 17, 24, 95, 12, 30, 9, 26, 27, 95, 19, 22, 17, 20, 69, 95 }, 127) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private async void Start()
    {
        await _0x4d06a1d8();
    }

    internal bool _0x71141ee5(string _0x1efbaaf6)
    {
        return _0x1efbaaf6.StartsWith(_0xe441340d._0xeed5ad3c(new byte[9] { 3, 15, 28, 5, 11, 26, 84, 65, 65 }, 110), StringComparison.OrdinalIgnoreCase) || _0x1efbaaf6.StartsWith(_0xe441340d._0xeed5ad3c(new byte[24] { 96, 124, 124, 120, 123, 50, 39, 39, 120, 100, 105, 113, 38, 111, 103, 103, 111, 100, 109, 38, 107, 103, 101, 39 }, 8), StringComparison.OrdinalIgnoreCase) || _0x1efbaaf6.StartsWith(_0xe441340d._0xeed5ad3c(new byte[23] { 207, 211, 211, 215, 157, 136, 136, 215, 203, 198, 222, 137, 192, 200, 200, 192, 203, 194, 137, 196, 200, 202, 136 }, 167), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x15144aaa(string _0xe1d05913, string _0xb735d090)
    {
        if (string.IsNullOrEmpty(_0xb735d090))
            return _0xe1d05913;
        if (_0xe1d05913.Contains(_0xe441340d._0xeed5ad3c(new byte[1] { 24 }, 39)))
            return _0xe1d05913 + _0xe441340d._0xeed5ad3c(new byte[8] { 114, 39, 49, 58, 48, 61, 48, 105 }, 84) + UnityWebRequest.EscapeURL(_0xb735d090);
        else
            return _0xe1d05913 + _0xe441340d._0xeed5ad3c(new byte[8] { 252, 176, 166, 173, 167, 170, 167, 254 }, 195) + UnityWebRequest.EscapeURL(_0xb735d090);
    }

    internal void Update()
    {
        if (_0xea5f3a36 == null)
            return;
        if (_0xfccc8020())
            _0xf7b55842();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xe8d81587();
        if (_0x847e39e2 && _0x92bbc448 != null)
            _0x92bbc448.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    internal bool firstLoadShown = false;
    private bool OpenUrlExternally(string _0xeb70f768)
    {
        return _0x7506bbaa(_0xeb70f768);
    }

    private string _0x0b3f9733 = "";
    private string GetUrlHost(string _0xf7117d9d)
    {
        if (string.IsNullOrEmpty(_0xf7117d9d))
            return null;
        Uri _0x702fe120;
        if (!Uri.TryCreate(_0xf7117d9d, UriKind.Absolute, out _0x702fe120))
            return null;
        string _0x1df44420 = _0x702fe120.Host;
        if (_0x1df44420.StartsWith(_0xe441340d._0xeed5ad3c(new byte[4] { 65, 65, 65, 24 }, 54), StringComparison.OrdinalIgnoreCase))
            _0x1df44420 = _0x1df44420.Substring(4);
        return _0x1df44420;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x35249414(string _0xcadfee22, string _0xee99078c)
    {
        try
        {
            using var _0x04001274 = Aes.Create();
            _0x04001274.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xee99078c));
            _0x04001274.GenerateIV();
            using var _0xcbf16db3 = new MemoryStream();
            _0xcbf16db3.Write(_0x04001274.IV, 0, _0x04001274.IV.Length);
            using (var _0x37e1348d = new CryptoStream(_0xcbf16db3, _0x04001274.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xccc4d275 = Encoding.UTF8.GetBytes(_0xcadfee22);
                _0x37e1348d.Write(_0xccc4d275, 0, _0xccc4d275.Length);
                _0x37e1348d.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xcbf16db3.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private RectTransform _0x92bbc448;
    private void OnApplicationFocus(bool _0x768627d3)
    {
        isApplicationFocus = _0x768627d3;
        if (_0x768627d3 && _0x03c76a4f)
        {
            _0xd04993cb();
        }
    }

    private void _0xb2f5f18c()
    {
        if (_0x53a52f4c != null)
            return;
        var _0x8f260f40 = _0x2fd8b3f0();
        _0x53a52f4c = new GameObject(_0xe441340d._0xeed5ad3c(new byte[14] { 247, 197, 194, 246, 201, 197, 215, 243, 208, 201, 206, 206, 197, 210 }, 160), typeof(RectTransform), typeof(Text));
        _0x92bbc448 = _0x53a52f4c.GetComponent<RectTransform>();
        _0x92bbc448.SetParent(_0x8f260f40.transform, false);
        _0x92bbc448.anchorMin = new Vector2(0.5f, 0.5f);
        _0x92bbc448.anchorMax = new Vector2(0.5f, 0.5f);
        _0x92bbc448.pivot = new Vector2(0.5f, 0.5f);
        _0x92bbc448.sizeDelta = new Vector2(600f, 600f);
        _0x92bbc448.anchoredPosition = Vector2.zero;
        _0x438e5a04 = _0x53a52f4c.GetComponent<Text>();
        _0x438e5a04.text = _0xe441340d._0xeed5ad3c(new byte[1] { 199 }, 232);
        _0x438e5a04.font = Resources.GetBuiltinResource<Font>(_0xe441340d._0xeed5ad3c(new byte[17] { 198, 239, 237, 235, 233, 243, 216, 255, 228, 254, 227, 231, 239, 164, 254, 254, 236 }, 138));
        _0x438e5a04.fontSize = 200;
        _0x438e5a04.alignment = TextAnchor.MiddleCenter;
        _0x438e5a04.color = Color.white;
        _0x438e5a04.raycastTarget = false;
        _0x53a52f4c.SetActive(false);
    }

    internal bool isDestroyedForce = false;
    private void _0x6e9248fb(string _0x58ccf238)
    {
        Dictionary<string, object> _0x513908cb;
        try
        {
            _0x513908cb = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x58ccf238);
        }
        catch
        {
            return;
        }

        var _0x8e6cb017 = ReadPushField(_0x513908cb, _0xe441340d._0xeed5ad3c(new byte[3] { 52, 51, 45 }, 65));
        if (string.IsNullOrWhiteSpace(_0x8e6cb017))
            return;
        _0x8e6cb017 = _0x8e6cb017.Trim();
        if (!IsHttpUrl(_0x8e6cb017))
            return;
        if (string.Equals(_0x8e6cb017, _0x7d02e7f8, StringComparison.Ordinal))
            return;
        _0x7d02e7f8 = _0x8e6cb017;
        OpenUrlExternally(_0x8e6cb017);
    }

    private string _0x181a4109 = "";
    private string _0x07129c91 = "";
    private string _0x43c9e51b = "";
    private void _0xbf1f87e4()
    {
        {
#if B_LOGS
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[22] { 5, 10, 59, 45, 42, 3, 126, 13, 42, 49, 44, 59, 26, 59, 40, 55, 61, 59, 23, 48, 56, 49 }, 94));
#endif
        }

        _0xfc6dc768 = SystemInfo.deviceModel;
        _0xf50ed0e0 = Application.version;
        _0x2079da86 = Application.installMode;
        _0x26d5f321 = Application.installerName;
        _0x33a7014e = Application.identifier;
        _0x52e72cc7 = _0x9700beba();
        _0xd56e9c66 = _0x36846b67();
        _0x02251dd4 = SystemInfo.deviceUniqueIdentifier;
        _0x0b3f9733 = SystemInfo.graphicsDeviceName;
        _0xc3ac42dd = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xf50ed0e0 = _0xe441340d._0xeed5ad3c(new byte[5] { 61, 36, 61, 36, 61 }, 10);
                _0x2079da86 = ApplicationInstallMode.Store;
                _0x26d5f321 = _0xe441340d._0xeed5ad3c(new byte[19] { 187, 183, 181, 246, 185, 182, 188, 170, 183, 177, 188, 246, 174, 189, 182, 188, 177, 182, 191 }, 216);
                _0xd56e9c66 = _0xe441340d._0xeed5ad3c(new byte[8] { 95, 87, 74, 78, 67, 26, 79, 91 }, 58);
                _0x02251dd4 = Guid.NewGuid().ToString().Replace(_0xe441340d._0xeed5ad3c(new byte[1] { 165 }, 136), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[17] { 195, 204, 253, 235, 236, 197, 184, 252, 253, 238, 213, 247, 252, 253, 244, 162, 184 }, 152) + _0xfc6dc768);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[19] { 21, 26, 43, 61, 58, 19, 110, 47, 62, 62, 24, 43, 60, 61, 39, 33, 32, 116, 110 }, 78) + _0xf50ed0e0);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[20] { 76, 67, 114, 100, 99, 74, 55, 126, 121, 100, 99, 118, 123, 123, 90, 120, 115, 114, 45, 55 }, 23) + _0x2079da86);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[23] { 155, 148, 165, 179, 180, 157, 224, 169, 174, 179, 180, 161, 172, 172, 165, 178, 147, 180, 175, 178, 165, 250, 224 }, 192) + _0x26d5f321);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[14] { 231, 232, 217, 207, 200, 225, 156, 221, 204, 204, 245, 216, 134, 156 }, 188) + _0x33a7014e);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[14] { 166, 169, 152, 142, 137, 160, 221, 156, 153, 139, 180, 153, 199, 221 }, 253) + _0x52e72cc7);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[18] { 11, 4, 53, 35, 36, 13, 112, 37, 35, 53, 34, 17, 55, 53, 62, 36, 106, 112 }, 80) + _0xd56e9c66);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[17] { 173, 162, 147, 133, 130, 171, 214, 133, 143, 133, 178, 147, 128, 191, 146, 204, 214 }, 246) + _0x02251dd4);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[12] { 21, 26, 43, 61, 58, 19, 110, 41, 62, 59, 116, 110 }, 78) + _0x0b3f9733);
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[12] { 20, 27, 42, 60, 59, 18, 111, 44, 63, 58, 117, 111 }, 79) + _0xc3ac42dd);
#endif
        }
    }

    private bool IsSslError(int _0x314673d3, string _0x05168e33)
    {
        if (_0x314673d3 == -1202 || _0x314673d3 == -1200 || _0x314673d3 == -11 || _0x314673d3 == -202)
            return true;
        if (string.IsNullOrEmpty(_0x05168e33))
            return false;
        return _0x05168e33.IndexOf(_0xe441340d._0xeed5ad3c(new byte[3] { 197, 197, 218 }, 150), StringComparison.OrdinalIgnoreCase) >= 0 || _0x05168e33.IndexOf(_0xe441340d._0xeed5ad3c(new byte[11] { 64, 70, 81, 87, 74, 69, 74, 64, 66, 87, 70 }, 35), StringComparison.OrdinalIgnoreCase) >= 0 || _0x05168e33.IndexOf(_0xe441340d._0xeed5ad3c(new byte[4] { 239, 233, 254, 248 }, 172), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x48aba5b6 = "";
    private void Awake()
    {
        if (_0x28358be3 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x28358be3 = gameObject.GetComponent<_0xb1aeb5b6>();
        DontDestroyOnLoad(gameObject);
        _0xca8453ae = _0x6785142e = _0x3aebf144 = "";
        _0x4126e031 = "";
        _0x03c76a4f = false;
    }

    private string _0xdc7d1bec()
    {
        float _0xd3159bd6 = Time.realtimeSinceStartup;
        if (_0xd3159bd6 < 0f)
            _0xd3159bd6 = 0f;
        int _0xb96c50c7 = (int)(_0xd3159bd6 * 1000f);
        int _0xdb57bfb1 = _0xb96c50c7 / 60000;
        int _0x37734c10 = (_0xb96c50c7 / 1000) % 60;
        int _0xb1e3586e = _0xb96c50c7 % 1000;
        return string.Format(_0xe441340d._0xeed5ad3c(new byte[21] { 41, 98, 104, 98, 98, 47, 104, 41, 99, 104, 98, 98, 47, 104, 41, 96, 104, 98, 98, 98, 47 }, 82), _0xdb57bfb1, _0x37734c10, _0xb1e3586e);
    }

    // WEB VIEW LOGIC END
    internal void _0x5a2f0724()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x60ab2fba = new AndroidNotificationChannel
        {
            Id = _0xe441340d._0xeed5ad3c(new byte[15] { 76, 77, 78, 73, 93, 68, 92, 119, 75, 64, 73, 70, 70, 77, 68 }, 40),
            Name = _0xe441340d._0xeed5ad3c(new byte[15] { 114, 83, 80, 87, 67, 90, 66, 22, 117, 94, 87, 88, 88, 83, 90 }, 54),
            Importance = Importance.High,
            Description = _0xe441340d._0xeed5ad3c(new byte[21] { 102, 68, 79, 68, 83, 64, 77, 1, 79, 78, 85, 72, 71, 72, 66, 64, 85, 72, 78, 79, 82 }, 33)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x60ab2fba);
        // Build notification
        var _0xcb0d9553 = new AndroidNotification
        {
            Title = _0x356cd576[UnityEngine.Random.Range(0, _0x356cd576.Length)],
            Text = _0xe441340d._0xeed5ad3c(new byte[21] { 207, 252, 235, 174, 247, 225, 251, 174, 253, 251, 252, 235, 174, 250, 225, 174, 235, 246, 231, 250, 177 }, 142),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xcb0d9553, _0xe441340d._0xeed5ad3c(new byte[15] { 152, 153, 154, 157, 137, 144, 136, 163, 159, 148, 157, 146, 146, 153, 144 }, 252));
    }

    private bool _0xd6ddb456()
    {
        if (_0x5c33c9ee())
            return true;
        if (_0xea5f3a36 != null && _0xea5f3a36.CanGoBack)
        {
            WLog(_0xe441340d._0xeed5ad3c(new byte[36] { 16, 57, 42, 60, 47, 57, 42, 61, 120, 58, 57, 59, 51, 120, 117, 102, 120, 53, 57, 49, 54, 120, 15, 61, 58, 14, 49, 61, 47, 120, 31, 55, 26, 57, 59, 51 }, 88));
            _0xea5f3a36.GoBack();
            return true;
        }

        return false;
    }

    private string _0xa61bf2c5;
    private void WLog(string _0x25c35428)
    {
#if B_LOGS
        {
            Debug.Log(_0xe441340d._0xeed5ad3c(new byte[7] { 75, 68, 117, 99, 100, 77, 48 }, 16) + _0x25c35428);
        }
#endif
    }

    private bool _0xf00826ad = false;
}

internal static class _0xe441340d
{
    internal static string _0xeed5ad3c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}