$(document).ready(function () {
    GetEventList();

    //setInterval(function () { GetEventList1(); }, 3000);

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

function GetEventList1() {
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
    debugger;
    if (cricketList.length > 0) {
        $('#table_FE tr').remove();
        if (cricketList != null && cricketList.length > 0) {
            var html1 = "<tr><th>Game</th><th style='text-align:center'>1</th><th style='text-align:center'>X</th><th style='text-align:center'>2</th></tr>";
            var html2 = "";
            for (var i = 0; i < cricketList.length; i++) {
                html2 = html2.concat("<tr><td style='width:55%' class='left-text'><b><a style='color:#372f2c' href = '/FrontEnd/FrontEndEventDetail?gameId=" + cricketList[i].gameId + "'>" + cricketList[i].eventName + "</a></b></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>" + GetValue(cricketList[i].eventDetail.t1[0][0].b1) + "</td><td style='background-color: #FAA9BA'>" + GetValue(cricketList[i].eventDetail.t1[0][0].l1) + "</td></tr></table></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>-</td><td style='background-color: #FAA9BA'>-</td></tr></table></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>" + GetValue(cricketList[i].eventDetail.t1[0][1].b1) + "</td><td style='background-color: #FAA9BA'>" + GetValue(cricketList[i].eventDetail.t1[0][1].l1) + "</td></tr></table></td></tr>");
            }
            var result = html1.concat(html2);
            $('#table_FE').append(result);
        }
        else {
            var html = "<tr><th>Game/th><th style='text-align:center'>1</th><th style='text-align:center'>X</th><th style='text-align:center'>2</th></tr><tr><td colspan='4' style='text-align: center'>No Records Found</td></tr>";
            $('#table_FE').append(html);
        }
    }
}

function GetValue(value) {
    if (value != undefined && value == "0.00") {
        value = "-";
    }
    return value;
}