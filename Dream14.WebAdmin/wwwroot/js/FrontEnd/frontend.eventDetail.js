$(document).ready(function () {
    debugger;
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

                $('#th1_header').html(eventList.eventName);
                $('#th2_header').html(eventList.eventDate);
                $('#th3_header').html(eventList.eventTime);
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

function BindT1Details(t1) {

    var old_b3 = parseFloat($('#b3').html());
    var old_b2 = parseFloat($('#b2').html());
    var old_b1 = parseFloat($('#b1').html());
    var old_l1 = parseFloat($('#l1').html());
    var old_l2 = parseFloat($('#l2').html());
    var old_l3 = parseFloat($('#l3').html());

    $('#Table_t1 tr').remove();
    if (t1 != null && t1.length > 0) {
        //<span style='margin-left: 610px;'>Maximum Bet 1</span>
        var html1 = "<tr class='table1_header' style='cursor:pointer'><th colspan='3'>MATCH_ODDS<i id='matchOdds_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td></td><td><table style='width:100%'><tr><td style='width:33%'></td><td style='width:33%'></td><td style='width:33%;background-color:#72BBEF'>BACK</td></tr></table></td><td><table style='width:100%'><tr><td style='width:33%; text-align:center; background-color:#FAA9BA'>LAY</td><td style='width:33%'></td><td style='width:33%'></td></tr></table></td></tr>";
        var html2 = "";
        for (var i = 0; i < t1.length; i++) {
            for (var j = 0; j < t1[i].length; j++)
                html2 = html2.concat("<tr><td class='left-text'><b>" + t1[i][j].nat + "</b></td><td><table style='width:100%;'><tr><td id='b3' style='background-color:#72BBEF'>" + t1[i][j].b3 + "</td><td id='b2' style='background-color:#72BBEF'>" + t1[i][j].b2 + "</td><td id='b1' style='background-color:#72BBEF'>" + t1[i][j].b1 + "</td></tr></table></td><td><table style='width:100%;'><tr><td id='l1' style='background-color:#FAA9BA'>" + t1[i][j].l1 + "</td><td id='l2' style='background-color:#FAA9BA'>" + t1[i][j].l2 + "</td><td id='l3' style='background-color:#FAA9BA'>" + t1[i][j].l3 + "</td></tr></table></td></tr>");
        }
        var result = html1.concat(html2)
        $('#Table_t1').append(result);

        var new_b3 = parseFloat($('#b3').html());
        var new_b2 = parseFloat($('#b2').html());
        var new_b1 = parseFloat($('#b1').html());
        var new_l1 = parseFloat($('#l1').html());
        var new_l2 = parseFloat($('#l2').html());
        var new_l3 = parseFloat($('#l3').html());
 
        if (old_b3 != NaN && old_b2 != NaN && old_b1 != NaN && old_l3 != NaN && old_l2 != NaN && old_l1 != NaN) {

            if (old_b3 > new_b3) {
                BindRedColor("b3", "blue");
            }
            else if (old_b3 < new_b3) {
                BindPurpleColor("b3", "blue");
            }

            if (old_b2 > new_b2) {
                BindRedColor("b2", "blue");
            }
            else if (old_b2 < new_b2) {
                BindPurpleColor("b2", "blue");
            }

            if (old_b1 > new_b1) {
                BindRedColor("b1", "blue");
            }
            else if (old_b1 < new_b1) {
                BindPurpleColor("b1", "blue");
            }

            if (old_l1 > new_l1) {
                BindRedColor("l1", "blue");
            }
            else if (old_l1 < new_l1){
                BindPurpleColor("l1", "blue");
            }

            if (old_l2 > new_l2) {
                BindRedColor("l2", "blue");
            }
            else if (old_l2 < new_l2){
                BindPurpleColor("l2", "blue");
            }

            if (old_l3 > new_l3) {
                BindRedColor("l3", "blue");
            }
            else if (old_l3 < new_l3) {
                BindPurpleColor("l3", "blue");
            }
        }
    }
    else {
        //<span style='margin-left: 610px;'>Maximum Bet 1</span>
        var html = "<tr class='table1_header' style='cursor:pointer'><th colspan='3'>MATCH_ODDS <i id='matchOdds_Modal' class='fa fa-info-circle' style='font-size:24px;float:right;cursor: pointer'></i></th></tr><tr><td colspan='3' style='text-align: center'>No Records Found</td></tr>";
        $('#Table_t1').append(html);
    }
}

function BindT2Details(t2) {
    $('#Table_t2 tr').remove();
    if (t2 != null && t2.length > 0) {
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
            html2 = html2.concat("<tr><td class='left-text'><b>" + t3[i].nat + "</b></td><td style=' background-color:#FAA9BA'>" + t3[i].l1 + "</td><td style=' background-color:#72BBEF'>" + t3[i].b1 + "</td><td>Min: " + intToString(t3[i].min) + " Max: " + intToString(t3[i].max) + " </td></tr>");
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
            html2 = html2.concat("<tr><td class='left-text'><b>" + t4[i].nat + "</b></td><td style=' background-color:#72BBEF'>" + t4[i].b1 + "</td><td style=' background-color:#FAA9BA'>" + t4[i].l1 + "</td><td>Min : " + intToString(t4[i].min) + " Max : " + intToString(t4[i].max) + " </td></tr>");
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


function BindRedColor(itemId, type) {
    $('#' + itemId).css("background-color", "red");
    RestoreOriginalColor(itemId, type);
}

function BindPurpleColor(itemId, type) {
    $('#' + itemId).css("background-color", "purple");
    RestoreOriginalColor(itemId, type);
}

function RestoreOriginalColor(itemId, type) {
    if (type == "blue")
        setTimeout(function () { SetBlueColor(itemId) }, 600);
    else if (type == "pink")
        setTimeout(function () { SetPinkColor(itemId) }, 600);
}


function SetBlueColor(itemId) {
    $('#' + itemId).css("background-color", "#72BBEF");
}


function SetPinkColor(itemId) {
    $('#' + itemId).css("background-color", "#FAA9BA");
}
