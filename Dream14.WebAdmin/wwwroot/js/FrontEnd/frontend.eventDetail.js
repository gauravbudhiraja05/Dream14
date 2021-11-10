
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
                BindT1Details(eventList.t1, eventList.t1PercentageDetail, eventList.t1BetValueDetail);
                BindT2Details(eventList.t2);
                BindT3Details(eventList.t3);
                BindT4Details(eventList.t4);
                BindHeaderDetails(eventList);
                GetModalDetails();
                //AddToggle();
                //FilterEventDetailStatus(eventList.eventDetailStatus);
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
                BindT1Details(eventList.t1, eventList.t1PercentageDetail, eventList.t1BetValueDetail);
                BindT2Details(eventList.t2);
                BindT3Details(eventList.t3);
                BindT4Details(eventList.t4);
                BindHeaderDetails(eventList);
                GetModalDetails();
                //AddToggle();
                //FilterEventDetailStatus(eventList.eventDetailStatus);
                BindMinMaxValue(eventList.minMaxList);

            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function BindT1Details(t1, t1PercentageDetail, t1BetValueDetail) {

    var old_b3 = parseFloat($('#b3').html());
    var old_b2 = parseFloat($('#b2').html());
    var old_b1 = parseFloat($('#b1').html());
    var old_l1 = parseFloat($('#l1').html());
    var old_l2 = parseFloat($('#l2').html());
    var old_l3 = parseFloat($('#l3').html());

    var old_t1_betValue_team0 = $('#t1_betValue_team0').html();
    var old_t1_betValue_team1 = $('#t1_betValue_team1').html();

    var old_t1Bet_team0 = $('#t1Bet_team0').html();
    var old_t1Bet_team1 = $('#t1Bet_team1').html();

    $('#Table_t1 tr').remove();
    if (t1 != null && t1.length > 0) {

        var html1 = "<tr class='table1_header' style='cursor:pointer'><th colspan='3'>MATCH_ODDS<i id='matchOdds_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td><table style='width:100%'><tr><td>Max : <span id='MatchOddsMaxValue'>0</span></td><td>Min : <span id='MatchOddsMinValue'>0</span></td><td></td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:#72BBEF'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:#FAA9BA'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
        var html2 = "";
        for (var i = 0; i < t1.length; i++) {
            for (var j = 0; j < t1[i].length; j++)
                html2 = html2.concat("<tr style='cursor:pointer'><td class='left-text'><table><tr><td><b>" + t1[i][j].nat + "</b></td><td><p id='t1_betValue_team" + j + "'>0</p></td></tr><tr><td colspan='2'><p id='t1Bet_team" + j + "'></p></td></tr></table></td><td><table style='width:100%;'><tr><td class='bet-click' id='b3_Team" + j + "_" + t1[i][j].b3 + "' style='background-color:#72BBEF'>" + t1[i][j].b3 + "<br/><span class='lowertext'>" + t1[i][j].bs3 + "</span></td><td class='bet-click' id='b2_Team" + j + "_" + t1[i][j].b2 + "' style='background-color:#72BBEF'>" + t1[i][j].b2 + "<br/><span class='lowertext'>" + t1[i][j].bs2 + "</span></td><td class='bet-click' id='b1_Team" + j + "_" + t1[i][j].b1 + "' style='background-color:#72BBEF'>" + t1[i][j].b1 + "<br/><span class='lowertext'>" + t1[i][j].bs1 + "</span></td></tr></table></td><td><table style='width:100%;'><tr><td class='bet-click' id='l1_Team" + j + "_" + t1[i][j].l1 + "' style='background-color:#FAA9BA'>" + t1[i][j].l1 + "<br/><span class='lowertext'>" + t1[i][j].ls1 + "</span></td><td class='bet-click' id='l2_Team" + j + "_" + t1[i][j].l2 + "' style='background-color:#FAA9BA'>" + t1[i][j].l2 + "<br/><span class='lowertext'>" + t1[i][j].ls2 + "</span></td><td class='bet-click' id='l3_Team" + j + "_" + t1[i][j].l3 + "' style='background-color:#FAA9BA'>" + t1[i][j].l3 + "<br/><span class='lowertext'>" + t1[i][j].ls3 + "</span></td></tr></table></td></tr>");
        }
        var result = html1.concat(html2)
        $('#Table_t1').append(result);

        if (t1BetValueDetail != null) {
            $('#t1_betValue_team0').html(t1BetValueDetail.team1BetValue);
            $('#t1_betValue_team1').html(t1BetValueDetail.team2BetValue);
        }
        else if (old_t1_betValue_team0 != undefined && old_t1_betValue_team1 != undefined) {
            $('#t1_betValue_team0').html(old_t1_betValue_team0);
            $('#t1_betValue_team1').html(old_t1_betValue_team1);
        }

        BindBetValue()

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
        //<span style='margin-left: 610px;'>Maximum Bet 1</span>
        var html = "<tr class='table1_header' style='cursor:pointer'><th colspan='3'>MATCH_ODDS <i id='matchOdds_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td colspan='3' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t1').append(html);
    }

    $('.bet-click').click(function () {
        var type = $(this).attr('id').split("_")[0];
        var team = $(this).attr('id').split("_")[1];
        var betValue = $(this).attr('id').split("_")[2]
        if (betValue != "0.00") {
            AddBet(betValue, team, type);
        }
    });
}

