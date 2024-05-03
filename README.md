### Wwise: Getting Started 
## Gibran Mobarak 
Let me just preface with this is just scratching the surface with what you can do with Wwise. This audio engine is a beast for sure. 
	What is Wwise? Wwise is an audio middleware for game audio that streamlines the process of sound design for interactive mediums. Overall it has the 
 capability for authoring new sounds, dynamic mixing changing on game conditions, Spatial audio, interactive music based on game cues, and real time synthesis. 
To integrate Wwise with your unity project you must first go to the AudioKinetic website and download Wwise onto your computer. Once you have Wwise downloaded, 
create a new Wwise project through the Wwise launcher. Back in the Wwise launcher, navigate to the Unity tab and find the unity project in which you want to 
integrate Wwise with. Click “Integrate Wwise In Project" which will take you to a page with more specifics. Here, make sure the Wwise SDK is installed and that the 
Wwise project path points to the Wwise project you just created. Scroll down and click “Integrate”. 
Great now both your Wwise and Unity projects should be integrated with one another and you can start sound designing! Make sure to disarm Unitys native audio engine 
so that wwise works seamlessly. 
	The fundamental foundation of Wwise are work units. Work Units contain information related to a particular section or element within your project (Ex. Audio-
 Mixer Hierarchy, Audio Devices, Events) and help you organize your project. Work Units are actually XML files created within the project structure of Wwise. Inside 
 these Work Units are your objects which you create. Sounds that you create will be placed under the work unit in the Audio-Mixer Hierarchy found in the “designer” 
 layout. When importing audio files into the Audio-Mixer Hierarchy the object type will be “Sound SFX”.  In the designer layout you can change the volume, pitch , 
 filtering, aux sends, effects, real time parameter control, states and playback start/stop of your audio file. 
	After importing your sound click the “Events” tab next to the “Audio” tab to assign the sound to an event. This is how your sound will be called and played 
 in Unity. Click on the default work unit under the events folder and create a new Event child. In your new event page, click “Add”. Here you will see a bunch of 
 different results that can be an outcome of the event; the one we want to select is “Play”. Navigate back to the audio tab and drag the audio object you want to 
 play under the “target” section of your new event. You can make sure everything is working by pressing play on the event transport control and hearing your sound 
 being played by the event. 
	To export this sound into Unity the first step is to create a soundbank. Soundbanks are the collection of both the code and the audio assets used during the 
 games runtime. Every game needs at least one soundbank but larger ones might have more. Switch to the soundbank layout. Create a new soundbank under the default 
 work unit in the soundbank tab of the project explorer. In the soundbank layout, drag the event you created for your sound into your soundbank. Then select generate 
 all (or select what platform you want to generate for) and make sure there are no error messages. 
	Now navigate back to Unity and let's implement this sound in our game. Events can be called in script using the following syntax: 
 AkSoundEngine.PostEvent("EVENT_NAME", gameObject);
Try simply playing your event under the Start method to see if it works. Make sure to click “Generate sound bank” in the Wwise picker window in unity before running 
the game. 
	Now that we got basic sound working we can talk a little bit more about more cool things you can do with Wwise. Let's start with randomization. You can 
randomize at a couple different levels including randomization of parameters in the designer layout such as volume pitch and filters as well as randomization of 
which sound will be played in an event. For parameter randomization, switch to the designer layout and navigate to the sound you want to implement randomization to. 
Make sure you are on the general settings tab to see the parameters. Next to volume, pitch, filters, and delay you will see a grayed out small circle that looks a 
bit like the pepsi logo, this is your randomization control. Double click the circle and a randomizer window will appear. Here you can enable the randomization as 
well as setting minimum and maximum offsets. In general settings you can also loop your audio file as well, choosing a set amount of loops or having it loop 
infinitely. 
	To randomize sample choice, create a new child under the Actor-Mixer Hierarchy work unit of the type “Random Container” and put your desired sounds in that 
container. This container will randomize the samples that are in it when assigned to an event. You can improve randomness by checking the “Avoid playing last” box 
and set the amount of samples you want to wait for to repeat the same sound again. Similarly you can create a Sequence Container child in the Actor-Mixer Hierarchy 
work unit if you want your samples to play in sequence from one event. However, the samples will not be played in the order they appear in the Hierarchy. You need to 
set the sample order by dragging them to the playlist window and setting the order there. 
	There are many ways in which Wwise communicates with your game in Unity. There are multiple game syncs including switches, states and triggers. These game 
syncs change the sound playing based on events in the game. Another major interface between your game and Wwise is Real Time Parameter Control (RTPC). RTPC is an 
important factor in creating interactive music and sounds with Wwise. The interactive music hierarchy is the section of Wwise that is most similar to a traditional 
DAW. Here you can upload music stems and edit them, add effects, and loop. Working with RTPC we can create interactive features of the music, like stems coming in 
after a certain amount of points are reached. In the RTPC tab of one of your stems you can create what is essentially an automation graph responding to different 
parameters you choose. For example you can set the Y axis to be volume and the X axis to be your in game parameter. Draw in the automation you want to hear (maybe 
the second track comes in after 10 points) and create a new game parameter that will be called in script in unity using AkSoundEngine.SetRTPC("Game Parameters In 
WWise", variable in script);.
	There is a lot more in Wwise that I didn’t get to dive in completely like the synth engine and more complex mixing techniques which would be the next place 
to look to to keep learning more. This engine definitely makes audio implementation in games much more straightforward than what comes in the box at unity especially 
with them only having 5 people dedicated to audio. It is refreshing to have a workspace that is similar to a traditional DAW like we have seen before but with a ton 
more capabilities and workflow for game audio. 


Sources: 
https://www.audiokinetic.com/en/learn/videos/2wmwy5nzzfs/
https://www.audiokinetic.com/en/library/edge/?source=Unity&id=index.html
https://www.audiokinetic.com/en/courses/wwise101/?source=wwise101&id=video_tutorial_101_08#read
https://www.audiokinetic.com/en/courses/wwise301/?source=wwise301&id=Creating_a_WwiseType_Event_property#read
https://www.audiokinetic.com/en/library/edge/?source=Unity&id=class_ak_event.html
https://alessandrofama.com/tutorials/wwise/unity/events#posting-wwise-events-using-the-wwise-picker-in-unity
https://www.audiokinetic.com/en/library/edge/?source=Unity&id=unity_picker.html
https://www.audiokinetic.com/en/courses/wwise201/?source=wwise201&id=looping_clips#:~:text=This%20is%20done%20by%20moving,the%20clip%20begins%20to%20repeat.
https://www.youtube.com/watch?v=mCOwTQ-wG-o
https://alessandrofama.com/tutorials/wwise/unity/events
https://www.youtube.com/watch?v=HEvkBiz9JfQ&list=PL2YvvQu4Ub5uzib_IZJfTfhyQpIk0CXsA
https://www.audiokinetic.com/en/library/wwise_launcher/?source=InstallGuide&id=integrating_wwise_into_a_unity_project#:~:text=To%20integrate%20Wwise%20into%20a%20Unity%20project%3A&text=A%20list%20of%20all%20Unity,Project%20for%20the%20desired%20project.
