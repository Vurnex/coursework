function calcInterest() {

    var loanAmount = document.getElementById("loanAmount").value;

    var interestRate = document.getElementById("interestRate").value;

    var requiredYears = document.getElementById("requiredYears").value;

    if (loanAmount <= 0 || interestRate <= 0 || requiredYears <= 0) {

        alert("Please enter a value higher than zero.");

        location.href = "problem1.html";
        exit();
    }

    var totalInterest = loanAmount * interestRate * requiredYears;

    alert(totalInterest + " in interest will be paid.");

    document.getElementById("finalAmount").innerHTML = totalInterest;

}