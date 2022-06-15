using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class JSONAccess : MonoBehaviour
{
    [System.Serializable]
    public class Entry
    {
        public string @id;
        public string @type;
        public string representation_of;
        public string reference_organ;
        public string scenegraph;
        public string scenegraphNode;
        public List<int> transformMatrix;
        public string tooltip;
        public Color color;
        public float opacity;
        public bool unpickable;
        public string _lighting;
        public bool zoomBasedOpacity;
    }

    [System.Serializable]
    public class EntryList
    {
        public Entry[] entries;
    }

    public EntryList entryList = new EntryList();
    
    public void JsonFormatting(string json)
    {
        json = "{ \"entries\": " + json;
        json = json + " }";
        entryList = JsonUtility.FromJson<EntryList>(json);
    }
}
