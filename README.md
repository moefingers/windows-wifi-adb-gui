# Summary / Use
<div style="display:flex; justify-content: space-between;">
<div> A GUI nested in the windows task tray to control music on a device running ADB over WIFI.
This is a passion project begun prior to 2019 and I resumed work on it in April 2024.

As of late, <u>**it is required to pair a device prior**</u> to connection. See images. And don't forget to input the address again with NEW port from OTHER page on your Wireless Debugging application AFTER you pair.
</div>
<img src="https://raw.githubusercontent.com/moefingers/windows-wifi-adb-gui/shepherd/README-demo.gif">
</div>

<!-- inc image -->
<!-- ![Image](/README-pair1.png) -->
<div style="display:flex">
<img src="https://raw.githubusercontent.com/moefingers/windows-wifi-adb-gui/shepherd/README-pair1.png" width="49%">
<img src="https://raw.githubusercontent.com/moefingers/windows-wifi-adb-gui/shepherd/README-pair2.png" width="49%">
</div>


## Notes
Application may stall or wait during connection attempt. This is normal. I may change that in the future.

Android Debug Bridge version 1.0.41 | Version 35.0.1-11580240 | Associated [NOTICE.txt](https://github.com/moefingers/windows-wifi-adb-gui/notice.txt)

# Downloads
[Release 3.0.0.8](https://github.com/moefingers/windows-wifi-adb-gui/raw/shepherd/download/WIFI-ADB-GUI.exe)
<!-- the above line is a placeholder -->
## Incomplete tasks
- Discovered adb shell media_cmd as alternative to old command adb shell media dispatch which was deprecated to the point of being functionless. Sticking with shell input keyevents as this is hypothetically more direct but will investigate further in the future.
- Set volume command no longer works, although shell shows everything is fine. Get volume works fine though. Will investigate in future.


## Completed tasks
- added demo gif
- no longer shows error on successful connect but rather a friendly connected message
- version 3.0.0.8 minimizes secondary window when minimizing first
- added download and release to github
- redid get volume commands
- Added regexp for more consistent volume output in shell
- New adb shell no longer uses old media command format. Reworked adb to use shell input keyevents.
- added flexbox to readme images
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