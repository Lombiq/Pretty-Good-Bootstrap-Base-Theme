# Updating Bootstrap

1. At first, replace the old Bootstrap files with the latest ones. Here you can download the [latest version] (http://getbootstrap.com)
2. Check whether the actual theme has a base theme. You can find it in Theme.txt, at the theme's root folder.
3. Check if there are any errors in the *.less files in the theme's folder, and in the base theme's folder too.
4. Typical error after upgrading, is when a mixin gets "undeclared". Then you have to import the [mixins file] (...Bootstrap/less/mixins)
5. Recompile the *.less files of the base theme, then continue recompiling the theme's *.less files.
6. After recompiling, check if there is any compile errors.
7. Compare the original look of the site, with the look of the upgraded one. If there is anything different(text size, color, margins, paddings, etc), check whether it is the error of the data export/import process.
8. If there are any real errors, fix them by modifying the *.less files