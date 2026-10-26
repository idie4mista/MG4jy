Question:

Explain how the FloatAnimation script works to animate the fish food GameObjects up and down. 

Make sure to mention the Start() and Update() methods and _up and _timer variables. 

You can ignore the StopAnimation() method.

Answer:

First, the script first serializes 2 floats, the movespeed, and the switchspeed. movespeed is how fast it moves multiplied by Time.deltaTime, aka how long has it been since the frame, in seconds.

Then, bool _up is declared and set to true, then float _timer is declared and defaulted to 0.0

Then, When the player presses play, dictated by the Start() method, _timer is set to the value of _switchspeed. 


Now, every frame aka an Update() method, it checks if _up is true. If it is, then it will translate the object on the Y axis UPWARDS by the movespeed * time.deltaTime. If it isn't, then it translates downwards. In the same frame, _timer is reduced by Time.deltaTime, then set to the difference. once this number reaches or passes 0, the value of _timer is set to the original value once again, then the value of _up is flipped, meaning if it was true, it's now false, and vice versa. 


