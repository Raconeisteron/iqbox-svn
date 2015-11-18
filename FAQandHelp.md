

### How do I contact you or leave feedback? ###
We'd love to hear what you think! Please add [a comment on our feedback page here](http://iqboxblog.wordpress.com/feedback/).

### How do I get started with IQBox? ###
Unzip the program and run IQBox.EXE. That's it. No install required. It will detect that it's the first run and give you the startup wizard. You can copy the program into your program files folder after that if you like.

### Does running IQBox make any system changes or install things in my registry? ###
Nope, unless you set it to run on Windows Startup. If you did add that, first remove that option in the File->Advanced menu. Aside from that, no files are written to your system folders (except your temp folders), no registry entries are made. In the future, we might store data in the special User\AppData\IQBox folder. But again, that's not any system-wide change.

### Can't seem to connect? ###
Ensure your SVN path ends in a slash in the setup wizard. Also, test it by using SVN if you like.

### Where can I find a free SVN server account to connect to? ###
There are a few places on the net:
http://www.sliksvn.com/
http://www.assembla.com/catalog/tag/free
http://unfuddle.com/
http://www.codespaces.com/

### Where can I find free SVN server software for Windows ###
There's lots of options. One we looked at was:
http://www.visualsvn.com/

### How can I install IQBox as a service? ###
You can use [FireDaemon](http://www.firedaemon.com/) or [NSSM](https://iain.cx/src/nssm/). Use the command line "start" (no quotes) to automatically start in the system tray with automatic synchronization on.
You can set it to run on Windows login start-up with the options in the File>Advanced Options menu. Future releases will let you install as a service more easily.

### How do I uninstall the program? ###
Just delete the program's folder. If you want to remove the subversion files, just delete all .svn folders in your IQBox folder. The folders are hidden. (.svn folders are the standard way SVN chooses to track changes.) Also, if you set it to run on Windows start up, turn that off.

### How do I get those cool green icons when my file is sync'd ###
Just install [TortoiseSVN](http://tortoisesvn.net/). It's free and it will add shell integration for any sync'd files.

### How precisely does IQBox sync with SVN? ###
When the scheduler runs, it...
(1) **adds** ("svn add") all non-version controlled files,
(2) **deletes** ("svn delete --keep-local") all files that are missing (ie that the user must have deleted),
(3) **commits** ("svn commit -m --force-log"). This uploads your files. You might think it is better to update first, but we don't want to give our user surprises with an unexpected or bad merge. We just want the most recent version on the server- Old versions are stored in SVN anyhow. This behavior will likely change, and improve.
(4) **updates** (svn update). This is where you'll get any remote updates or files. They'll pop right into the folder.

Future plans to improve this are:
  * Delete/add/commit the **specific** files in real-time rather than batch them all at once.
  * Deal with version conflicts automatically or in a better way.
  * Automatically detect SVN issues when interrupted and SVN cleanup.

### What happens technically if I run the startup wizard twice? ###
To be technical, it will then do another SVN export in the folder you chose with the server/user/password chosen in the Wizard.

### Can I set up IQBox to start automatically in the systray? ###
Yes. If you start IQBox with the command line "IQBox.exe start" it will start in your tray. So just want a windows shortcut which includes that command line and put it into your start menu's Startup folder.

### My sync stopped working! I don't get it! I need help! ###
You'll need to read up on subversion (SVN). You will likely just need to do a SVN cleanup in **each** folder and subfolder if the problem is bad. To do a basic cleanup, check the File->Advanced menu.
Hopefully in future versions, this won't be an issue.

### Can I use IQBox for SVN version control when programming? ###
First note: If you're interesting in using IQBox for programming, send us feedback on our [blog](http://iqboxblog.wordpress.com/) since we are strongly considering adding features for programming.
To answer your questions: Yes, you can use it for programming, but only for simple thing. It won't merge code, and it commits **before** updating. So, you'll risk overwriting if you are working on the same file as someone else! Also, for complex things like branching and conflicts you'll still need to know some SVN. **Don't** use automatic syncing while you are programming  (only when you're not working on it so your get updates right away). Just sync manually. This is for a few reasons. For one, your other coders will have partial files that they may try to run or merge. There's also no use of the message log at this time!

### Can I have multiple IQBoxes on one PC? ###
Yes, just copy the entire IQBox program into a different folder, and run IQBox.exe from there. If you think this would be a good feature, make a comment.