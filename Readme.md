# Pretty Good Bootstrap Base Theme Orchard Theme Readme



## Project Description

An Orchard base theme building on Twitter's Bootstrap framework.

We've also created a [complete sample theme](https://github.com/Lombiq/Pretty-Good-Bootstrap-Base-Theme-Sample) demonstrating what you can do with PGBBT.

PGBBT is the base for the themes of all Lombiq websites, including [Lombiq.com](http://lombiq.com/), [Orchard Dojo](http://orcharddojo.net/) and [DotNest.com](http://dotnest.com/).

The theme is also available for [DotNest](http://dotnest.com/) sites.


## Documentation

- [What's the Great Purpose?](Docs/Purpose.md)
- [Structure](Docs/Structure.md)
- [How to...](Docs/HowTo.md)

### Updating Bootstrap

1. At first, replace the old Bootstrap files with the latest ones. Here you can download the [latest version] (http://getbootstrap.com)
2. Check if there are any errors in the *.less files in the theme's folder, and in the base theme's folder too.
3. Typical error after upgrading is when a mixin gets "undeclared". Then you have to import the mixins file.
4. Recompile the *.less files of the theme (WEB ESSENTIALS/Re-compile All LESS Files).
5. After recompiling, check if there are any compile errors.
6. Compare the original look of the site with the look of the upgraded one.
7. If there is anything different (text size, color, margins, paddings, etc), fix them by modifying the *.less files.

PGBBT currently includes the Bootstrap 3.2. **The latest version is only compatible with Orchard 1.8!**

The module's source is available in two public source repositories, automatically mirrored in both directions with [Git-hg Mirror](https://githgmirror.com):

- [https://bitbucket.org/Lombiq/pretty-good-bootstrap-base-theme](https://bitbucket.org/Lombiq/pretty-good-bootstrap-base-theme) (Mercurial repository)
- [https://github.com/Lombiq/Pretty-Good-Bootstrap-Base-Theme](https://github.com/Lombiq/Pretty-Good-Bootstrap-Base-Theme) (Git repository)

Bug reports, feature requests and comments are warmly welcome, **please do so via GitHub**.
Feel free to send pull requests too, no matter which source repository you choose for this purpose.

This project is developed by [Lombiq Technologies Ltd](http://lombiq.com/). Commercial-grade support is available through Lombiq.