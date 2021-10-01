$(document).ready(function () {
    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemSuperAdmin').addClass('current');

    // DataTable for Admin users
    var userListTable = $('#tblAgents').DataTable({

        "pageLength": 10
    });

    $(".dataTables_empty").text("There are no agents yet.");

    // Search on Admin user Grid using Search Text box
    $('#txtSearchAgentList').keyup(function () {
        userListTable.search($(this).val()).draw();
    });

    var rowsCount = $('#tblAgents tbody tr').length;
    //alert(rowsCount);
    if (rowsCount < 10) {
        $("#tblAgents_paginate").hide();
    }
    else {
        $("#tblAgents_paginate").show();
    }

    if (rowsCount <= 1) {
        $("#btnDeleteAllCheckedAgent").hide();
        //$(".table_checkbox").hide();
    }
    else {
        $("#btnDeleteAllCheckedAgent").show();
        // $(".table_checkbox").show();
    }

    // Hide un-neccessary controls of datatable plugin for Admin User tables
    $('.dataTables_length').hide();
    $('.dataTables_filter').hide();
    $('.dataTables_info').hide();

});

function ChangeAgentUserStatus(status, userId) {
    $.ajax({
        type: "POST",
        url: "/SuperAdmin/ChangeAgentUserStatus",
        data: { status: status, userId: userId },
        async: false,
        beforeSend: function (xhr) {
            onBegin(xhr);
        },
        success: function (data) {
            debugger;
            onSuccess(data);
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

function OpenOperationPopUp(userId) {

    $.get('/Home/DepositWithdrawl/' + userId, function (data) {

        $('#partialDepositWithdrawl').html(data);
        $('#partialDepositWithdrawl').show();
        $("#partialDepositWithdrawl_popup, .popup_window_overlay").fadeToggle(200);
    });

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
        'The agent user status was successfully updated.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/SuperAdmin/AgentUsers";
    });
};

var onFailed = function (context) {
    //alert("Failed");
};


