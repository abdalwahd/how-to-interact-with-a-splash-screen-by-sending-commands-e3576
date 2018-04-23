# How to interact with a Splash Screen by sending commands


<p>In this example a custom Progress Bar Control is added to a Splash Screen. The example shows how to update this Progress Bar Control dynamically by sending commands from a Splash Screen Manager.</p><p>Splash Screens are displayed by a Splash Screen Manager in a separate thread. Interaction with Splash Screens can be performed via the command mechanism. You send a command via the SplashScreenManager.SendCommand method and process this command by overriding the SplashScreen.ProcessCommand method.</p><br />
<p>In the example, custom commands are sent to the Splash Screen to advance the progress of the Splash Screen's Progress Bar Control.</p><br />


<br/>


