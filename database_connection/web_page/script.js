$(function () {

    get_posts();

    function get_posts() {
        console.log("getting posts..");
        $.ajax({
            url: "http://localhost:55329/api/values",
            success: function (result) {
                console.log(result);
            }
        });

    }


})