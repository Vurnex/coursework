

<!DOCTYPE html>

    <title>Lab 6</title>

    <head>

        <meta charset="UTF-8">

        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <!--script src="Lab6script.js"></script-->

        <link rel="stylesheet" href="Lab6styles.css">

    </head>

    <body>

        <h2 id="Title">ITS-362 Lab 6</h2>

        <form method="POST" action="displayResults.php" id=calculator>

            <label id="label1">Enter the first value: </label>
            <input type="text" name="operand1" id="text1"><br>
            
            <label id="label2">Enter the second value: </label>
            <input type="text" name="operand2" id="text2"><br>

            <label id="label3">Choose the operation to be performed: </label>
            <select name="operator" id="select1">
                    <option value="Blank"></option>
                    <option value="Addition">Addition</option>
                    <option value="Subtraction">Subtraction</option>
                    <option value="Multiplication">Multiplication</option>
                    <option value="Division">Division</option>
                  </select>

            </label><br>

            <input type="submit" value="Submit Data!" id=Submit><br>

        </form>

        <label id="border1"> </label>
        <label id="border2"> </label>
        <label id="border3"> </label>
        <label id="border4"> </label>

    </body>
</html>