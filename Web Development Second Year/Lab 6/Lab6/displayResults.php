

<?php

if(ctype_digit($_POST["operand1"]) && ctype_digit($_POST["operand2"])){

    //inputs are valid
}
else {

    echo '<script>alert("Inputs are invalid")</script>';
    echo '<script>location.href = "Lab6php.php"</script>';
    exit();

}

if (($_POST["operator"]) == "Blank") {

    echo '<script>alert("Please select an operation.")</script>';
    echo '<script>location.href = "Lab6php.php"</script>';
    exit();
}

if(isset($_POST["operator"])){

    $operator=$_POST["operator"];

    $operand1=$_POST["operand1"];
    $operand2=$_POST["operand2"];

    if ($operator == "Addition")
    {
        $result = $operand1 + $operand2;
    }
    else if ($operator == "Subtraction")
    {
        $result = $operand1 - $operand2;
    }
    else if ($operator == "Multiplication")
    {
        $result = $operand1 * $operand2;
    }
    else if ($operator == "Division")
    {
        $result = $operand1 / $operand2;
    }
}
?>


<!DOCTYPE html>

    <title>Lab 6</title>

    <head>

        <meta charset="UTF-8">

        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <!--script src="Lab6script.js"></script-->

        <link rel="stylesheet" href="Lab6styles.css"> 

    </head>

    <body>

        <label id="result">Result:</label>
        <span"><?php echo $result;?></span><br>

        <form action="Lab6php.php">

            <input type="submit" value="Back To Main Page"><br>

        </form>

    </body>
</html>