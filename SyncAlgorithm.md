# Realtime Change Detection #
At this time, the real-time change detection simply triggers a stand-alone sync. Because SVN adds "journaling", the sync is much faster than a traditional full file scan. _Improvement: Process the specific file that changed instead of running the full sync._

# Stand-alone Sync #

  * **svn st** is called and the results are stored into a string.
_Improvement: Do not list all at once. Terminate the "svn st" thread once 20-100 files that need work are loaded, since we don't need to load the whole list at once._

  * The string is split into an array, and the original string removed from memory to save RAM.

  * For each entry in the array:
    * Get the flag f = A, !, M, D
    * Get the filename r
    * Is the status over 10s old? Then get the status (svn st file) again in case files are changing rapidly.
    * Process File(r, f)

PROCESS FILE FUNCTION (file, flag):
  * Case "?"
    * Item not under Ver Control: Add and commit file.
  * Case "A"
    * Scheduled for addition, but not uploaded, so upload now: commit file.
  * Case "M"
    * Modified. commit file.
  * Case "C"
    * Item is in conflict with updates received from repository. Currently, no automated handling for this. _Recommended: Copy the file to file\_conflict\_datestamp.ext and add+commit that file, and/or notify the user, and/or rename the old file and keep this as the current new one._
  * Case "I"
    * Item is being ignored by SVN, do nothing
  * Case "!"
    * Item is missing, so it was deleting by the user or some other program. So, delete it on SVN with svn delete file
  * Case "~"
    * Item is versioned as a directory, but has been replaced by a file, or vice versa. The second column tells the status of a file's or directory's properties. No support for this case at this time.
  * Case "L"
    * Item is locked. At this time, do nothing. Locks are resolved in other methods.
  * Case Else
    * Do nothing.