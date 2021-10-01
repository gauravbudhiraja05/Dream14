$(document).ready(function () {

    $(".popup_close_btn").click(function () {
        $(".popup_window, .popup_window_overlay").fadeOut(200);
    });

    $("#btnSave").click(function () {
        debugger;
        if (ValidateDepositWithDrawl() == false) {
            return false;
        }
        else {
            $.ajax({
                type: "POST",
                url: "/Home/DepositWithdrawl",
                async: false,
                beforeSend: function (xhr) {
                    onBegin(xhr);
                },
                data: { Balance: $('#Balance').val(), Deposit: $('#Deposit').val(), WithDrawl: $('#WithDrawl').val(), UserId: $('#UserId').val() },
                success: function (data) {
                    onSuccess(data);
                },
                error: function (e) {
                    onFailed(e);
                }
            });
        }

    });

});

function ValidateDepositWithDrawl() {

    var isValid = true;

    // check if the form input is valid
    // check if the form input is valid
    if (!$("#formDepositWithdrawl").valid()) {
        $("#formDepositWithdrawl").submit();
        isValid = false;
    }


    if ($("#Balance").val().trim().length == 0) {
        $("span[id='Balance_Error']").text("Please enter the balance amount.");
        isValid = false;

    }
    else {
        $("span[id='Balance_Error']").text("");
    }


    if ($("#Deposit").val().trim().length == 0) {
        $("span[id='Deposit_Error']").text("Please enter the deposit amount.");
        isValid = false;
    }
    else {
        $("span[id='Deposit_Error']").text("");
    }


    if ($("#WithDrawl").val().trim().length == 0) {
        $("span[id='WithDrawl_Error']").text("Please enter the withdrawl amount.");
        isValid = false;

    }
    else {
        $("span[id='WithDrawl_Error']").text("");
    }

    return isValid;

}

var onBegin = function () {
    $(".loaderModal").show()
};


var onComplete = function () {
    //alert("onComplete");
};

var onSuccess = function (context) {
    debugger;
    swal(
        'Amount has been changed successfully!',
        '',
        'success'
    ).then(function () {
        $(".loaderModal").hide();
        $(".popup_window, .popup_window_overlay").fadeOut(200);
        $('#Balance').val('');
        $('#Deposit').val('');
        $('#WithDrawl').val('');
        window.location.reload();
        return true;
    });
};

var onFailed = function (context) {
    //alert("Failed");
};
