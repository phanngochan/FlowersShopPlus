function btnLogin() {
    var phone = document.getElementById("txtnumber").value.trim();
    var pass = document.getElementById("txtpassword").value.trim();
    var errornumber = document.getElementById("err-number");
    var errorpassword = document.getElementById("err-password");
    var check = true;

    if (phone == "" && pass == "") {
        errornumber.innerHTML = "Fill your phone number!";
        errorpassword.innerHTML = "Fill your password!";
        document.getElementById("txtnumber").focus();
        check = false;
    }
    if (phone == "") {
        errornumber.innerHTML = "Fill your phone number!"
        document.getElementById("txtnumber").focus();
        check = false;
    }
    else {
        errornumber.innerHTML = "";
    }

    if (pass == "") {
        errorpassword.innerHTML = "Fill your password!"
        document.getElementById("txtpassword").focus();
        check = false;
    }
    else {
        errorpassword.innerHTML = "";
    }
    return check;
}