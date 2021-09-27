$(document).ready(function () {
    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemSuperAdmin').addClass('current');

    // DataTable for Admin users
    var userListTable = $('#tblAdmins').DataTable({

        "pageLength": 10
    });

    $(".dataTables_empty").text("There are no admins yet.");

    // Search on Admin user Grid using Search Text box
    $('#txtSearchAdminList').keyup(function () {
        userListTable.search($(this).val()).draw();
    });

    var rowsCount = $('#tblAdmins tbody tr').length;
    //alert(rowsCount);
    if (rowsCount < 10) {
        $("#tblAdmins_paginate").hide();
    }
    else {
        $("#tblAdmins_paginate").show();
    }

    if (rowsCount <= 1) {
        $("#btnDeleteAllCheckedAdmin").hide();
        //$(".table_checkbox").hide();
    }
    else {
        $("#btnDeleteAllCheckedAdmin").show();
        // $(".table_checkbox").show();
    }

    // Hide un-neccessary controls of datatable plugin for Admin User tables
    $('.dataTables_length').hide();
    $('.dataTables_filter').hide();
    $('.dataTables_info').hide();

});

function ChangeAdminUserStatus(status, userId) {
    $.ajax({
        type: "POST",
        url: "/SuperAdmin/ChangeAdminUserStatus",
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



