(function () {
    S('.reset-cache button').on('click', () => {
        S.ajax({
            url: '/ResetCache',
            success: () => {
                alert('Website cache reset & recompile complete');
            }
        });
    });
})();