$(document).ready(function () {
    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemSuperAdmin').addClass('current');

    // DataTable for Admin users
    var userListTable = $('#tblUsers').DataTable({

        "pageLength": 10
    });

    $(".dataTables_empty").text("There are no users yet.");

    // Search on Admin user Grid using Search Text box
    $('#txtSearchUserList').keyup(function () {
        userListTable.search($(this).val()).draw();
    });

    var rowsCount = $('#tblUsers tbody tr').length;
    //alert(rowsCount);
    if (rowsCount < 10) {
        $("#tblUsers_paginate").hide();
    }
    else {
        $("#tblUsers_paginate").show();
    }

    //if (rowsCount <= 1) {
    //    $("#btnDeleteAllCheckedAdmin").hide();
    //    //$(".table_checkbox").hide();
    //}
    //else {
    //    $("#btnDeleteAllCheckedAdmin").show();
    //    // $(".table_checkbox").show();
    //}

    // Hide un-neccessary controls of datatable plugin for Admin User tables
    $('.dataTables_length').hide();
    $('.dataTables_filter').hide();
    $('.dataTables_info').hide();

});

function ChangeUserStatus(id) {
    $.ajax({
        type: "POST",
        url: "/SuperAdmin/ChangeUserStatus",
        data: { id: id },
        async: false,
        beforeSend: function (xhr) {
            onBegin(xhr);
        },
        success: function (data) {
            debugger;
            onSuccess1(data);
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
        'The admin user status was successfully updated.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/SuperAdmin/AdminUsers";
    });
};

var onSuccess1 = function () {
    $(".loaderModal").hide();
    swal(
        'The user status was successfully updated.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/Home/UserList";
    });
};

var onFailed = function (context) {
    //alert("Failed");
};



