/*
* Summary: Describe what the tool does here. This should be the same as the xml summary
* Use: Describe how to use this script - ie. what components it requires, etc
* Tested with: Unity 2018.4
* Author: Abel Waller 2019
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Include this!!!
namespace EML
{

    /// <summary>
    /// Describe what the tool does here. This should be the same as the summary above
    /// To make this, right click on the class name and select snippet > insert comment
    /// </summary>
    [RequireComponent(typeof(Collider))] //This means the class requires a collider
    public class ExampleScript : MonoBehaviour
    {
        //Ignore this line
#pragma warning disable 

        private string a = "This isn't visible in the inspector!";

        [Tooltip("Give extra info to show in the inspector here. Try hovering over B in the inspector!")]
        public string b = "This is in the inspector!";

        [HideInInspector]
        public string c = "This isn't visible in the inspector!";

        [SerializeField]
        private string d = "This is in the inspector!";

        private Collider collide; //This is where we will store the collider on the object, so that we can use it later


        private int int1 = 5; // this is an integer
        private float float1 = 10.5f; // this is a float - C# uses these for decimals
        private string string1 = "This is a string, C# uses these for words/sentences/names/etc";
        private GameObject obj; //This is a gameobject - Unity uses this to refer to objects in the scene. EVERYTHING is a gameobject, if its in the unity hierarchy
        private Vector3 position = new Vector3(0f, 0f, 0f); //This is a vector - unity uses vector3 to refer to positions, rotations, scale, etc. You'll probably use these at some point


        /// <summary>
        /// This is a property. They're similar to getters and setters in Java, but C# lets you do much more with them. 
        /// This returns the x component of the vector we defined above, and lets you set it as well
        /// Note the capital letter - lowercase for variables, uppercase for properties!
        /// </summary>
        private float PositionXValue
        {
            get => position.x;
            set => position.x = value;
        }


        // Start is called before the first frame update
        void Start()
        {
            // Debug prints things to the unity console
            Debug.Log("A: " + a);
            Debug.Log("B: " + b);
            Debug.Log("C: " + c);
            Debug.Log("D: " + d);

            //We get the collider on the object and store it. We want to store it, because GetComponent is cpu intensive and repeated calls aren't great
            collide = GetComponent<Collider>();

            PositionXValue = 1f; //This is how to set a property!

            Debug.Log(position); //Note the x value is 1 now, not 0
        }

        // Update is called once per frame
        void Update()
        {
            
        }


        // This is a special function - if this script has a collider, we do whatever is in this function everytime we enter a trigger collider
        private void OnTriggerEnter(Collider other)
        {
            
        }


        // Basic C# stuff here

        /// <summary>
        /// This just adds 2 integers
        /// </summary>
        /// <param name="a">One integer to add</param>
        /// <param name="b">Another integer to add</param>
        /// <returns>The sum</returns>
        private int Add(int a, int b)
        {

            // Try hovering over the name of this function in VisualStudio to see how xml comments work!
            
            // This is private, so we can only use this inside this script


            return a + b;
        }


#pragma warning restore
    }
}
