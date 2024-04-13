# Summary / Use
A GUI nested in the windows task tray to control music on a device running ADB over WIFI.\
This is a passion project begun prior to 2019 and I resumed work on it in April 2024.\
As of late, <u>**it is required to pair a device prior**</u> to connection. See images.
<!-- inc image -->
<!-- ![Image](/README-pair1.png) -->
<img src="https://raw.githubusercontent.com/moefingers/windows-wifi-adb-gui/shepherd/README-pair1.png" width="200">
<img src="https://raw.githubusercontent.com/moefingers/windows-wifi-adb-gui/shepherd/README-pair2.png" width="200">

## Notes
Application may stall or wait during connection attempt. This is normal. I may change that in the future.

Android Debug Bridge version 1.0.41 | Version 35.0.1-11580240 | Associated [NOTICE.txt](https://github.com/moefingers/windows-wifi-adb-gui/notice.txt)

# Downloads
[](https://github.com/moefingers/windows-wifi-adb-gui/release/WIFI%20ADB%20GUI)
<!-- the above line is a placeholder -->
## Incomplete tasks
- New adb shell no longer uses old media command format. Reworking to use adb shell input keyevents


## Completed tasks
- Ensure command windows are hidden during execution for smooth user experience.
- Stop using Shell in favor of Process.Start
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
- Customize error handling from adb shell
- Verify application opens on clicking of taskbar
- updated readme images