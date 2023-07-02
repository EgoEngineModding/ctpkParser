# CTPK Parser

This is some code I wrote to parse the Dirt Rally 2.0 database in CTPK format (`base.ctpk`).

I have not touched any of this code for a very long time, and I have not tested it at all before uploading it to this repo. Things may be broken in weird and arbitrary ways or they may work perfectly.

This repo is currently not targeted towards end users, but towards develops who may possibly
learn something from my reverse engineering efforts.

## A note about IDs
The id's of ctpk objects are their names hashed used DJB2. I have managed to brute force a decent number of them but many are still unknown. The definitions, IDs, names and structures of these objects can be found in the .cs files residing in `ctpkLib/ObjectTypes`.
All these files have been autogenerated directly from the game's parsing code so they should be correct.

## Supported version
I have no idea if the database structure has changed at all in recent updates to the game.
This tool was developed with either version `1.1.126.9701` or `1.2.127.3511` of Dirt Rally 2.0.

## Docs
The docs folder contains some files I wrote up on the format and 010 Editor parsers (probably broken).
`ctpk_format.txt` is mostly correct. The largest issue is that at the time of writing it I had not
yet realized that the database used ProtoBuf to store data.

# Pull-Requests are welcome
If you want to improve/fix any of this code feel free to submit a Pull-Request.
I will try to help with any technical queries if I am able to.