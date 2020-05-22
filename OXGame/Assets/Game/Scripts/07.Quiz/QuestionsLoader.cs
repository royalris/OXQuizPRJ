using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsLoader : MonoBehaviour
{
    string path = "question";

    public  string[] Category = new string[7] {"인물","애니","역사","과학","국어","엽기","미술"} ;
    private static List<Questions> quests = new List<Questions>();

  
    private void Start()
    {
        QuestionsContainer qc = QuestionsContainer.Load(path);
        quests = qc.questionsList;
    }

    public  List<Questions> SetQuiz(string _category)
    {
        List<Questions> send = new List<Questions>();
        if(quests.Count ==0)
        {
            print("a");
        }
        for (int i = 0; i < quests.Count; i++)
        {
            //if(quests[i].catagory == _category)
            {
                send.Add(quests[i]);
            }
        }
            return send;
    }
}
