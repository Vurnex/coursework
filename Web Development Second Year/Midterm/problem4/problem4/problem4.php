<!DOCTYPE html>

<title>Problem 4</title>

<head>

    <meta charset="UTF-8">

    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <!--script src="Lab6script.js"></script-->

    <link rel="stylesheet" href="problem4styles.css">

</head>

<body>

    <h2 id="Title">ITS-362 Lab 6</h2>

    <form method="POST" action="displayInfo.php" id=giveInfo>

        <label id="label1">Enter a name: </label>
        <input type="text" name="newName" id="text1"><br>
        
        <label id="label2">Enter an Age: </label>
        <input type="number" name="newAge" id="text2"><br>

        <label id="label3">Enter an E-Mail: </label>
        <input type="text" name="newEmail" id="text3"><br>

        <label id="label4">Enter a pet's name: </label>
        <input type="text" name="newPet" id="text4"><br>

        <input type="submit" value="Submit Data" id=Submit><br>

    </form>

</body>
</html>
