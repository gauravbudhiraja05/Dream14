$(document).ready(function () {
    GetEventList();

    //setInterval(function () { GetEventList(); }, 60000);

});



function GetEventList() {
    $.ajax({
        type: "POST",
        url: "/SuperAdmin/GetApiList",
        success: function (cricketList) {
            BindData(cricketList);
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function BindData(cricketList) {
    if (cricketList.length > 0) {
        $('#tblEvents tr').slice(1).remove();
        for (var i = 0; i < cricketList.length; i++) {
            $('#tblEvents tbody').after("<tr><td><a style='color:#372f2c' href = '/SuperAdmin/EventDetail?gameId=" + cricketList[i].gameId + "'>" + cricketList[i].eventName + "</a></td><td>" + cricketList[i].inPlay + "</td><td>" + cricketList[i].tv + "</td><td style='width:75px;text-align: center;'><a class='view_item' href = '/SuperAdmin/EventDetail?gameId=" + cricketList[i].gameId + "' ></a></tr>");
        }
    }
}

function ViewEventDetail(gameId) {
    window.Location.href = "/EventDetail?gameId=" + gameId;
}

var onBegin = function () {
    $(".loaderModal").show();
};


var onComplete = function () {
    //alert("onComplete");
};

var onSuccess = function (context) {
    $(".loaderModal").hide();
    swal(
        'The admin user status was successfully updated.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/SuperAdmin/AdminUsers";
    });
};

var onFailed = function (context) {
    //alert("Failed");
};



