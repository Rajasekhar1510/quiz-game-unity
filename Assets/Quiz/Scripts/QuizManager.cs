using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private QuizUI quizUI;
    [SerializeField] private QuizDataScriptable quizData;

    private List<Question> questions;

    private Question selectedQuestion;

    private void Start()
    {
        questions = quizData.questions;

        SelectQuestion();
    }

    void SelectQuestion()
    {
        int val = Random.Range(0, questions.Count);
        selectedQuestion = questions[val];

        quizUI.SetQuestion(selectedQuestion);
    }

    public bool Answer(string answered)
    {
        bool correctAns = false;

        if (answered == selectedQuestion.correctAns)
        {
            //yes
            correctAns = true;
        }
        else
        {
            //no
        }
        Invoke("SelectQuestion", 0.9f);

        return correctAns;
    }

}
[System.Serializable]
public class Question
{
    [Header("Question Details")]
    public string questionInfo;
    public QuestionType questionType;
    public Sprite questionImg;
    public AudioClip questionClip;
    public UnityEngine.Video.VideoClip questionVideo;

    [Header("Option and answer Details")]
    public List<string> options;
    public string correctAns;
}
[System.Serializable]
public enum QuestionType
{
    TEXT,
    IMAGE,
    VIDEO,
    AUDIO
}