using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendedFunctions : MonoBehaviour
{
    public static GameObject FindChildObject(GameObject parent, string childName)
    {
        //stub
        GameObject o = parent.transform.Find(childName).gameObject;
        return o;
    }

    public static GameObject FindChildObjectRecursive(GameObject parent, string childName)
    {
        //stub
        GameObject oo = FindChildObject(parent, childName);
        if(oo != null)
        {
            return oo;
        }
        for(int i = 0; i < parent.transform.childCount; i++)
        {
            GameObject o = FindChildObject(parent.transform.GetChild(i).gameObject, childName);
            if(o == null)
            {
                FindChildObjectRecursive(parent.transform.GetChild(i).gameObject, childName);
            }
            else
            {
                return o;
            }
        }
        return null;
    }
}
