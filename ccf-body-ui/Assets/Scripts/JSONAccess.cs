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
        public string entityId;
        public List<string> ccf_annotations;
        public string representation_of;
        public string reference_organ;
        public string scenegraph;
        public string scenegraphNode;
        public List<float> transformMatrix;
        public string tooltip;
        public List<float> color;
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
        // the JsonUtility class doesn't have functionality for JSON lists yet, so I have to make it into an object
        json = "{ \"entries\": " + json;
        json = json + " }";
        // JsonUtility was not reading the @ symbols so I removed them
        json = json.Replace("@", "");
        entryList = JsonUtility.FromJson<EntryList>(json);
    }
}
