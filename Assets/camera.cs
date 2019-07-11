using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour {
    public RawImage rawImage;
    public GameObject CameraLength;

    WebCamTexture webCamTexture;
    WebCamDevice[] webCamDevice;
    int selectCamera = 0;

    void Start() {
        webCamTexture = new WebCamTexture();


        webCamDevice = WebCamTexture.devices;
        rawImage.texture = webCamTexture;
        webCamTexture.Play();
        ChangeCamera();
    }

    public void ChangeCamera() {
        int cameras = webCamDevice.Length; //カメラの個数
        CameraLength.GetComponent<TextMesh>().text = cameras.ToString();
        if (cameras <= 1)
            return; // カメラが1台しかなかったら実行せず終了

        selectCamera++;
        if (selectCamera >= cameras)
            selectCamera = 0;

        webCamTexture.Stop(); // カメラを停止
        webCamTexture = new WebCamTexture(webCamDevice[selectCamera].name); //カメラを変更
        rawImage.texture = webCamTexture;
        webCamTexture.Play(); // 別カメラを開始
    }
}
