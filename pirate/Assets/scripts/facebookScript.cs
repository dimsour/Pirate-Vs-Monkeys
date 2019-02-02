using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facebookScript : MonoBehaviour {

    // https://www.facebook.com/MonkeyTest123-218863551928268/

	public void fbButton ()
    {
        Application.OpenURL("https://www.facebook.com/The-Monkey-Island-302762076804562/");
       /* if (checkPackageAppIsPresent("com.facebook.katana"))
        {
            Application.OpenURL("fb://page/375158539307294"); //there is Facebook app installed so let's use it
        }
        else
        {
            Application.OpenURL("https://www.facebook.com/Dimitris.Sour"); // no Facebook app - use built-in web browser
        }*/


    }
    /*private bool checkPackageAppIsPresent(string package)
    {
        AndroidJavaClass up = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ca = up.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject packageManager = ca.Call<AndroidJavaObject>("getPackageManager");

        //take the list of all packages on the device
        AndroidJavaObject appList = packageManager.Call<AndroidJavaObject>("getInstalledPackages", 0);
        int num = appList.Call<int>("size");
        for (int i = 0; i < num; i++)
        {
            AndroidJavaObject appInfo = appList.Call<AndroidJavaObject>("get", i);
            string packageNew = appInfo.Get<string>("packageName");
            if (packageNew.CompareTo(package) == 0)
            {
                return true;
            }
        }
        return false;
    }*/
}
