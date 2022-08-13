var finalGrade = 0;
var chosenAssessment = "Lab";

function labClick(){

    $('#Grade1').css('display', 'block');
    $('#Grade2').css('display', 'block');
    $('#Grade3').css('display', 'block');
    $('#Grade4').css('display', 'block');
    $('#Grade5').css('display', 'block');
    $('#Grade6').css('display', 'block');
    $('#Grade7').css('display', 'block');
    $('#Grade8').css('display', 'block');
    $('#Grade9').css('display', 'block');
    $('#Grade10').css('display', 'block');
    $('#Grade11').css('display', 'none');
    $('#Grade12').css('display', 'none');
    $('#Grade13').css('display', 'none');
    $('#Grade14').css('display', 'none');
    $('#Grade15').css('display', 'none');

    chosenAssessment = "Lab";
    
}

function quizClick(){

    $('#Grade1').css('display', 'block');
    $('#Grade2').css('display', 'block');
    $('#Grade3').css('display', 'block');
    $('#Grade4').css('display', 'block');
    $('#Grade5').css('display', 'block');
    $('#Grade6').css('display', 'block');
    $('#Grade7').css('display', 'block');
    $('#Grade8').css('display', 'block');
    $('#Grade9').css('display', 'block');
    $('#Grade10').css('display', 'block');
    $('#Grade11').css('display', 'none');
    $('#Grade12').css('display', 'none');
    $('#Grade13').css('display', 'none');
    $('#Grade14').css('display', 'none');
    $('#Grade15').css('display', 'none');

    chosenAssessment = "Quiz";
    
}

function examClick(){

    $('#Grade1').css('display', 'block');
    $('#Grade2').css('display', 'block');
    $('#Grade3').css('display', 'none');
    $('#Grade4').css('display', 'none');
    $('#Grade5').css('display', 'none');
    $('#Grade6').css('display', 'none');
    $('#Grade7').css('display', 'none');
    $('#Grade8').css('display', 'none');
    $('#Grade9').css('display', 'none');
    $('#Grade10').css('display', 'none');
    $('#Grade11').css('display', 'none');
    $('#Grade12').css('display', 'none');
    $('#Grade13').css('display', 'none');
    $('#Grade14').css('display', 'none');
    $('#Grade15').css('display', 'none');

    chosenAssessment = "Exam";
    
}

function participationClick(){

    $('#Grade1').css('display', 'block');
    $('#Grade2').css('display', 'block');
    $('#Grade3').css('display', 'block');
    $('#Grade4').css('display', 'block');
    $('#Grade5').css('display', 'block');
    $('#Grade6').css('display', 'block');
    $('#Grade7').css('display', 'block');
    $('#Grade8').css('display', 'block');
    $('#Grade9').css('display', 'block');
    $('#Grade10').css('display', 'block');
    $('#Grade11').css('display', 'block');
    $('#Grade12').css('display', 'block');
    $('#Grade13').css('display', 'block');
    $('#Grade14').css('display', 'block');
    $('#Grade15').css('display', 'block');

    chosenAssessment = "Participation";

}

function projectClick() {

    $('#Grade1').css('display', 'block');
    $('#Grade2').css('display', 'none');
    $('#Grade3').css('display', 'none');
    $('#Grade4').css('display', 'none');
    $('#Grade5').css('display', 'none');
    $('#Grade6').css('display', 'none');
    $('#Grade7').css('display', 'none');
    $('#Grade8').css('display', 'none');
    $('#Grade9').css('display', 'none');
    $('#Grade10').css('display', 'none');
    $('#Grade11').css('display', 'none');
    $('#Grade12').css('display', 'none');
    $('#Grade13').css('display', 'none');
    $('#Grade14').css('display', 'none');
    $('#Grade15').css('display', 'none');

    chosenAssessment = "Project";
}

