using UnityEngine;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
public class ImageEnumManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    [SerializedDictionary]
    public SerializedDictionary<characterImages,Sprite> images = new SerializedDictionary<characterImages, Sprite>();
    [SerializedDictionary]
    public SerializedDictionary<backgrounds, Sprite> backgroundImages = new SerializedDictionary<backgrounds, Sprite>();
    public Sprite questionMark;
    public Sprite GetSprite(characterImages characterImage) 
    {
        try
        {
            Sprite toReturn;
            images.TryGetValue(characterImage, out toReturn);
            return toReturn;
        }
        catch (System.Exception)
        {

            return questionMark;
        }
    }
    public Sprite GetBackground(backgrounds backgroundImage)
    {
        try
        {
            Sprite toReturn;
            backgroundImages.TryGetValue(backgroundImage, out toReturn);
            return toReturn;
        }
        catch (System.Exception)
        {

            return questionMark;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class ImagePair
{
    public characterImages name;
    public Sprite image;
}