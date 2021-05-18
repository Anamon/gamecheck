# gamecheck

The `gamecheck` repository is part of a planned database project on computer and video games.

## The parent project

This repository is part of an as yet unnamed computer and video game database project that I started about two decades ago, and that has gone through several revisions and restarts since. Compared to other video game database projects, it regards games more as works of fiction, rather than products or collectibles.

What that means in practice is that I focus less on collecting information about creators, technical specifications or release details (such as publishers, distribution information, or different versions) – generally, I'm not trying to replicate the inimitable work of the [MobyGames](https://www.mobygames.com/) or [OGDB](https://ogdb.eu/) communities. Instead, I describe and categorise games based on their narrative content, themes, connections to other games, and so on. I only gather some key release and technical data about the games in order to make it easier to find them.

Apart from the fact that I simply enjoy creating and maintaining databases, I also started the project because I felt that existing projects lack structured ways of capturing information about the narrative contents of the games they describe. I believe that this information can be extremely valuable in many different use cases, the most obvious ones being to look for games that share similar themes or scenarios, or finding games one has played years ago, based only on some sketchy memories of what they were about.

Other principles of the project are *depth before breadth*, in that I may have collected information on a relatively small number of games so far, but I focussed on completeness and detail; and *incompleteness before speculation*, in that I only add information that I have either determined myself from owning and playing the games, or from credible original sources. A lot of speculative and plain wrong information about games spreads through the web, originating on some site, then being plagiarised by some other site, and before you know it, a completely made-up piece of information seems more credible because of the number of seemingly independent places it's repeated in. I wrote a [blog post](https://dirgames.wordpress.com/2016/11/09/editorial-aldos-adventures-in-misinformation/) about this a while ago, in the context of a previous iteration of this project.

## This repository

In the end, I still need some way to identify the actual game files, or rather, I will need it for a few ideas I have on how the database could be used in the far-off future.

For that reason, I started collecting metadata about the games I documents some years ago. I fill the gaps whenever I revisit games I already documented, so now this metadata collection is growing along with the main database.

The structure, and the decision on what I do and don't add to the catalog, may seem a bit haphazard to the outside observer, and it may in fact well be. This isn't fleshed out, but I collect as much as I think I will need for the use cases I have in mind. Details can be worked out later.

### The format

Currently, I collect this data in the form of `.sfv` checksum files for IBM PC compatible titles, in an extended format created by [RapidCRC](http://rapidcrc.sourceforge.net/). This format includes not just the CRC32 checksums of the files, but also their size in Bytes and their timestamp.

Before you complain: this project is about file identification. CRC32 is sufficiently collision-free for the use cases it's intended for. Files are not declared a match unless their sizes, and usually names, are identical as well. The checksums are *only* intended to identify files from trustworthy sources.

## The license

I haven't formalised things yet, but the intention behind both the database project and this checksum collection (as far as it can even be considered copyrightable) is that it will always be openly accessible under a license that liberally permits reuse. I see the closed nature of most video game database projects as a big problem and risk (let alone a bit of a sham seeing as most databases are supported through voluntary user contributions).
