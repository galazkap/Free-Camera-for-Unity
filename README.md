
# Free Camera and Camera Changer

  <p align="center"> <img  width="500" src="https://user-images.githubusercontent.com/74678721/101545338-67e03280-39a7-11eb-8020-f2d60cbb6b26.png"> </p>
  
The free camera and camera changer are two simple tools made on the Unity engine. These tools can be useful when testing the game, when we need to quickly move from one place to another. You can also use them as mechanic in the game. It all depends on you.


  

## Free Camera

Free camera allows us to move camera everywhere we want. It works just like noclip.

Free camera is very easy to use. It's enough to use a ready prefab or create a new camera and use the script "Free Camera".

<p align="center"> <img src="https://user-images.githubusercontent.com/74678721/101545132-18016b80-39a7-11eb-885f-513d5e6700fb.gif"> </p>

**Script setting**
Free Camera has several configurable settings that allow you to set it according to your personal preferences. Changing the settings does not require interfering with the script, everything can be changed from the inspector level.
 - *Camera Speed* - Current camera speed (initial)
 - *Camera Speed Multiplier* - How much faster the camera should move after pressing the binded key
 - *Max Camera Speed* - The maximum camera speed used when changing speed in game
 - *Mouse Sensitivity* - The sensitivity of the mouse when moving the camera
 - *Camera Switch* - Possibility to enable and disable free camera in the game by pressing binded key
<p align="center"> <img src="https://user-images.githubusercontent.com/74678721/101545614-cdccba00-39a7-11eb-9e57-75e51861358c.png"> </p>

**Standard Keyboard controls**

- Use **W A S D** to move camera
- Use **Q** and **E** to move up and down.
- Hold down **Shift** to move faster.
- Use **F** to enable/disable free camera.
- While holding **RMB**

	* Scroll up or down to speed up or slow down the camera movement

	* Move the mouse to look around


**Change Keyboard controls**
If you don't like the standard keyboard binding you can easily change them using the script 'Simple Camera Input'.
<p align="center"> <img src="https://user-images.githubusercontent.com/74678721/101542251-cce55980-39a2-11eb-8125-1e5d51e1dacf.png"> </p>
Note that although the keys is assigned in this script, it still uses the Unity Input System. Additionally, it is not possible to change the mouse settings via this script and it should be done using the above-mentioned unity input system.

  

## Camera Changer

Camera changer is a very simple tool that allows you to add several cameras to the scene and move between them during the game.

Like the Free Camera, it is very easy to use, just drag a ready-made prefab onto the scene or add a script to an existing object.
<p align="center"> <img src="https://user-images.githubusercontent.com/74678721/101551127-d2e23700-39b0-11eb-8f95-2902ab6fd2d2.gif"> </p>

**Camera changer can be associated with a free camera.**

Of course, you don't have to use the full functionality of camera changer, but if you want to take advantage of changes in the camera position in real time, you have to insert a free camera into the camera changer as one of the available cameras. This will allow you to move to the selected position and set a static camera in it.

It is equally possible to use all free cameras and switch between them at your own discretion or use all static cameras that have been set up before.

**Script setting**
Configuring the Camera Changer is very simple, just drag all selected cameras that you want to use to the appropriate list.

 - *Cameras* - List of cameras to be handled by the script
 - *Save* - A key that is used to save the camera to the selected position.
 - *Select Camera* - Keys that are used to change cameras. (**The camera index corresponds to the index of the selected key**)

<p align="center"> <img src="https://user-images.githubusercontent.com/74678721/101551672-aed32580-39b1-11eb-9ef5-27d8dfb2d817.png"> </p>

**How to use it**
 - To change the camera, press the appropriate key.
	 -  e.g Press **KeyPad0** to switch to **FreeCamera1**.
 - To save the camera in the desired location, press key combinations for saving and the appropriate camera 
	 - e.g Press **Space + KeyPad2** to save DefaultCamera in selected position.

## TODO:

 - Add smooth camera change to CameraChanger
 - Add taking screenshots to a Free Camera
