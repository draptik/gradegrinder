http://stackoverflow.com/questions/6864219/running-nunit-against-net-4-0-nhibernate-over-sqlite-cannot-load-sqlite-dll


I have this problem using fluent nhibernate and automappings with sqlite, in a .net framework 4 solution, i checked in the new system.data.sqlite site and it's a problem related with the resources inside the library, they already fixed but not it's not a release soon.

The link with the checkin: Checkin info in system.data.sqlite repository

I downloaded the source code i compiled myself, and it's working now with the automapper in fluent nhibernate, maybe can work for you meanwhile the people of system.data.sqlite relase a new version:

Compiled source code of 1.0.74.0 version with the fix


---------------------------------------------------------------------------
HERE IS THE LINK:

http://dl.dropbox.com/u/11743464/System.Data.SQLite%201.0.74.0.rar

HERE IS THE COMMIT (NO RELEASE YET):

http://system.data.sqlite.org/index.html/ci/55f56ce508

NOTE: THIS ONLY WORKS FOR X86! NOT FOR X64!!!!


