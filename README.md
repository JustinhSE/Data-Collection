## Bridging Unity and ROS for Data Collection


This project aims to seamlessly collect and transfer object coordinate data from Unity to ROS, empowering the integration of virtual environments with real-world robotic systems.

### 🔑 Key Features
- Unity-ROS Communication: Establishes a robust connection using the Unity Robotics ROS TCP Connector for efficient data exchange.
- Object Coordinate Conversion: Seamlessly transforms Unity object coordinates into ROS-compatible object coordinates using custom code, ensuring compatibility between systems.
- Data Publication: Publishes object position and rotation data to a designated ROS topic at a configurable frequency, enabling real-time data access for robotic applications.

### 🖥️ Core Components:

**RosPublisher class:** 
- Establishes the ROS connection.
- Registers a publisher for object data.
- Implements the ToRos method for coordinate conversion.
- Periodically publishes object position and rotation to ROS
