var res;

$(function () {

    get_posts();

    $("#post_btn").click(function () {
        if ($("#firstName").val() && $("#lastName").val() && $("#textData").val() && $("#email").val()) {
            new_post();
        } else {
            alert("Missing data fields..");
        }
    });

    function new_post() {

        new_post_obj = {

            First_Name: $("#firstName").val(),
            Last_Name: $("#lastName").val(),
            text: $("#textData").val(),
            email: $("#email").val()

        };

        var value = JSON.stringify(new_post_obj);

        $.ajax({

            url: "api/values",
            type: "POST", 
            data: { '': value },
            success: function () {
                location.reload();
            }

        });



    }


    function get_posts() {
        console.log("getting posts..");
        $.ajax({
            url: "./api/values",
            success: function (result) {
                res = result;

                for (var i = 0; i < res.length; i++) {
                    addPostToTable(result[i]);
                }  
            }
        });

    }

    function addPostToTable(post) {
        $('#users_table').append('<tr><td>' + post['First_Name'] + '</td><td>' + post['Last_Name'] + '</td><td>' + post['Text'] + '</td><td>' + post['Email'] + '</td></tr>');
    }

})