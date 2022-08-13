<?php

if(isset($_POST["newName"])){

    $newName=$_POST["newName"];
    $newAge=$_POST["newAge"];
    $newEmail=$_POST["newEmail"];
    $newPet=$_POST["newPet"];

}
?>

<!DOCTYPE html>

    <title>ITS-362 Midterm Problem 4</title>

    <head>

        <meta charset="UTF-8">

        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <!--script src="Lab6script.js"></script-->

        <link rel="stylesheet" href="problem4styles.css"> 

    </head>

    <body>

        <label id="Name">Name: </label>
        <span id="span1"><?php echo $newName;?></span><br>

        <label id="Age">Age: </label>
        <span id="span2"><?php echo $newAge;?></span><br>

        <label id="E-mail">E-Mail: </label>
        <span id="span3"><?php echo $newEmail;?></span><br>

        <label id="Pet">Pet Name: </label>
        <span id="span4"><?php echo $newPet;?></span><br>

        <form action="problem4.php">

            <input type="submit" value="Back To Main Page" id="backButton"><br>

        </form>

    </body>
</html>