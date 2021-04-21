# Ringcordion

Turns Nintendo Switch Ringcon into an accordion. You can play triads in major or minor scale from C to A. 

If you don't want to dig into the project, please download the [build for Windows](https://www.dropbox.com/s/wdee8vhs5vo06bw/RC_build_19042021.rar?dl=0). Please use Alt+F4 to close the build, I've been too lazy to add a "close" button.

**_To play_**, 
## 1. Download Ringcon Driver AND do everything [@ringrunnermg](https://github.com/ringrunnermg) recommends. 
_I’ll quote the whole thing here:_

- Download the latest version from the releases tab https://github.com/ringrunnermg/Ringcon-Driver/releases/tag/1.0.1
- Download the latest version of Vigembus from https://github.com/ViGEm/ViGEmBus/releases and install it
- Connect the controllers (info below)
- Run the program, this should set up a virtual x360 controller on your computer.

**Connecting and Disconnecting the Controllers**
- Hold down the bluetooth button on the controller until the lights start flashing.
- Go to the bluetooth settings on Windows 10 and add a device. The controller should show up as "Joycon(L)" or "Joycon(R)"
- Make sure the Joycon shows up in the bluetooth settings as connected, the lights should still be flashing (This seems to be where windows 7 falls over... Note: The Ringcon Driver does not work on windows 7)
- Connect the other controller, ensure you now have both controllers showing up under Bluetooth as connected.
- Connect the Ringcon
- Always leave the Ringcon driver running in the background.
 
## 2. Before running the driver, tick: 
- Combine JoyCons
- Ringcon to Analog Stick
- Ringcon Full RH

![Screenshot 2021-04-19 230311](https://user-images.githubusercontent.com/17061437/115303107-7adbee00-a163-11eb-9aff-6eeda2f228ae.png)


## 3. Run either Unity project or the [build from the archive](https://www.dropbox.com/s/wdee8vhs5vo06bw/RC_build_19042021.rar?dl=0).
## 4. Take the Ringcon with both hands, your right hand on JoyCon, the JoyCon facing you.
![IMG_1469](https://user-images.githubusercontent.com/17061437/115303260-b080d700-a163-11eb-9f24-b887fa17c7b7.jpg)

## 5. Have fun <3


# Controls:
Pulling and pushing work like real accordion’s “bellows”. If you stop moving the bellows, the sound will stop as well.
The buttons switch the triad to another tonic note. Here’s the scheme I mapped it to:
![RC controls](https://user-images.githubusercontent.com/17061437/115304426-3ea98d00-a165-11eb-8ef5-43db3ed13b06.jpg)


Tilt switches the scale. If you tilt the Ringcon towards yourself, you’ll get the major triad. Tilting away makes it minor.
![rc switch](https://user-images.githubusercontent.com/17061437/115306216-cb554a80-a167-11eb-8a87-b866a9b54732.gif)

For obvious reasons, it also works with X360 controller. If you have one, you won’t need the Ringcon or the Ringcon Driver, but you’ll miss most of the fun. The ringcon will be visualized in Unity anyway.

The repository contains Unity project, Wwise project and the builded version for Win 86-64. If you modify something from the Wwise side, please make sure you generate soundbanks before running the project in Unity.
The accordion timbre is run by several Wwise Synth One instances. It’s been resynthesized from the real accordion timbre.



# Thanks:
- [@ringrunnermg](https://github.com/ringrunnermg) for the driver AND the special version that returns the pushing and pulling values.
- [@superlouis64](https://github.com/SuperLouis64) and [Mike Choi](https://twitter.com/mechachoi) for the inspiration.
- [@Audiokinetic](https://github.com/audiokinetic) and [@Unity](https://github.com/Unity-Technologies) for the awesome tools.
- [Marc Giguere](https://www.mgfilmmusic.com/) for the awesome 3d model I used to visualize the process of playing in Unity.
- [@pilgun](https://github.com/pilgun) for having shared super useful info on GitHub licensing.
- V@£}€\^*} for all the support and listening to my "YOU'LL NEVER GUESS WHAT'S INSIDE THE RINGCON" extatic screams.
- [@Xorboo](https://github.com/Xorboo) and [@alxtrkhv](https://github.com/alxtrkhv) for their huge help with cleaning my repository!

**Great resources I haven’t used in this project but got lots of ideas from:**
- A [library for JoyCons](https://github.com/Looking-Glass/JoyconLib) by [@Looking Glass](https://github.com/Looking-Glass)
- [Nintendo Switch reverse engineering](https://github.com/dekuNukem/Nintendo_Switch_Reverse_Engineering) by [@dekuNukem](https://github.com/dekuNukem)

