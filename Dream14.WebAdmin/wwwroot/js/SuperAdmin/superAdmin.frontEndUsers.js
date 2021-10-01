$(document).ready(function () {
    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemSuperAdmin').addClass('current');

    // DataTable for Admin users
    var userListTable = $('#tblFrontEnds').DataTable({

        "pageLength": 10
    });

    $(".dataTables_empty").text("There are no frontEnds yet.");

    // Search on Admin user Grid using Search Text box
    $('#txtSearchFrontEndList').keyup(function () {
        userListTable.search($(this).val()).draw();
    });

    var rowsCount = $('#tblFrontEnds tbody tr').length;
    //alert(rowsCount);
    if (rowsCount < 10) {
        $("#tblFrontEnds_paginate").hide();
    }
    else {
        $("#tblFrontEnds_paginate").show();
    }

    if (rowsCount <= 1) {
        $("#btnDeleteAllCheckedFrontEnd").hide();
        //$(".table_checkbox").hide();
    }
    else {
        $("#btnDeleteAllCheckedFrontEnd").show();
        // $(".table_checkbox").show();
    }

    // Hide un-neccessary controls of datatable plugin for Admin User tables
    $('.dataTables_length').hide();
    $('.dataTables_filter').hide();
    $('.dataTables_info').hide();

});



function ChangeFrontEndUserStatus(status, userId) {
    $.ajax({
        type: "POST",
        url: "/SuperAdmin/ChangeFrontEndUserStatus",
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
        'The frontend user status was successfully updated.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/SuperAdmin/FrontEndUsers";
    });
};

var onFailed = function (context) {
    //alert("Failed");
};

