<!DOCTYPE html>

    <title>Lab 5</title>

    <head>

        <meta charset="UTF-8">

        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <!--script src="Lab5script.js"></script-->

        <!--link rel="stylesheet" href="Lab5styles.css"-->    

    </head>

    <body>

        <h2 id="Title">ITS-362 Lab 5</h2>

        <?php

            class Employee {

                public $employeeID;
                public $employeeHours;
                public $employeeHourlyPay;

                public function __construct($employeeID, $employeeHours, $employeeHourlyPay){

                    $this->employeeID = $employeeID;
                    $this->employeeHours = $employeeHours;
                    $this->employeeHourlyPay = $employeeHourlyPay;
                }

                public function newMessage(){

                    echo "The employee ID is " . $this->employeeID . ". They will work " . $this->employeeHours . " hours a week and be paid $" . $this->employeeHourlyPay . " an hour. <br>";
                }

                public function calcWeeklyPay(){

                    $weeklyPay = $this->employeeHours * $this->employeeHourlyPay;

                    echo "This employee will make $" . $weeklyPay . " a week, before taxes.";

                }

            }

            $newEmployee = new Employee(3002, 40, 25.00);
            $newEmployee->newMessage();
            $newEmployee->calcWeeklyPay();

        ?>
    

    </body>
</html>