------------------------------------------------------------------
2D Sky v.1.0
------------------------------------------------------------------

	This package contains sprites and scripts to help you quickly add 2D parallax sky into your scene.

	Features
		• Sunny sky sprites.
		• Scripts to control cloud flow.
		• Use Unity 2D features, doesn't other 2d frameworks.
		• Supports all player platforms.
		• Unity and Unity Pro compatible.

	Web Player Demo:
		http://ge-team.com/pages/unity-3d/2d-sky/

	Thank you for your support and enjoy your creations,

	Gold Experience Team
	Products: www.ge-team.com/pages
	Support: geteamdev@gmail.com



------------------------------------------------------------------
Using Demo Scene
------------------------------------------------------------------

	1. Open Demo in "2D Sky/scenes/Demo"
	2. In Hierarchy tab, there are objects name NearClound, MidCloud, FarCloud.
	3. Click on any of them you will see Cloud Flow component in Inspector tab.
		3.1 Enable Large Cloud loop
				Check if this game object has large cloud sprites under its hierarchy.
		3.2 Behavior
				- Switch Left Right, this forces clouds to move left/right.
				- Flow The Same Way, random left/right then force cloud move together.
		3.3 Min/Max Speed, Amount to random the clouds speed.
		3.4 Camera, an orthographic camera that will render the clonds.
	5. Click on object names Sunny_01_sky.
	6. Look for Sky BG component in Inspector tab, this component does strength Sunny_01_sky sprite to fit the screen.
	7. There is a parameter names Camera, you have to drag an orthographic camera in Hierarchy to this parameter. 
	8. You may try adjust parameters then copy and paste it into your own scene.