function exCreditClick() {

    $('#Grade1').css('display', 'block');
    $('#Grade2').css('display', 'none');
    $('#Grade3').css('display', 'none');
    $('#Grade4').css('display', 'none');
    $('#Grade5').css('display', 'none');
    $('#Grade6').css('display', 'none');
    $('#Grade7').css('display', 'none');
    $('#Grade8').css('display', 'none');
    $('#Grade9').css('display', 'none');
    $('#Grade10').css('display', 'none');
    $('#Grade11').css('display', 'none');
    $('#Grade12').css('display', 'none');
    $('#Grade13').css('display', 'none');
    $('#Grade14').css('display', 'none');
    $('#Grade15').css('display', 'none');

    chosenAssessment = "Extra Credit";
}

function inputData(){

    var grade1 = document.getElementById("Grade1").value;

    var grade2 = document.getElementById("Grade2").value;

    var grade3 = document.getElementById("Grade3").value;

    var grade4 = document.getElementById("Grade4").value;

    var grade5 = document.getElementById("Grade5").value;

    var grade6 = document.getElementById("Grade6").value;

    var grade7 = document.getElementById("Grade7").value;

    var grade8 = document.getElementById("Grade8").value;

    var grade9 = document.getElementById("Grade9").value;

    var grade10 = document.getElementById("Grade10").value;

    var grade11 = document.getElementById("Grade11").value;

    var grade12 = document.getElementById("Grade12").value;

    var grade13 = document.getElementById("Grade13").value;

    var grade14 = document.getElementById("Grade14").value;

    var grade15 = document.getElementById("Grade15").value;

    //initialize weights
    var labWeight = 0.30;
    var quizWeight = 0.10;
    var examWeight = 0.30;
    var projectWeight = 0.20;
    var exCreditWeight = 0.05;
    var participationWeight = 0.10;

    //determine the category. calculate averages and apply weights. send the weighted
    //grade to a function to get the final grade.

    if (chosenAssessment == "Lab") {

        var labAverage = parseFloat(grade1) + parseFloat(grade2) + parseFloat(grade3) 
        + parseFloat(grade4) + parseFloat(grade5) + parseFloat(grade6) + parseFloat(grade7) 
        + parseFloat(grade8) + parseFloat(grade9) + parseFloat(grade10);

        labAverage = labAverage / 10;

        var labWeighted = labAverage * labWeight;

        document.getElementById("labList1").innerHTML = parseFloat(grade1);
        document.getElementById("labList2").innerHTML = parseFloat(grade2);
        document.getElementById("labList3").innerHTML = parseFloat(grade3);
        document.getElementById("labList4").innerHTML = parseFloat(grade4);
        document.getElementById("labList5").innerHTML = parseFloat(grade5);
        document.getElementById("labList6").innerHTML = parseFloat(grade6);
        document.getElementById("labList7").innerHTML = parseFloat(grade7);
        document.getElementById("labList8").innerHTML = parseFloat(grade8);
        document.getElementById("labList9").innerHTML = parseFloat(grade9);
        document.getElementById("labList10").innerHTML = parseFloat(grade10);

        getFinalGrade(labWeighted);

    }
    else if (chosenAssessment == "Quiz"){

        var quizAverage = parseFloat(grade1) + parseFloat(grade2) + parseFloat(grade3) 
        + parseFloat(grade4) + parseFloat(grade5) + parseFloat(grade6) + parseFloat(grade7) 
        + parseFloat(grade8) + parseFloat(grade9) + parseFloat(grade10);

        quizAverage = quizAverage / 10;

        var quizWeighted = quizAverage * quizWeight;

        document.getElementById("quizList1").innerHTML = parseFloat(grade1);
        document.getElementById("quizList2").innerHTML = parseFloat(grade2);
        document.getElementById("quizList3").innerHTML = parseFloat(grade3);
        document.getElementById("quizList4").innerHTML = parseFloat(grade4);
        document.getElementById("quizList5").innerHTML = parseFloat(grade5);
        document.getElementById("quizList6").innerHTML = parseFloat(grade6);
        document.getElementById("quizList7").innerHTML = parseFloat(grade7);
        document.getElementById("quizList8").innerHTML = parseFloat(grade8);
        document.getElementById("quizList9").innerHTML = parseFloat(grade9);
        document.getElementById("quizList10").innerHTML = parseFloat(grade10);

        getFinalGrade(quizWeighted);
    }
    else if(chosenAssessment == "Exam"){

        var examAverage = parseFloat(grade1) + parseFloat(grade2)

        examAverage = examAverage / 2;
        var examWeighted = examAverage * examWeight;

        document.getElementById("examList1").innerHTML = parseFloat(grade1);
        document.getElementById("examList2").innerHTML = parseFloat(grade1);

        getFinalGrade(examWeighted);
  
    }
    else if(chosenAssessment == "Participation") {

        var participAverage = parseFloat(grade1) + parseFloat(grade2) + parseFloat(grade3) 
        + parseFloat(grade4) + parseFloat(grade5) + parseFloat(grade6) + parseFloat(grade7) 
        + parseFloat(grade8) + parseFloat(grade9) + parseFloat(grade10); + parseFloat(grade11);
        + parseFloat(grade12); + parseFloat(grade13); + parseFloat(grade14); + parseFloat(grade15);

        participAverage = participAverage / 15;
        var participationWeighted = participAverage * participationWeight;

        document.getElementById("participationList1").innerHTML = parseFloat(grade1);
        document.getElementById("participationList2").innerHTML = parseFloat(grade2);
        document.getElementById("participationList3").innerHTML = parseFloat(grade3);
        document.getElementById("participationList4").innerHTML = parseFloat(grade4);
        document.getElementById("participationList5").innerHTML = parseFloat(grade5);
        document.getElementById("participationList6").innerHTML = parseFloat(grade6);
        document.getElementById("participationList7").innerHTML = parseFloat(grade7);
        document.getElementById("participationList8").innerHTML = parseFloat(grade8);
        document.getElementById("participationList9").innerHTML = parseFloat(grade9);
        document.getElementById("participationList10").innerHTML = parseFloat(grade10);
        document.getElementById("participationList11").innerHTML = parseFloat(grade11);
        document.getElementById("participationList12").innerHTML = parseFloat(grade12);
        document.getElementById("participationList13").innerHTML = parseFloat(grade13);
        document.getElementById("participationList14").innerHTML = parseFloat(grade14);
        document.getElementById("participationList15").innerHTML = parseFloat(grade15);

        getFinalGrade(participationWeighted);

    }
    else if(chosenAssessment == "Project") {

        var projectAverage = parseFloat(grade1);
        var projectWeighted = projectAverage * projectWeight;

        document.getElementById("projectList").innerHTML = parseFloat(grade1);

        getFinalGrade(projectWeighted);
    }
    else if(chosenAssessment == "Extra Credit") {

        var exCreditAverage = parseFloat(grade1);

        var exCreditWeighted = exCreditAverage * exCreditWeight;

        document.getElementById("exCreditList").innerHTML = parseFloat(grade1);

        getFinalGrade(exCreditWeighted);
    }
    
}