function BindBetValue() {
    var type = "b1";
    var gameId = getUrlParameter('gameId');
    $.ajax({
        type: "POST",
        url: "/FrontEnd/GetUserStakeValue1",
        data: { type: type, gameId: gameId },
        success: function (stakeValue) {
            var bet = stakeValue.split(':')[0];
            var stake = stakeValue.split(':')[1];
            $('#t1Bet_team0').html("-" + stake);
            bet = bet.substr(bet.indexOf("."));
            var profit = bet * stake;
            $('#t1Bet_team1').html(profit);
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function AddBet(betValue, team, type) {

    // Get the modal
    var betModal = document.getElementById("betModal");
    var popupOverLay = document.getElementById("popup_overlay");
    var btnSaveBet = document.getElementById("btnSaveBet");
    var btnResetBet = document.getElementById("btnResetBet");
    var betCloseSpan = document.getElementsByClassName("betClose")[0];

    var gameId = getUrlParameter('gameId');

    var teamName = "";
    if (team == "Team0") {
        teamName = $($('#Table_t1 td.left-text b')[0]).html();
    }
    else {
        teamName = $($('#Table_t1 td.left-text b')[1]).html();
    }

    GetStakeValue(teamName, type, gameId);

    $('#txtTeamName').val(teamName);

    betModal.style.display = "block";
    popupOverLay.style.display = 'block';

    $('#txtBetValue').val(betValue);

    betCloseSpan.onclick = function () {
        betModal.style.display = "none";
    }

    btnResetBet.onclick = function () {
        betModal.style.display = "none";
    }

    GetUserBetButtonValue();

    $('#txtStakeValue').change(function () {
        var btnValue = $(this).val();
        var betValue = $('#txtBetValue').val().substr($('#txtBetValue').val().indexOf("."));
        var percentageValue = btnValue * betValue;
        $('#txtProfit').val(percentageValue);

        if ($('#txtStakeValue').val() == "") {
            $('#t1_betValue_team1').html("0");
        }
        else {
            $('#t1_betValue_team1').html($('#txtStakeValue').val());
        }
        $('#t1_betValue_team0').html($('#txtProfit').val());
    });

    btnSaveBet.onclick = function () {
        var betValue = $('#txtBetValue').val();
        var stakeValue = $('#txtStakeValue').val();
        $.ajax({
            type: "POST",
            url: "/FrontEnd/UpdateUserBetValue",
            data: { betValue: betValue, stakeValue: stakeValue, type: type, gameId: gameId, teamName: teamName },
            success: function () {
                betModal.style.display = "none";
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    }
}

function GetStakeValue(teamName, type, gameId) {
    $.ajax({
        type: "POST",
        url: "/FrontEnd/GetUserStakeValue",
        data: { type: type, gameId: gameId, teamName: teamName },
        success: function (stakeValue) {
            $('#txtStakeValue').val(stakeValue);
            var betValue = $('#txtBetValue').val().substr($('#txtBetValue').val().indexOf("."));
            var percentageValue = stakeValue * betValue;
            $('#txtProfit').val(percentageValue);

            if ($('#txtStakeValue').val() == "") {
                $('#t1_betValue_team1').html("0");
            }
            else {
                $('#t1_betValue_team1').html($('#txtStakeValue').val());
            }
            $('#t1_betValue_team0').html($('#txtProfit').val());
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function GetUserBetButtonValue() {

    $.ajax({
        type: "POST",
        url: "/FrontEnd/GetUserBetButtonValue",
        success: function (btnValueList) {
            if (btnValueList != null && btnValueList != undefined && btnValueList != "") {

                $('#btn_bet1').html(btnValueList["Button1"].split(":")[0]).val(btnValueList["Button1"].split(":")[1]);
                $('#btn_bet2').html(btnValueList["Button2"].split(":")[0]).val(btnValueList["Button2"].split(":")[1]);
                $('#btn_bet3').html(btnValueList["Button3"].split(":")[0]).val(btnValueList["Button3"].split(":")[1]);
                $('#btn_bet4').html(btnValueList["Button4"].split(":")[0]).val(btnValueList["Button4"].split(":")[1]);
                $('#btn_bet5').html(btnValueList["Button5"].split(":")[0]).val(btnValueList["Button5"].split(":")[1]);
                $('#btn_bet6').html(btnValueList["Button6"].split(":")[0]).val(btnValueList["Button6"].split(":")[1]);
                $('#btn_bet7').html(btnValueList["Button7"].split(":")[0]).val(btnValueList["Button7"].split(":")[1]);
                $('#btn_bet8').html(btnValueList["Button8"].split(":")[0]).val(btnValueList["Button8"].split(":")[1]);
                $('#btn_bet9').html(btnValueList["Button9"].split(":")[0]).val(btnValueList["Button9"].split(":")[1]);
                $('#btn_bet10').html(btnValueList["Button10"].split(":")[0]).val(btnValueList["Button10"].split(":")[1]);


                $('.btn-new').click(function () {
                    var btnValue = $(this).html();
                    $('#txtStakeValue').val(btnValue);
                    var betValue = $('#txtBetValue').val().substr($('#txtBetValue').val().indexOf("."));
                    var percentageValue = btnValue * betValue;
                    $('#txtProfit').val(percentageValue);

                    if ($('#txtStakeValue').val() == "") {
                        $('#t1_betValue_team1').html("0");
                    }
                    else {
                        $('#t1_betValue_team1').html($('#txtStakeValue').val());
                    }
                    $('#t1_betValue_team0').html($('#txtProfit').val());

                });
            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function BindT2Details(t2) {
    $('#Table_t2 tr').remove();
    if (t2 != null && t2.length > 0) {
        var html1 = "<tr class='table2_header' style='cursor:pointer'><th colspan='3'>Bookmaker market <i id='bookmaker_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td><table style='width:100%'><tr><td>Max : <span id='BookmakerMarketMaxValue'>0</span></td><td>Min : <span id='BookmakerMarketMinValue'>0</span></td><td></td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:#72BBEF'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:#FAA9BA'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
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
                    html2 = html2.concat("<td><table style='width:100%;'><tr style=' background-color:#72BBEF'><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%'>" + t2[i].bm1[j].b1 + "<span class='lowertext'>" + intToString(t2[i].bm1[j].bs1) + "</span></td></tr></table></td><td><table style='width:100%;'><tr style=' background-color:#FAA9BA'><td style='width:33%'>" + t2[i].bm1[j].l1 + "<span class='lowertext'>" + intToString(t2[i].bm1[j].ls1) + "</span></td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>");
                }

                maxValue = t2[i].bm1[j].max;
                minValue = t2[i].bm1[j].min;
            }
            html2 = html2.concat("<Tr><td colspan='3' style='text-align:right'>" + remark + "</td></tr>")
        }
        var result = html1.concat(html2)
        $('#Table_t2').append(result);

        $('#BookmakerMarketMaxValue').html(intToString(maxValue));
        $('#BookmakerMarketMinValue').html(intToString(minValue));
    }
    else {
        var html = "<tr class='table2_header' style='cursor:pointer'><th colspan='3'>Bookmaker market <i id='bookmaker_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td colspan='3' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t2').append(html);
    }
}

function BindT3Details(t3) {
    $('#Table_t3 tr').remove();
    if (t3 != null && t3.length > 0) {
        var html1 = "<tr class='table3_header' style='cursor:pointer'><th colspan='4'>Session Market <i id='sessionMarket_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td style='text-align:center; background-color:#FAA9BA'>NO</td><td style='text-align:center; background-color:#72BBEF'>YES</td><td></td></tr>";
        var html2 = "";
        for (var i = 0; i < t3.length; i++) {
            html2 = html2.concat("<tr><td class='left-text'><b>" + t3[i].nat + "</b></td><td style=' background-color:#FAA9BA'>" + t3[i].l1 + "<span class='lowertext'>" + intToString(t3[i].ls1) + "</span></td><td style=' background-color:#72BBEF'>" + t3[i].b1 + "<span class='lowertext'>" + intToString(t3[i].bs1) + "</span></td><td><table style='width:100%'><tr><td>Max : <span id='SessionMarketMax_" + t3[i].sid + "'>" + intToString(t3[i].max) + "</span></td><td>Min : <span id='SessionMarketMin_" + t3[i].sid + "'>" + intToString(t3[i].min) + "</span></td><td></td></tr></table></td></tr>");
        }
        var result = html1.concat(html2)
        $('#Table_t3').append(result);
    }
    else {
        var html = "<tr class='table3_header' style='cursor:pointer'><th colspan='3'>Session Market <i id='sessionMarket_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td colspan='4' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t3').append(html);
    }
}

function BindT4Details(t4) {
    $('#Table_t4 tr').remove();
    if (t4 != null && t4.length > 0) {
        var html1 = "<tr class='table4_header' style='cursor:pointer'><th colspan='4'>Fancy1 Market <i id='Fancy1Market_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td style='text-align:center; background-color:#72BBEF'>BACK</td><td style='text-align:center; background-color:#FAA9BA'>LAY</td><td></td></tr>";
        var html2 = "";
        for (var i = 0; i < t4.length; i++) {
            html2 = html2.concat("<tr><td class='left-text'><b>" + t4[i].nat + "</b></td><td style=' background-color:#72BBEF'>" + t4[i].b1 + "<span class='lowertext'>" + intToString(t4[i].bs1) + "</span></td><td style=' background-color:#FAA9BA'>" + t4[i].l1 + "<span class='lowertext'>" + intToString(t4[i].ls1) + "</span></td><td><table style='width:100%'><tr><td>Max : <span id='Fancy1MarketMax_" + t4[i].sid + "'>" + intToString(t4[i].max) + "</span></td><td>Min : <span id='Fancy1MarketMin_" + t4[i].sid + "'>" + intToString(t4[i].min) + "</span></td><td></td></tr></table></td></tr>");
        }
        var result = html1.concat(html2)
        $('#Table_t4').append(result);
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

function ViewEventDetail(gameId) {
    window.Location.href = "/EventDetail?gameId=" + gameId;
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

var onBegin = function () {
    $(".loaderModal").show();
};

var onComplete = function () {
    //alert("onComplete");
};

var onSuccess = function () {
    $(".loaderModal").hide();
    swal(
        'The admin user status was successfully updated.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/SuperAdmin/AdminUsers";
    });
};

var onFailed = function () {
    //alert("Failed");
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
