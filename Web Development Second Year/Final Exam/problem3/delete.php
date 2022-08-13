<?php

session_start();

$id = $_GET['id'];

$dsn = "mysql:host=localhost;dbname=StudentList";
$username = "root";
$password = "";

try {

    $db = new PDO($dsn, $username, $password);

    //construct a SELECT statement and execute it by using the query() method of the PDO object.
    $sql = "DELETE FROM student
    WHERE StudentID = '$id'";

    $q = $db->query($sql);

    //The PDO::FETCH_ASSOC mode instructs the fetch() method to return a result set as an array indexed by column name.
    $q->setFetchMode(PDO::FETCH_ASSOC);

    echo "Record successfully deleted. Redirecting.";

    header('Refresh: 2; URL = problem3adminhome.php');

}
catch(PDOException $e) {

    header("Location: problem1ErrorPage.php");

}