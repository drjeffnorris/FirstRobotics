# First Robotics HoloLens Project
This is a starter Unity project for the NASA FIRST Robotics teams that are piloting the use of the HoloLens in the competition.  It is a simple TCP/IP server that runs on the HoloLens and accepts connections from applications on the driver's station.  Teams can modify and extend this project to do interesting things with the data that's received.  __Note that this project only works with a special build of the HoloLens operating system, so if you've stumbled across this project and you aren't on one of the aforementioned NASA teams, sorry - this won't work for you.__

# Setup
Communication from the driver station to the HoloLens via a USB cable depends on a service called IPoverUSB.  We configure this service to reroute connections made to port 1000 on the driver station to port 1000 on the HoloLens.  To set this up, you'll need to follow these steps on every computer that you want to be able to communicate with the HoloLens over USB:

1. Install Visual Studio 2015 Update 3 or later from this page: https://developer.microsoft.com/en-us/windows/holographic/install_the_tools.  This will install the IpOverUSB service.
2. Double-click on the Setup\ipoverusb-first.reg file in this project.  This will add a registry key that adds an IPOverUSB mapping from port 1000 on the local computer to port 1000 on the HoloLens.
3. Either reboot the computer, or open an elevated command prompt by pressing Win-X and selecting "Command Prompt (Admin)" and run the following commands:
~~~
sc stop IpOverUsbSvc
sc start IpOverUsbSvc
~~~

# Other notes

You wouldn’t think that a simple TCP/IP server would be a challenging thing to put together, but HoloLens apps are restricted to APIs that are both:

1.	Supported for Universal Windows Platform apps
2.	Available in the extremely out of date version of Mono that Unity uses

Plus, we don’t want to use any of Unity’s networking stuff because that is going to be hard to integrate with from other non-Unity applications (like the Driver Station).
