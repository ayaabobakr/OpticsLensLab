var GetLogin = function () {
    var username = $('#txtUsername').val();
    var password = $('#txtPassword').val();
    var loginUrl = "/api/Values/GetLogin";
    var loginData = JSON.stringify({ "Username": username, "Password": password });
    $.ajax({
        type: "POST",
        data: loginData,
        url: loginUrl,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (result === "Logged In Successfully") {
                sessionStorage.setItem("accesstoken", result.access_loginUrl);
                window.location.href = "Orders.html";
                alert(result)
            } else {
                alert(result)
            }

        },
        error: function (result) {
            alert(result)
        }
    });
};