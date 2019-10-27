using System.Collections;
using UnityEngine;

public class KomachiFaceAnimation : MonoBehaviour
{
    private SkinnedMeshRenderer mSkinnedMeshRenderer;
    //口パクのブレンドシェイプの値
    private float mRipValue = 0.0f;
    //瞬きのブレンドシェイプの値
    private float mBlinkValue = 0.0f;
    [Header("口パクの速度")]
    public float mRipSpeed = 1.0f;
    [Header("瞬きの速度")]
    public float mBlinkSpeed = 1.0f;
    [Header("口パクするか")]
    public bool mIsRip = true;
    [Header("瞬きするか")]
    public bool mIsBlink = true;

    /// <summary>
    /// 入力値の制限
    /// </summary>
    private void OnValidate()
    {
        mRipSpeed = Mathf.Clamp(mRipSpeed, -100, 100);
        mBlinkSpeed = Mathf.Clamp(mBlinkSpeed, -100, 100);
    }

    private void Start()
    {
        var face = GameObject.Find("mirai_scene/mirai2019_dance/face");
        if (face == null)
        {
            Debug.LogError("小町ちゃんの顔が取得できなかった\nデフォルトから名前を変えた不届き者がこの中にいる");
            Destroy(this);
            return;
        }
        mSkinnedMeshRenderer = face.GetComponent<SkinnedMeshRenderer>();
        StartCoroutine(RipCoroutine());
        StartCoroutine(BlinkCoroutine());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            mIsRip = !mIsRip;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            mIsBlink = !mIsBlink;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RipReset();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            BlinkReset();
        }
    }

    /// <summary>
    /// 口パク関連のデータを初期化する
    /// </summary>
    public void RipReset()
    {
        mRipValue = 0;
        mSkinnedMeshRenderer.SetBlendShapeWeight(0, mRipValue);
        mRipSpeed = Mathf.Abs(mRipSpeed);
    }

    /// <summary>
    /// 瞬き関連のデータを初期化する
    /// </summary>
    public void BlinkReset()
    {
        mBlinkValue = 0;
        mSkinnedMeshRenderer.SetBlendShapeWeight(5, mBlinkValue);
        mBlinkSpeed = Mathf.Abs(mBlinkSpeed);
    }

    /// <summary>
    /// 口パクコルーチン
    /// </summary>
    /// <returns></returns>
    private IEnumerator RipCoroutine()
    {
        while (true)
        {
            if (mIsRip)
            {
                mSkinnedMeshRenderer.SetBlendShapeWeight(0, mRipValue);
                mRipValue = Mathf.Clamp(mRipValue + mRipSpeed, 0, 100);
                if (mRipValue >= 100 || mRipValue <= 0) mRipSpeed *= -1.0f;
            }
            yield return null;
        }
    }

    /// <summary>
    /// 瞬きコルーチン
    /// </summary>
    /// <returns></returns>
    private IEnumerator BlinkCoroutine()
    {
        while (true)
        {
            if (mIsBlink)
            {
                mSkinnedMeshRenderer.SetBlendShapeWeight(5, mBlinkValue);
                mBlinkValue = Mathf.Clamp(mBlinkValue + mBlinkSpeed, 0, 100);
                if (mBlinkValue >= 100 || mBlinkValue <= 0) mBlinkSpeed *= -1.0f;
            }
            yield return null;
        }
    }
}
