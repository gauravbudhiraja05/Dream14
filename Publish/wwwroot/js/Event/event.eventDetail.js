
$(document).ready(function () {

    BindEventDetails();

    //setInterval(function () { BindEventDetails1(); }, 1000);
});


function BindEventDetails() {
    var gameId = getUrlParameter('gameId')
    $.ajax({
        type: "POST",
        url: "/Event/GetEventDetail?gameId=" + gameId,
        success: function (eventList) {
            if (eventList != null) {
                BindT1Details(eventList.t1, eventList.t1PercentageDetail);
                BindT2Details(eventList.t2);
                BindT3Details(eventList.t3);
                BindT4Details(eventList.t4);
                BindHeaderDetails(eventList);
                GetModalDetails();
                //AddToggle();
                FilterEventDetailStatus(eventList.eventDetailStatus);
                BindMinMaxValue(eventList.minMaxList);
            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function BindEventDetails1() {
    var gameId = getUrlParameter('gameId')
    $.ajax({
        type: "POST",
        url: "/Event/GetEventDetail?gameId=" + gameId,
        success: function (eventList) {
            if (eventList != null) {
                BindT1Details(eventList.t1, eventList.t1PercentageDetail);
                BindT2Details(eventList.t2);
                BindT3Details(eventList.t3);
                BindT4Details(eventList.t4);
                BindHeaderDetails(eventList);
                GetModalDetails();
                //AddToggle();
                FilterEventDetailStatus(eventList.eventDetailStatus);
                BindMinMaxValue(eventList.minMaxList);
            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function BindT1Details(t1, t1PercentageDetail) {

    var old_b3 = parseFloat($('#b3').html());
    var old_b2 = parseFloat($('#b2').html());
    var old_b1 = parseFloat($('#b1').html());
    var old_l1 = parseFloat($('#l1').html());
    var old_l2 = parseFloat($('#l2').html());
    var old_l3 = parseFloat($('#l3').html());
    $('#Table_t1 tr').remove();
    if (t1 != null && t1.length > 0) {

        var roleName = $('#hdnRoleName').val();

        if (roleName == "SuperAdmin") {
            //<span style='margin-left: 870px;'>Maximum Bet 1</span>
            var html1 = "<tr class='table1_header' style='cursor:pointer'><th colspan='3'><input type='checkbox' id='checkT1' class='check_all' />&nbsp;&nbsp;MATCH_ODDS<i id='matchOdds_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td><table style='width:100%'><tr><td>Max : <span id='MatchOddsMaxValue'>0</span></td><td>Min : <span id='MatchOddsMinValue'>0</span></td><td><button type='button' class='edit_item' id='btnEditMaxMinMatchOdds'></button></td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:#72BBEF'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:#FAA9BA'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
            var html2 = "";
            for (var i = 0; i < t1.length; i++) {
                for (var j = 0; j < t1[i].length; j++)
                    html2 = html2.concat("<tr><td class='left-text' rowspan='2'><table style='width:100%'><tr><td style='width:80%' colspan='2'><b class='nat-text'>" + t1[i][j].nat + "</b></td><td></td></tr></table></td><td><table style='width:100%;'><tr><td id='b3' style='background-color:#72BBEF'>" + t1[i][j].b3 + "<br/><span class='lowertext'>" + t1[i][j].bs3 + "</span></td><td id='b2' style='background-color:#72BBEF'>" + t1[i][j].b2 + "<br/><span class='lowertext'>" + t1[i][j].bs2 + "<span></td><td id='b1' style='background-color:#72BBEF'>" + t1[i][j].b1 + "<br/><span class='lowertext'>" + t1[i][j].bs1 + "<span></td></tr></table></td><td><table style='width:100%;'><tr><td id='l1' style='background-color:#FAA9BA'>" + t1[i][j].l1 + "<br/><span class='lowertext'>" + t1[i][j].ls1 + "<span></td><td id='l2' style='background-color:#FAA9BA'>" + t1[i][j].l2 + "<br/><span class='lowertext'>" + t1[i][j].ls2 + "<span></td><td id='l3' style='background-color:#FAA9BA'>" + t1[i][j].l3 + "<br/><span class='lowertext'>" + t1[i][j].ls3 + "<span></td></tr></table></td></tr>");
            }
            var result = html1.concat(html2)
            $('#Table_t1').append(result);

            SetT1Left(t1PercentageDetail);
        }
        else {
            //<span style='margin-left: 610px;'>Maximum Bet 1</span>
            var html1 = "<tr class='table1_header' style='cursor:pointer'><th colspan='3'>MATCH_ODDS <i id='matchOdds_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:#72BBEF'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:#FAA9BA'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
            var html2 = "";
            for (var i = 0; i < t1.length; i++) {
                for (var j = 0; j < t1[i].length; j++)
                    html2 = html2.concat("<tr><td class='left-text'><b>" + t1[i][j].nat + "</b></td><td><table style='width:100%;'><tr><td id='b3' style='background-color:#72BBEF'>" + t1[i][j].b3 + "</td><td id='b2' style='background-color:#72BBEF'>" + t1[i][j].b2 + "</td><td id='b1' style='background-color:#72BBEF'>" + t1[i][j].b1 + "</td></tr></table></td><td><table style='width:100%;'><tr><td id='l1' style='background-color:#FAA9BA'>" + t1[i][j].l1 + "</td><td id='l2' style='background-color:#FAA9BA'>" + t1[i][j].l2 + "</td><td id='l3' style='background-color:#FAA9BA'>" + t1[i][j].l3 + "</td></tr></table></td></tr>");
            }
            var result = html1.concat(html2)
            $('#Table_t1').append(result);
        }

        $('#checkT1').click(function () {
            HeaderCheckedClick('T1');
        });

        GetMinMaxMatchOddsModal();

        var new_b3 = parseFloat($('#b3').html());
        var new_b2 = parseFloat($('#b2').html());
        var new_b1 = parseFloat($('#b1').html());
        var new_l1 = parseFloat($('#l1').html());
        var new_l2 = parseFloat($('#l2').html());
        var new_l3 = parseFloat($('#l3').html());

        if (old_b3 != NaN && old_b2 != NaN && old_b1 != NaN && old_l3 != NaN && old_l2 != NaN && old_l1 != NaN) {

            if (old_b3 > new_b3) {
                ChangeColor("b3", "blue", "red");
            }
            else if (old_b3 < new_b3) {
                ChangeColor("b3", "blue", "purple");
            }

            if (old_b2 > new_b2) {
                ChangeColor("b2", "blue", "red");
            }
            else if (old_b2 < new_b2) {
                ChangeColor("b2", "blue", "purple");
            }

            if (old_b1 > new_b1) {
                ChangeColor("b1", "blue", "red");
            }
            else if (old_b1 < new_b1) {
                ChangeColor("b1", "blue", "purple");
            }

            if (old_l1 > new_l1) {
                ChangeColor("l1", "blue", "red");
            }
            else if (old_l1 < new_l1) {
                ChangeColor("l1", "blue", "purple");
            }

            if (old_l2 > new_l2) {
                ChangeColor("l2", "blue", "red");
            }
            else if (old_l2 < new_l2) {
                ChangeColor("l2", "blue", "purple");
            }

            if (old_l3 > new_l3) {
                ChangeColor("l3", "blue", "red");
            }
            else if (old_l3 < new_l3) {
                ChangeColor("l3", "blue", "purple");
            }
        }
    }
    else {
        var html = "<tr class='table1_header' style='cursor:pointer'><th colspan='3'>MATCH_ODDS<i id='matchOdds_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td colspan='3' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t1').append(html);
    }
}

function SetT1Left(t1PercentageDetail) {
    var team1 = $($('#Table_t1 .left-text .nat-text')[0]).html();
    var team2 = $($('#Table_t1 .left-text .nat-text')[1]).html();
    $($('#Table_t1 .left-text')[0]).empty();
    $($('#Table_t1 .left-text')[1]).empty();
    $($($($('#Table_t1 .left-text')[1]).parent()).find('td')[0]).remove();
    var percentage = "";
    if (t1PercentageDetail == null) {
        percentage = "0";
    }
    else {
        percentage = t1PercentageDetail.percentage;
    }
    var html = "<table class='rowspan_t1'><tr><td style='width:80%'><b>" + team1 + "</b></td><td style='vertical-align:bottom' rowspan='2'><span class= 'right-text percentageT1'>" + percentage + " % &nbsp;&nbsp;<button type='button' class='edit_item1 percentageT1Edit'></button></span></td></tr><tr><td><b>" + team2 + "</b></td></tr><table>";
    $($('.left-text')[0]).append(html);

    GetT1PercentageModal(t1PercentageDetail);
}

function GetT1PercentageModal(t1PercentageDetail) {


    var t1PercentageModal = document.getElementById("t1PercentageModal");
    var popupOverLay = document.getElementById("popup_overlay");
    var btnSaveT1Percentage = document.getElementById("btnSaveT1Percentage");
    var btnRemoveT1Percentage = document.getElementById("btnRemoveT1Percentage");

    if (t1PercentageDetail != null) {
        $('#txtT1Percentage').val(t1PercentageDetail.percentage);
        $('#txtTeamA_L1').val(t1PercentageDetail.teamAL1Value);
        $('#txtTeamB_L1').val(t1PercentageDetail.teamBL1Value);
        $('#txtTeamA_B1').val(t1PercentageDetail.teamAB1Value);
        $('#txtTeamB_B1').val(t1PercentageDetail.teamBB1Value);
    }
    else {
        $('#txtT1Percentage').val("0");
        $('#txtTeamA_L1').val("0");
        $('#txtTeamB_L1').val("0");
        $('#txtTeamA_B1').val("0");
        $('#txtTeamB_B1').val("0");
    }

    $('.percentageT1Edit').click(function () {
        t1PercentageModal.style.display = "block";
        popupOverLay.style.display = 'block';
    });

    btnSaveT1Percentage.onclick = function () {

        var t1PercentageDetail = { Sid: 'T1', GameId: getUrlParameter('gameId'), EventDetailName: 'T1', Percentage: $('#txtT1Percentage').val(), TeamAL1Value: $('#txtTeamA_L1').val(), TeamBL1Value: $('#txtTeamB_L1').val(), TeamAB1Value: $('#txtTeamA_B1').val(), TeamBB1Value: $('#txtTeamB_B1').val() };
        $.ajax({
            type: "POST",
            url: "/Event/UpdateT1Percentage",
            data: { t1PercentageDetail: t1PercentageDetail},
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }

    btnRemoveT1Percentage.onclick = function () {

        var gameId = getUrlParameter('gameId');
        $.ajax({
            type: "POST",
            url: "/Event/RemoveT1Percentage",
            data: { gameId: gameId },
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }
}

function BindT2Details(t2) {
    $('#Table_t2 tr').remove();
    if (t2 != null && t2.length > 0) {

        var roleName = $('#hdnRoleName').val();

        if (roleName == "SuperAdmin") {
            var html1 = "<tr class='table2_header' style='cursor:pointer'><th colspan='3'><input type='checkbox' id = 'checkT2' class='check_all' > &nbsp;&nbsp; Bookmaker market <i id='bookmaker_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td><table style='width:100%'><tr><td>Max : <span id='BookmakerMarketMaxValue'>0</span></td><td>Min : <span id='BookmakerMarketMinValue'>0</span></td><td><button type='button' class='edit_item' id='btnEditMaxMinBookmakerMarket'></button></td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:#72BBEF'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:#FAA9BA'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
            var html2 = "";
            var remark = "";
            var maxValue = "";
            var minValue = "";
            for (var i = 0; i < t2.length; i++) {
                for (var j = 0; j < t2[i].bm1.length; j++) {
                    html2 = html2.concat("<tr><td class='left-text'><b>" + t2[i].bm1[j].nat + "</b></td>");
                    remark = t2[i].bm1[j].remark;
                    if (t2[i].bm1[j].b1 == "0.00" && t2[i].bm1[j].l1 == "0.00") {
                        html2 = html2.concat("<td colspan='2' style='text-align:center;background-color:#36454f;color:white;'><h2 style='color:red'>SUSPENDED</h2></td></tr>");
                    }
                    else {
                        html2 = html2.concat("<td><table style='width:100%;'><tr style=' background-color:#72BBEF'><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%'>" + t2[i].bm1[j].b1 + "<br/><span class='lowertext'>" + intToString(t2[i].bm1[j].bs1) + "</span></td></tr></table></td><td><table style='width:100%;'><tr style=' background-color:#FAA9BA'><td style='width:33%'>" + t2[i].bm1[j].l1 + "<br/><span class='lowertext'>" + intToString(t2[i].bm1[j].ls1) + "</span></td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>");
                    }

                    maxValue = t2[i].bm1[j].max;
                    minValue = t2[i].bm1[j].min;
                }
                html2 = html2.concat("<Tr><td colspan='3' style='text-align:right'>" + remark + "</td></tr>")
            }
            var result = html1.concat(html2);
            $('#Table_t2').append(result);

            $('#BookmakerMarketMaxValue').html(intToString(maxValue));
            $('#BookmakerMarketMinValue').html(intToString(minValue));

            $('#checkT2').click(function () {
                debugger;
                HeaderCheckedClick('T2');
            });

            GetMinMaxBookMakerMarketModal();
        }
        else {
            var html1 = "<tr class='table2_header' style='cursor:pointer'><th colspan='3'>Bookmaker market <i id='bookmaker_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:#72BBEF'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:#FAA9BA'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
            var html2 = "";
            var remark = "";
            for (var i = 0; i < t2.length; i++) {
                for (var j = 0; j < t2[i].bm1.length; j++) {
                    html2 = html2.concat("<tr><td class='left-text'><b>" + t2[i].bm1[j].nat + "</b></td>");
                    remark = t2[i].bm1[j].remark;
                    if (t2[i].bm1[j].b1 == "0.00" && t2[i].bm1[j].l1) {
                        html2 = html2.concat("<td colspan='2' style='text-align:center;background-color:#36454f;color:white;'><h2 style='color:red'>SUSPENDED</h2></td></tr>");
                    }
                    else {
                        html2 = html2.concat("<td><table style='width:100%;'><tr style=' background-color:#72BBEF'><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%'>" + t2[i].bm1[j].b1 + "</td></tr></table></td><td><table style='width:100%;'><tr style=' background-color:#FAA9BA'><td style='width:33%'>" + t2[i].bm1[j].l1 + "</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>");
                    }
                }
                html2 = html2.concat("<Tr><td colspan='3' style='text-align:right'>" + remark + "</td></tr>")
            }
            var result = html1.concat(html2)
            $('#Table_t2').append(result);
        }

    }
    else {
        var html = "<tr class='table2_header' style='cursor:pointer'><th colspan='3'>Bookmaker market <i id='bookmaker_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td colspan='3' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t2').append(html);
    }
}

function BindT3Details(t3) {
    $('#Table_t3 tr').remove();
    if (t3 != null && t3.length > 0) {

        var roleName = $('#hdnRoleName').val();

        if (roleName == "SuperAdmin") {
            var html1 = "<tr class='table3_header' style='cursor:pointer'><th colspan='5'><input type='checkbox' id='checkT3' class='check_all' >&nbsp;&nbsp; Session Market <i id='sessionMarket_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td style='text-align:center; background-color:#FAA9BA'>NO</td><td style='text-align:center; background-color:#72BBEF'>YES</td><td></td></tr>";
            var html2 = "";
            for (var i = 0; i < t3.length; i++) {
                html2 = html2.concat("<tr><td class='left-text'><input type='checkbox' id=check_" + t3[i].sid + " class='check_all check_T3' >&nbsp;&nbsp;<b>" + t3[i].nat + "</b></td><td style=' background-color:#FAA9BA'>" + t3[i].l1 + "<span class='lowertext'>" + intToString(t3[i].ls1) + "</span></td><td style=' background-color:#72BBEF'>" + t3[i].b1 + "<span class='lowertext'>" + intToString(t3[i].bs1) + "</span></td><td><table style='width:100%'><tr><td>Max : <span id='SessionMarketMax_" + t3[i].sid + "'>" + intToString(t3[i].max) + "</span></td><td>Min : <span id='SessionMarketMin_" + t3[i].sid + "'>" + intToString(t3[i].min) + "</span></td><td><button type='button' id='Sessionbtn_" + t3[i].sid + "' class='edit_item sessionMinMaxEdit'></button></td></tr></table></td></tr>");
            }
            var result = html1.concat(html2)
            $('#Table_t3').append(result);

            $('#checkT3').click(function () {
                HeaderCheckedClick('T3');
            });

            $('.check_T3').click(function () { UpdateT3Status() });

            GetMinMaxSessionMarketModal();
        }
        else {
            var html1 = "<tr class='table3_header' style='cursor:pointer'><th colspan='4'>Session Market <i id='sessionMarket_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td style='text-align:center; background-color:#FAA9BA'>NO</td><td style='text-align:center; background-color:#72BBEF'>YES</td><td></td></tr>";
            var html2 = "";
            for (var i = 0; i < t3.length; i++) {
                html2 = html2.concat("<tr><td class='left-text'><b>" + t3[i].nat + "</b></td><td style=' background-color:#FAA9BA'>" + t3[i].l1 + "</td><td style=' background-color:#72BBEF'>" + t3[i].b1 + "</td><td>Min: " + intToString(t3[i].min) + " Max: " + intToString(t3[i].max) + " </td></tr>");
            }
            var result = html1.concat(html2)
            $('#Table_t3').append(result);
        }


    }
    else {
        var html = "<tr class='table3_header' style='cursor:pointer'><th colspan='3'>Session Market <i id='sessionMarket_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td colspan='4' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t3').append(html);
    }
}

function BindT4Details(t4) {
    $('#Table_t4 tr').remove();
    if (t4 != null && t4.length > 0) {
        var roleName = $('#hdnRoleName').val();

        if (roleName == "SuperAdmin") {
            var html1 = "<tr class='table4_header' style='cursor:pointer'><th colspan='4'><input type='checkbox' id ='checkT4' class='check_all' > &nbsp;&nbsp; Fancy1 Market <i id='Fancy1Market_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td style='text-align:center; background-color:#72BBEF'>BACK</td><td style='text-align:center; background-color:#FAA9BA'>LAY</td><td></td></tr>";
            var html2 = "";
            for (var i = 0; i < t4.length; i++) {
                html2 = html2.concat("<tr><td class='left-text'><input type='checkbox' id=check_" + t4[i].sid + " class='check_all check_T4' > &nbsp;&nbsp;<b>" + t4[i].nat + "</b></td><td style=' background-color:#72BBEF'>" + t4[i].b1 + "<span class='lowertext'>" + intToString(t4[i].bs1) + "</span></td><td style=' background-color:#FAA9BA'>" + t4[i].l1 + "<span class='lowertext'>" + intToString(t4[i].ls1) + "</span></td><td><table style='width:100%'><tr><td>Max : <span id='Fancy1MarketMax_" + t4[i].sid + "'>" + intToString(t4[i].max) + "</span></td><td>Min : <span id='Fancy1MarketMin_" + t4[i].sid + "'>" + intToString(t4[i].min) + "</span></td><td><button type='button' id='Fancy1btn_" + t4[i].sid + "' class='edit_item fancy1MinMaxEdit'></button></td></tr></table> </td></tr>");
            }
            var result = html1.concat(html2)
            $('#Table_t4').append(result);

            $('#checkT4').click(function () {
                HeaderCheckedClick('T4');
            });

            $('.check_T4').click(function () { UpdateT4Status() });

            GetMinMaxFancy1MarketModal();
        }
        else {
            var html1 = "<tr class='table4_header' style='cursor:pointer'><th colspan='4'>Fancy1 Market <i id='Fancy1Market_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td style='text-align:center; background-color:#72BBEF'>BACK</td><td style='text-align:center; background-color:#FAA9BA'>LAY</td><td></td></tr>";
            var html2 = "";
            for (var i = 0; i < t4.length; i++) {
                html2 = html2.concat("<tr><td class='left-text'><b>" + t4[i].nat + "</b></td><td style=' background-color:#72BBEF'>" + t4[i].b1 + "</td><td style=' background-color:#FAA9BA'>" + t4[i].l1 + "</td><td>Min : " + intToString(t4[i].min) + " Max : " + intToString(t4[i].max) + " </td></tr>");
            }
            var result = html1.concat(html2)
            $('#Table_t4').append(result);
        }

    }
    else {
        var html = "<tr class='table4_header' style='cursor:pointer'><th colspan='3'>Fancy1 Market <i id='Fancy1Market_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td colspan='4' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t4').append(html);
    }
}

function BindHeaderDetails(eventList) {
    $('#th1_header').html(eventList.eventName);
    $('#th2_header').html(eventList.eventDate);
    $('#th3_header').html(eventList.eventTime);
}

function GetModalDetails() {

    // Get the modal
    var matchOddsModal = document.getElementById("matchOddsModal");
    var bookMakerModal = document.getElementById("bookMakerModal");
    var sessionMarketModal = document.getElementById("sessionMarketModal");
    var fancy1MarketModal = document.getElementById("fancy1MarketModal");

    // Get the button that opens the modal
    var matchOddsBtn = document.getElementById("matchOdds_Modal");
    var bookmakerBtn = document.getElementById("bookmaker_Modal");
    var sessionMarketBtn = document.getElementById("sessionMarket_Modal");
    var fancy1MarketBtn = document.getElementById("Fancy1Market_Modal");

    // Get the <span> element that closes the modal
    var matchOddsCloseSpan = document.getElementsByClassName("matchOddsClose")[0];
    var bookmakerCloseSpan = document.getElementsByClassName("bookmakerClose")[0];
    var sessionMarketCloseSpan = document.getElementsByClassName("sessionMarketClose")[0];
    var fancy1MarketCloseSpan = document.getElementsByClassName("fancy1MarketClose")[0];

    // When the user clicks the button, open the modal
    matchOddsBtn.onclick = function () {
        matchOddsModal.style.display = "block";
    }
    bookmakerBtn.onclick = function () {
        bookMakerModal.style.display = "block";
    }
    sessionMarketBtn.onclick = function () {
        sessionMarketModal.style.display = "block";
    }
    fancy1MarketBtn.onclick = function () {
        fancy1MarketModal.style.display = "block";
    }


    // When the user clicks on <span> (x), close the modal
    matchOddsCloseSpan.onclick = function () {
        matchOddsModal.style.display = "none";
    }
    bookmakerCloseSpan.onclick = function () {
        bookMakerModal.style.display = "none";
    }
    sessionMarketCloseSpan.onclick = function () {
        sessionMarketModal.style.display = "none";
    }
    fancy1MarketCloseSpan.onclick = function () {
        fancy1MarketModal.style.display = "none";
    }
}

function AddToggle() {

    $('.table1_header').click(function () {
        $(this).nextUntil('tr.table1_header').slideToggle(100);
    });

    $('.table2_header').click(function () {
        $(this).nextUntil('tr.table2_header').slideToggle(100);
    });

    $('.table3_header').click(function () {
        $(this).nextUntil('tr.table3_header').slideToggle(100);
    });

    $('.table4_header').click(function () {
        $(this).nextUntil('tr.table4_header').slideToggle(100);
    });

}

function intToString(value) {
    var val = parseInt(value);

    var num = val.toString().replace(/[^0-9.]/g, '');
    if (num < 1000) {
        return num;
    }
    let si = [
        { v: 1E3, s: "K" },
        { v: 1E6, s: "M" },
        { v: 1E9, s: "B" },
        { v: 1E12, s: "T" },
        { v: 1E15, s: "P" },
        { v: 1E18, s: "E" }
    ];
    let index;
    for (index = si.length - 1; index > 0; index--) {
        if (num >= si[index].v) {
            break;
        }
    }
    return (num / si[index].v).toFixed(2).replace(/\.0+$|(\.[0-9]*[1-9])0+$/, "$1") + si[index].s;
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

function ChangeColor(itemId, type, color) {
    $('#' + itemId).css("background-color", color);
    RestoreOriginalColor(itemId, type);
}

function RestoreOriginalColor(itemId, type) {
    if (type == "blue")
        setTimeout(function () { SetOriginalColor(itemId, "#72BBEF") }, 600);
    else if (type == "pink")
        setTimeout(function () { SetOriginalColor(itemId, "#FAA9BA") }, 600);
}

function SetOriginalColor(itemId, colorCode) {
    $('#' + itemId).css("background-color", colorCode);
}


function FilterEventDetailStatus(eventDetailStatus) {
    if (eventDetailStatus != null) {
        if (eventDetailStatus.detailStatusList != null && eventDetailStatus.detailStatusList.length > 0) {
            BindDetailStatusList(eventDetailStatus.detailStatusList);
        }
    }
    else {
        BindAllChecboxes();
    }
}

function BindMinMaxValue(minMaxList) {

    for (var i = 0; i < minMaxList.length; i++) {
        if (minMaxList[i].eventDetailName == "T1") {
            $('#MatchOddsMaxValue').html(intToString(minMaxList[i].maxValue));
            $('#MatchOddsMinValue').html(intToString(minMaxList[i].minValue));
        }
        else if (minMaxList[i].eventDetailName == "T2") {
            $('#BookmakerMarketMaxValue').html(intToString(minMaxList[i].maxValue));
            $('#BookmakerMarketMinValue').html(intToString(minMaxList[i].minValue));
        }
        else if (minMaxList[i].eventDetailName == "T3") {
            $('#SessionMarketMax_' + minMaxList[i].sid).html(intToString(minMaxList[i].maxValue));
            $('#SessionMarketMin_' + minMaxList[i].sid).html(intToString(minMaxList[i].minValue));
        }
        else if (minMaxList[i].eventDetailName == "T4") {
            $('#Fancy1MarketMax_' + minMaxList[i].sid).html(intToString(minMaxList[i].maxValue));
            $('#Fancy1MarketMin_' + minMaxList[i].sid).html(intToString(minMaxList[i].minValue));
        }
    }
}

function BindDetailStatusList(detailStatusList) {
    for (var i = 0; i < detailStatusList.length; i++) {

        if (detailStatusList[i].eventDetailName == 'T1') {
            $('#checkT1').prop('checked', detailStatusList[i].isActive);
        }
        else if (detailStatusList[i].eventDetailName == 'T2') {
            $('#checkT2').prop('checked', detailStatusList[i].isActive);
        }
        else if (detailStatusList[i].eventDetailName == 'T3') {
            $('#checkT3').prop('checked', detailStatusList[i].isActive);
        }
        else if (detailStatusList[i].eventDetailName == 'T4') {
            $('#checkT4').prop('checked', detailStatusList[i].isActive);
        }
    }

    BindT3CheckBoxes();
    BindT4CheckBoxes();
}

function BindAllChecboxes() {
    $('#checkT1').prop('checked', true);
    $('#checkT2').prop('checked', true);
    $('#checkT3').prop('checked', true);
    $('#checkT4').prop('checked', true);
}

function HeaderCheckedClick(eventDetailName) {
    var gameId = getUrlParameter('gameId');
    var isSelected = $('#check' + eventDetailName).prop('checked');
    $.ajax({
        type: "POST",
        url: "/Event/ChangeEventDetailStatus",
        data: { eventDetailName: eventDetailName, gameId: gameId, isSelected: isSelected },
        success: function () {
            if (eventDetailName == "T3") {
                CheckT3Status(eventDetailName);
            }
            else {
                CheckT4Status(eventDetailName);
            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function BindT3CheckBoxes() {
    var gameId = getUrlParameter('gameId');
    $.ajax({
        type: "POST",
        url: "/Event/GetT3CheckBoxDetails",
        data: { gameId: gameId },
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                if (data[i].mid == "True")
                    $('#check_' + data[i].sid).prop('checked', true);
                else
                    $('#check_' + data[i].sid).prop('checked', false);
            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function BindT4CheckBoxes() {
    var gameId = getUrlParameter('gameId');
    $.ajax({
        type: "POST",
        url: "/Event/GetT4CheckBoxDetails",
        data: { gameId: gameId },
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                if (data[i].mid == "True")
                    $('#check_' + data[i].sid).prop('checked', true);
                else
                    $('#check_' + data[i].sid).prop('checked', false);
            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function CheckT3Status(eventDetailName) {

    var isSelected = $('#check' + eventDetailName).prop('checked');
    if (isSelected) {
        ChangeT3CheckBoxStatus(true);
    }
    else {
        ChangeT3CheckBoxStatus(false);
    }
}

function CheckT4Status(eventDetailName) {
    var isSelected = $('#check' + eventDetailName).prop('checked');
    if (isSelected) {
        ChangeT4CheckBoxStatus(true);
    }
    else {
        ChangeT4CheckBoxStatus(false);
    }
}

function ChangeT3CheckBoxStatus(status) {

    $('.check_T3').each(function () {
        $(this).prop('checked', status);
    });

    UpdateT3Status();

}

function ChangeT4CheckBoxStatus(status) {
    $('.check_T4').each(function () {
        $(this).prop('checked', status);
    });

    UpdateT4Status();
}

function UpdateT3Status() {
    var t3List = [];
    var gameId = getUrlParameter('gameId');
    $('.check_T3').each(function () {
        var t3 = { mid: gameId, sid: $(this).prop('id').substring($(this).prop('id').indexOf("_") + 1), nat: $(this).prop('checked') };
        t3List.push(t3);
    });

    $.ajax({
        type: "POST",
        url: "/Event/UpdateT3Status",
        data: { t3List: t3List },
        success: function () {
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });

    SetT3HeaderCheckboxStatus();
}

function UpdateT4Status() {
    var t4List = [];
    var gameId = getUrlParameter('gameId');
    $('.check_T4').each(function () {
        var t4 = { mid: gameId, sid: $(this).prop('id').substring($(this).prop('id').indexOf("_") + 1), nat: $(this).prop('checked') };
        t4List.push(t4);
    });

    $.ajax({
        type: "POST",
        url: "/Event/UpdateT4Status",
        data: { t4List: t4List },
        success: function () {
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });

    SetT4HeaderCheckboxStatus();
}

function SetT3HeaderCheckboxStatus() {
    if ($(".check_T3:unchecked").length == 0) {
        $('#checkT3').prop('checked', true);
    }
    else {
        $('#checkT3').prop('checked', false);
    }
}

function SetT4HeaderCheckboxStatus() {
    if ($(".check_T4:unchecked").length == 0) {
        $('#checkT4').prop('checked', true);
    }
    else {
        $('#checkT4').prop('checked', false);
    }
}

function GetMinMaxMatchOddsModal() {

    // Get the modal
    var matchOddsMinMaxModal = document.getElementById("matchOddsMinMaxModal");
    var popupOverLay = document.getElementById("popup_overlay");
    var btnSaveMatchOddsMinMax = document.getElementById("btnSaveMatchOddsMinMax");

    // Get the button that opens the modal
    var btnEditMaxMinMatchOdds = document.getElementById("btnEditMaxMinMatchOdds");

    // When the user clicks the button, open the modal
    btnEditMaxMinMatchOdds.onclick = function () {
        matchOddsMinMaxModal.style.display = "block";
        popupOverLay.style.display = 'block';

        $('#txtMatchOddsMax').val($('#MatchOddsMaxValue').html());
        $('#txtMatchOddsMin').val($('#MatchOddsMinValue').html());
    }


    btnSaveMatchOddsMinMax.onclick = function () {

        var maxValue = $('#txtMatchOddsMax').val();
        var minValue = $('#txtMatchOddsMin').val();
        var gameId = getUrlParameter('gameId');
        $.ajax({
            type: "POST",
            url: "/Event/UpdateMatchOddsMinMax",
            data: { maxValue: maxValue, minValue: minValue, gameId: gameId },
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }
}

function GetMinMaxBookMakerMarketModal() {

    // Get the modal
    var bookmakerMarketMinMaxModal = document.getElementById("bookmakerMarketMinMaxModal");
    var popupOverLay = document.getElementById("popup_overlay");
    var btnSaveBookmakerMarketMinMax = document.getElementById("btnSaveBookmakerMarketMinMax");
    var btnRemoveBookmakerMarketMinMax = document.getElementById("btnRemoveBookmakerMarketMinMax");

    // Get the button that opens the modal
    var btnEditMaxMinBookmakerMarket = document.getElementById("btnEditMaxMinBookmakerMarket");

    // When the user clicks the button, open the modal
    btnEditMaxMinBookmakerMarket.onclick = function () {
        bookmakerMarketMinMaxModal.style.display = "block";
        popupOverLay.style.display = 'block';

        $('#txtBookmakerMarketMax').val(stringToInt($('#BookmakerMarketMaxValue').html()));
        $('#txtBookmakerMarketMin').val(stringToInt($('#BookmakerMarketMinValue').html()));
    }


    btnSaveBookmakerMarketMinMax.onclick = function () {

        var maxValue = $('#txtBookmakerMarketMax').val();
        var minValue = $('#txtBookmakerMarketMin').val();
        var gameId = getUrlParameter('gameId');
        $.ajax({
            type: "POST",
            url: "/Event/UpdateBookmakerMarketMinMax",
            data: { maxValue: maxValue, minValue: minValue, gameId: gameId },
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }

    btnRemoveBookmakerMarketMinMax.onclick = function () {

        var gameId = getUrlParameter('gameId');
        $.ajax({
            type: "POST",
            url: "/Event/RemoveBookmakerMarketMinMax",
            data: { gameId: gameId },
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }
}

function GetMinMaxSessionMarketModal() {

    // Get the modal
    var sessionMarketMinMaxModal = document.getElementById("sessionMarketMinMaxModal");
    var popupOverLay = document.getElementById("popup_overlay");
    var btnSaveSessionMarketMinMax = document.getElementById("btnSaveSessionMarketMinMax");
    var btnRemoveSessionMarketMinMax = document.getElementById("btnRemoveSessionMarketMinMax");

    var sid = "";
    $('.sessionMinMaxEdit').click(function () {
        sid = $(this).attr('Id').substring($(this).attr('Id').indexOf("_") + 1);
        sessionMarketMinMaxModal.style.display = "block";
        popupOverLay.style.display = 'block';

        $('#txtSessionMarketMax').val(stringToInt($('#SessionMarketMax_' + sid).html()));
        $('#txtSessionMarketMin').val(stringToInt($('#SessionMarketMin_' + sid).html()));
    });

    btnSaveSessionMarketMinMax.onclick = function () {

        var maxValue = $('#txtSessionMarketMax').val();
        var minValue = $('#txtSessionMarketMin').val();
        var gameId = getUrlParameter('gameId');
        $.ajax({
            type: "POST",
            url: "/Event/UpdateSessionMarketMinMax",
            data: { maxValue: maxValue, minValue: minValue, gameId: gameId, sid: sid },
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }

    btnRemoveSessionMarketMinMax.onclick = function () {



        var gameId = getUrlParameter('gameId');
        $.ajax({
            type: "POST",
            url: "/Event/RemoveSessionMarketMinMax",
            data: { gameId: gameId, sid: sid },
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }
}

function GetMinMaxFancy1MarketModal() {

    // Get the modal
    var fancy1MarketMinMaxModal = document.getElementById("fancy1MarketMinMaxModal");
    var popupOverLay = document.getElementById("popup_overlay");
    var btnSaveFancy1MarketMinMax = document.getElementById("btnSaveFancy1MarketMinMax");
    var btnRemoveFancy1MarketMinMax = document.getElementById("btnRemoveFancy1MarketMinMax");

    var sid = "";
    $('.fancy1MinMaxEdit').click(function () {
        sid = $(this).attr('Id').substring($(this).attr('Id').indexOf("_") + 1);
        fancy1MarketMinMaxModal.style.display = "block";
        popupOverLay.style.display = 'block';

        $('#txtFancy1MarketMax').val(stringToInt($('#Fancy1MarketMax_' + sid).html()));
        $('#txtFancy1MarketMin').val(stringToInt($('#Fancy1MarketMin_' + sid).html()));
    });

    btnSaveFancy1MarketMinMax.onclick = function () {

        var maxValue = $('#txtFancy1MarketMax').val();
        var minValue = $('#txtFancy1MarketMin').val();

        var gameId = getUrlParameter('gameId');
        $.ajax({
            type: "POST",
            url: "/Event/UpdateFancy1MarketMinMax",
            data: { maxValue: maxValue, minValue: minValue, gameId: gameId, sid: sid },
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }

    btnRemoveFancy1MarketMinMax.onclick = function () {

        var gameId = getUrlParameter('gameId');
        $.ajax({
            type: "POST",
            url: "/Event/RemoveFancy1MarketMinMax",
            data: { gameId: gameId, sid: sid },
            success: function () {
                $(".popup_window, .popup_window_overlay").fadeOut(200);
                BindEventDetails();
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }
}

function stringToInt(value) {
    multiplier = value.substr(-1).toLowerCase();
    if (multiplier == "k")
        return parseFloat(value) * 1000;
    else if (multiplier == "m")
        return parseFloat(value) * 1000000;
    else
        return value;
}