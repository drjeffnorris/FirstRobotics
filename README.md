# FirstHoloLensSocketTest
This is a simple TCP/IP server for the HoloLens.  You wouldn’t think that this would be a challenging thing to put together, but HoloLens apps are restricted to APIs that are both:

1.	Supported for Universal Windows Platform apps
2.	Available in the extremely out of date version of Mono that Unity uses

Plus, we don’t want to use any of Unity’s networking stuff because that is going to be hard to integrate with from other non-Unity applications (like the Driver Station).
