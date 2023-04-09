
    loadProjectStatus();


$(document).ready(function () {

    $('#vacancy-tab').click(function () {
        $('#vacancy-tab').removeClass('active');       // ADD CLASS TO ALL THE TAGS.
        $('#Jobseeker-tab').removeClass('active');
        if ($(this).hasClass('active')) {    // CHECK IF THE TAG HAS 'active' CLASS.

            $(this).removeClass('active');
        }
        else {
            $(this).addClass('active');
        }

    })

    $('#Jobseeker-tab').click(function () {
        $('#vacancy-tab').removeClass('active');       // ADD CLASS TO ALL THE TAGS.
        $('#Jobseeker-tab').removeClass('active');
        if ($(this).hasClass('active')) {    // CHECK IF THE TAG HAS 'active' CLASS.

            $(this).removeClass('active');
        }
        else {
            $(this).addClass('active');
        }

    })
});


var Projects = [];

//
function loadGridStatus() {
    $.ajax({
        type: 'POST',
        url: "Dashboard.aspx/loadGridviewStatusData",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            if (response.d.length > 0) {
                $("#divHeader").empty();
                $("#tbl1 tbody").empty();
                $("#tbl1 tfoot").empty();
                $('#divHeader').append('<table class="table table-sm mb-0" id="tblSeeker"  style="width:100%"><thead><tr><th style="width:25%">District</th><th style="width:25%">Job Seeker</th><th style="width:25%">Active</th><th style="width:25%">Recruited</th></tr></thead><tbody>');
                for (var i = 0; i < response.d.length; i++) {

                    $("#tbl1 tbody").append('<tr class="' + response.d[i].DistName + ' distview"><td style="width:32%">' + response.d[i].DistName + '</td> <td style="width:23%"><h6 class="text-warning mb-0">' + response.d[i].Vacancy + '</h6></td><td style="width:23%"><h6 class="text-primary mb-0">' + response.d[i].ActiveJob + '</h6></td><td style="width:24%"><h6 class="text-success mb-0">' + response.d[i].Recruited + '</h6></td> </tr>');

                }

                var result = [];
                $('#tbl1 tbody tr').each(function () {
                    $('td', this).each(function (index, val) {
                        if (!isNaN($(val).text())) {
                            if (!result[index])
                                result[index] = 0;
                            result[index] += parseInt($(val).text());
                        }
                    });
                });

                $('#tbl1').append('<tfoot><tr></tr></tfoot>');
                $(result).each(function () {
                    result[0] = 'Total';
                    $('#tbl1 tfoot tr').last().append('<td><h6 class="text-danger mb-0">' + this + '</h6></td>')

                });
                $('#tbl1 tfoot').find('tr:last td:first').html('<h6 class="text-success mb-0">TOTAL</h6>');
                
            }
        },
        failure: function (response) {
            alert(response.d);
        },
        error: function (response) {
            var msg = jQuery.parseJSON(response.responseText);
            console.log("Message: " + msg.Message);
            console.log("StackTrace: " + msg.StackTrace);
            console.log("ExceptionType: " + msg.ExceptionType);
        },
        dataType: 'json'
    });

}


$('#map-view .dist-block').click(function (e) {

    var distid = $(this).data('district');
    $('#tbl1 tr').removeClass('active');
    $('#tbl1 tr.' + distid.DistName).addClass('active');
    $('#divBody').stop().animate({
        scrollTop: $('#tbl1 tr.' + distid.DistName).position().top
    });
});

$('#map-view .dist-block').click(function (e) {

    var distid = $(this).data('district');
    $('#tbl1 tr').removeClass('active');
    $('#tbl1 tr.' + distid.DistName).addClass('active');
    $('#divBody').stop().animate({
        scrollTop: $('#tbl1 tr.' + distid.DistName).position().top
    });
});

$('.dist-block').mousemove(function (e) {

    var distid = $(this).data('district');
    $("#distheatName").html(distid.DistName);

    $('div#heat-pop-up').css({
        'left': e.offsetX - 600,
        'top': e.offsetY - 10
    });
    $('div#heat-pop-up').show();
});


$('.dist-block').mouseout(function (e) {
    var distid = $(this).data('district');
    $("#distheatName").html(distid.DistName);

    $('div#heat-pop-up').css({
        'left': e.offsetX - 600,
        'top': e.offsetY - 10
    });
    $('div#heat-pop-up').hide();
});


