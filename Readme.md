# Updating Bootstrap



1. At first, replace the old Bootstrap files with the latest ones. Here you can download the [latest version] (http://getbootstrap.com)
2. Check if there are any errors in the *.less files in the theme's folder, and in the base theme's folder too.
3. Typical error after upgrading is when a mixin gets "undeclared". Then you have to import the mixins file.
4. Recompile the *.less files of the theme (WEB ESSENTIALS/Re-compile All LESS Files).
5. After recompiling, check if there are any compile errors.
6. Compare the original look of the site with the look of the upgraded one.
7. If there is anything different (text size, color, margins, paddings, etc), fix them by modifying the *.less files.