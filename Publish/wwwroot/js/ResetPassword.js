$(document).ready(function () {

    $(".popup_close_btn").click(function () {
        $(".popup_window, .popup_window_overlay").fadeOut(200);
    });

});

var onBegin = function () {
    $(".loaderModal").show()
};



var onComplete = function () {
    //alert("onComplete");
};

var onSuccess = function (context) {
    debugger;
    swal(
        'Password has been changed successfully!',
        '',
        'success'
    ).then(function () {
        $(".loaderModal").hide();
        $(".popup_window, .popup_window_overlay").fadeOut(200);
        $('#txtOldPassword').val('');
        $('#txtNewPassword').val('');
        $('#txtConfirmPassword').val('');
        return true;
    });
};

var onFailed = function (context) {
    //alert("Failed");
};
