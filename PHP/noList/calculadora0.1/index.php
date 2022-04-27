<?php 

    $value1 = 0;
    $value2 = 0;
    $result = 0;

    if(isset($_GET["value1"],$_GET["value2"])){

        $value1 = $_GET["value1"];
        $value2 = $_GET["value2"];

        $result = $value1 + $value2;
    }
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Calculadora</title>
    <link rel="styleSheet" href="./index.css">
</head>
<body>
    <div class="container">
        <h1>Calculadora basica</h1>
        <form method="get">
            <label for="value1">Informe o primeiro valor:</label><br>
            <input type="number" name="value1" id="value1" required
                    value="<?php echo "$value1"?>"><br>
            <label for="value1">Informe o segundo valor:</label><br>
            <input type="number" name="value2" id="value2" required 
                    value="<?php echo "$value2"?>"><br>
            <label for="value1">Resultado</label><br>
            <input type="number" name="result" id="result" 
                value="<?php echo "$result"?>"
            disabled><br>
            <input type="submit" value="Calcular">
        </form>
    </div>
</body>
</html>