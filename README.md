# GearVRControllerKeyturn
Open source utility scripts for adding keyturn functionality to the gear VR controller in Unity

## Oculus Utilities for Unity are required 

You can download them from https://developer.oculus.com/downloads/package/oculus-utilities-for-unity-5/1.18.1/

Do this right after adding this into your project.


### Built in Unity Version 2017.2.0f1

This package has a prefab for the Tracked Pose Driver component that was added in Unity 2017.2 for generic XR devices.


### Scenes
***GearVR_Keyturn***
This scene shows off the keyturn method with a red ball that has a sphere collider attached to it  
[Video](https://drive.google.com/file/d/0B5WA9qR0jNE-dW1yLTYxOTZIdmc/view?usp=sharing)

***GearVR_Grab***
This scene shows off grab functionality with a hand attached. Grab works by clicking the touchpad on the controller
(<blockquote class="twitter-video" data-lang="en"><p lang="en" dir="ltr">Here&#39;s a grab example from my mobile <a href="https://twitter.com/hashtag/VR?src=hash&amp;ref_src=twsrc%5Etfw">#VR</a> talk. Using a key turn rotation to extend a hand and grab objects. <a href="https://t.co/pJb37AvGQ3">pic.twitter.com/pJb37AvGQ3</a></p>&mdash; Dan Miller (@DanMillerDev) <a href="https://twitter.com/DanMillerDev/status/921424012487491585?ref_src=twsrc%5Etfw">October 20, 2017</a></blockquote>
<script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>)




### Building to Device


In order to build to a device you will need to replace the oculussig_temp with a osig file for your device
