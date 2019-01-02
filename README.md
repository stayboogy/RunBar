# RunBar

This is a simple program/shell for launching various tools from a Windows environment, mainly WinPE.  

This is provided open-source because not much in this realm is, and that discourages development and improvement and cleaner more accurate results.  

If you use any or all of this in your project I ask that you send me an email of thanks with a link to your project, which should also be open-source, to idaboogerman@gmail.com, and give me some credit somewhere.

https://www.youtube.com/watch?v=wGn7AOD_lFI&feature=youtu.be


	1. In order for this to run properly or at all, you must have the WinPE-NetFx.cab and the corresponding lanugage package for your build dism added to your .wim


	2. In order for this to run as a proper WinPE shell, it mush be run from winpeshl.ini like so:

		[LaunchApp]
		AppPath = AbsoluteOrVariable\PathTo\RunBar\RunBar.exe

	This will keep the application running therefore providing a low resource shell, and this keeps a cmd window from being visible and the program from just opening and closing and then rebooting your WinPE session as it does when run from [LaunchApps].


	3. I provide only the skeleton program here, which is very minimal and only provided for others to use and build on for their needs, and which is different from my personal build shown in the youtube video.