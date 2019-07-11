using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class SysInfo : MonoBehaviour {

    public TextMesh sysinfo;


    // Use this for initialization
    void Start() {

        sysinfo.text = string.Format("Name: {0}", SystemInfo.deviceName) + "\r\n";
        sysinfo.text += string.Format("Model: {0}", SystemInfo.deviceModel) + "\r\n";
        sysinfo.text += string.Format("Type: {0}", SystemInfo.deviceType) + "\r\n";
        sysinfo.text += string.Format("GraphicDeviceName: {0}", SystemInfo.graphicsDeviceName) + "\r\n\r\n";

        sysinfo.text += string.Format("OS: {0}", SystemInfo.operatingSystem) + "\r\n";
        sysinfo.text += string.Format("CPU: {0}", SystemInfo.processorType) + "\r\n";
        sysinfo.text += string.Format("Core: {0}", SystemInfo.processorCount) + "\r\n";
        sysinfo.text += string.Format("Frequeny: {0} MHz", SystemInfo.processorFrequency) + "\r\n";
        sysinfo.text += string.Format("RAM: {0} MB", SystemInfo.systemMemorySize) + "\r\n\r\n";

        Resolution reso = Screen.currentResolution;
        sysinfo.text += string.Format("Resolution: {0} x {1}", reso.width, reso.height) + "\r\n";
        sysinfo.text += string.Format("RefreshRate: {0} Hz", reso.refreshRate) + "\r\n\r\n";

        sysinfo.text += string.Format("Battery Level: {0:##.#} %", SystemInfo.batteryLevel * 100) + "\r\n";
        sysinfo.text += string.Format("Battery Status: {0}", SystemInfo.batteryStatus) + "\r\n";

    }

    // Update is called once per frame
    void Update() {
    }
}