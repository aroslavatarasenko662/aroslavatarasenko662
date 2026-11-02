using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x82ef1ee8 : MonoBehaviour
{
    private _0x4654f060 _0x9b282b72 = _0x4654f060.Portrait;
    //public bool executeInUpdate;
    private float _0x018e883b { get; set; }
    private Vector3 _0xbedc7da1 { get; set; }
    private Vector3 _0x66bb0089 { get; set; }

    private Color _0xc76f10c3 = Color.white;
    public enum _0x4654f060
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x93757605 { get; set; }
    private Vector3 _0x85bdbe76 { get; set; }
    private Vector3 _0x70f5a293 { get; set; }

    private static _0x82ef1ee8 _0xf219dcf8;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xc76f10c3;
        Matrix4x4 _0x003d0f34 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xa9eb1174.orthographic)
        {
            float _0x3403442b = this._0xa9eb1174.farClipPlane - this._0xa9eb1174.nearClipPlane;
            float _0x9c256202 = (this._0xa9eb1174.farClipPlane + this._0xa9eb1174.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x9c256202), new Vector3(this._0xa9eb1174.orthographicSize * 2 * this._0xa9eb1174.aspect, this._0xa9eb1174.orthographicSize * 2, _0x3403442b));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xa9eb1174.fieldOfView, this._0xa9eb1174.farClipPlane, this._0xa9eb1174.nearClipPlane, this._0xa9eb1174.aspect);
        }

        Gizmos.matrix = _0x003d0f34;
    }

    private Vector3 _0x584efe97 { get; set; }
    private float _0x44ec1c40 { get; set; }

    private void _0xacaca027()
    {
        float _0x68111c12, _0x826774da, _0xd35c7b48, _0x9aeef14c;
        if (this._0x9b282b72 == _0x4654f060.Landscape)
            this._0xa9eb1174.orthographicSize = 1f / this._0xa9eb1174.aspect * this._0x835fb030 / 2f;
        else
            this._0xa9eb1174.orthographicSize = this._0x835fb030 / 2f;
        this._0x44ec1c40 = 2f * this._0xa9eb1174.orthographicSize;
        this._0x018e883b = this._0x44ec1c40 * this._0xa9eb1174.aspect;
        float _0xb265cb46 = this._0xa9eb1174.transform.position.x;
        float _0x5a6e6350 = this._0xa9eb1174.transform.position.y;
        _0x68111c12 = _0xb265cb46 - this._0x018e883b / 2;
        _0x826774da = _0xb265cb46 + this._0x018e883b / 2;
        _0xd35c7b48 = _0x5a6e6350 + this._0x44ec1c40 / 2;
        _0x9aeef14c = _0x5a6e6350 - this._0x44ec1c40 / 2;
        this._0x93757605 = new Vector3(_0x68111c12, _0x9aeef14c, 0);
        this._0x85bdbe76 = new Vector3(_0xb265cb46, _0x9aeef14c, 0);
        this._0x66bb0089 = new Vector3(_0x826774da, _0x9aeef14c, 0);
        this._0xb40e5aee = new Vector3(_0x68111c12, _0x5a6e6350, 0);
        this._0x838b5544 = new Vector3(_0xb265cb46, _0x5a6e6350, 0);
        this._0xbedc7da1 = new Vector3(_0x826774da, _0x5a6e6350, 0);
        this._0x70f5a293 = new Vector3(_0x68111c12, _0xd35c7b48, 0);
        this._0x584efe97 = new Vector3(_0xb265cb46, _0xd35c7b48, 0);
        this._0x18f1d5bb = new Vector3(_0x826774da, _0xd35c7b48, 0);
    }

    private float _0x835fb030 = 1;
    private Vector3 _0xb40e5aee { get; set; }

    private void Awake()
    {
        this._0xa9eb1174 = this.GetComponent<Camera>();
        _0xf219dcf8 = this;
        this._0xacaca027();
    }

    private Vector3 _0x838b5544 { get; set; }

    private new Camera _0xa9eb1174;
    private Vector3 _0x18f1d5bb { get; set; }
}