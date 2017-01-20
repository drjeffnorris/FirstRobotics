# First Robotics HoloLens Project
This is a starter Unity project for the NASA FIRST Robotics teams that are piloting the use of the HoloLens in the competition.  It is a simple TCP/IP server that runs on the HoloLens and accepts connections from applications on the driver's station over a USB cable.  Teams should modify and extend this project to do interesting things with the data that's received.

This project only works with a special build of the HoloLens operating system, so if you've stumbled across this project and you aren't on one of the aforementioned NASA teams, sorry - this code won't work for you.  In addition, a special policy exception has been installed to the HoloLens devices that have been shipped to the NASA teams that is specific to _only this application_.  This is why teams need to download and modify this application instead of starting from scratch - a different application will not be covered by the same exception.

# Setup
Communication from the driver station to the HoloLens via a USB cable depends on a service called IPoverUSB.  We configure this service to reroute connections made to port 1000 on the driver station to port 1000 on the HoloLens.  To set this up, you'll need to follow these steps on every computer that you want to be able to communicate with the HoloLens over USB:

1. Install Visual Studio 2015 Update 3 or later from this page: https://developer.microsoft.com/en-us/windows/holographic/install_the_tools.  This will install the IpOverUSB service.  This is the same software you have to download for all HoloLens development.
2. Double-click on the ipoverusb-first.reg file in the Setup folder of this project.  This will add a registry key to the computer that configures an IPOverUSB mapping from port 1000 on the local computer to port 1000 on the HoloLens.
3. Either reboot the computer, or open an elevated command prompt by pressing Win-X and selecting "Command Prompt (Admin)" and run the following commands:
~~~
sc stop IpOverUsbSvc
sc start IpOverUsbSvc
~~~
4. You can confirm that IpOverUsbSvc is functioning by running the following commands in an elevated command prompt:
~~~
sc query IpOverUsbSvc
~~~

# Building and testing this application

Once you've performed the setup steps above you should be able to build this project from Unity following the same process described in the HoloLens developer documentation.  