function getFinalGrade(weightedGrade) {

    finalGrade = finalGrade + weightedGrade;
    
    document.getElementById("final").innerHTML = finalGrade;

    if(finalGrade >= 90)
    {
        document.getElementById("letter").innerHTML = "A";
    }
    else if(finalGrade >= 80)
    {
        document.getElementById("letter").innerHTML = "B";
    }
    else if(finalGrade >= 70)
    {
        document.getElementById("letter").innerHTML = "C";
    }
    else if(finalGrade >= 60)
    {
        document.getElementById("letter").innerHTML = "D";
    }
    else if(finalGrade < 60)
    {
        document.getElementById("letter").innerHTML = "F";
    }

}

function clearForm() {

    var frm = document.getElementsByName('input-form')[0];

    frm.reset();  // Reset form fields

    alert("Cleared")

    return false; // Prevent page refresh
}

function redirectPage(weightedGrade) {

    if(finalGrade >= 90)
    {
        alert("Your grade is an A. Excellent work. The page will redirect in 5 seconds.")
        setTimeout(function(){
            window.location.href = 'https://www.google.com/';
         }, 5000); //redirect after 5 seconds
    }
    else if(finalGrade >= 80)
    {
        location.href = "gradeBPage.html";
    }
    else if(finalGrade >= 70)
    {
        location.href = "gradeCPage.html";
    }
    else if(finalGrade >= 60)
    {
        location.href = "gradeDPage.html";
    }
    else if(finalGrade < 60)
    {
        location.href = "gradeFPage.html";
    }

}
