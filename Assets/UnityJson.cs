using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UnityJson : MonoBehaviour
{
    public string fileName;
    public Book book = new Book();
    public Books books = new Books();
    void Start()
    {
        /* Debug.Log(JsonUtility.ToJson(book));
         Debug.Log(JsonUtility.ToJson(books));*/
        string filePath = Application.streamingAssetsPath + "/" + fileName + ".json";
        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }
        string jsonInfo = JsonUtility.ToJson(books);
        File.WriteAllText(filePath, jsonInfo);
    }
}
[System.Serializable]
public class Books {
    public List<Book> book_ = new List<Book>();
}

[System.Serializable]
public class Book {
    public int id;
    public string name;
    public string author;
}