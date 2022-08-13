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

        $productName = "Box of Cookies";
        $productPrice = 5.0; //$5
        $productDiscount = 0.10; //10% off

        function discount() {
            $GLOBALS['discountedPrice'] = $GLOBALS['productDiscount'] * $GLOBALS['productPrice'];
          }

          discount();

          echo "Product Name: " . $productName . "<br>";
          echo "Product Price: " . $productPrice . "<br>";
          echo "This product is 10% off. The discounted price is: " . $productPrice - $discountedPrice;

        ?>
    

    </body>
</html>