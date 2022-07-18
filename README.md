# ROS2Test

A ROS2 test project featuring the ROS2ForUnity package from RobotecAI.

ROS2ForUnity is a "high-performance communication solution to connect Unity3D and ROS2 ecosystem in a ROS2 'native' way. Communication is not bridged as in several other solutions, but instead it uses ROS2 middleware stack (rcl layer and below), which means you can have ROS2 nodes in your simulation."

This test relies on a ROS2 talker/listener pair.  Together they move around a game object on screen.

![start](https://user-images.githubusercontent.com/84337590/179428099-3c447756-8dc3-44ec-a350-33e83b8e204a.png)

There are three objects in the scene:

red cube -- a talker on the playfield<BR>
blue sphere -- a listener on the playfield<BR>
green cylinder -- a target indicator hovering above the playfield<BR>

A geometry message is published by the talker and read by the listener.  There are actually multiple topics:

![list](https://user-images.githubusercontent.com/74695555/179434220-e699ee1d-b888-4255-9a9e-a2707b143b77.png)

but the message queries the cylinder for it's x and z coordinates, which are then passed on to the listener through the message.

![point](https://user-images.githubusercontent.com/74695555/179434223-7b718ac9-423f-4b2f-b92a-149f3503909d.png)

Upon receipt of the message, the sphere's initial velocity is altered by a force directing it toward the target.

![mid](https://user-images.githubusercontent.com/84337590/179428100-4a8e354f-c6f2-4698-adf3-232e2e101a0b.png)

While you could direct the sphere directly toward the target location immediately and stop, this method was more interesting to watch.
  
![midway](https://user-images.githubusercontent.com/74695555/179434596-29059091-fb51-4984-a54b-cd47d88bfd2a.png)
  
After a couple more orbits the sphere zeroes in on its target.

![almost](https://user-images.githubusercontent.com/84337590/179428101-544548c9-66f7-45ca-a7bb-bc41c5b69689.png)

Once the sphere is within a minimum distance threshold, it stops.

![endAnnotated](https://user-images.githubusercontent.com/84337590/179428102-73afa29e-bfd4-4f9b-9345-1c542bb9dc81.png)
