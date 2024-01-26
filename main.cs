using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RosMessageTypes.Geometry;
using Unity.Robotics.ROSTCPConnector.ROSGeometry;
using Unity.Robotics.ROSTCPConnector;

public class RosPublisher: MonoBehaviour
{
    ROSConnection ros;
    public string topicName = "testtest";
   
    // The game object
    public GameObject cube;
    // Publish the cube's position and rotation every N seconds
    public float publishMessageFrequency = 0.5f;

    // Used to determine how much time has elapsed since the last message was published
    private float timeElapsed;
     
    void Start()
    {
        // start the ROS connection
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterPublisher<PointMsg>(topicName);
        //method call
    }


    PointMsg ToRos(Vector3 position)
    {
        return position.To<FLU>();
    }

    
    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > publishMessageFrequency)
        {

            Vector3 cubePos = new Vector3(cube.transform.position.x, cube.transform.position.y, cube.transform.position.z);

            // Finally send the message to server_endpoint.py running in ROS
            Debug.Log(ToRos(cubePos));
            ros.Publish(topicName, ToRos(cubePos));

            timeElapsed = 0;
        }
    }
}