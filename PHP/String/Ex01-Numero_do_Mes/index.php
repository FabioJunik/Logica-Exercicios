<?php 

    $monthes = ["","janeiro","fevereiro","março","abril","maio","junho",
                "julho","agosto","setembro","outubro","novembro","desembro"];

    $text = '';
    $result ='';
    $newText='';

    if(isset($_GET["text"])){

        $text = $_GET["text"];
        $pieces = explode(" ",$text);

        foreach($pieces as $item){

            $lowerItem = mb_strtolower($item);
            $position = array_search($lowerItem,$monthes);
            $newText .= ($position? $position:$item)." ";
        }
        $result = $newText;
    }
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Ex-01</title>
    <link rel="stylesheet" href="./styles.css">
</head>
<body>
    <div class="container">
        <h1>Troca a o mês pelo seu número </h1>
        <form method="get">
            <label for="text">Digite uma frase contendo um mês</label>
            <input type="text" name="text" id="text" 
                value="<?php echo "$text"?>" required>

            <label for="result">Resultado</label>
            <input type="text" name="result" id="result" 
                value="<?php echo "$result"?>" disabled>
            
            <input type="submit" value="Executar">
        </form>
    </div>
</body>
</html>