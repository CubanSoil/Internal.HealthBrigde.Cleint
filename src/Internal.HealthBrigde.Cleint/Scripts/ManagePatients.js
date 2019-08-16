
//Get all patients and populate a table
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: '/api/patients',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            $("#DIV").html('');
            var DIV = '';
            $.each(data, function (i, item) {
                var rows = "<tr>" +
                    "<td id='FirstName'>" + "<a href='/patients/edit/" + item.IdNumber + "'>" + item.FirstName+ "</a>" + "</td>" +
                    "<td id='FirstName'>" + "<a href='/patients/edit/" + item.IdNumber + "'>" + item.LastName + "</a>" + "</td>" +
                    "<td id='IdNumber'>" + item.IdNumber + "</td>" + "</tr>";
                $('#patients').append(rows);
            }); //End of foreach Loop
            console.log(data);
        }, //End of AJAX Success function

        failure: function (data) {
            alert(data.responseText);
        }, //End of AJAX failure function
        error: function (data) {
            alert(data.responseText);
        } //End of AJAX error function

    });
});
