﻿
$(document).ready(function () {
    GetEventList();

    //setInterval(function () { GetEventList1(); }, 3000);

});

function GetEventList() {
    $.ajax({
        type: "POST",
        url: "/Event/GetEventsList",
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
        url: "/Event/GetEventsList",
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
    if (cricketList != null && cricketList.crickets != null) {
        $('#tblEvents tr').slice(1).remove();
        if (cricketList.crickets.length > 0) {

            var roleName = $('#hdnRoleName').val();

            if (roleName == "SuperAdmin") {
                var html1 = "<tr><th class='table_checkbox'><input type='checkbox' onclick='AllChecked()' id='checkallEvents' class='check_all'><span>Select All</span></th><th>Game</th><th style='text-align:center'>1</th><th style='text-align:center'>X</th><th style='text-align:center'>2</th></tr>";
                var html2 = "";
                for (var i = 0; i < cricketList.crickets.length; i++) {
                    html2 = html2.concat("<tr><Td style='width:10%' class='table_checkbox'><input onClick=EventChecked() type='checkbox' id='checkitem_" + cricketList.crickets[i].gameId + "' class='check_item'></td><td style='width:45%' class='left-text'><b><a style='color:#372f2c' href = '/Event/EventDetail?gameId=" + cricketList.crickets[i].gameId + "'>" + cricketList.crickets[i].eventName + "</a></b></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>" + GetValue(cricketList.crickets[i].eventDetail.t1[0][0].b1) + "</td><td style='background-color: #FAA9BA'>" + GetValue(cricketList.crickets[i].eventDetail.t1[0][0].l1) + "</td></tr></table></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>-</td><td style='background-color: #FAA9BA'>-</td></tr></table></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>" + GetValue(cricketList.crickets[i].eventDetail.t1[0][1].b1) + "</td><td style='background-color: #FAA9BA'>" + GetValue(cricketList.crickets[i].eventDetail.t1[0][1].l1) + "</td></tr></table></td></tr>");
                }
                var result = html1.concat(html2);
                $('#tblEvents').append(result);

                CheckEventList(cricketList.gameIds)
            }
            else {
                var html1 = "<tr><th>Game</th><th style='text-align:center'>1</th><th style='text-align:center'>X</th><th style='text-align:center'>2</th></tr>";
                var html2 = "";
                for (var i = 0; i < cricketList.crickets.length; i++) {
                    html2 = html2.concat("<tr><td style='width:55%' class='left-text'><b><a style='color:#372f2c' href = '/Event/EventDetail?gameId=" + cricketList.crickets[i].gameId + "'>" + cricketList.crickets[i].eventName + "</a></b></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>" + GetValue(cricketList.crickets[i].eventDetail.t1[0][0].b1) + "</td><td style='background-color: #FAA9BA'>" + GetValue(cricketList.crickets[i].eventDetail.t1[0][0].l1) + "</td></tr></table></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>-</td><td style='background-color: #FAA9BA'>-</td></tr></table></td><td style='width:15%'><table style='width:100%;'><tr><td style='background-color: #72BBEF'>" + GetValue(cricketList.crickets[i].eventDetail.t1[0][1].b1) + "</td><td style='background-color: #FAA9BA'>" + GetValue(cricketList.crickets[i].eventDetail.t1[0][1].l1) + "</td></tr></table></td></tr>");
                }
                var result = html1.concat(html2);
                $('#tblEvents').append(result);
            }

        }
        else {
            var html = "<tr><th>Game</th><th style='text-align:center'>1</th><th style='text-align:center'>X</th><th style='text-align:center'>2</th></tr><tr><td colspan='4' style='text-align: center'>No Records Found</td></tr>";
            $('#tblEvents').append(html);
        }
    }
}

function GetValue(value) {
    if (value != undefined && value == "0.00") {
        value = "-";
    }
    return value;
}

function CheckEventList(gameIds) {
    debugger;
    if (gameIds != null && gameIds.length > 0) {
        for (var i = 0; i < gameIds.length; i++) {
            $('#checkitem_' + gameIds[i]).prop('checked', true);
        }
    }
    else {
        SelectAllEvents();
    }

    SetAllCheckedCheckboxStatus();
}

function EventChecked() {

    SetAllCheckedCheckboxStatus();
    ChangeEventsStatus();
}

function AllChecked() {
    var checkBox = document.getElementById("checkallEvents");
    if (checkBox.checked == true) {
        SelectAllEvents();
    } else {
        DeSelectAllEvents();
    }
    SetAllCheckedCheckboxStatus();
    ChangeEventsStatus();
}


function SelectAllEvents() {
    SelectedCricketGameId = [];
    $('.check_item').each(function () {
        $(this).prop('checked', true);
    });
}

function DeSelectAllEvents() {
    SelectedCricketGameId = [];
    $('.check_item').each(function () {
        $(this).prop('checked', false);
    });
}

function SetAllCheckedCheckboxStatus() {
    if ($(".check_item:unchecked").length == 0) {
        $('#checkallEvents').prop('checked', true);
    }
    else {
        $('#checkallEvents').prop('checked', false);
    }
}

function ChangeEventsStatus() {
    debugger;
    var cricketList = [];
    var cricket = []
    $('.check_item').each(function () {
        cricket = { GameId: $(this).prop('id').substring($(this).prop('id').indexOf("_") + 1), M1: $(this).prop('checked') };
        cricketList.push(cricket);
    });


    $.ajax({
        type: "POST",
        url: "/Event/ChangeEventsStatus",
        data: { cricketList: cricketList },
        success: function () {

        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}



