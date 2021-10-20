$(document).ready(function () {
    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemSuperAdmin').addClass('current');

    // DataTable for Master users
    var userListTable = $('#tblMasters').DataTable({

        "pageLength": 10
    });

    $(".dataTables_empty").text("There are no masters yet.");

    // Search on Master user Grid using Search Text box
    $('#txtSearchMasterList').keyup(function () {
        userListTable.search($(this).val()).draw();
    });

    var rowsCount = $('#tblMasters tbody tr').length;
    //alert(rowsCount);
    if (rowsCount < 10) {
        $("#tblMasters_paginate").hide();
    }
    else {
        $("#tblMasters_paginate").show();
    }

    if (rowsCount <= 1) {
        $("#btnDeleteAllCheckedMaster").hide();
        //$(".table_checkbox").hide();
    }
    else {
        $("#btnDeleteAllCheckedMaster").show();
        // $(".table_checkbox").show();
    }

    // Hide un-neccessary controls of datatable plugin for Master User tables
    $('.dataTables_length').hide();
    $('.dataTables_filter').hide();
    $('.dataTables_info').hide();

});

function ChangeMasterUserStatus(status, userId) {
    $.ajax({
        type: "POST",
        url: "/SuperAdmin/ChangeMasterUserStatus",
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
        'The master user status was successfully updated.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/SuperAdmin/MasterUsers";
    });
};





