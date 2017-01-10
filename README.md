# First Robotics HoloLens Project
This is a starter Unity project for the NASA FIRST Robotics teams that are piloting the use of the HoloLens in the competition.  Currently it consists of just a basic TCP/IP server that can receive messages over a socket.  Note that this project only works with a special build of the HoloLens operating system, so if you've stumbled across this project and you aren't on one of the aforementioned NASA teams, sorry - this won't work for you.

You wouldn’t think that a simple TCP/IP server would be a challenging thing to put together, but HoloLens apps are restricted to APIs that are both:

1.	Supported for Universal Windows Platform apps
2.	Available in the extremely out of date version of Mono that Unity uses

Plus, we don’t want to use any of Unity’s networking stuff because that is going to be hard to integrate with from other non-Unity applications (like the Driver Station).
