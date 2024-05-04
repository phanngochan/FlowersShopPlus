function changeTotal() {
    let Quantity = event.target;
    let sTotal = event.target.parentElement.nextSibling;
    let sPrice = event.target.parentElement.previousElementSibling.innerText;
    let ssubTotal = document.getElementById("subTotalBox");

    let SubTotal = ssubTotal.innerHTML.split("$");
    let Total = sTotal.innerText.split("$");
    let Price = sPrice.split("$");
    let output = parseFloat(parseFloat(Quantity.value) * parseFloat(Price[1]));
    let NewSubTotal = parseFloat(SubTotal[1]) + (output - parseFloat(Total[1]))

    sTotal.innerHTML = "$" + output;
    ssubTotal.innerHTML = "$" + NewSubTotal;

}