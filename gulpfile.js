var gulp = require('gulp');

var release = 'bin/Release/netcoreapp3.1/';
var publish = 'bin/Publish/ResetCache/'

gulp.task('publish', function () {
    p = gulp.src(['resetcache.html', 'resetcache.js', release + 'Saber.Vendor.ResetCache.dll'])
        .pipe(gulp.dest(publish, { overwrite: true }));
    return p;
});