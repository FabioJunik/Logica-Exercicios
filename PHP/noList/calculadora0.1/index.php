<?php 

    $value1 = 0;
    $value2 = 0;
    $result = 0;

    if(isset($_GET["value1"],$_GET["value2"],$_GET["operations"])){

        $value1 = $_GET["value1"];
        $value2 = $_GET["value2"];
        $operation = $_GET["operations"];

        switch($operation){
            case 'sum':
                $result = $value1 + $value2;
            break;
            case 'sub':
                $result = $value1 - $value2;
            break;
            case 'mul':
                $result = $value1 * $value2;
            break;
            case 'div':
                $result = $value1 / $value2;
            break;

        }

    }
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Calculadora</title>
    <link rel="stylesheet" href="./styles.css">
</head>
<body>
    <div class="container">
        <h1>Calculadora basica</h1>
        <form method="get">
            <label for="value1">Informe o primeiro valor:</label>
            <input type="number" name="value1" id="value1" 
                value="<?php echo "$value1"?>" required>

            <label for="value1">Informe o segundo valor:</label>
            <input type="number" name="value2" id="value2"  
                value="<?php echo "$value2"?>" required>

            <label for="value1">Selecione uma operação</label>
            <select name="operations">
                <option value="sum">+</option>
                <option value="sub">-</option>
                <option value="mul">x</option>
                <option value="div">/</option>
            </select>

            <label for="value1">Resultado</label>
            <input type="number" name="result" id="result" 
                value="<?php echo "$result"?>" disabled>
            <input type="submit" value="Calcular">
        </form>
    </div>
</body>
</html>