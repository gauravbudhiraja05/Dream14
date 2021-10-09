$(document).ready(function () {

    BindEventDetails();

    //setInterval(function () { BindEventDetails(); }, 300);
});


function BindEventDetails() {
    var gameId = getUrlParameter('gameId')
    $.ajax({
        type: "POST",
        url: "/SuperAdmin/GetEventDetail?gameId=" + gameId,
        success: function (eventList) {
            if (eventList != null) {
                BindT1Details(eventList.t1);
                BindT2Details(eventList.t2);
                BindT3Details(eventList.t3);
                BindT4Details(eventList.t4);
            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function BindT1Details(t1) {
    $('#Table_t1 tr').slice(1).remove();
    if (t1 != null && t1.length > 0) {
        var html1 = "<tr><th colspan='3' style='text-align:center'>MATCH_ODDS</th></tr><tr><td></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:lightblue'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:lightpink'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
        var html2 = "";
        for (var i = 0; i < t1.length; i++) {
            for (var j = 0; j < t1[i].length; j++)
                html2 = html2.concat("<tr><td><b>" + t1[i][j].nat + "</b></td><td><table style='width:100%;'><tr style='background-color:lightblue'><td>" + t1[i][j].b3 + "</td><td>" + t1[i][j].b2 + "</td><td>" + t1[i][j].b1 + "</td></tr></table></td><td><table style='width:100%;'><tr style='background-color:lightpink'><td>" + t1[i][j].l1 + "</td><td>" + t1[i][j].l2 + "</td><td>" + t1[i][j].l3 + "</td></tr></table></td></tr>");
        }
        var result = html1.concat(html2)
        $('#Table_t1').append(result);
    }
    else {
        var html = "<tr><th colspan='3' style='text-align:center'>MATCH_ODDS</th></tr><tr><td colspan='3' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t1').append(html);
    }
}

function BindT2Details(t2) {
    $('#Table_t2 tr').slice(1).remove();
    if (t2 != null && t2.length > 0) {
        var html1 = "<tr><th colspan='3' style='text-align:center'>Bookmaker market</th></tr><tr><td></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:lightblue'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:lightpink'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
        var html2 = "";
        var remark = "";
        for (var i = 0; i < t2.length; i++) {
            for (var j = 0; j < t2[i].bm1.length; j++) {
                html2 = html2.concat("<tr><td><b>" + t2[i].bm1[j].nat + "</b></td>");
                remark = t2[i].bm1[j].remark;
                if (t2[i].bm1[j].b1 == "0.00" && t2[i].bm1[j].l1) {
                    html2 = html2.concat("<td colspan='2' style='text-align:center;background-color:#36454f;color:white;'><h2>SUSPENDED</h2></td></tr>");
                }
                else {
                    html2 = html2.concat("<td><table style='width:100%;'><tr style=' background-color:lightblue'><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%'>" + t2[i].bm1[j].b1 + "</td></tr></table></td><td><table style='width:100%;'><tr style=' background-color:lightpink'><td style='width:33%'>" + t2[i].bm1[j].l1 + "</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>");
                }
            }
            html2 = html2.concat("<Tr><td colspan='3' style='text-align:right'>" + remark + "</td></tr>")
        }
        var result = html1.concat(html2)
        $('#Table_t2').append(result);
    }
    else {
        var html = "<tr><th colspan='3' style='text-align:center'>Bookmaker market</th></tr><tr><td colspan='3' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t2').append(html);
    }
}

function BindT3Details(t3) {
    $('#Table_t3 tr').slice(1).remove();
    if (t3 != null && t3.length > 0) {
        var html1 = "<tr><th colspan='4' style='text-align:center'>Session Market</th></tr><tr><td></td><td style='text-align:center; background-color:lightpink'>NO</td><td style='text-align:center; background-color:lightblue'>YES</td><td></td></tr>";
        var html2 = "";
        for (var i = 0; i < t3.length; i++) {
            html2 = html2.concat("<tr><td><b>" + t3[i].nat + "</b></td><td style=' background-color:lightpink'>" + t3[i].l1 + "</td><td style=' background-color:lightblue'>" + t3[i].b1 + "</td><td>Min: " + intToString(t3[i].min) + " Max: " + intToString(t3[i].max) + " </td></tr>");
        }
        var result = html1.concat(html2)
        $('#Table_t3').append(result);
    }
    else {
        var html = "<tr><th colspan='3' style='text-align:center'>Session Market</th></tr><tr><td colspan='4' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t3').append(html);
    }
}

function BindT4Details(t4) {
    $('#Table_t4 tr').slice(1).remove();
    if (t4 != null && t4.length > 0) {
        var html1 = "<tr><th colspan='4' style='text-align:center'>Fancy1 Market</th></tr><tr><td></td><td style='text-align:center; background-color:lightblue'>BACK</td><td style='text-align:center; background-color:lightpink'>LAY</td><td></td></tr>";
        var html2 = "";
        for (var i = 0; i < t4.length; i++) {
            html2 = html2.concat("<tr><td><b>" + t4[i].nat + "</b></td><td style=' background-color:lightblue'>" + t4[i].b1 + "</td><td style=' background-color:lightpink'>" + t4[i].l1 + "</td><td>Min : " + intToString(t4[i].min) + " Max : " + intToString(t4[i].max) + " </td></tr>");
        }
        var result = html1.concat(html2)
        $('#Table_t4').append(result);
    }
    else {
        var html = "<tr><th colspan='3' style='text-align:center'>Fancy1 Market</th></tr><tr><td colspan='4' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t4').append(html);
    }
}




function intToString(value) {
    var val = parseInt(value);

    if (val == 50000)
        return "50k";
    else if (val == 25000)
        return "25k";
    else if (val == 10000)
        return "25k";
    else return val;

}

var getUrlParameter = function getUrlParameter(sParam) {
    var sPageURL = window.location.search.substring(1),
        sURLVariables = sPageURL.split('&'),
        sParameterName,
        i;

    for (i = 0; i < sURLVariables.length; i++) {
        sParameterName = sURLVariables[i].split('=');

        if (sParameterName[0] === sParam) {
            return typeof sParameterName[1] === undefined ? true : decodeURIComponent(sParameterName[1]);
        }
    }
    return false;
};

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



