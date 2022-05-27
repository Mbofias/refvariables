To use this you can create ScriptableObjects of the basic type of variables (int, float, char, string, bool).

You can use that to add a certain layer of abstraction and make scripts not depend on other gameobjects being on the scene to work properly.
An easy example would be using it on the player HP:

-We make the player HP a float reference (it allows you to either make it a normal float or a custom float variable, and switch between those on the inspector itself) </br>
-We make a float variable from the AssetMenu(that will hold the value of our player HP, so it should be referenced on the player HP) </br>
-Now every script that needs to check on the player HP to make something can have a reference to the player HP asset, and doesn't need to check wether the player is on scene or not, increasing the abstraction there is between multiple gameobjects, and makes doing changes and debuging certain things easier.

-This works pretty well with this custom events package: https://github.com/Mbofias/customevents .

PS. This is my own approach to an idea I found on a youtube video about unity game architecture and abstraction using Scriptable Objects.
