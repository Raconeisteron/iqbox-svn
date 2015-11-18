# Pre-Alpha 5 #
  * Individual file commits to make committing much more reliable in the event of a file system with constant change.
  * Added lots of logic to deal with SVN interruptions or corruptions.
  * Removal of some externally generated dependencies to improve speed and simplicity.
  * Launches SVN in a separate thread, allowing for better user interface.
  * Prompts user to add trailing slash during setup of server (common error)
  * Added statistics of how many items are left to process.
  * Added option to reset all SVN data in case .svn folder settings get very messed up.
  * Option to start with Windows.
  * Option to send custom SVN command.
  * Improved user interface with icons.
  * **fix** Removed the BOM character from logs.
  * Various other fixes and improvements.

# Pre-Alpha 4 #
  * Initial release.
  * SSL support
  * Delta file uploading
  * Setup wizard