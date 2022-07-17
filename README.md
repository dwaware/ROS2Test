# ROS2Test
 A ROS2 test project.

A quick talker/listener test that utlizes published messages move around a gameobject on screen:

![start](https://user-images.githubusercontent.com/84337590/179428099-3c447756-8dc3-44ec-a350-33e83b8e204a.png)

There are three objects in the scene:

red cube -- talker
blue sphere -- listenter
green cylinder -- target indicator

A geometry message is published by the talker and read by the listener.  The geometry message indicates a target point taken from the coordinates of the cylinder.  Upon receipt of the message, the sphere's initial velocity is altered by a force directing it toward the target.

![mid](https://user-images.githubusercontent.com/84337590/179428100-4a8e354f-c6f2-4698-adf3-232e2e101a0b.png)

While you could direct the sphere directly toward the target location immediately and stop, this method was more interesting to watch.

![almost](https://user-images.githubusercontent.com/84337590/179428101-544548c9-66f7-45ca-a7bb-bc41c5b69689.png)

Once the sphere is within a minimum distance threshold, the sphere stops.

![endAnnotated](https://user-images.githubusercontent.com/84337590/179428102-73afa29e-bfd4-4f9b-9345-1c542bb9dc81.png)
