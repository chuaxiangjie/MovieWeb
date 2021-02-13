function MovieLibrary(listId, action, iParams) {
    this.listId = listId;        // Reference to the div where data should be added
    this.action = action;
    this.params = iParams;      // Additional parameters to pass to the controller
    this.loading = false;       // true if asynchronous loading is in process

    debugger;

    var self = this;

    ShouldReset = function () {
        if (typeof iParams.resetIndex !== 'undefined' && iParams.resetIndex)
            return true;

        return false;
    }

    this.AppendMovieToList = function (itemIndex) {
        this.loading = true;
        // $("#footer").css("display", "block"); // show loading info

        let fullUrl = self.action;

        if (ShouldReset()) {
            fullUrl = fullUrl + '/?itemindex=' + 0;
        } else {
            fullUrl = fullUrl + '/?itemindex=' + itemIndex;
        }

        if (typeof iParams.searchTitle !== 'undefined' && iParams.searchTitle)
            fullUrl = fullUrl + '&title=' + iParams.searchTitle;

        $.ajax({
            type: 'GET',
            url: fullUrl,
            dataType: "html"
        })
            .done(function (result) {
                if (result) {

                    if (ShouldReset()) {
                        $("#" + self.listId).html('');
                        $("#" + self.listId).append(result);
                    } else {
                        $("#" + self.listId).append(result);
                    }

                    self.loading = false;
                }
            })
            .fail(function (thrownError) {
                console.log("Error in AppendMovieToList:", thrownError);
            })
            .always(function () {
                // $("#footer").css("display", "none"); // hide loading info
            });
    }

    window.onscroll = function (ev) {
        if ((window.innerHeight + window.scrollY) >= document.body.offsetHeight) {
            //User is currently at the bottom of the page
            if (!self.loading) {
                var itemIndex = $('#' + self.listId).children('.item-box').last().data("itemindex");

                console.log(itemIndex);

                self.AppendMovieToList(itemIndex);
            }
        }
    };

    this.AppendMovieToList(0);
}
