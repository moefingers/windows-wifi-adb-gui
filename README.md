# Before anything...

This project is deemed by me as incomplete as of April 2024. Previously, this program was hardcoded to use a particular address and port since it was only used by me. Now, I want anyone to be able to use it and I want to share this passion project with the world. As such, at the very least it should use a dynamic address/port that a user may specify. Currently, that is the goal as well as a few other tasks.


## Incomplete tasks
- 
- Stop using Shell in favor of Process.Start
- Ensure command windows are hidden during execution for smooth user experience.
- Verify application opens on clicking of taskbar
- Customize error handling from adb shell

## Completed tasks
- Added form for address and port input.
- Begun readme
- Rename ambiguous variables like File1, FileName1, FileStream1, BinaryWriter1, BytesToWrite1 etc. Embarassing, but I was a child that many years ago.
- Moved errorbox to sub
- Moved get volume command to sub
- Polished on form load logic and moved down logic for buttons
- Refactored GetConnectedDeviceVolume logic to GetConnectedDeviceVolume sub, called when raising, lowering, or setting volume manually
- added comments on pretty much everything
- renamed more variables
- Clean up the code.. Remove redundant code.
- With the previous point, make a sub to execute connection instead of duplicate code.
- Ensure address/port input is working. - New issue arose instead.
- Update to include latest version of ADB and associated required NOTICE.txt
- Updated execution to include pair prior to connect and prompt user

# Summary / Use
A GUI nested in the windows task tray to control music on a device running ADB over WIFI.\
This is a passion project begun prior to 2019 and I resumed work on it in April 2024.\
As of late, <u>**it is required to pair a device prior**</u> to connection. 
<!-- inc image -->
<!-- ![Image](/README-pair1.png) -->
<img src="https://github.com/moefingers/windows-wifi-adb-gui/README-pair1.png" width="200">
<img src="https://github.com/moefingers/windows-wifi-adb-gui/README-pair2.png" width="200">

## Notes
Application may stall or wait during connection attempt. This is normal. I may change that in the future.

Android Debug Bridge version 1.0.41 | Version 35.0.1-11580240 | Associated [NOTICE.txt](https://github.com/moefingers/windows-wifi-adb-gui/notice.txt)

# Downloads
[](https://github.com/moefingers/windows-wifi-adb-gui/release/WIFI%20ADB%20GUI)
<!-- the above line is a placeholder -->