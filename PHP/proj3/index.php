<?php
    /*function capicua(int $num) : bool{
        $num = 121;
        $inv = 0;
        $original = $num;
        while($num != 0){
            $resto = $num % 10;
            $num = (int)($num / 10);
            $inv= $inv * 10 + $resto;
        }
        return $original!=$inv;
    }
    em vez da declaração de arrays $a=[0][0]
    podemos declarar:*/
    $nome = "Carlos";
    $a["Aluno"]=[
        "Ana" => [
            "nome" => "Ana Leucádio",
            "idade" => 20
        ],
        "Carlos"=> [
            "nome" => "Carlos Carvalho",
            "idade" => 32
        ]
    ];
    //echo $a["Aluno"][$nome]["nome"];
    echo "1. Crie um vetor com 20 elementos inteiros e apresente o maior número desse vetor.<br>";
    $vector = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20];
    $vector1 = [2,5,7];
    $vector2 = [3,2,7];
    $vector3 = [];
    $k=0;
    $max = 0;
    for($i=0;$i<20;$i++){
        if($vector[$i]>$max){
            $max=$vector[$i];
        }
    }
    echo "o maior número do vector é o ".$max;
    echo "<br><br>";
    echo "2. Apresente a quantidade de números pares e ímpares existentes num vetor.<br>";
    $pares="";
    $impares="";
    for($i=0;$i<20;$i++){
        if($vector[$i]%2==0){
            $pares=$pares.", ".$vector[$i];
        }
        else{
            $impares=$impares.", ".$vector[$i];
        }
    }
    echo "pares do vector: ".$pares."<br>";
    echo "impares do vector: ".$impares."<br>";
    echo "<br><br>";
    echo "3. Dados dois vetores de 10 elementos, crie um terceiro vetor com os números únicos a apenas um dos vetores
    iniciais.<br>";
    for($i=0;$i<3;$i++){
        $flag=false;
        for($j=0;$j<3;$j++){
            if($vector1[$i]==$vector2[$j]){
                $flag=true;
            }
        }
        if(!$flag){
            $vector3[]=$vector1[$i];

        }
    }
    for($i=0;$i<3;$i++){
        $flag=false;
        for($j=0;$j<3;$j++){
            if($vector2[$i]==$vector1[$j]){
                $flag=true;
            }
        }
        if(!$flag){
            $vector3[]=$vector2[$i];
        }
    }
    echo "números não comuns aos dois vectores: ";
    foreach($vector3 as $num){
        echo $num.", ";
    }
    echo "<br><br>";
    echo "4. Some 2 matrizes de tamanho 4x4.<br>";
    $matriz1[0]=[1,2,3,4];
    $matriz1[1]=[2,3,4,5];
    $matriz1[2]=[4,5,7,8];
    $matriz1[3]=[9,8,5,4];
    $matriz2[0]=[1,2,3,4];
    $matriz2[1]=[2,3,4,5];
    $matriz2[2]=[4,5,7,8];
    $matriz2[3]=[9,8,5,4];
    $matriz4[0]=[1,2,3,4,5];
    $matriz4[1]=[2,3,4,5,4];
    $matriz4[2]=[4,5,7,8,7];
    $matriz4[3]=[9,8,5,4,4];
    $matriz4[4]=[9,8,5,4,15];
    for($i=0;$i<4;$i++){
        for($c=0;$c<4;$c++){
            $matriz3[$i][$c]=$matriz1[$i][$c]+$matriz2[$i][$c];
        }
    }
    for($i=0;$i<4;$i++){
        for($c=0;$c<4;$c++){
            echo "[".$matriz3[$i][$c]."]";
        }
        echo "<br>";
    }
    echo "<br><br>";
    echo "5. Crie uma função que retorne os elementos da diagonal principal de uma matriz de tamanho 5x5.<br>";
    function diagonal($matriz4){
        $diagonal = "";
        for($i=0;$i<5;$i++){
            for($tab=0;$tab<$i;$tab++){
                $diagonal= $diagonal."&emsp;";
            }
            $diagonal=$diagonal.$matriz4[$i][$i]."<br>";
        }
        return $diagonal;
    }
    echo diagonal($matriz4);
    echo "<br><br>";
    echo "6. Crie uma função em PHP que ao receber o número de um mês retorne a sua string, por exemplo, ao receber 3
    retorna Março.<br>";
    $mes=[1=>"Janeiro",2=>"Fevereiro",3=>"Março",4=>"Abril",5=>"Maio",6=>"Junho",7=>"Julho",8=>"Agosto",9=>"Setembro",10=>"Outubro",11=>"Novembro",12=>"Dezembro"];
    $mesescolhido=3;
    echo $mesescolhido." = ".$mes[$mesescolhido];
    echo "<br><br><br>";
    echo "7. Crie um array associativo que permita armazenar a seguinte informação sobre uma lista de alunos:<br>";
    $aluno=[
        [
            "nome"=>"nome",
            "morada"=>[
                "endereço"=>"endereço",
                "código postal"=> "0000-000",
                "localidade"=> "localidade"
            ],
            "contactos"=>[
                "email"=>"email",
                "telefone"=>123456789,
                "telemóvel"=>123546789
            ],
            "curso"=>[
                "nome"=>"curso",
                "UFCD´S"=>[
                    "código"=>1345,
                    "descrição"=>"descrição"
                ]
            ]
        ]
    ];
    echo $aluno[0]["curso"]["UFCD´S"]["código"];
?>