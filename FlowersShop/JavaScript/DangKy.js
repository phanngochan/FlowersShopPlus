function btnSignUp() {
    var name = document.getElementById("txtName").value.trim();
    var number = document.getElementById("txtnumber").value.trim();
    var cccd = document.getElementById("txtcccd").value.trim();
    var password = document.getElementById("txtpassword").value.trim();

    var errname = document.getElementById("err-name");
    var errcccd = document.getElementById("err-cccd");
    var errnumber = document.getElementById("err-number");
    var errpassword = document.getElementById("err-password");
    var check = true;

    var firstThreeDigits = password.substring(0, 3);

    if (name == "") {
        //alert("Fill last name!");
        errname.innerHTML = "Fill your username!";
        check = false;
        document.getElementById("txtName").focus();
    } else errname.innerHTML = "";

    if (number == "") {
        errnumber.innerHTML = "Fill your phone number!";
        check = false;
        document.getElementById("txtnumber").focus();
    }
    else if (/^0[1-9]{9}/.test(number) == false) {
        errnumber.innerHTML = "Wrong phone number!";
        check = false;
        document.getElementById("txtnumber").focus();
        
    } else errnumber.innerHTML = "";


    if (cccd == "") {
        alert("cccd")
        errcccd.innerHTML = "Fill your id number!";
        check = false;
        document.getElementById("txtcccd").focus();
    }
    else if (/^[0-9]{12}/.test(cccd) == false) {
        errcccd.innerHTML = "Wrong id number!";
        check = false;
        document.getElementById("txtcccd").focus();
    } else errcccd.innerHTML = "";


    if (password == "") {
        errpassword.innerHTML = "Fill your passwword!";
        check = false;
        document.getElementById("txtpassword").focus();
    }
    else if (password.length < 8) {
        console.log(password);
        errpassword.innerHTML = "Mật khẩu ít nhất 8 kí tự";
        check = false;
        document.getElementById("txtpassword").focus();
        document.getElementById("txtpassword").value = null;

    }
    else if (!password.match(/[A-Z]/)) {
        console.log(password);
        errpassword.innerHTML = "Ít nhất 1 chữ hoa";
        check = false;
        document.getElementById("txtpassword").focus();
        document.getElementById("txtpassword").value = null;
    }

    else if (!firstThreeDigits.match(/^\d+$/)) {
        console.log(password);
        errpassword.innerHTML = "3 kí tự đầu là số";
        check = false;
        document.getElementById("txtpassword").focus();
        document.getElementById("txtpassword").value = null;
    }
    else {
        errpassword.innerHTML = "";
    }

    if (errnumber.innerHTML === "" && errname.innerHTML === "" && errpassword.innerHTML === "" && errcccd.innerHTML === "") {
        check = true;
    }
    else check = false;
    return check;
}