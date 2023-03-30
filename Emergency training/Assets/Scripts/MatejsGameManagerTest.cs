using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using Unity.VisualScripting;
using static MatejsGameManagerTest;


public class MatejsGameManagerTest : MonoBehaviour
{




    public class Step
    {
        public int stepNumber;
        public string title;
        public string description;
        public string positiveFeedback;
        public string negativeFeedback;

        public Step(int stepNumber, string title, string description, string positiveFeedback, string negativeFeedback)
        {
            this.stepNumber = stepNumber;
            this.title = title;
            this.description = description;
            this.positiveFeedback = positiveFeedback;
            this.negativeFeedback = negativeFeedback;
        }
    }


    public class GameManager
    {
        public List<Step> steps;
        public int currentStep;
     

        public GameManager()
        {
            // Initialize the steps list in the constructor
            steps = new List<Step>();

            // Add the steps to the list
            steps.Add(new Step(1, "Evacuation Plan", "Learn the building's evacuation plan", "Great job! You've taken an important first step in fire safety.", "Oops, you missed an important step. Remember to always familiarize yourself with the evacuation plan in any building you enter."));
            steps.Add(new Step(2, "Fire Extinguisher", "Learn how to use a fire extinguisher", "Excellent work! You now know how to use a fire extinguisher in case of emergency.", "Remember to aim the fire extinguisher at the base of the fire, not at the flames."));
            steps.Add(new Step(3, "Smoke Detector", "Learn how to test and maintain smoke detectors", "Well done! You're now equipped to ensure your smoke detectors are working properly.", "Remember to test your smoke detectors regularly to ensure they're functioning correctly."));
            steps.Add(new Step(4, "Emergency Contacts", "Learn who to contact in case of emergency", "Fantastic! You're now prepared to reach out to the appropriate authorities in case of emergency.", "Make sure you have the correct phone numbers saved and accessible in case of emergency."));
            steps.Add(new Step(5, "Emergency Escape Route", "Learn and practice an emergency escape route", "Brilliant work! You're now prepared with a clear plan for emergency evacuation.", "Make sure to practice your emergency escape route with family and colleagues to ensure everyone knows what to do in case of emergency."));

            // Set the current step for the beggining of the game
            currentStep = 1;
        }

        public void Start()
        {
            // Get the steps from the GameManager
            GameManager gameManager = new GameManager();
            steps = gameManager.steps;

            // Load the current step from PlayerPrefs
            currentStep = PlayerPrefs.GetInt("CurrentStep", 0);

            //or this? It's becoming a mess :-D 
            gameManager.LoadProgress();

            // Show the UI for the current step
            UIManager.Instance.ShowPrompt(steps[currentStep].description);
        }


        public void CompleteCurrentStep()
        {
            // Increment the current step and save it to PlayerPrefs
            currentStep++;
            PlayerPrefs.SetInt("CurrentStep", currentStep);
            PlayerPrefs.Save();

            // If we've completed all steps, reset the game
            if (currentStep >= steps.Count)
            {
                ResetGame();
            }
            else
            {
                // Show the UI for the next step
                UIManager.Instance.ShowPrompt(steps[currentStep].description);
                //UIManager.ShowPrompt();
                //UIManager.showText(); - Doesn't work and I don't know why
            }
        }

        public void StartGame()
        {

            string json = Resources.Load<TextAsset>("steps").text;
            steps = JsonConvert.DeserializeObject<List<Step>>(json);

            // set the current step to 0
            currentStep = 0;
        }

        public void SaveProgress()
        {
            // save the current step to player prefs or another data store
            PlayerPrefs.SetInt("currentStep", currentStep);
        }

        public void LoadProgress()
        {
            // load the current step from player prefs or another data store
            currentStep = PlayerPrefs.GetInt("currentStep");
        }

        public Step GetCurrentStep()
        {
            return steps[currentStep];
        }

        public string GetCurrentStepTitle()
        {
            return steps[currentStep].title;
        }

        public string GetCurrentStepDescription()
        {
            return steps[currentStep].description;
        }
        public void ResetGame()
        {
            currentStep = 0;
            SaveProgress();
            UIManager.Instance.ShowMainMenu();
        }
    }

    // UI Manager
    public class UIManager
    {

        public TextMeshProUGUI resultText;
        public static UIManager Instance { get; private set; }
        private GameManager gameManager;

        /*  private void Awake()
          {
              if (Instance == null)
              {
                  Instance = this;
              }
              else
              {
                  Destroy(gameObject);
              }
          } */

        public void ShowPrompt(string promptText)
        {

        }

        public void showText()
        {
            resultText.text = gameManager.GetCurrentStepTitle().ToString();
        }

        public void ShowMainMenu()
        {
            // show the main menu UI element
        }
    } 

}
